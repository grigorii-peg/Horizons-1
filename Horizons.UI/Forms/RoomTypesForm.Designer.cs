namespace Horizons.UI.Forms
{
    partial class RoomTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTypesForm));
            this.dataGridViewRoomTypes = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPersonCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NightCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomTypes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRoomTypes
            // 
            this.dataGridViewRoomTypes.AllowUserToAddRows = false;
            this.dataGridViewRoomTypes.AllowUserToDeleteRows = false;
            this.dataGridViewRoomTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoomTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.TitleColumn,
            this.MaxPersonCountColumn,
            this.NightCostColumn});
            this.dataGridViewRoomTypes.Location = new System.Drawing.Point(31, 40);
            this.dataGridViewRoomTypes.Name = "dataGridViewRoomTypes";
            this.dataGridViewRoomTypes.ReadOnly = true;
            this.dataGridViewRoomTypes.RowHeadersVisible = false;
            this.dataGridViewRoomTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoomTypes.Size = new System.Drawing.Size(411, 151);
            this.dataGridViewRoomTypes.TabIndex = 0;
            this.dataGridViewRoomTypes.SelectionChanged += new System.EventHandler(this.dataGridViewTourOrders_SelectionChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // TitleColumn
            // 
            this.TitleColumn.DataPropertyName = "RoomType";
            this.TitleColumn.HeaderText = "Тип номера";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // MaxPersonCountColumn
            // 
            this.MaxPersonCountColumn.DataPropertyName = "MaxPersonCount";
            this.MaxPersonCountColumn.HeaderText = "Максимальное кол-во проживающих";
            this.MaxPersonCountColumn.Name = "MaxPersonCountColumn";
            this.MaxPersonCountColumn.ReadOnly = true;
            // 
            // NightCostColumn
            // 
            this.NightCostColumn.DataPropertyName = "NightCost";
            this.NightCostColumn.HeaderText = "Стоимость (за ночь)";
            this.NightCostColumn.Name = "NightCostColumn";
            this.NightCostColumn.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStripButton,
            this.EditStripButton,
            this.toolStripSeparator2,
            this.DeleteStripButton,
            this.exitStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(497, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddStripButton
            // 
            this.AddStripButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.AddStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddStripButton.Image")));
            this.AddStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStripButton.Name = "AddStripButton";
            this.AddStripButton.Size = new System.Drawing.Size(81, 22);
            this.AddStripButton.Text = "Добавить";
            this.AddStripButton.Click += new System.EventHandler(this.AddStripButton_Click);
            // 
            // EditStripButton
            // 
            this.EditStripButton.Enabled = false;
            this.EditStripButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EditStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditStripButton.Image")));
            this.EditStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditStripButton.Name = "EditStripButton";
            this.EditStripButton.Size = new System.Drawing.Size(81, 22);
            this.EditStripButton.Text = "Изменить";
            this.EditStripButton.Click += new System.EventHandler(this.EditStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DeleteStripButton
            // 
            this.DeleteStripButton.Enabled = false;
            this.DeleteStripButton.ForeColor = System.Drawing.Color.DarkRed;
            this.DeleteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteStripButton.Image")));
            this.DeleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteStripButton.Name = "DeleteStripButton";
            this.DeleteStripButton.Size = new System.Drawing.Size(74, 22);
            this.DeleteStripButton.Text = "Удалить";
            this.DeleteStripButton.Click += new System.EventHandler(this.DeleteStripButton_Click);
            // 
            // exitStripButton
            // 
            this.exitStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitStripButton.Name = "exitStripButton";
            this.exitStripButton.Size = new System.Drawing.Size(48, 22);
            this.exitStripButton.Text = "Выход";
            this.exitStripButton.Click += new System.EventHandler(this.exitStripButton_Click);
            // 
            // RoomTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 235);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewRoomTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RoomTypesForm";
            this.Text = "Типы номеров";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomTypes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoomTypes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddStripButton;
        private System.Windows.Forms.ToolStripButton EditStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeleteStripButton;
        private System.Windows.Forms.ToolStripButton exitStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPersonCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NightCostColumn;
    }
}