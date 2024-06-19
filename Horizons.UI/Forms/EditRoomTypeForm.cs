using Horizons.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horizons.UI.Forms
{
    public partial class EditRoomTypeForm : Form
    {
        public RoomType RoomType { get; set; }

        public EditRoomTypeForm()
        {
            InitializeComponent();
            //FillControls();
            RoomType = new RoomType();
        }
        public EditRoomTypeForm(RoomType roomType)
        {
            InitializeComponent();
            this.RoomType = roomType;
            roomType = new RoomType();
            InitTourOrder(roomType);
        }


        private void InitTourOrder(RoomType roomType)
        {
            roomTypeTextBox.Text = roomType.Title;
            maxPersonCountTextBox.Text = roomType.MaxPersonCount.ToString();
            nightCostTextBox.Text = roomType.NightCost.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //this.Excursion.Id = ((User)clientComboBox.SelectedItem).Id;
            this.RoomType.Title = roomTypeTextBox.Text;
            this.RoomType.MaxPersonCount = int.Parse(maxPersonCountTextBox.Text);
            this.RoomType.NightCost = int.Parse(nightCostTextBox.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
