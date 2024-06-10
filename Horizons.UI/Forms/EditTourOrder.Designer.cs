namespace Horizons.UI.Forms
{
    partial class EditTourOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.personNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.transferComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата выезда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество проживающих";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип номера";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Трансфер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Заказчик";
            // 
            // dateStartTimePicker
            // 
            this.dateStartTimePicker.Location = new System.Drawing.Point(198, 57);
            this.dateStartTimePicker.Name = "dateStartTimePicker";
            this.dateStartTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateStartTimePicker.TabIndex = 9;
            this.dateStartTimePicker.ValueChanged += new System.EventHandler(this.dateStartTimePicker_ValueChanged);
            // 
            // dateEndTimePicker
            // 
            this.dateEndTimePicker.Location = new System.Drawing.Point(198, 99);
            this.dateEndTimePicker.Name = "dateEndTimePicker";
            this.dateEndTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateEndTimePicker.TabIndex = 10;
            // 
            // personNumericUpDown
            // 
            this.personNumericUpDown.Location = new System.Drawing.Point(198, 141);
            this.personNumericUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.personNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.personNumericUpDown.Name = "personNumericUpDown";
            this.personNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.personNumericUpDown.TabIndex = 12;
            this.personNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(198, 18);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(200, 21);
            this.clientComboBox.TabIndex = 13;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Location = new System.Drawing.Point(198, 182);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.roomTypeComboBox.TabIndex = 14;
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // transferComboBox
            // 
            this.transferComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transferComboBox.FormattingEnabled = true;
            this.transferComboBox.Location = new System.Drawing.Point(198, 224);
            this.transferComboBox.Name = "transferComboBox";
            this.transferComboBox.Size = new System.Drawing.Size(200, 21);
            this.transferComboBox.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(34, 271);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 37);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(303, 271);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 37);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditTourOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 327);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.transferComboBox);
            this.Controls.Add(this.roomTypeComboBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.personNumericUpDown);
            this.Controls.Add(this.dateEndTimePicker);
            this.Controls.Add(this.dateStartTimePicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTourOrder";
            this.Text = "Добавление тура";
            ((System.ComponentModel.ISupportInitialize)(this.personNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateStartTimePicker;
        private System.Windows.Forms.DateTimePicker dateEndTimePicker;
        private System.Windows.Forms.NumericUpDown personNumericUpDown;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
        private System.Windows.Forms.ComboBox transferComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}