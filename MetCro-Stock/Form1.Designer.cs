namespace MetCro_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar_Sim = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripTextBox_KNum = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Label1 = new System.Windows.Forms.Label();
            this.toolStripButton_Layout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_test = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Kally = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton_Layout,
            this.toolStripTextBox_KNum,
            this.toolStripButton_Start,
            this.toolStripSeparator2,
            this.toolStripProgressBar_Sim,
            this.toolStripSeparator3,
            this.toolStripButton_test,
            this.toolStripButton_Kally});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(612, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripProgressBar_Sim
            // 
            this.toolStripProgressBar_Sim.Name = "toolStripProgressBar_Sim";
            this.toolStripProgressBar_Sim.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripTextBox_KNum
            // 
            this.toolStripTextBox_KNum.Font = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox_KNum.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox_KNum.Name = "toolStripTextBox_KNum";
            this.toolStripTextBox_KNum.Size = new System.Drawing.Size(150, 25);
            this.toolStripTextBox_KNum.Text = "输入上下共模拟K线数目...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(512, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 12);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "条目数...";
            // 
            // toolStripButton_Layout
            // 
            this.toolStripButton_Layout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Layout.Image = global::MetCro_Stock.Properties.Resources.icons8_layout_48;
            this.toolStripButton_Layout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Layout.Name = "toolStripButton_Layout";
            this.toolStripButton_Layout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Layout.Text = "toolStripButton2";
            this.toolStripButton_Layout.Click += new System.EventHandler(this.ToolStripButton_Layout_Click);
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Start.Image = global::MetCro_Stock.Properties.Resources.start;
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Start.Text = "toolStripButton1";
            this.toolStripButton_Start.Click += new System.EventHandler(this.ToolStripButton_Start_Click);
            // 
            // toolStripButton_test
            // 
            this.toolStripButton_test.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_test.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_test.Image")));
            this.toolStripButton_test.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_test.Name = "toolStripButton_test";
            this.toolStripButton_test.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton_test.Text = "测试树";
            this.toolStripButton_test.Click += new System.EventHandler(this.ToolStripButton_test_Click);
            // 
            // toolStripButton_Kally
            // 
            this.toolStripButton_Kally.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Kally.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Kally.Image")));
            this.toolStripButton_Kally.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Kally.Name = "toolStripButton_Kally";
            this.toolStripButton_Kally.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton_Kally.Text = "Kally资金管理";
            this.toolStripButton_Kally.Click += new System.EventHandler(this.ToolStripButton_Kally_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 297);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "蒙特卡罗-股价走势模拟器";
            this.Load += new System.EventHandler(this.Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Layout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_Sim;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_KNum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_test;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Kally;
    }
}

