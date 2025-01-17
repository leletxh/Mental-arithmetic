using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace 口算生成
{
    public partial class Form1 : Form
    {
        bool done = true;
        bool success = false;
        string fpath = "";
        private static readonly Lazy<Random> random = new Lazy<Random>(() => new Random());

        public Form1()
        {
            InitializeComponent();
            num3.Maximum = num.Value;
            num3.Visible = false;
            num3label.Visible = false;
            jia.Checked = true; // 加法turn表示开启
            jian.Checked = true; // 减法turn表示开启
            cheng.Checked = true; // 乘法turn表示开启
            chu.Checked = true; // 除法turn表示开启
        }

        private void hunhe_CheckedChanged(object sender)
        {
            if (hunhe.Checked)
            {
                num3.Visible = true;
                num3label.Visible = true;
            }
            else
            {
                num3.Visible = false;
                num3label.Visible = false;
            }
            num4.Value = (int)num.Value / 84;
        }

        private void crownNumeric1_ValueChanged(object sender, EventArgs e)
        {
            num3.Maximum = num.Value;
        }

        private async void save_Click(object sender, EventArgs e)
        {
            if (num.Value == 0)
            {
                MessageBox.Show("请输入题目数量！");
                return;
            }
            if (num2.Value == 0)
            {
                MessageBox.Show("请输入最大答案！");
                return;
            }
            if (!done) 
            {
                MessageBox.Show("请勿重复点击！");
                return;
            }
            string localFilePath = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word文档（*.docx）|*.docx";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                done = false;
                localFilePath = sfd.FileName.ToString(); // 保存路径
            }
            else
            {
                return;
            }

            bool jiafa = jia.Checked; // 加法turn表示开启
            bool jianfa = jian.Checked; // 减法turn表示开启
            bool chengfa = cheng.Checked; // 乘法turn表示开启
            bool chufa = chu.Checked; // 除法turn表示开启
            bool hunheyunsuan = hunhe.Checked; // 混合turn表示开启
            int timushuliang = (int)num.Value; // 题目数量
            int fanwei = (int)num2.Value; // 最大答案
            int hunheshuliang = 0;
            if (hunheyunsuan)
            {
                hunheshuliang = (int)num3.Value; // 混合运算数量
            }

            // 定义操作符数组
            List<char> operations = new List<char>();
            if (jiafa) operations.Add('+');
            if (jianfa) operations.Add('-');
            if (chengfa) operations.Add('*');
            if (chufa) operations.Add('÷'); 

            // 确保至少有一个操作符被选中
            if (operations.Count == 0)
            {
                MessageBox.Show("请选择至少一种运算类型！");
                return;
            }

            // 显示进度条
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = timushuliang;
            ProgressBar.Value = 0;

            await Task.Run(() =>
            {
                CreateMathQuestionDocument(localFilePath, timushuliang, operations.ToArray(), fanwei, hunheyunsuan ? hunheshuliang : 0, ProgressBar);
            });
            if (ProgressBar.Value == ProgressBar.Maximum)
            {
                done = true;
                MessageBox.Show("文档创建成功！");
                success = true;
                fpath = localFilePath;
                open.Visible = true;
            }
            else
            {
                done = true;
                open.Visible = false;
            }

        }

        static void CreateMathQuestionDocument(string filePath, int numberOfQuestions, char[] operations, int maxResult, int mixedOperationCount, ReaLTaiizor.Controls.AloneProgressBar progressBar)
        {
            try
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    // 添加主文档部分
                    MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                    mainPart.Document = new Document(new Body());

                    // 设置字体大小和样式
                    StyleDefinitionsPart stylePart = mainPart.AddNewPart<StyleDefinitionsPart>();
                    stylePart.Styles = new Styles(
                        new Style(
                            new Name() { Val = "LargeText" },
                            new BasedOn() { Val = "Normal" },
                            new NextParagraphStyle() { Val = "Normal" },
                            new FontSize() { Val = "36" }, // 字号再增加
                            new FontSizeComplexScript() { Val = "36" })
                        { Type = StyleValues.Paragraph, StyleId = "LargeText", Default = true });

                    Table table = new Table();

                    TableProperties tblProps = new TableProperties(
                        new TableWidth() { Width = "100%", Type = TableWidthUnitValues.Pct },
                        new TableBorders(
                            new TopBorder() { Val = BorderValues.None, Size = 0 },
                            new BottomBorder() { Val = BorderValues.None, Size = 0 },
                            new LeftBorder() { Val = BorderValues.None, Size = 0 },
                            new RightBorder() { Val = BorderValues.None, Size = 0 },
                            new InsideHorizontalBorder() { Val = BorderValues.None, Size = 0 },
                            new InsideVerticalBorder() { Val = BorderValues.None, Size = 0 }),
                        new TableLayout() { Type = TableLayoutValues.Fixed });
                    table.Append(tblProps);

                    TableGrid grid = new TableGrid(
                        new GridColumn() { Width = "25%" },
                        new GridColumn() { Width = "25%" },
                        new GridColumn() { Width = "25%" },
                        new GridColumn() { Width = "25%" });
                    table.Append(grid);
                    List<string> questions = GenerateMathQuestions(numberOfQuestions, operations, maxResult, mixedOperationCount, progressBar);
                    for (int i = 0; i < questions.Count; i += 4)
                    {
                        TableRow row = new TableRow();

                        for (int j = 0; j < 4 && i + j < questions.Count; j++)
                        {
                            TableCell cell = CreateTableCell(questions[i + j]);
                            row.Append(cell);
                        }

                        table.Append(row);
                    }
                    mainPart.Document.Body.Append(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建文档时出错：" + ex.Message);
            }
        }

        static List<string> GenerateMathQuestions(int count, char[] operations, int maxResult, int mixedOperationCount, ReaLTaiizor.Controls.AloneProgressBar progressBar)
        {
            List<string> questions = new List<string>();
            mixedOperationCount = Math.Min(mixedOperationCount, count);
            for (int i = 0; i < mixedOperationCount; i++)
            {
                string question = GenerateMixedMathQuestion(operations, maxResult);
                questions.Add(question);
                UpdateProgressBar(progressBar, i + 1);
            }
            for (int i = mixedOperationCount; i < count; i++)
            {
                string question = GenerateMathQuestion(operations, maxResult);
                questions.Add(question);
                UpdateProgressBar(progressBar, i + 1);
            }

            return questions;
        }

        static string GenerateMathQuestion(char[] operations, int maxResult)
        {
            int num1, num2;
            char operation = GetRandomOperation(random.Value, operations);

            string question = "";
            switch (operation)
            {
                case '+':
                    do
                    {
                        num1 = random.Value.Next(1, maxResult);
                        num2 = random.Value.Next(1, maxResult - num1 + 1);
                    } while (num1 + num2 > maxResult);
                    question = $"{num1} + {num2}";
                    break;
                case '-':
                    do
                    {
                        num1 = random.Value.Next(1, maxResult);
                        num2 = random.Value.Next(1, num1);
                    } while (num1 - num2 <= 0 || num1 - num2 > maxResult);
                    question = $"{num1} - {num2}";
                    break;
                case '*':
                    do
                    {
                        num1 = random.Value.Next(1, (int)Math.Sqrt(maxResult) + 1);
                        num2 = random.Value.Next(1, maxResult / num1 + 1);
                    } while (num1 * num2 > maxResult);
                    question = $"{num1} * {num2}";
                    break;
                case '÷':
                    do
                    {
                        num2 = random.Value.Next(1, (int)Math.Sqrt(maxResult) + 1);
                        num1 = num2 * random.Value.Next(1, maxResult / num2 + 1);
                    } while (num1 / num2 > maxResult || num2 == 0);
                    question = $"{num1} ÷ {num2}";
                    break;
            }

            return question;
        }

        static string GenerateMixedMathQuestion(char[] operations, int maxResult)
        {
            int num1, num2, num3;
            char op1, op2;

            do
            {
                num1 = random.Value.Next(1, maxResult);
                num2 = random.Value.Next(1, num1); // Ensure num1 > num2
                num3 = random.Value.Next(1, maxResult);
                op1 = GetRandomOperation(random.Value, operations);
                op2 = GetRandomOperation(random.Value, operations);

                // Ensure division is valid and results in an integer
                if (op1 == '÷')
                {
                    num2 = random.Value.Next(1, (int)Math.Sqrt(num1) + 1);
                    num1 = num2 * random.Value.Next(1, num1 / num2 + 1);
                }
                if (op2 == '÷')
                {
                    num3 = random.Value.Next(1, (int)Math.Sqrt(num2) + 1);
                    num2 = num3 * random.Value.Next(1, num2 / num3 + 1);
                }

            } while (!IsValidExpression(num1, num2, num3, op1, op2, maxResult));

            return $"{num1} {op1} {num2} {op2} {num3}";
        }

        static int EvaluateExpression(int num1, int num2, int num3, char op1, char op2)
        {
            int intermediateResult = ApplyOperation(num1, num2, op1);
            return ApplyOperation(intermediateResult, num3, op2);
        }

        static bool IsValidExpression(int num1, int num2, int num3, char op1, char op2, int maxResult)
        {
            try
            {
                int result = EvaluateExpression(num1, num2, num3, op1, op2);
                return result >= 0 && result <= maxResult;
            }
            catch (DivideByZeroException)
            {
                return false;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }

        static int ApplyOperation(int a, int b, char operation)
        {
            switch (operation)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '÷':
                    if (b == 0) throw new DivideByZeroException();
                    if (a % b != 0) throw new InvalidOperationException("Division does not result in an integer.");
                    return a / b; // Ensure no division by zero occurs before calling this method
                default: throw new ArgumentException("Invalid operation");
            }
        }

        static char GetRandomOperation(Random random, char[] operations)
        {
            return operations[random.Next(operations.Length)];
        }

        static TableCell CreateTableCell(string text)
        {
            TableCell cell = new TableCell();

            // 单元格属性
            TableCellProperties cellProps = new TableCellProperties(
                new TableCellWidth() { Type = TableWidthUnitValues.Pct, Width = "25%" });
            cell.Append(cellProps);

            // 段落
            Paragraph paragraph = new Paragraph();
            Run run = new Run(new Text(text));

            // 设置段落样式
            ParagraphProperties pProps = new ParagraphProperties(
                new ParagraphStyleId() { Val = "LargeText" });
            paragraph.Append(pProps);
            paragraph.Append(run);

            // 在每个题目后面添加一个空行
            Paragraph spacingPara = new Paragraph();
            ParagraphProperties spacingPProps = new ParagraphProperties(
                new SpacingBetweenLines() { After = "40" }); // 调整行间距
            spacingPara.Append(spacingPProps);

            cell.Append(paragraph, spacingPara);

            return cell;
        }

        delegate void UpdateProgressBarDelegate(ReaLTaiizor.Controls.AloneProgressBar progressBar, int value);

        static void UpdateProgressBar(ReaLTaiizor.Controls.AloneProgressBar progressBar, int value)
        {
            if (progressBar.InvokeRequired)
            {
                UpdateProgressBarDelegate del = new UpdateProgressBarDelegate(UpdateProgressBar);
                progressBar.Invoke(del, new object[] { progressBar, value });
            }
            else
            {
                progressBar.Value = value;
            }
        }

        private void crownNumeric1_ValueChanged_1(object sender, EventArgs e)
        {
            num.Value = (int)num4.Value * 84;
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (success)
            {
                try
                {
                    Process.Start("explorer.exe", fpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开失败，请检查文件是否存在！");
                }
            }
        }
    }
}



