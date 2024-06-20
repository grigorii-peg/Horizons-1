using Horizons.Context;
using Horizons.Context.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Horizons.UI.Forms;

namespace Horizons.UI.Forms
{
    public partial class EditTourOrderForm : Form
    {
        public TourOrder TourOrder { get; set; }
        public EditTourOrderForm()
        {
            InitializeComponent();
            FillControls();
            TourOrder = new TourOrder();
        }

        public EditTourOrderForm(TourOrder tourOrder)
        {
            InitializeComponent();
            this.TourOrder = tourOrder;
            FillControls();
            InitTourOrder(tourOrder);
            Text = label3.Text = "Изменение тура";
            
        }

        private void FillControls()
        {
            using (var db = new HorizonsDbContext())
            {
                clientComboBox.Items.Clear();
                clientComboBox.Items.AddRange(db.Users.Where(x => x.RoleId == 1).ToArray());
                clientComboBox.DisplayMember = nameof(User.Fullname);
                clientComboBox.SelectedIndex = 0;

                roomTypeComboBox.Items.Clear();
                roomTypeComboBox.Items.AddRange(db.RoomTypes.ToArray());
                roomTypeComboBox.DisplayMember = nameof(RoomType.Title);
                roomTypeComboBox.SelectedIndex = 0;

                transferComboBox.Items.Clear();
                transferComboBox.Items.AddRange(db.Transfers.ToArray());
                transferComboBox.DisplayMember = nameof(Transfer.Title);
                transferComboBox.SelectedIndex = 0;

                excursionComboBox.Items.Clear();
                excursionComboBox.Items.AddRange(db.Excursions.ToArray());
                excursionComboBox.DisplayMember = nameof(Excursion.Title);
                excursionComboBox.SelectedIndex = 0;

                if (TourOrder == null)
                {
                    dateStartTimePicker.MinDate = DateTime.Now.AddDays(1).Date;
                    dateEndTimePicker.MinDate = DateTime.Now.AddDays(2).Date;
                }
            }
        }

        private void InitTourOrder(TourOrder tourOrder)
        {
            clientComboBox.SelectedItem = clientComboBox.Items.Cast<User>().FirstOrDefault(x => x.Id == TourOrder.ClientId);
            roomTypeComboBox.SelectedItem = roomTypeComboBox.Items.Cast<RoomType>().FirstOrDefault(x => x.Id == TourOrder.RoomTypeId);
            transferComboBox.SelectedItem = transferComboBox.Items.Cast<Transfer>().FirstOrDefault(x => x.Id == TourOrder.TransferId);
            dateStartTimePicker.Value = TourOrder.StartDate;
            dateEndTimePicker.Value = TourOrder.EndDate;
            personNumericUpDown.Value = TourOrder.PersonCount;
        }

        private void dateStartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateEndTimePicker.MinDate = dateStartTimePicker.MinDate.AddDays(1).Date;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.TourOrder.ClientId = ((User)clientComboBox.SelectedItem).Id;
            this.TourOrder.StartDate = dateStartTimePicker.Value;
            this.TourOrder.EndDate = dateEndTimePicker.Value;
            this.TourOrder.PersonCount = int.Parse(personNumericUpDown.Value.ToString());
            this.TourOrder.RoomTypeId = ((RoomType)roomTypeComboBox.SelectedItem).Id;
            this.TourOrder.TransferId = ((Transfer)transferComboBox.SelectedItem).Id;
            this.TourOrder.ManagerId = CurrentUser.User.Id;
            this.TourOrder.ExcursionsId = ((Excursion)excursionComboBox.SelectedItem).Id;
            DialogResult = DialogResult.OK;
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            personNumericUpDown.Maximum = ((RoomType)roomTypeComboBox.SelectedItem).MaxPersonCount;
        }

        private void sumCalculation(object sender, EventArgs e)
        {
            try
            {
                totalCostTextBox.Text = ((((Transfer)transferComboBox.SelectedItem).Cost + ((RoomType)roomTypeComboBox.SelectedItem).NightCost * (dateEndTimePicker.Value - dateStartTimePicker.Value).Days + ((Excursion)excursionComboBox.SelectedItem).Cost)*personNumericUpDown.Value).ToString();
            }
            catch { }
        }
    }
}
