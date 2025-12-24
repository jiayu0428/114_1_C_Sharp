namespace Q2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.GroupBox groupBoxOilLube;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkLube;

        private System.Windows.Forms.GroupBox groupBoxFlush;
        private System.Windows.Forms.CheckBox chkRadiator;
        private System.Windows.Forms.CheckBox chkTransmission;

        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkMuffler;
        private System.Windows.Forms.CheckBox chkTireRotation;

        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.TextBox txtHours;

        private System.Windows.Forms.GroupBox groupBoxFees;
        private System.Windows.Forms.Label labelServiceFee;
        private System.Windows.Forms.Label lblServiceFeeValue;
        private System.Windows.Forms.Label labelLaborFee;
        private System.Windows.Forms.Label lblLaborFeeValue;
        private System.Windows.Forms.Label labelPartsFee;
        private System.Windows.Forms.Label lblPartsFeeValue;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label lblTotalValue;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}

