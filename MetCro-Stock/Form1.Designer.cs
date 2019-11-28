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
            this.toolStripTextBox_KNum = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar_Sim = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.交易ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_TradeControl = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox_Instrumens = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel_ItemsMarkets = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_Time = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_MarketBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_MarketBegin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_MarketFuture = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_AddTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_DeCreaseTime = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Layout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Kally = new System.Windows.Forms.ToolStripButton();
            this.tradeUserControl1 = new MetCro_Stock.TradeUserControl();
            this.toolStripButton_StartRealMarketGoing = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripButton_Layout,
            this.toolStripTextBox_KNum,
            this.toolStripButton_Start,
            this.toolStripSeparator2,
            this.toolStripProgressBar_Sim,
            this.toolStripSeparator3,
            this.toolStripButton_Kally});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(918, 36);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripTextBox_KNum
            // 
            this.toolStripTextBox_KNum.Font = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripTextBox_KNum.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox_KNum.Name = "toolStripTextBox_KNum";
            this.toolStripTextBox_KNum.Size = new System.Drawing.Size(223, 36);
            this.toolStripTextBox_KNum.Text = "输入上下共模拟K线数目...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripProgressBar_Sim
            // 
            this.toolStripProgressBar_Sim.Name = "toolStripProgressBar_Sim";
            this.toolStripProgressBar_Sim.Size = new System.Drawing.Size(150, 33);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(768, 9);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 18);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "条目数...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.交易ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 32);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 交易ToolStripMenuItem
            // 
            this.交易ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_TradeControl,
            this.ToolStripMenuItem_Report});
            this.交易ToolStripMenuItem.Name = "交易ToolStripMenuItem";
            this.交易ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.交易ToolStripMenuItem.Text = "交易";
            // 
            // ToolStripMenuItem_TradeControl
            // 
            this.ToolStripMenuItem_TradeControl.Name = "ToolStripMenuItem_TradeControl";
            this.ToolStripMenuItem_TradeControl.Size = new System.Drawing.Size(164, 30);
            this.ToolStripMenuItem_TradeControl.Text = "交易界面";
            this.ToolStripMenuItem_TradeControl.Click += new System.EventHandler(this.ToolStripMenuItem_TradeControl_Click);
            // 
            // ToolStripMenuItem_Report
            // 
            this.ToolStripMenuItem_Report.Name = "ToolStripMenuItem_Report";
            this.ToolStripMenuItem_Report.Size = new System.Drawing.Size(164, 30);
            this.ToolStripMenuItem_Report.Text = "绩效报告";
            this.ToolStripMenuItem_Report.Click += new System.EventHandler(this.ToolStripMenuItem_Report_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripComboBox_Instrumens,
            this.toolStripLabel_ItemsMarkets,
            this.toolStripButton_MarketBack,
            this.toolStripButton_MarketBegin,
            this.toolStripButton_MarketFuture,
            this.toolStripButton6,
            this.toolStripButton_AddTime,
            this.toolStripTextBox_Time,
            this.toolStripButton_DeCreaseTime,
            this.toolStripButton_StartRealMarketGoing});
            this.toolStrip2.Location = new System.Drawing.Point(0, 68);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(918, 32);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripComboBox_Instrumens
            // 
            this.toolStripComboBox_Instrumens.Name = "toolStripComboBox_Instrumens";
            this.toolStripComboBox_Instrumens.Size = new System.Drawing.Size(121, 32);
            this.toolStripComboBox_Instrumens.Click += new System.EventHandler(this.ComboxItems_Click);
            // 
            // toolStripLabel_ItemsMarkets
            // 
            this.toolStripLabel_ItemsMarkets.Name = "toolStripLabel_ItemsMarkets";
            this.toolStripLabel_ItemsMarkets.Size = new System.Drawing.Size(86, 29);
            this.toolStripLabel_ItemsMarkets.Text = "总条目数:";
            // 
            // toolStripTextBox_Time
            // 
            this.toolStripTextBox_Time.Name = "toolStripTextBox_Time";
            this.toolStripTextBox_Time.Size = new System.Drawing.Size(100, 32);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(0, 29);
            // 
            // toolStripButton_MarketBack
            // 
            this.toolStripButton_MarketBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_MarketBack.Image = global::MetCro_Stock.Properties.Resources.anniu;
            this.toolStripButton_MarketBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_MarketBack.Name = "toolStripButton_MarketBack";
            this.toolStripButton_MarketBack.Size = new System.Drawing.Size(28, 29);
            this.toolStripButton_MarketBack.Text = "toolStripButton3";
            this.toolStripButton_MarketBack.Click += new System.EventHandler(this.ToolStripButton_MarketBack_Click);
            // 
            // toolStripButton_MarketBegin
            // 
            this.toolStripButton_MarketBegin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_MarketBegin.Image = global::MetCro_Stock.Properties.Resources.start;
            this.toolStripButton_MarketBegin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_MarketBegin.Name = "toolStripButton_MarketBegin";
            this.toolStripButton_MarketBegin.Size = new System.Drawing.Size(28, 29);
            this.toolStripButton_MarketBegin.Text = "toolStripButton5";
            this.toolStripButton_MarketBegin.Click += new System.EventHandler(this.ToolStripButton_MarketBegin_Click);
            // 
            // toolStripButton_MarketFuture
            // 
            this.toolStripButton_MarketFuture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_MarketFuture.Image = global::MetCro_Stock.Properties.Resources.anniu1;
            this.toolStripButton_MarketFuture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_MarketFuture.Name = "toolStripButton_MarketFuture";
            this.toolStripButton_MarketFuture.Size = new System.Drawing.Size(28, 29);
            this.toolStripButton_MarketFuture.Text = "toolStripButton2";
            this.toolStripButton_MarketFuture.Click += new System.EventHandler(this.ToolStripButton_MarketFuture_Click);
            // 
            // toolStripButton_AddTime
            // 
            this.toolStripButton_AddTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_AddTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AddTime.Image")));
            this.toolStripButton_AddTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddTime.Name = "toolStripButton_AddTime";
            this.toolStripButton_AddTime.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton_AddTime.Text = "+";
            this.toolStripButton_AddTime.Click += new System.EventHandler(this.ToolStripButton_AddTime_Click);
            // 
            // toolStripButton_DeCreaseTime
            // 
            this.toolStripButton_DeCreaseTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_DeCreaseTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_DeCreaseTime.Image")));
            this.toolStripButton_DeCreaseTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DeCreaseTime.Name = "toolStripButton_DeCreaseTime";
            this.toolStripButton_DeCreaseTime.Size = new System.Drawing.Size(23, 29);
            this.toolStripButton_DeCreaseTime.Text = "-";
            this.toolStripButton_DeCreaseTime.Click += new System.EventHandler(this.ToolStripButton_DeCreaseTime_Click);
            // 
            // toolStripButton_Layout
            // 
            this.toolStripButton_Layout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Layout.Image = global::MetCro_Stock.Properties.Resources.icons8_layout_48;
            this.toolStripButton_Layout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Layout.Name = "toolStripButton_Layout";
            this.toolStripButton_Layout.Size = new System.Drawing.Size(28, 33);
            this.toolStripButton_Layout.Text = "toolStripButton2";
            this.toolStripButton_Layout.Click += new System.EventHandler(this.ToolStripButton_Layout_Click);
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Start.Image = global::MetCro_Stock.Properties.Resources.start;
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(28, 33);
            this.toolStripButton_Start.Text = "toolStripButton1";
            this.toolStripButton_Start.Click += new System.EventHandler(this.ToolStripButton_Start_Click);
            // 
            // toolStripButton_Kally
            // 
            this.toolStripButton_Kally.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Kally.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Kally.Image")));
            this.toolStripButton_Kally.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Kally.Name = "toolStripButton_Kally";
            this.toolStripButton_Kally.Size = new System.Drawing.Size(127, 33);
            this.toolStripButton_Kally.Text = "Kally资金管理";
            this.toolStripButton_Kally.Click += new System.EventHandler(this.ToolStripButton_Kally_Click);
            // 
            // tradeUserControl1
            // 
            this.tradeUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tradeUserControl1.Location = new System.Drawing.Point(0, 304);
            this.tradeUserControl1.Name = "tradeUserControl1";
            this.tradeUserControl1.Size = new System.Drawing.Size(918, 142);
            this.tradeUserControl1.TabIndex = 4;
            this.tradeUserControl1.Visible = false;
            // 
            // toolStripButton_StartRealMarketGoing
            // 
            this.toolStripButton_StartRealMarketGoing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_StartRealMarketGoing.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_StartRealMarketGoing.Image")));
            this.toolStripButton_StartRealMarketGoing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_StartRealMarketGoing.Name = "toolStripButton_StartRealMarketGoing";
            this.toolStripButton_StartRealMarketGoing.Size = new System.Drawing.Size(50, 29);
            this.toolStripButton_StartRealMarketGoing.Text = "启动";
            this.toolStripButton_StartRealMarketGoing.Click += new System.EventHandler(this.ToolStripButton_StartRealMarketGoing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 446);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.tradeUserControl1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "蒙特卡罗-股价走势模拟器";
            this.Load += new System.EventHandler(this.Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Kally;
        private TradeUserControl tradeUserControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 交易ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_TradeControl;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Report;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Instrumens;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_ItemsMarkets;
        private System.Windows.Forms.ToolStripButton toolStripButton_MarketBack;
        private System.Windows.Forms.ToolStripButton toolStripButton_MarketBegin;
        private System.Windows.Forms.ToolStripButton toolStripButton_MarketFuture;
        private System.Windows.Forms.ToolStripSeparator toolStripButton6;
        private System.Windows.Forms.ToolStripLabel toolStripButton_AddTime;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Time;
        private System.Windows.Forms.ToolStripButton toolStripButton_DeCreaseTime;
        private System.Windows.Forms.ToolStripButton toolStripButton_StartRealMarketGoing;
    }
}

