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
            this.tabControlMain.Size = new System.Drawing.Size(541, 469);
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
            this.tabPage1.Size = new System.Drawing.Size(533, 443);
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
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "随机生成点";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxRandomNumer);
            this.groupBox1.Controls.Add(this.richTextBoxOutputResult);
            this.groupBox1.Controls.Add(this.buttonRandomAndFind);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 366);
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
            this.richTextBoxOutputResult.Size = new System.Drawing.Size(151, 275);
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
            this.textBox2.Location = new System.Drawing.Point(543, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(104, 443);
            this.textBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 443);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "寻找最近点对";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridDraw)).EndInit();
            this.tabPage2.ResumeLayout(false);
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
    }
}

