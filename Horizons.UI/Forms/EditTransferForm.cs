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
    public partial class EditTransferForm : Form
    {
        public Transfer Transfer { get; set; }

        public EditTransferForm()
        {
            InitializeComponent();
            //FillControls();
            Transfer = new Transfer();
        }
        public EditTransferForm(Transfer transfer)
        {
            InitializeComponent();
            this.Transfer = transfer;
            transfer = new Transfer();
            InitTourOrder(transfer);
            Text = label3.Text = "Изменение трансфера";
        }


        private void InitTourOrder(Transfer transfer)
        {
            transferNameTextBox.Text = transfer.Title;
            costTextBox.Text = transfer.Cost.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //this.Excursion.Id = ((User)clientComboBox.SelectedItem).Id;
            this.Transfer.Title = transferNameTextBox.Text;
            this.Transfer.Cost = int.Parse(costTextBox.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
