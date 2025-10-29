namespace MultipleConditionsDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Button judgeButton;
        private System.Windows.Forms.Label gradeTextBox;

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
            this.labelGrade = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.judgeButton = new System.Windows.Forms.Button();
            this.gradeTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrade.Location = new System.Drawing.Point(12, 18);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(122, 52);
            this.labelGrade.TabIndex = 0;
            this.labelGrade.Text = "成績:";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextBox.Location = new System.Drawing.Point(140, 18);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(140, 57);
            this.scoreTextBox.TabIndex = 1;
            // 
            // judgeButton
            // 
            this.judgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judgeButton.Location = new System.Drawing.Point(48, 316);
            this.judgeButton.Name = "judgeButton";
            this.judgeButton.Size = new System.Drawing.Size(259, 91);
            this.judgeButton.TabIndex = 2;
            this.judgeButton.Text = "等級判斷";
            this.judgeButton.UseVisualStyleBackColor = true;
            this.judgeButton.Click += new System.EventHandler(this.judgeButton_Click);
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gradeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTextBox.Location = new System.Drawing.Point(140, 124);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(259, 83);
            this.gradeTextBox.TabIndex = 3;
            this.gradeTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "等級:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.judgeButton);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.labelGrade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

