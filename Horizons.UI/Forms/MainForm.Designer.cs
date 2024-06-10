namespace Horizons.UI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTourOrders = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfNightsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcursionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourOrders)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.25F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewTourOrders, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.58824F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.41177F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 425);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridViewTourOrders
            // 
            this.dataGridViewTourOrders.AllowUserToAddRows = false;
            this.dataGridViewTourOrders.AllowUserToDeleteRows = false;
            this.dataGridViewTourOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.ClientColumn,
            this.StartDateColumn,
            this.EndDateColumn,
            this.AmountOfNightsColumn,
            this.PersonColumn,
            this.RoomTypeColumn,
            this.TransferColumn,
            this.ExcursionColumn,
            this.TotalCostColumn,
            this.ManagerColumn});
            this.dataGridViewTourOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTourOrders.Location = new System.Drawing.Point(3, 82);
            this.dataGridViewTourOrders.Name = "dataGridViewTourOrders";
            this.dataGridViewTourOrders.ReadOnly = true;
            this.dataGridViewTourOrders.RowHeadersVisible = false;
            this.dataGridViewTourOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTourOrders.Size = new System.Drawing.Size(794, 340);
            this.dataGridViewTourOrders.TabIndex = 0;
            this.dataGridViewTourOrders.SelectionChanged += new System.EventHandler(this.dataGridViewTourOrders_SelectionChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // ClientColumn
            // 
            this.ClientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClientColumn.DataPropertyName = "Client";
            this.ClientColumn.HeaderText = "Заказчик";
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.ReadOnly = true;
            this.ClientColumn.Width = 80;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StartDateColumn.DataPropertyName = "StartDate";
            this.StartDateColumn.HeaderText = "Дата заезда";
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.ReadOnly = true;
            this.StartDateColumn.Width = 89;
            // 
            // EndDateColumn
            // 
            this.EndDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EndDateColumn.DataPropertyName = "EndDate";
            this.EndDateColumn.HeaderText = "Дата выезда";
            this.EndDateColumn.Name = "EndDateColumn";
            this.EndDateColumn.ReadOnly = true;
            this.EndDateColumn.Width = 91;
            // 
            // AmountOfNightsColumn
            // 
            this.AmountOfNightsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AmountOfNightsColumn.DataPropertyName = "AmountOfNights";
            this.AmountOfNightsColumn.HeaderText = "Количество ночей";
            this.AmountOfNightsColumn.Name = "AmountOfNightsColumn";
            this.AmountOfNightsColumn.ReadOnly = true;
            this.AmountOfNightsColumn.Width = 113;
            // 
            // PersonColumn
            // 
            this.PersonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PersonColumn.DataPropertyName = "PersonCount";
            this.PersonColumn.HeaderText = "Количество проживающих";
            this.PersonColumn.Name = "PersonColumn";
            this.PersonColumn.ReadOnly = true;
            this.PersonColumn.Width = 151;
            // 
            // RoomTypeColumn
            // 
            this.RoomTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RoomTypeColumn.DataPropertyName = "RoomType";
            this.RoomTypeColumn.HeaderText = "Тип номера";
            this.RoomTypeColumn.Name = "RoomTypeColumn";
            this.RoomTypeColumn.ReadOnly = true;
            this.RoomTypeColumn.Width = 85;
            // 
            // TransferColumn
            // 
            this.TransferColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TransferColumn.DataPropertyName = "Transfer";
            this.TransferColumn.HeaderText = "Трансфер";
            this.TransferColumn.Name = "TransferColumn";
            this.TransferColumn.ReadOnly = true;
            this.TransferColumn.Width = 83;
            // 
            // ExcursionColumn
            // 
            this.ExcursionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ExcursionColumn.DataPropertyName = "AmountOfExcursions";
            this.ExcursionColumn.HeaderText = "Количество экскурсий";
            this.ExcursionColumn.Name = "ExcursionColumn";
            this.ExcursionColumn.ReadOnly = true;
            this.ExcursionColumn.Width = 134;
            // 
            // TotalCostColumn
            // 
            this.TotalCostColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalCostColumn.DataPropertyName = "TotalCost";
            this.TotalCostColumn.HeaderText = "Стоимость";
            this.TotalCostColumn.Name = "TotalCostColumn";
            this.TotalCostColumn.ReadOnly = true;
            this.TotalCostColumn.Width = 87;
            // 
            // ManagerColumn
            // 
            this.ManagerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ManagerColumn.DataPropertyName = "Manager";
            this.ManagerColumn.HeaderText = "Менеджер";
            this.ManagerColumn.Name = "ManagerColumn";
            this.ManagerColumn.ReadOnly = true;
            this.ManagerColumn.Width = 85;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Новые горизонты";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddStripButton;
        private System.Windows.Forms.ToolStripButton EditStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeleteStripButton;
        private System.Windows.Forms.ToolStripButton exitStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewTourOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfNightsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcursionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerColumn;
    }
}