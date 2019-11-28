namespace MetCro_Stock
{
    partial class TradeUserControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Buy = new System.Windows.Forms.Button();
            this.button_PB = new System.Windows.Forms.Button();
            this.button_SellShort = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Buy
            // 
            this.button_Buy.Location = new System.Drawing.Point(47, 34);
            this.button_Buy.Name = "button_Buy";
            this.button_Buy.Size = new System.Drawing.Size(75, 27);
            this.button_Buy.TabIndex = 0;
            this.button_Buy.Text = "开多";
            this.button_Buy.UseVisualStyleBackColor = true;
            // 
            // button_PB
            // 
            this.button_PB.Location = new System.Drawing.Point(240, 34);
            this.button_PB.Name = "button_PB";
            this.button_PB.Size = new System.Drawing.Size(75, 27);
            this.button_PB.TabIndex = 1;
            this.button_PB.Text = "平多";
            this.button_PB.UseVisualStyleBackColor = true;
            // 
            // button_SellShort
            // 
            this.button_SellShort.Location = new System.Drawing.Point(47, 94);
            this.button_SellShort.Name = "button_SellShort";
            this.button_SellShort.Size = new System.Drawing.Size(75, 28);
            this.button_SellShort.TabIndex = 2;
            this.button_SellShort.Text = "开空";
            this.button_SellShort.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "平空";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 28);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(321, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 28);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(77, 28);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "2";
            // 
            // TradeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_SellShort);
            this.Controls.Add(this.button_PB);
            this.Controls.Add(this.button_Buy);
            this.Name = "TradeUserControl";
            this.Size = new System.Drawing.Size(912, 316);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Buy;
        private System.Windows.Forms.Button button_PB;
        private System.Windows.Forms.Button button_SellShort;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
