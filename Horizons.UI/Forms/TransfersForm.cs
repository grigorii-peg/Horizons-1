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
                dataGridViewTransferType.DataSource = db.TourOrders
                    .Include(x => x.Client)
                    .Include(x => x.Manager)
                    .Include(x => x.Excursions)
                    .Include(x => x.RoomType)
                    .Include(x => x.Transfer)
                    .ToList()
                    .Select(x => new
                    {
                        Id = x.Id,
                        Client = x.Client.Fullname,
                        StartDate = x.StartDate,
                        EndDate = x.EndDate,
                        AmountOfNights = (x.EndDate - x.StartDate).Days,
                        PersonCount = x.PersonCount,
                        RoomType = x.RoomType.Title,
                        Transfer = x.Transfer.Title,
                        AmountOfExcursions = x.Excursions.Count,
                        TotalCost = x.Transfer.Cost + x.Excursions.Sum(y => y.Cost) + x.RoomType.NightCost,
                        Manager = x.Manager.Fullname,
                    })
                    .ToList();
            }
        }

        private void AddStripButton_Click(object sender, EventArgs e)
        {
            var addTourOrder = new EditTourOrderForm();
            if (addTourOrder.ShowDialog() == DialogResult.OK)
            {
                using (var db = new HorizonsDbContext())
                {
                    db.TourOrders.Add(addTourOrder.TourOrder);

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
                var tourOrder = db.TourOrders.FirstOrDefault(x => x.Id == id);

                var addTourOrder = new EditTourOrderForm(tourOrder);
                if (addTourOrder.ShowDialog() == DialogResult.OK)
                {
                    tourOrder.ClientId = addTourOrder.TourOrder.ClientId;
                    tourOrder.StartDate = addTourOrder.TourOrder.StartDate;
                    tourOrder.EndDate = addTourOrder.TourOrder.EndDate;
                    tourOrder.PersonCount = addTourOrder.TourOrder.PersonCount;
                    tourOrder.RoomTypeId = addTourOrder.TourOrder.RoomTypeId;
                    tourOrder.TransferId = addTourOrder.TourOrder.TransferId;
                    tourOrder.ManagerId = addTourOrder.TourOrder.ManagerId;

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
                var tourOrder = db.TourOrders.FirstOrDefault(x => x.Id == id);

                if (MessageBox.Show($"Вы хотите удалить тур {tourOrder.StartDate.ToShortDateString()}?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    db.TourOrders.Remove(tourOrder);

                    db.SaveChanges();

                    FillTourOrders();
                };
            }
        }

    }
}

