namespace RadioButtonDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.blackTeaRadioButton = new System.Windows.Forms.RadioButton();
            this.milkTeaRadioButton = new System.Windows.Forms.RadioButton();
            this.juiceRadioButton = new System.Windows.Forms.RadioButton();
            this.coffeeRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tunaSanRadioButton = new System.Windows.Forms.RadioButton();
            this.hamSanRadioButton = new System.Windows.Forms.RadioButton();
            this.jellySanRadioButton = new System.Windows.Forms.RadioButton();
            this.sendButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blackTeaRadioButton);
            this.groupBox1.Controls.Add(this.milkTeaRadioButton);
            this.groupBox1.Controls.Add(this.juiceRadioButton);
            this.groupBox1.Controls.Add(this.coffeeRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(62, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 327);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飲料";
            // 
            // blackTeaRadioButton
            // 
            this.blackTeaRadioButton.AutoSize = true;
            this.blackTeaRadioButton.Location = new System.Drawing.Point(90, 174);
            this.blackTeaRadioButton.Name = "blackTeaRadioButton";
            this.blackTeaRadioButton.Size = new System.Drawing.Size(103, 36);
            this.blackTeaRadioButton.TabIndex = 7;
            this.blackTeaRadioButton.TabStop = true;
            this.blackTeaRadioButton.Text = "紅茶";
            this.blackTeaRadioButton.UseVisualStyleBackColor = true;
            // 
            // milkTeaRadioButton
            // 
            this.milkTeaRadioButton.AutoSize = true;
            this.milkTeaRadioButton.Location = new System.Drawing.Point(90, 114);
            this.milkTeaRadioButton.Name = "milkTeaRadioButton";
            this.milkTeaRadioButton.Size = new System.Drawing.Size(103, 36);
            this.milkTeaRadioButton.TabIndex = 6;
            this.milkTeaRadioButton.TabStop = true;
            this.milkTeaRadioButton.Text = "奶茶";
            this.milkTeaRadioButton.UseVisualStyleBackColor = true;
            // 
            // juiceRadioButton
            // 
            this.juiceRadioButton.AutoSize = true;
            this.juiceRadioButton.Location = new System.Drawing.Point(90, 233);
            this.juiceRadioButton.Name = "juiceRadioButton";
            this.juiceRadioButton.Size = new System.Drawing.Size(103, 36);
            this.juiceRadioButton.TabIndex = 5;
            this.juiceRadioButton.TabStop = true;
            this.juiceRadioButton.Text = "果汁";
            this.juiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // coffeeRadioButton
            // 
            this.coffeeRadioButton.AutoSize = true;
            this.coffeeRadioButton.Location = new System.Drawing.Point(90, 60);
            this.coffeeRadioButton.Name = "coffeeRadioButton";
            this.coffeeRadioButton.Size = new System.Drawing.Size(103, 36);
            this.coffeeRadioButton.TabIndex = 4;
            this.coffeeRadioButton.TabStop = true;
            this.coffeeRadioButton.Text = "咖啡";
            this.coffeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tunaSanRadioButton);
            this.groupBox2.Controls.Add(this.hamSanRadioButton);
            this.groupBox2.Controls.Add(this.jellySanRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(331, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 291);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "三明治";
            // 
            // tunaSanRadioButton
            // 
            this.tunaSanRadioButton.AutoSize = true;
            this.tunaSanRadioButton.Location = new System.Drawing.Point(29, 193);
            this.tunaSanRadioButton.Name = "tunaSanRadioButton";
            this.tunaSanRadioButton.Size = new System.Drawing.Size(199, 36);
            this.tunaSanRadioButton.TabIndex = 9;
            this.tunaSanRadioButton.TabStop = true;
            this.tunaSanRadioButton.Text = "鮪魚三明治";
            this.tunaSanRadioButton.UseVisualStyleBackColor = true;
            // 
            // hamSanRadioButton
            // 
            this.hamSanRadioButton.AutoSize = true;
            this.hamSanRadioButton.Location = new System.Drawing.Point(29, 132);
            this.hamSanRadioButton.Name = "hamSanRadioButton";
            this.hamSanRadioButton.Size = new System.Drawing.Size(199, 36);
            this.hamSanRadioButton.TabIndex = 8;
            this.hamSanRadioButton.TabStop = true;
            this.hamSanRadioButton.Text = "火腿三明治";
            this.hamSanRadioButton.UseVisualStyleBackColor = true;
            // 
            // jellySanRadioButton
            // 
            this.jellySanRadioButton.AutoSize = true;
            this.jellySanRadioButton.Location = new System.Drawing.Point(29, 77);
            this.jellySanRadioButton.Name = "jellySanRadioButton";
            this.jellySanRadioButton.Size = new System.Drawing.Size(199, 36);
            this.jellySanRadioButton.TabIndex = 7;
            this.jellySanRadioButton.TabStop = true;
            this.jellySanRadioButton.Text = "果醬三明治";
            this.jellySanRadioButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sendButton.Location = new System.Drawing.Point(99, 481);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(171, 83);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "送出訂單";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(373, 481);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 83);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 764);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton blackTeaRadioButton;
        private System.Windows.Forms.RadioButton milkTeaRadioButton;
        private System.Windows.Forms.RadioButton juiceRadioButton;
        private System.Windows.Forms.RadioButton coffeeRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton tunaSanRadioButton;
        private System.Windows.Forms.RadioButton hamSanRadioButton;
        private System.Windows.Forms.RadioButton jellySanRadioButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button exitButton;
    }
}

