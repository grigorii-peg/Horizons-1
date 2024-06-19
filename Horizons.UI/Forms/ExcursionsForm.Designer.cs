namespace Horizons.UI.Forms
{
    partial class ExcursionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcursionsForm));
            this.dataGridViewExcursions = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.exitStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcursions)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewExcursions
            // 
            this.dataGridViewExcursions.AllowUserToAddRows = false;
            this.dataGridViewExcursions.AllowUserToDeleteRows = false;
            this.dataGridViewExcursions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExcursions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewExcursions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcursions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.TitleColumn,
            this.CostColumn});
            this.dataGridViewExcursions.Location = new System.Drawing.Point(32, 44);
            this.dataGridViewExcursions.Name = "dataGridViewExcursions";
            this.dataGridViewExcursions.ReadOnly = true;
            this.dataGridViewExcursions.RowHeadersVisible = false;
            this.dataGridViewExcursions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcursions.Size = new System.Drawing.Size(296, 146);
            this.dataGridViewExcursions.TabIndex = 0;
            this.dataGridViewExcursions.SelectionChanged += new System.EventHandler(this.dataGridViewTourOrders_SelectionChanged);
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
            this.TitleColumn.DataPropertyName = "Title";
            this.TitleColumn.HeaderText = "Название экскурсии";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            // 
            // CostColumn
            // 
            this.CostColumn.DataPropertyName = "Cost";
            this.CostColumn.HeaderText = "Цена";
            this.CostColumn.Name = "CostColumn";
            this.CostColumn.ReadOnly = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(397, 25);
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
            // ExcursionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 210);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewExcursions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExcursionsForm";
            this.Text = "Экскурсии";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcursions)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExcursions;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddStripButton;
        private System.Windows.Forms.ToolStripButton EditStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeleteStripButton;
        private System.Windows.Forms.ToolStripButton exitStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostColumn;
    }
}