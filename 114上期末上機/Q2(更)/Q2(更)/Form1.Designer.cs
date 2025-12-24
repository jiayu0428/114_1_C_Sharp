namespace Q2_更_
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UI controls
        private System.Windows.Forms.GroupBox groupBoxOilLubrication;
        private System.Windows.Forms.CheckBox checkBoxOilChange;
        private System.Windows.Forms.CheckBox checkBoxLubrication;

        private System.Windows.Forms.GroupBox groupBoxCleaning;
        private System.Windows.Forms.CheckBox checkBoxRadiator;
        private System.Windows.Forms.CheckBox checkBoxTransmission;

        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.CheckBox checkBoxInspection;
        private System.Windows.Forms.CheckBox checkBoxMuffler;
        private System.Windows.Forms.CheckBox checkBoxTireRotation;

        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.TextBox textBoxParts;

        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.TextBox textBoxHours;

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit; // Exit button

        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label labelServiceFee;
        private System.Windows.Forms.Label labelServiceFeeValue;
        private System.Windows.Forms.Label labelLaborFee;
        private System.Windows.Forms.Label labelLaborFeeValue;
        private System.Windows.Forms.Label labelPartsFee;
        private System.Windows.Forms.Label labelPartsFeeValue;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTaxValue;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalValue;

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
            this.groupBoxOilLubrication = new System.Windows.Forms.GroupBox();
            this.checkBoxOilChange = new System.Windows.Forms.CheckBox();
            this.checkBoxLubrication = new System.Windows.Forms.CheckBox();
            this.groupBoxCleaning = new System.Windows.Forms.GroupBox();
            this.checkBoxRadiator = new System.Windows.Forms.CheckBox();
            this.checkBoxTransmission = new System.Windows.Forms.CheckBox();
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.checkBoxInspection = new System.Windows.Forms.CheckBox();
            this.checkBoxMuffler = new System.Windows.Forms.CheckBox();
            this.checkBoxTireRotation = new System.Windows.Forms.CheckBox();
            this.labelParts = new System.Windows.Forms.Label();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelServiceFee = new System.Windows.Forms.Label();
            this.labelServiceFeeValue = new System.Windows.Forms.Label();
            this.labelLaborFee = new System.Windows.Forms.Label();
            this.labelLaborFeeValue = new System.Windows.Forms.Label();
            this.labelPartsFee = new System.Windows.Forms.Label();
            this.labelPartsFeeValue = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTaxValue = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.groupBoxOilLubrication.SuspendLayout();
            this.groupBoxCleaning.SuspendLayout();
            this.groupBoxOther.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOilLubrication
            // 
            this.groupBoxOilLubrication.Controls.Add(this.checkBoxOilChange);
            this.groupBoxOilLubrication.Controls.Add(this.checkBoxLubrication);
            this.groupBoxOilLubrication.Location = new System.Drawing.Point(12, 58);
            this.groupBoxOilLubrication.Name = "groupBoxOilLubrication";
            this.groupBoxOilLubrication.Size = new System.Drawing.Size(250, 82);
            this.groupBoxOilLubrication.TabIndex = 0;
            this.groupBoxOilLubrication.TabStop = false;
            this.groupBoxOilLubrication.Text = "機油與潤滑服務";
            // 
            // checkBoxOilChange
            // 
            this.checkBoxOilChange.Location = new System.Drawing.Point(10, 20);
            this.checkBoxOilChange.Name = "checkBoxOilChange";
            this.checkBoxOilChange.Size = new System.Drawing.Size(220, 20);
            this.checkBoxOilChange.TabIndex = 0;
            this.checkBoxOilChange.Text = "機油更換 (NT$780)";
            // 
            // checkBoxLubrication
            // 
            this.checkBoxLubrication.Location = new System.Drawing.Point(10, 46);
            this.checkBoxLubrication.Name = "checkBoxLubrication";
            this.checkBoxLubrication.Size = new System.Drawing.Size(220, 20);
            this.checkBoxLubrication.TabIndex = 1;
            this.checkBoxLubrication.Text = "潤滑保養 (NT$540)";
            // 
            // groupBoxCleaning
            // 
            this.groupBoxCleaning.Controls.Add(this.checkBoxRadiator);
            this.groupBoxCleaning.Controls.Add(this.checkBoxTransmission);
            this.groupBoxCleaning.Location = new System.Drawing.Point(13, 178);
            this.groupBoxCleaning.Name = "groupBoxCleaning";
            this.groupBoxCleaning.Size = new System.Drawing.Size(250, 80);
            this.groupBoxCleaning.TabIndex = 1;
            this.groupBoxCleaning.TabStop = false;
            this.groupBoxCleaning.Text = "清洗服務";
            // 
            // checkBoxRadiator
            // 
            this.checkBoxRadiator.Location = new System.Drawing.Point(10, 20);
            this.checkBoxRadiator.Name = "checkBoxRadiator";
            this.checkBoxRadiator.Size = new System.Drawing.Size(220, 20);
            this.checkBoxRadiator.TabIndex = 0;
            this.checkBoxRadiator.Text = "水箱清洗 (NT$900)";
            // 
            // checkBoxTransmission
            // 
            this.checkBoxTransmission.Location = new System.Drawing.Point(10, 46);
            this.checkBoxTransmission.Name = "checkBoxTransmission";
            this.checkBoxTransmission.Size = new System.Drawing.Size(220, 20);
            this.checkBoxTransmission.TabIndex = 1;
            this.checkBoxTransmission.Text = "變速箱清洗 (NT$2,400)";
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Controls.Add(this.checkBoxInspection);
            this.groupBoxOther.Controls.Add(this.checkBoxMuffler);
            this.groupBoxOther.Controls.Add(this.checkBoxTireRotation);
            this.groupBoxOther.Location = new System.Drawing.Point(3, 328);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(318, 140);
            this.groupBoxOther.TabIndex = 2;
            this.groupBoxOther.TabStop = false;
            this.groupBoxOther.Text = "其他維修服務";
            // 
            // checkBoxInspection
            // 
            this.checkBoxInspection.Location = new System.Drawing.Point(10, 19);
            this.checkBoxInspection.Name = "checkBoxInspection";
            this.checkBoxInspection.Size = new System.Drawing.Size(220, 20);
            this.checkBoxInspection.TabIndex = 0;
            this.checkBoxInspection.Text = "檢驗 (NT$450)";
            // 
            // checkBoxMuffler
            // 
            this.checkBoxMuffler.Location = new System.Drawing.Point(10, 45);
            this.checkBoxMuffler.Name = "checkBoxMuffler";
            this.checkBoxMuffler.Size = new System.Drawing.Size(220, 20);
            this.checkBoxMuffler.TabIndex = 1;
            this.checkBoxMuffler.Text = "更換消音器 (NT$3,000)";
            // 
            // checkBoxTireRotation
            // 
            this.checkBoxTireRotation.Location = new System.Drawing.Point(10, 70);
            this.checkBoxTireRotation.Name = "checkBoxTireRotation";
            this.checkBoxTireRotation.Size = new System.Drawing.Size(220, 20);
            this.checkBoxTireRotation.TabIndex = 2;
            this.checkBoxTireRotation.Text = "輪胎換位 (NT$600)";
            // 
            // labelParts
            // 
            this.labelParts.Location = new System.Drawing.Point(280, 20);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(120, 20);
            this.labelParts.TabIndex = 3;
            this.labelParts.Text = "零件費用 (NT$):";
            // 
            // textBoxParts
            // 
            this.textBoxParts.Location = new System.Drawing.Point(400, 18);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.Size = new System.Drawing.Size(120, 29);
            this.textBoxParts.TabIndex = 4;
            this.textBoxParts.Text = "0";
            this.textBoxParts.TextChanged += new System.EventHandler(this.textBoxParts_TextChanged);
            // 
            // labelHours
            // 
            this.labelHours.Location = new System.Drawing.Point(280, 60);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(120, 20);
            this.labelHours.TabIndex = 5;
            this.labelHours.Text = "工時 (小時):";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(400, 58);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(120, 29);
            this.textBoxHours.TabIndex = 6;
            this.textBoxHours.Text = "0";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(280, 100);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 30);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "計算";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(420, 100);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(560, 100);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 30);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.labelServiceFee);
            this.groupBoxResults.Controls.Add(this.labelServiceFeeValue);
            this.groupBoxResults.Controls.Add(this.labelLaborFee);
            this.groupBoxResults.Controls.Add(this.labelLaborFeeValue);
            this.groupBoxResults.Controls.Add(this.labelPartsFee);
            this.groupBoxResults.Controls.Add(this.labelPartsFeeValue);
            this.groupBoxResults.Controls.Add(this.labelTax);
            this.groupBoxResults.Controls.Add(this.labelTaxValue);
            this.groupBoxResults.Controls.Add(this.labelTotal);
            this.groupBoxResults.Controls.Add(this.labelTotalValue);
            this.groupBoxResults.Location = new System.Drawing.Point(22, 493);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(760, 170);
            this.groupBoxResults.TabIndex = 10;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "費用明細";
            // 
            // labelServiceFee
            // 
            this.labelServiceFee.Location = new System.Drawing.Point(10, 25);
            this.labelServiceFee.Name = "labelServiceFee";
            this.labelServiceFee.Size = new System.Drawing.Size(150, 20);
            this.labelServiceFee.TabIndex = 0;
            this.labelServiceFee.Text = "服務與工資總額:";
            // 
            // labelServiceFeeValue
            // 
            this.labelServiceFeeValue.Location = new System.Drawing.Point(170, 25);
            this.labelServiceFeeValue.Name = "labelServiceFeeValue";
            this.labelServiceFeeValue.Size = new System.Drawing.Size(200, 20);
            this.labelServiceFeeValue.TabIndex = 1;
            this.labelServiceFeeValue.Text = "NT$ 0";
            // 
            // labelLaborFee
            // 
            this.labelLaborFee.Location = new System.Drawing.Point(10, 50);
            this.labelLaborFee.Name = "labelLaborFee";
            this.labelLaborFee.Size = new System.Drawing.Size(150, 20);
            this.labelLaborFee.TabIndex = 2;
            this.labelLaborFee.Text = "工時費用:";
            // 
            // labelLaborFeeValue
            // 
            this.labelLaborFeeValue.Location = new System.Drawing.Point(170, 50);
            this.labelLaborFeeValue.Name = "labelLaborFeeValue";
            this.labelLaborFeeValue.Size = new System.Drawing.Size(200, 20);
            this.labelLaborFeeValue.TabIndex = 3;
            this.labelLaborFeeValue.Text = "NT$ 0";
            // 
            // labelPartsFee
            // 
            this.labelPartsFee.Location = new System.Drawing.Point(10, 75);
            this.labelPartsFee.Name = "labelPartsFee";
            this.labelPartsFee.Size = new System.Drawing.Size(150, 20);
            this.labelPartsFee.TabIndex = 4;
            this.labelPartsFee.Text = "零件費用:";
            // 
            // labelPartsFeeValue
            // 
            this.labelPartsFeeValue.Location = new System.Drawing.Point(170, 75);
            this.labelPartsFeeValue.Name = "labelPartsFeeValue";
            this.labelPartsFeeValue.Size = new System.Drawing.Size(200, 20);
            this.labelPartsFeeValue.TabIndex = 5;
            this.labelPartsFeeValue.Text = "NT$ 0";
            // 
            // labelTax
            // 
            this.labelTax.Location = new System.Drawing.Point(10, 100);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(150, 20);
            this.labelTax.TabIndex = 6;
            this.labelTax.Text = "稅金 (6%):";
            // 
            // labelTaxValue
            // 
            this.labelTaxValue.Location = new System.Drawing.Point(170, 100);
            this.labelTaxValue.Name = "labelTaxValue";
            this.labelTaxValue.Size = new System.Drawing.Size(200, 20);
            this.labelTaxValue.TabIndex = 7;
            this.labelTaxValue.Text = "NT$ 0";
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(10, 125);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(150, 25);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "總費用:";
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold);
            this.labelTotalValue.Location = new System.Drawing.Point(170, 125);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(200, 25);
            this.labelTotalValue.TabIndex = 9;
            this.labelTotalValue.Text = "NT$ 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 711);
            this.Controls.Add(this.groupBoxOilLubrication);
            this.Controls.Add(this.groupBoxCleaning);
            this.Controls.Add(this.groupBoxOther);
            this.Controls.Add(this.labelParts);
            this.Controls.Add(this.textBoxParts);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxResults);
            this.Name = "Form1";
            this.Text = "汽車維修費用計算系統";
            this.groupBoxOilLubrication.ResumeLayout(false);
            this.groupBoxCleaning.ResumeLayout(false);
            this.groupBoxOther.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

