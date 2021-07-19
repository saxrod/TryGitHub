
namespace _20210716_HW
{
    partial class TaxCalculator
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
            this.yearModeRadioButton = new System.Windows.Forms.RadioButton();
            this.daysModeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alertLabel = new System.Windows.Forms.Label();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.CCLabel = new System.Windows.Forms.Label();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resetButton = new System.Windows.Forms.Button();
            this.comfirmButton = new System.Windows.Forms.Button();
            this.CCComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearModeRadioButton
            // 
            this.yearModeRadioButton.AutoSize = true;
            this.yearModeRadioButton.Location = new System.Drawing.Point(34, 62);
            this.yearModeRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearModeRadioButton.Name = "yearModeRadioButton";
            this.yearModeRadioButton.Size = new System.Drawing.Size(73, 19);
            this.yearModeRadioButton.TabIndex = 0;
            this.yearModeRadioButton.TabStop = true;
            this.yearModeRadioButton.Text = "全年度";
            this.yearModeRadioButton.UseVisualStyleBackColor = true;
            this.yearModeRadioButton.CheckedChanged += new System.EventHandler(this.yearModeRadioButton_CheckedChanged);
            // 
            // daysModeRadioButton2
            // 
            this.daysModeRadioButton2.AutoSize = true;
            this.daysModeRadioButton2.Location = new System.Drawing.Point(115, 62);
            this.daysModeRadioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daysModeRadioButton2.Name = "daysModeRadioButton2";
            this.daysModeRadioButton2.Size = new System.Drawing.Size(73, 19);
            this.daysModeRadioButton2.TabIndex = 1;
            this.daysModeRadioButton2.TabStop = true;
            this.daysModeRadioButton2.Text = "依期間";
            this.daysModeRadioButton2.UseVisualStyleBackColor = true;
            this.daysModeRadioButton2.CheckedChanged += new System.EventHandler(this.daysModeRadioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.alertLabel);
            this.panel1.Controls.Add(this.carTypeComboBox);
            this.panel1.Controls.Add(this.outputTextBox);
            this.panel1.Controls.Add(this.CCLabel);
            this.panel1.Controls.Add(this.carTypeLabel);
            this.panel1.Controls.Add(this.endDateTimePicker);
            this.panel1.Controls.Add(this.startDateTimePicker);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.comfirmButton);
            this.panel1.Controls.Add(this.CCComboBox);
            this.panel1.Controls.Add(this.daysModeRadioButton2);
            this.panel1.Controls.Add(this.yearModeRadioButton);
            this.panel1.Location = new System.Drawing.Point(95, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 448);
            this.panel1.TabIndex = 2;
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.ForeColor = System.Drawing.Color.Red;
            this.alertLabel.Location = new System.Drawing.Point(477, 152);
            this.alertLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(41, 15);
            this.alertLabel.TabIndex = 9;
            this.alertLabel.Text = "label3";
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Items.AddRange(new object[] {
            "自用小客車",
            "營業用小客車",
            "大客車",
            "貨車",
            "曳引車",
            "機車",
            "自用電動小客車",
            "營業用電動小客車",
            "電動機車",
            "電動大客車及貨車"});
            this.carTypeComboBox.Location = new System.Drawing.Point(168, 149);
            this.carTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(224, 23);
            this.carTypeComboBox.TabIndex = 12;
            this.carTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.carTypeComboBox_SelectedIndexChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(69, 329);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(599, 90);
            this.outputTextBox.TabIndex = 11;
            // 
            // CCLabel
            // 
            this.CCLabel.AutoSize = true;
            this.CCLabel.Location = new System.Drawing.Point(60, 204);
            this.CCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CCLabel.Name = "CCLabel";
            this.CCLabel.Size = new System.Drawing.Size(96, 30);
            this.CCLabel.TabIndex = 8;
            this.CCLabel.Text = "車子CC數/\r\n馬力(HP、PS)";
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(81, 152);
            this.carTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(67, 15);
            this.carTypeLabel.TabIndex = 7;
            this.carTypeLabel.Text = "選擇車種";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(441, 55);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(217, 25);
            this.endDateTimePicker.TabIndex = 6;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(196, 56);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(196, 25);
            this.startDateTimePicker.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(381, 278);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 29);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "取消重填";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // comfirmButton
            // 
            this.comfirmButton.Location = new System.Drawing.Point(248, 278);
            this.comfirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comfirmButton.Name = "comfirmButton";
            this.comfirmButton.Size = new System.Drawing.Size(100, 29);
            this.comfirmButton.TabIndex = 3;
            this.comfirmButton.Text = "確定送出";
            this.comfirmButton.UseVisualStyleBackColor = true;
            this.comfirmButton.Click += new System.EventHandler(this.comfirmButton_Click);
            // 
            // CCComboBox
            // 
            this.CCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCComboBox.FormattingEnabled = true;
            this.CCComboBox.Items.AddRange(new object[] {
            "<500cc",
            "501cc - 600cc",
            "601cc - 1200cc",
            "1201cc - 1800cc",
            "1801cc - 2400cc",
            "2401cc - 3000cc",
            "3001cc - 4200cc",
            "4201cc - 5400cc",
            "5401cc - 6600cc",
            "6601cc - 7800cc",
            "7801cc "});
            this.CCComboBox.Location = new System.Drawing.Point(168, 209);
            this.CCComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CCComboBox.Name = "CCComboBox";
            this.CCComboBox.Size = new System.Drawing.Size(224, 23);
            this.CCComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "到";
            // 
            // TaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TaxCalculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TaxCalculator";
            this.Load += new System.EventHandler(this.TaxCalculatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton yearModeRadioButton;
        private System.Windows.Forms.RadioButton daysModeRadioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.Label CCLabel;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button comfirmButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ComboBox CCComboBox;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.Label label1;
    }
}

