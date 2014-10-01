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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(647, 443);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.buttonFindDraw);
            this.tabPage1.Controls.Add(this.pointsGridDraw);
            this.tabPage1.Controls.Add(this.buttonClearDraw);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "直接绘点";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFindDraw
            // 
            this.buttonFindDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindDraw.Location = new System.Drawing.Point(520, 27);
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
            this.pointsGridDraw.Location = new System.Drawing.Point(415, 68);
            this.pointsGridDraw.Name = "pointsGridDraw";
            this.pointsGridDraw.ReadOnly = true;
            this.pointsGridDraw.RowTemplate.Height = 23;
            this.pointsGridDraw.Size = new System.Drawing.Size(200, 313);
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
            this.buttonClearDraw.Location = new System.Drawing.Point(424, 27);
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
            this.panel1.Size = new System.Drawing.Size(377, 403);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "随机生成点";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 21);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 443);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "寻找最近点对";
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridDraw)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox1;
    }
}

