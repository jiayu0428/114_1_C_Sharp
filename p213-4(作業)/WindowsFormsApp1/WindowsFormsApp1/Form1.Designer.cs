namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grossIncomeLabel = new System.Windows.Forms.Label();
            this.standardDeductionLabel = new System.Windows.Forms.Label();
            this.otherExemptionsLabel = new System.Windows.Forms.Label();
            this.netIncomeLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.taxPayableLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 29);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 29);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 29);
            this.textBox3.TabIndex = 2;
            // 
            // grossIncomeLabel
            // 
            this.grossIncomeLabel.AutoSize = true;
            this.grossIncomeLabel.Location = new System.Drawing.Point(73, 71);
            this.grossIncomeLabel.Name = "grossIncomeLabel";
            this.grossIncomeLabel.Size = new System.Drawing.Size(62, 18);
            this.grossIncomeLabel.TabIndex = 3;
            this.grossIncomeLabel.Text = "總收入";
            // 
            // standardDeductionLabel
            // 
            this.standardDeductionLabel.AutoSize = true;
            this.standardDeductionLabel.Location = new System.Drawing.Point(37, 130);
            this.standardDeductionLabel.Name = "standardDeductionLabel";
            this.standardDeductionLabel.Size = new System.Drawing.Size(98, 18);
            this.standardDeductionLabel.TabIndex = 4;
            this.standardDeductionLabel.Text = "標準扣除額";
            // 
            // otherExemptionsLabel
            // 
            this.otherExemptionsLabel.AutoSize = true;
            this.otherExemptionsLabel.Location = new System.Drawing.Point(37, 185);
            this.otherExemptionsLabel.Name = "otherExemptionsLabel";
            this.otherExemptionsLabel.Size = new System.Drawing.Size(98, 18);
            this.otherExemptionsLabel.TabIndex = 5;
            this.otherExemptionsLabel.Text = "其他豁免額";
            // 
            // netIncomeLabel
            // 
            this.netIncomeLabel.AutoSize = true;
            this.netIncomeLabel.Location = new System.Drawing.Point(402, 63);
            this.netIncomeLabel.Name = "netIncomeLabel";
            this.netIncomeLabel.Size = new System.Drawing.Size(62, 18);
            this.netIncomeLabel.TabIndex = 6;
            this.netIncomeLabel.Text = "淨收入";
            this.netIncomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(479, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 29);
            this.textBox4.TabIndex = 7;
            // 
            // taxPayableLabel
            // 
            this.taxPayableLabel.AutoSize = true;
            this.taxPayableLabel.Location = new System.Drawing.Point(357, 130);
            this.taxPayableLabel.Name = "taxPayableLabel";
            this.taxPayableLabel.Size = new System.Drawing.Size(116, 18);
            this.taxPayableLabel.TabIndex = 8;
            this.taxPayableLabel.Text = "個人應繳稅款";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(479, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 29);
            this.textBox5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.taxPayableLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.netIncomeLabel);
            this.Controls.Add(this.otherExemptionsLabel);
            this.Controls.Add(this.standardDeductionLabel);
            this.Controls.Add(this.grossIncomeLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label grossIncomeLabel;
        private System.Windows.Forms.Label standardDeductionLabel;
        private System.Windows.Forms.Label otherExemptionsLabel;
        private System.Windows.Forms.Label netIncomeLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label taxPayableLabel;
        private System.Windows.Forms.TextBox textBox5;
    }
}

