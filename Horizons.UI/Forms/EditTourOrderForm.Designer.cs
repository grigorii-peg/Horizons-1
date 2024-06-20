namespace Horizons.UI.Forms
{
    partial class EditTourOrderForm
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
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.transferComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.excursionComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.personNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(81, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(79, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата выезда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество проживающих";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(86, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип номера";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(95, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Трансфер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(98, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Заказчик";
            // 
            // dateStartTimePicker
            // 
            this.dateStartTimePicker.Location = new System.Drawing.Point(197, 102);
            this.dateStartTimePicker.Name = "dateStartTimePicker";
            this.dateStartTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateStartTimePicker.TabIndex = 9;
            this.dateStartTimePicker.ValueChanged += new System.EventHandler(this.sumCalculation);
            // 
            // dateEndTimePicker
            // 
            this.dateEndTimePicker.Location = new System.Drawing.Point(197, 144);
            this.dateEndTimePicker.Name = "dateEndTimePicker";
            this.dateEndTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateEndTimePicker.TabIndex = 10;
            this.dateEndTimePicker.ValueChanged += new System.EventHandler(this.sumCalculation);
            // 
            // personNumericUpDown
            // 
            this.personNumericUpDown.Location = new System.Drawing.Point(197, 186);
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
            this.personNumericUpDown.ValueChanged += new System.EventHandler(this.sumCalculation);
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Location = new System.Drawing.Point(197, 227);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.roomTypeComboBox.TabIndex = 14;
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.sumCalculation);
            // 
            // transferComboBox
            // 
            this.transferComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transferComboBox.FormattingEnabled = true;
            this.transferComboBox.Location = new System.Drawing.Point(197, 269);
            this.transferComboBox.Name = "transferComboBox";
            this.transferComboBox.Size = new System.Drawing.Size(200, 21);
            this.transferComboBox.TabIndex = 15;
            this.transferComboBox.SelectedIndexChanged += new System.EventHandler(this.sumCalculation);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(33, 395);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 37);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Window;
            this.cancelButton.Location = new System.Drawing.Point(302, 395);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 37);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(145, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Добавление тура";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(54, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Общая стоимость";
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Location = new System.Drawing.Point(197, 353);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalCostTextBox.TabIndex = 20;
            // 
            // excursionComboBox
            // 
            this.excursionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.excursionComboBox.FormattingEnabled = true;
            this.excursionComboBox.Location = new System.Drawing.Point(197, 309);
            this.excursionComboBox.Name = "excursionComboBox";
            this.excursionComboBox.Size = new System.Drawing.Size(200, 21);
            this.excursionComboBox.TabIndex = 22;
            this.excursionComboBox.SelectedIndexChanged += new System.EventHandler(this.sumCalculation);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(86, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Экскурсия";
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(197, 63);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(200, 21);
            this.clientComboBox.TabIndex = 13;
            // 
            // EditTourOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Horizons.UI.Properties.Resources.nesvizh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 446);
            this.Controls.Add(this.excursionComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditTourOrderForm";
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
        private System.Windows.Forms.ComboBox roomTypeComboBox;
        private System.Windows.Forms.ComboBox transferComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox excursionComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox clientComboBox;
    }
}