using Horizons.Context;
using Horizons.Context.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Horizons.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dataGridViewTourOrders.AutoGenerateColumns = false;
            FillTourOrders();
        }

        private void FillTourOrders()
        {
            using (var db = new HorizonsDbContext())
            {
                dataGridViewTourOrders.DataSource = db.TourOrders
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
                        AmountOfExcursions = x.Excursions.Title,
                        TotalCost = (x.Transfer.Cost + x.RoomType.NightCost * (x.EndDate - x.StartDate).Days + x.Excursions.Cost) * x.PersonCount,
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
                    MessageBox.Show("Запись была успешно добавлена!", "Добавление тура", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int.TryParse(dataGridViewTourOrders.SelectedRows[0].Cells["IdColumn"].Value.ToString(), out var id);
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
                    MessageBox.Show("Запись была успешно изменена!", "Изменение тура", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.SaveChanges();

                    FillTourOrders();
                };
            }
        }

        private void dataGridViewTourOrders_SelectionChanged(object sender, EventArgs e)
        {
            EditStripButton.Enabled = DeleteStripButton.Enabled = dataGridViewTourOrders.SelectedRows.Count == 1;
        }

        private void DeleteStripButton_Click(object sender, EventArgs e)
        {
            using (var db = new HorizonsDbContext())
            {
                int.TryParse(dataGridViewTourOrders.SelectedRows[0].Cells["IdColumn"].Value.ToString(), out var id);
                var tourOrder = db.TourOrders.FirstOrDefault(x => x.Id == id);

                if (MessageBox.Show($"Вы действительно хотите удалить тур с датой заезда - {tourOrder.StartDate.ToShortDateString()}?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    db.TourOrders.Remove(tourOrder);
                    MessageBox.Show("Запись была успешно удалена!", "Удаление тура", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.SaveChanges();

                    FillTourOrders();
                };
            }
        }

        private void roomsTypeButton_Click(object sender, EventArgs e)
        {
            RoomTypesForm rtf = new RoomTypesForm();
            rtf.ShowDialog();
        }

        private void excursionsButton_Click(object sender, EventArgs e)
        {
            ExcursionsForm ef = new ExcursionsForm();
            ef.ShowDialog();
        }

        private void typeTransfersbutton_Click(object sender, EventArgs e)
        {
            TransfersForm tf = new TransfersForm();
            tf.ShowDialog();
        }
    }
}
