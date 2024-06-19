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
    public partial class RoomTypesForm : Form
    {
        public RoomTypesForm()
        {
            InitializeComponent();
            dataGridViewRoomTypes.AutoGenerateColumns = false;
            FillTourOrders();
        }

        private void FillTourOrders()
        {
            using (var db = new HorizonsDbContext())
            {
                dataGridViewRoomTypes.DataSource = db.RoomTypes                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
                    .ToList()
                    .Select(x => new
                    {
                        Id = x.Id,
                        RoomType = x.Title,
                        MaxPersonCount = x.MaxPersonCount,
                        NightCost = x.NightCost,
                    })
                    .ToList();
            }
        }

        private void AddStripButton_Click(object sender, EventArgs e)
        {
            var addRoomType = new EditRoomTypeForm();
            if (addRoomType.ShowDialog() == DialogResult.OK)
            {
                using (var db = new HorizonsDbContext())
                {
                    db.RoomTypes.Add(addRoomType.RoomType);
                    MessageBox.Show("Запись была успешно добавлена!", "Добавление типа номера", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                int.TryParse(dataGridViewRoomTypes.SelectedRows[0].Cells["IdColumn"].Value.ToString(), out var id);
                var roomType = db.RoomTypes.FirstOrDefault(x => x.Id == id);

                var addRoomType= new EditRoomTypeForm(roomType);
                if (addRoomType.ShowDialog() == DialogResult.OK)
                {
                    //roomType.Id = addRoomType.RoomType.Id;
                    roomType.Title = addRoomType.RoomType.Title;
                    roomType.MaxPersonCount = addRoomType.RoomType.MaxPersonCount;
                    roomType.NightCost = addRoomType.RoomType.NightCost;
                    MessageBox.Show("Запись была успешно изменена!", "Изменение типа номера", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();

                    FillTourOrders();
                };
            }
        }

        private void dataGridViewTourOrders_SelectionChanged(object sender, EventArgs e)
        {
            EditStripButton.Enabled = DeleteStripButton.Enabled = dataGridViewRoomTypes.SelectedRows.Count == 1;
        }

        private void DeleteStripButton_Click(object sender, EventArgs e)
        {
            using (var db = new HorizonsDbContext())
            {
                int.TryParse(dataGridViewRoomTypes.SelectedRows[0].Cells["IdColumn"].Value.ToString(), out var id);
                var roomType = db.RoomTypes.FirstOrDefault(x => x.Id == id);

                if (MessageBox.Show($"Вы действительно хотите удалить тип номера -  {roomType.Title}?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    db.RoomTypes.Remove(roomType);
                    MessageBox.Show("Запись была успешно удалена!", "Удаление типа номера", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();

                    FillTourOrders();
                };
            }
        }
    }
}
