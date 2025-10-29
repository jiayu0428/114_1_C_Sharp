namespace p132_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.coinTailsPictureBox = new System.Windows.Forms.PictureBox();
            this.coinHeadsPictureBox = new System.Windows.Forms.PictureBox();
            this.showTailsButton = new System.Windows.Forms.Button();
            this.showHeadsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coinTailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinHeadsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // coinTailsPictureBox
            // 
            this.coinTailsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("coinTailsPictureBox.Image")));
            this.coinTailsPictureBox.Location = new System.Drawing.Point(472, 74);
            this.coinTailsPictureBox.Name = "coinTailsPictureBox";
            this.coinTailsPictureBox.Size = new System.Drawing.Size(161, 156);
            this.coinTailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinTailsPictureBox.TabIndex = 0;
            this.coinTailsPictureBox.TabStop = false;
            // 
            // coinHeadsPictureBox
            // 
            this.coinHeadsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("coinHeadsPictureBox.Image")));
            this.coinHeadsPictureBox.Location = new System.Drawing.Point(120, 74);
            this.coinHeadsPictureBox.Name = "coinHeadsPictureBox";
            this.coinHeadsPictureBox.Size = new System.Drawing.Size(170, 156);
            this.coinHeadsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinHeadsPictureBox.TabIndex = 1;
            this.coinHeadsPictureBox.TabStop = false;
            this.coinHeadsPictureBox.Click += new System.EventHandler(this.coinHeadsPictureBox_Click);
            // 
            // showTailsButton
            // 
            this.showTailsButton.Location = new System.Drawing.Point(327, 272);
            this.showTailsButton.Name = "showTailsButton";
            this.showTailsButton.Size = new System.Drawing.Size(126, 43);
            this.showTailsButton.TabIndex = 2;
            this.showTailsButton.Text = "顯示背面";
            this.showTailsButton.UseVisualStyleBackColor = true;
            this.showTailsButton.Click += new System.EventHandler(this.showTailsButton_Click);
            // 
            // showHeadsButton
            // 
            this.showHeadsButton.Location = new System.Drawing.Point(135, 272);
            this.showHeadsButton.Name = "showHeadsButton";
            this.showHeadsButton.Size = new System.Drawing.Size(130, 45);
            this.showHeadsButton.TabIndex = 3;
            this.showHeadsButton.Text = "顯示正面";
            this.showHeadsButton.UseVisualStyleBackColor = true;
            this.showHeadsButton.Click += new System.EventHandler(this.showHeadsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(547, 272);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 43);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showHeadsButton);
            this.Controls.Add(this.showTailsButton);
            this.Controls.Add(this.coinHeadsPictureBox);
            this.Controls.Add(this.coinTailsPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coinTailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinHeadsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox coinTailsPictureBox;
        private System.Windows.Forms.PictureBox coinHeadsPictureBox;
        private System.Windows.Forms.Button showTailsButton;
        private System.Windows.Forms.Button showHeadsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

