namespace 口算生成
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.airForm1 = new ReaLTaiizor.Forms.AirForm();
            this.save = new ReaLTaiizor.Controls.AirButton();
            this.num3label = new ReaLTaiizor.Controls.BigLabel();
            this.num3 = new ReaLTaiizor.Controls.CrownNumeric();
            this.hunhe = new ReaLTaiizor.Controls.AirCheckBox();
            this.chu = new ReaLTaiizor.Controls.AirCheckBox();
            this.cheng = new ReaLTaiizor.Controls.AirCheckBox();
            this.jian = new ReaLTaiizor.Controls.AirCheckBox();
            this.jia = new ReaLTaiizor.Controls.AirCheckBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.num2 = new ReaLTaiizor.Controls.CrownNumeric();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.num = new ReaLTaiizor.Controls.CrownNumeric();
            this.ProgressBar = new ReaLTaiizor.Controls.AloneProgressBar();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.num4 = new ReaLTaiizor.Controls.CrownNumeric();
            this.open = new ReaLTaiizor.Controls.AirButton();
            this.airForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            this.SuspendLayout();
            // 
            // airForm1
            // 
            this.airForm1.BackColor = System.Drawing.Color.White;
            this.airForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.airForm1.Controls.Add(this.open);
            this.airForm1.Controls.Add(this.bigLabel3);
            this.airForm1.Controls.Add(this.num4);
            this.airForm1.Controls.Add(this.ProgressBar);
            this.airForm1.Controls.Add(this.save);
            this.airForm1.Controls.Add(this.num3label);
            this.airForm1.Controls.Add(this.num3);
            this.airForm1.Controls.Add(this.hunhe);
            this.airForm1.Controls.Add(this.chu);
            this.airForm1.Controls.Add(this.cheng);
            this.airForm1.Controls.Add(this.jian);
            this.airForm1.Controls.Add(this.jia);
            this.airForm1.Controls.Add(this.bigLabel2);
            this.airForm1.Controls.Add(this.num2);
            this.airForm1.Controls.Add(this.bigLabel1);
            this.airForm1.Controls.Add(this.num);
            this.airForm1.Customization = "AAAA/1paWv9ycnL/";
            this.airForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airForm1.Image = null;
            this.airForm1.Location = new System.Drawing.Point(0, 0);
            this.airForm1.MaximumSize = new System.Drawing.Size(800, 450);
            this.airForm1.MinimumSize = new System.Drawing.Size(530, 400);
            this.airForm1.Movable = true;
            this.airForm1.Name = "airForm1";
            this.airForm1.NoRounding = false;
            this.airForm1.Sizable = true;
            this.airForm1.Size = new System.Drawing.Size(800, 450);
            this.airForm1.SmartBounds = true;
            this.airForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.airForm1.TabIndex = 0;
            this.airForm1.Text = "口算生成器";
            this.airForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.Transparent = false;
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save.Image = null;
            this.save.Location = new System.Drawing.Point(18, 250);
            this.save.Name = "save";
            this.save.NoRounding = false;
            this.save.Size = new System.Drawing.Size(490, 41);
            this.save.TabIndex = 11;
            this.save.Text = "生成";
            this.save.Transparent = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // num3label
            // 
            this.num3label.AutoSize = true;
            this.num3label.BackColor = System.Drawing.Color.Transparent;
            this.num3label.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.num3label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.num3label.Location = new System.Drawing.Point(12, 197);
            this.num3label.Name = "num3label";
            this.num3label.Size = new System.Drawing.Size(171, 35);
            this.num3label.TabIndex = 10;
            this.num3label.Text = "混合运算数量";
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(189, 205);
            this.num3.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num3.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(120, 27);
            this.num3.TabIndex = 9;
            this.num3.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // hunhe
            // 
            this.hunhe.Checked = false;
            this.hunhe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hunhe.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.hunhe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hunhe.Image = null;
            this.hunhe.Location = new System.Drawing.Point(18, 169);
            this.hunhe.Name = "hunhe";
            this.hunhe.NoRounding = false;
            this.hunhe.Size = new System.Drawing.Size(92, 17);
            this.hunhe.TabIndex = 8;
            this.hunhe.Text = "出混合";
            this.hunhe.Transparent = false;
            this.hunhe.CheckedChanged += new ReaLTaiizor.Controls.AirCheckBox.CheckedChangedEventHandler(this.hunhe_CheckedChanged);
            // 
            // chu
            // 
            this.chu.Checked = false;
            this.chu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chu.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.chu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chu.Image = null;
            this.chu.Location = new System.Drawing.Point(312, 136);
            this.chu.Name = "chu";
            this.chu.NoRounding = false;
            this.chu.Size = new System.Drawing.Size(92, 17);
            this.chu.TabIndex = 7;
            this.chu.Text = "除";
            this.chu.Transparent = false;
            // 
            // cheng
            // 
            this.cheng.Checked = false;
            this.cheng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cheng.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.cheng.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cheng.Image = null;
            this.cheng.Location = new System.Drawing.Point(214, 136);
            this.cheng.Name = "cheng";
            this.cheng.NoRounding = false;
            this.cheng.Size = new System.Drawing.Size(92, 17);
            this.cheng.TabIndex = 6;
            this.cheng.Text = "乘";
            this.cheng.Transparent = false;
            // 
            // jian
            // 
            this.jian.Checked = false;
            this.jian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jian.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.jian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.jian.Image = null;
            this.jian.Location = new System.Drawing.Point(116, 136);
            this.jian.Name = "jian";
            this.jian.NoRounding = false;
            this.jian.Size = new System.Drawing.Size(92, 17);
            this.jian.TabIndex = 5;
            this.jian.Text = "减";
            this.jian.Transparent = false;
            // 
            // jia
            // 
            this.jia.Checked = false;
            this.jia.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.jia.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.jia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.jia.Image = null;
            this.jia.Location = new System.Drawing.Point(18, 136);
            this.jia.Name = "jia";
            this.jia.NoRounding = false;
            this.jia.Size = new System.Drawing.Size(92, 17);
            this.jia.TabIndex = 4;
            this.jia.Text = "加";
            this.jia.Transparent = false;
            this.jia.UseWaitCursor = true;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(12, 80);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(93, 35);
            this.bigLabel2.TabIndex = 3;
            this.bigLabel2.Text = "最大值";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(189, 88);
            this.num2.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.num2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(120, 27);
            this.num2.TabIndex = 2;
            this.num2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(12, 39);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(119, 35);
            this.bigLabel1.TabIndex = 1;
            this.bigLabel1.Text = "题目数量";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(189, 47);
            this.num.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(120, 27);
            this.num.TabIndex = 0;
            this.num.Value = new decimal(new int[] {
            84,
            0,
            0,
            0});
            this.num.ValueChanged += new System.EventHandler(this.crownNumeric1_ValueChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BackgroundColor = System.Drawing.Color.Green;
            this.ProgressBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ProgressBar.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ProgressBar.Location = new System.Drawing.Point(18, 297);
            this.ProgressBar.Maximum = 100;
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(490, 23);
            this.ProgressBar.Stripes = System.Drawing.Color.DarkGreen;
            this.ProgressBar.TabIndex = 12;
            this.ProgressBar.Text = "aloneProgressBar1";
            this.ProgressBar.Value = 0;
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.Location = new System.Drawing.Point(315, 39);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(67, 35);
            this.bigLabel3.TabIndex = 14;
            this.bigLabel3.Text = "页数";
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(388, 49);
            this.num4.Maximum = new decimal(new int[] {
            11904,
            0,
            0,
            0});
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(120, 27);
            this.num4.TabIndex = 13;
            this.num4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num4.ValueChanged += new System.EventHandler(this.crownNumeric1_ValueChanged_1);
            // 
            // open
            // 
            this.open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.open.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.open.Image = null;
            this.open.Location = new System.Drawing.Point(18, 326);
            this.open.Name = "open";
            this.open.NoRounding = false;
            this.open.Size = new System.Drawing.Size(87, 27);
            this.open.TabIndex = 15;
            this.open.Text = "打开";
            this.open.Transparent = false;
            this.open.Visible = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.airForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(530, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.ResumeLayout(false);
            this.airForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.CrownNumeric num;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.CrownNumeric num2;
        private ReaLTaiizor.Controls.BigLabel num3label;
        private ReaLTaiizor.Controls.CrownNumeric num3;
        private ReaLTaiizor.Controls.AirCheckBox hunhe;
        private ReaLTaiizor.Controls.AirCheckBox chu;
        private ReaLTaiizor.Controls.AirCheckBox cheng;
        private ReaLTaiizor.Controls.AirCheckBox jian;
        private ReaLTaiizor.Controls.AirCheckBox jia;
        private ReaLTaiizor.Controls.AirButton save;
        private ReaLTaiizor.Controls.AloneProgressBar ProgressBar;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.CrownNumeric num4;
        private ReaLTaiizor.Controls.AirButton open;
    }
}

