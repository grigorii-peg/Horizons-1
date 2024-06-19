using Horizons.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace Horizons.UI.Forms
{
    public partial class TransfersForm : Form
    {
        public TransfersForm()
        {
            InitializeComponent();
            dataGridViewTransferType.AutoGenerateColumns = false;
            FillTourOrders();
        }

        private void FillTourOrders()
        {
            using (var db = new HorizonsDbContext())
            {
                dataGridViewTransferType.DataSource = db.Transfers
                    .ToList()
                    .Select(x => new
                    {
                        Id = x.Id,
                        Title = x.Title,
                        Cost = x.Cost,
                    })
                    .ToList();
            }
        }

        private void AddStripButton_Click(object sender, EventArgs e)
        {
            var addTransfer = new EditTransferForm();
            if (addTransfer.ShowDialog() == DialogResult.OK)
            {
                using (var db = new HorizonsDbContext())
                {
                    db.Transfers.Add(addTransfer.Transfer);
                    MessageBox.Show("Запись была успешно добавлена!", "Добавление трансфера", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.SaveChanges();
                }

                FillTourOrders();
            };
        }

        private void exitStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditStripButton_Click(object sender, EventArgs e)
        {
            using (var db = new HorizonsDbContext())
            {
                int.TryParse(dataGridViewTransferType.SelectedRows[0].Cells["IdColumn"].Value.ToString(), out var id);
                var transfer = db.Transfers.FirstOrDefault(x => x.Id == id);

                var addtransfer = new EditTransferForm(transfer);
                if (addtransfer.ShowDialog() == DialogResult.OK)
                {
                    transfer.Id = addtransfer.Transfer.Id;
                    transfer.Title = addtransfer.Transfer.Title;
                    transfer.Cost = addtransfer.Transfer.Cost;
                    MessageBox.Show("Запись была успешно изменена!", "Изменение трансфера", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.SaveChanges();

                    FillTourOrders();
                };
            }
        }

        private void dataGridViewTourOrders_SelectionChanged(object sender, EventArgs e)
        {
            EditStripButton.Enabled = DeleteStripButton.Enabled = dataGridViewTransferType.SelectedRows.Count == 1;
        }

        private void DeleteStripButton_Click(object sender, EventArgs e)
        {
            using (var db = new HorizonsDbContext())
            {
                int.TryParse(dataGridViewTransferType.SelectedRows[0].Cells["IdColumn"].Value.ToString(), out var id);
                var transfer = db.Transfers.FirstOrDefault(x => x.Id == id);

                if (MessageBox.Show($"Вы действительно хотите удалить трансфер - {transfer.Title}?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    db.Transfers.Remove(transfer);
                    MessageBox.Show("Запись была успешно удалена!", "Удаление трансфера", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.SaveChanges();

                    FillTourOrders();
                };
            }
        }
    }
}

