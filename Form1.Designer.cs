namespace FindingClosestPoints
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonFindDraw = new System.Windows.Forms.Button();
            this.pointsGridDraw = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClearDraw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.caln2 = new System.Windows.Forms.Button();
            this.calnLogn = new System.Windows.Forms.Button();
            this.dataGridViewTimeComplex = new System.Windows.Forms.DataGridView();
            this.pointsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slowtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRandomNumer = new System.Windows.Forms.TextBox();
            this.richTextBoxOutputResult = new System.Windows.Forms.RichTextBox();
            this.buttonRandomAndFind = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridDraw)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeComplex)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(584, 482);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonFindDraw);
            this.tabPage1.Controls.Add(this.pointsGridDraw);
            this.tabPage1.Controls.Add(this.buttonClearDraw);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "直接绘点";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFindDraw
            // 
            this.buttonFindDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindDraw.Location = new System.Drawing.Point(414, 27);
            this.buttonFindDraw.Name = "buttonFindDraw";
            this.buttonFindDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonFindDraw.TabIndex = 3;
            this.buttonFindDraw.Text = "开始寻找";
            this.buttonFindDraw.UseVisualStyleBackColor = true;
            this.buttonFindDraw.Click += new System.EventHandler(this.buttonFindDraw_Click);
            // 
            // pointsGridDraw
            // 
            this.pointsGridDraw.AllowUserToAddRows = false;
            this.pointsGridDraw.AllowUserToDeleteRows = false;
            this.pointsGridDraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsGridDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsGridDraw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.pointsGridDraw.Location = new System.Drawing.Point(309, 68);
            this.pointsGridDraw.Name = "pointsGridDraw";
            this.pointsGridDraw.ReadOnly = true;
            this.pointsGridDraw.RowTemplate.Height = 23;
            this.pointsGridDraw.Size = new System.Drawing.Size(200, 339);
            this.pointsGridDraw.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 70;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 70;
            // 
            // buttonClearDraw
            // 
            this.buttonClearDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearDraw.Location = new System.Drawing.Point(318, 27);
            this.buttonClearDraw.Name = "buttonClearDraw";
            this.buttonClearDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonClearDraw.TabIndex = 1;
            this.buttonClearDraw.Text = "清除点";
            this.buttonClearDraw.UseVisualStyleBackColor = true;
            this.buttonClearDraw.Click += new System.EventHandler(this.buttonClearDraw_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 429);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "随机生成点";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.caln2);
            this.groupBox2.Controls.Add(this.calnLogn);
            this.groupBox2.Controls.Add(this.dataGridViewTimeComplex);
            this.groupBox2.Location = new System.Drawing.Point(203, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "时间复杂度分析";
            // 
            // caln2
            // 
            this.caln2.Location = new System.Drawing.Point(196, 18);
            this.caln2.Name = "caln2";
            this.caln2.Size = new System.Drawing.Size(75, 23);
            this.caln2.TabIndex = 2;
            this.caln2.Text = "测试n^2";
            this.caln2.UseVisualStyleBackColor = true;
            this.caln2.Click += new System.EventHandler(this.caln2_Click);
            // 
            // calnLogn
            // 
            this.calnLogn.Location = new System.Drawing.Point(50, 18);
            this.calnLogn.Name = "calnLogn";
            this.calnLogn.Size = new System.Drawing.Size(106, 23);
            this.calnLogn.TabIndex = 1;
            this.calnLogn.Text = "测试nLog(n)";
            this.calnLogn.UseVisualStyleBackColor = true;
            this.calnLogn.Click += new System.EventHandler(this.calnLogn_Click);
            // 
            // dataGridViewTimeComplex
            // 
            this.dataGridViewTimeComplex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTimeComplex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimeComplex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pointsNumber,
            this.time,
            this.slowtime});
            this.dataGridViewTimeComplex.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewTimeComplex.Name = "dataGridViewTimeComplex";
            this.dataGridViewTimeComplex.RowTemplate.Height = 23;
            this.dataGridViewTimeComplex.Size = new System.Drawing.Size(341, 329);
            this.dataGridViewTimeComplex.TabIndex = 0;
            // 
            // pointsNumber
            // 
            this.pointsNumber.HeaderText = "点数量";
            this.pointsNumber.Name = "pointsNumber";
            this.pointsNumber.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "nLog(n)耗费时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // slowtime
            // 
            this.slowtime.HeaderText = "n2耗费时间";
            this.slowtime.Name = "slowtime";
            this.slowtime.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxRandomNumer);
            this.groupBox1.Controls.Add(this.richTextBoxOutputResult);
            this.groupBox1.Controls.Add(this.buttonRandomAndFind);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "随机生成点";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "点个数";
            // 
            // textBoxRandomNumer
            // 
            this.textBoxRandomNumer.Location = new System.Drawing.Point(51, 26);
            this.textBoxRandomNumer.Name = "textBoxRandomNumer";
            this.textBoxRandomNumer.Size = new System.Drawing.Size(100, 21);
            this.textBoxRandomNumer.TabIndex = 2;
            this.textBoxRandomNumer.Text = "1000000";
            // 
            // richTextBoxOutputResult
            // 
            this.richTextBoxOutputResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutputResult.Location = new System.Drawing.Point(3, 88);
            this.richTextBoxOutputResult.Name = "richTextBoxOutputResult";
            this.richTextBoxOutputResult.Size = new System.Drawing.Size(151, 288);
            this.richTextBoxOutputResult.TabIndex = 1;
            this.richTextBoxOutputResult.Text = "";
            // 
            // buttonRandomAndFind
            // 
            this.buttonRandomAndFind.Location = new System.Drawing.Point(21, 59);
            this.buttonRandomAndFind.Name = "buttonRandomAndFind";
            this.buttonRandomAndFind.Size = new System.Drawing.Size(115, 23);
            this.buttonRandomAndFind.TabIndex = 0;
            this.buttonRandomAndFind.Text = "生成点并寻找最近";
            this.buttonRandomAndFind.UseVisualStyleBackColor = true;
            this.buttonRandomAndFind.Click += new System.EventHandler(this.buttonRandomAndFind_Click);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox2.Location = new System.Drawing.Point(586, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(104, 456);
            this.textBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 456);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "寻找最近点对";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridDraw)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimeComplex)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonClearDraw;
        private System.Windows.Forms.DataGridView pointsGridDraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button buttonFindDraw;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxOutputResult;
        private System.Windows.Forms.Button buttonRandomAndFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRandomNumer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button caln2;
        private System.Windows.Forms.Button calnLogn;
        private System.Windows.Forms.DataGridView dataGridViewTimeComplex;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn slowtime;
    }
}

