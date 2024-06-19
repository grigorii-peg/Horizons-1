namespace Horizons.UI.Forms
{
    partial class EditRoomTypeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.nightCostTextBox = new System.Windows.Forms.TextBox();
            this.roomTypeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.maxPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(113, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Добавление типа номера";
            this.label3.UseWaitCursor = true;
            // 
            // nightCostTextBox
            // 
            this.nightCostTextBox.Location = new System.Drawing.Point(165, 181);
            this.nightCostTextBox.Name = "nightCostTextBox";
            this.nightCostTextBox.Size = new System.Drawing.Size(192, 20);
            this.nightCostTextBox.TabIndex = 31;
            this.nightCostTextBox.UseWaitCursor = true;
            // 
            // roomTypeTextBox
            // 
            this.roomTypeTextBox.Location = new System.Drawing.Point(165, 83);
            this.roomTypeTextBox.Name = "roomTypeTextBox";
            this.roomTypeTextBox.Size = new System.Drawing.Size(192, 20);
            this.roomTypeTextBox.TabIndex = 29;
            this.roomTypeTextBox.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(18, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Стоимость (за ночь)";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(73, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Тип номера";
            this.label1.UseWaitCursor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Window;
            this.cancelButton.Location = new System.Drawing.Point(290, 235);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 37);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.UseWaitCursor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(21, 235);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 37);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.UseWaitCursor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // maxPersonCountTextBox
            // 
            this.maxPersonCountTextBox.Location = new System.Drawing.Point(165, 130);
            this.maxPersonCountTextBox.Name = "maxPersonCountTextBox";
            this.maxPersonCountTextBox.Size = new System.Drawing.Size(192, 20);
            this.maxPersonCountTextBox.TabIndex = 30;
            this.maxPersonCountTextBox.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 48);
            this.label4.TabIndex = 32;
            this.label4.Text = "Максимальное кол-во проживающих";
            this.label4.UseWaitCursor = true;
            // 
            // EditRoomTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 298);
            this.Controls.Add(this.maxPersonCountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nightCostTextBox);
            this.Controls.Add(this.roomTypeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditRoomTypeForm";
            this.Text = "Добавление типа номера";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nightCostTextBox;
        private System.Windows.Forms.TextBox roomTypeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox maxPersonCountTextBox;
        private System.Windows.Forms.Label label4;
    }
}