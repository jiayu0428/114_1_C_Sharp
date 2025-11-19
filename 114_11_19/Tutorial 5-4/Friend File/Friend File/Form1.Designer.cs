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
            this.SuspendLayout();
            // 
            // promptLabel
            // 
            // 提示用 Label：提示使用者輸入朋友名字。
            // 設定字型為 18 號以符合需求（字型家族使用預設的 Microsoft Sans Serif）。
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(12, 19);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(109, 13);
            this.promptLabel.TabIndex = 0;
            // 將提示文字設為繁體中文，末尾保留冒號以提示輸入欄位
            this.promptLabel.Text = "輸入朋友的名字:";
            // 
            // nameTextBox
            // 
            // 用來輸入朋友名字的文字方塊（TextBox）。
            // 同樣將字型設定為 18 號，讓輸入內容與介面字型一致。
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(127, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(153, 20);
            this.nameTextBox.TabIndex = 1;
            // 注意：TextBox 初始文字保留為空白，讓使用者輸入。
            // 
            // writeNameButton
            // 
            // 按鈕：將輸入的名字寫出/顯示或執行相關處理（事件在 Form1.cs 中實作）。
            // 字型設為 18，以符合全域 UI 字型大小需求。
            this.writeNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeNameButton.Location = new System.Drawing.Point(70, 56);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(75, 23);
            this.writeNameButton.TabIndex = 2;
            // 將按鈕文字改為繁體中文
            this.writeNameButton.Text = "寫名字";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // exitButton
            // 
            // 按鈕：離開或關閉表單。事件在 Form1.cs 中實作。
            // 字型設為 18，以保持介面一致性。
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(151, 56);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            // 將按鈕文字改為較常見的繁體用語「離開」
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 表單本身：設定預設自動縮放模式與表單大小（未變更）。
            // 同時將表單的字型設定為 18，以確保標題列及預設控制項樣式一致。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 96);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            // 將表單標題設為繁體中文
            this.Text = "朋友檔案";
            // 將表單的預設字型也設定為 18，以讓整體 UI 字型一致（若某控制項未額外指定字型，會繼承此設定）。
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

