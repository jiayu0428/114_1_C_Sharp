namespace Friend_File
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除所使用的資源。
        /// Dispose 方法會在表單關閉時釋放非託管資源與託管資源。
        /// </summary>
        /// <param name="disposing">如果為 true，表示要釋放託管資源；否則僅釋放非託管資源。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計工具所需的方法 —— 請勿使用程式碼編輯器直接修改此方法內容。
        /// 本方法負責初始化表單上的元件、屬性設定（例如位置、大小、文字、字型等），
        /// 以及事件綁定。以下註解以繁體中文說明每個元件的用途與設定目的。
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(12, 19);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(279, 40);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "輸入朋友的名字:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(297, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(153, 48);
            this.nameTextBox.TabIndex = 1;
            // 
            // writeNameButton
            // 
            this.writeNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeNameButton.Location = new System.Drawing.Point(12, 200);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(176, 73);
            this.writeNameButton.TabIndex = 2;
            this.writeNameButton.Text = "寫名字";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(216, 200);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(193, 73);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 324);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.promptLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "朋友檔案";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

