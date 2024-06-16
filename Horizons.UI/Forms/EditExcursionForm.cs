using Horizons.Context;
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
    public partial class EditExcursionForm : Form
    {
        public Excursion Excursion { get; set; }
        
        public EditExcursionForm()
        {
            InitializeComponent();
            //FillControls();
            Excursion = new Excursion();
        }
        public EditExcursionForm(Excursion excursion)
        {
            InitializeComponent();
            this.Excursion = excursion;
            Excursion = new Excursion();
            InitTourOrder(excursion);
        }


        private void InitTourOrder(Excursion excursion)
        {
            excursionTextBox.Text = Excursion.Title;
            costTextBox.Text = Excursion.Cost.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //this.Excursion.Id = ((User)clientComboBox.SelectedItem).Id;
            this.Excursion.Title = excursionTextBox.Text;
            this.Excursion.Cost = int.Parse(costTextBox.Text);    
            DialogResult = DialogResult.OK;
        }

    }
}
