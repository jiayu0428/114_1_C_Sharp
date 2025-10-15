﻿namespace Payroll_with_Overtime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRatePromptLabel = new System.Windows.Forms.Label();
            this.hoursWorkedPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.exitButton.Location = new System.Drawing.Point(680, 288);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(197, 67);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.clearButton.Location = new System.Drawing.Point(333, 288);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(167, 67);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.calculateButton.Location = new System.Drawing.Point(21, 288);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(222, 67);
            this.calculateButton.TabIndex = 24;
            this.calculateButton.Text = "計算薪資";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.grossPayLabel.Location = new System.Drawing.Point(333, 189);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(208, 42);
            this.grossPayLabel.TabIndex = 23;
            this.grossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(43, 176);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(200, 55);
            this.outputDescriptionLabel.TabIndex = 22;
            this.outputDescriptionLabel.Text = "總薪資：";
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(333, 90);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(185, 66);
            this.hourlyPayRateTextBox.TabIndex = 21;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(333, 7);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(185, 66);
            this.hoursWorkedTextBox.TabIndex = 20;
            // 
            // hourlyPayRatePromptLabel
            // 
            this.hourlyPayRatePromptLabel.AutoSize = true;
            this.hourlyPayRatePromptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.hourlyPayRatePromptLabel.Location = new System.Drawing.Point(87, 101);
            this.hourlyPayRatePromptLabel.Name = "hourlyPayRatePromptLabel";
            this.hourlyPayRatePromptLabel.Size = new System.Drawing.Size(156, 55);
            this.hourlyPayRatePromptLabel.TabIndex = 19;
            this.hourlyPayRatePromptLabel.Text = "時薪：";
            // 
            // hoursWorkedPromptLabel
            // 
            this.hoursWorkedPromptLabel.AutoSize = true;
            this.hoursWorkedPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.hoursWorkedPromptLabel.Location = new System.Drawing.Point(87, 18);
            this.hoursWorkedPromptLabel.Name = "hoursWorkedPromptLabel";
            this.hoursWorkedPromptLabel.Size = new System.Drawing.Size(156, 55);
            this.hoursWorkedPromptLabel.TabIndex = 18;
            this.hoursWorkedPromptLabel.Text = "工時：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(26F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 387);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hourlyPayRatePromptLabel);
            this.Controls.Add(this.hoursWorkedPromptLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.Name = "Form1";
            this.Text = "加班薪資計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.Button clearButton;
        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.Label grossPayLabel;
        internal System.Windows.Forms.Label outputDescriptionLabel;
        internal System.Windows.Forms.TextBox hourlyPayRateTextBox;
        internal System.Windows.Forms.TextBox hoursWorkedTextBox;
        internal System.Windows.Forms.Label hourlyPayRatePromptLabel;
        internal System.Windows.Forms.Label hoursWorkedPromptLabel;
    }
}

