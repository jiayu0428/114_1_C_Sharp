namespace Tutorial2_5
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
            this.cardbackPictureBox = new System.Windows.Forms.PictureBox();
            this.cardfacePictureBox = new System.Windows.Forms.PictureBox();
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardbackPictureBox
            // 
            this.cardbackPictureBox.Image = global::Tutorial2_5.Properties.Resources.Backface_Red;
            this.cardbackPictureBox.Location = new System.Drawing.Point(305, 26);
            this.cardbackPictureBox.Name = "cardbackPictureBox";
            this.cardbackPictureBox.Size = new System.Drawing.Size(167, 271);
            this.cardbackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardbackPictureBox.TabIndex = 1;
            this.cardbackPictureBox.TabStop = false;
            this.cardbackPictureBox.Click += new System.EventHandler(this.cardbackPictureBox_Click);
            // 
            // cardfacePictureBox
            // 
            this.cardfacePictureBox.Image = global::Tutorial2_5.Properties.Resources.Ace_Hearts;
            this.cardfacePictureBox.Location = new System.Drawing.Point(305, 26);
            this.cardfacePictureBox.Name = "cardfacePictureBox";
            this.cardfacePictureBox.Size = new System.Drawing.Size(164, 271);
            this.cardfacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardfacePictureBox.TabIndex = 0;
            this.cardfacePictureBox.TabStop = false;
            // 
            // showBackButton
            // 
            this.showBackButton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showBackButton.Location = new System.Drawing.Point(79, 326);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(249, 91);
            this.showBackButton.TabIndex = 2;
            this.showBackButton.Text = "顯示背面";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFaceButton
            // 
            this.showFaceButton.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showFaceButton.Location = new System.Drawing.Point(423, 326);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(260, 91);
            this.showFaceButton.TabIndex = 3;
            this.showFaceButton.Text = "顯示正面";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.cardbackPictureBox);
            this.Controls.Add(this.cardfacePictureBox);
            this.Name = "Form1";
            this.Text = "翻轉撲克牌";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardbackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardfacePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardfacePictureBox;
        private System.Windows.Forms.PictureBox cardbackPictureBox;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
    }
}

