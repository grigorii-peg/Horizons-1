﻿using Horizons.Context;
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
    public partial class ExcursionsForm : Form
    {
        public ExcursionsForm()
        {
            InitializeComponent();
            dataGridViewExcursions.AutoGenerateColumns = false;
            FillTourOrders();
        }

        private void FillTourOrders()
        {
            using (var db = new HorizonsDbContext())
            {
                dataGridViewExcursions.DataSource = db.Excursions
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
            var addExcursion = new EditExcursionForm();
            if (addExcursion.ShowDialog() == DialogResult.OK)
            {
                using (var db = new HorizonsDbContext())
                {
                    db.Excursions.Add(addExcursion.Excursion);
                    MessageBox.Show("Запись была успешно добавлена!", "Добавление экскурсии", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                int.TryParse(dataGridViewExcursions.SelectedRows[0].Cells["IdColumn"].Value.ToString(), out var id);
                var excursion = db.Excursions.FirstOrDefault(x => x.Id == id);

                var addExcursion = new EditExcursionForm(excursion);
                if (addExcursion.ShowDialog() == DialogResult.OK)
                {
                    //excursion.Id = addExcursion.Excursion.Id;
                    excursion.Title = addExcursion.Excursion.Title;
                    excursion.Cost = addExcursion.Excursion.Cost;
                    MessageBox.Show("Запись была успешно изменена!", "Изменение экскурсии", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SaveChanges();

                    FillTourOrders();
                };
            }
        }

        private void dataGridViewTourOrders_SelectionChanged(object sender, EventArgs e)
        {
            EditStripButton.Enabled = DeleteStripButton.Enabled = dataGridViewExcursions.SelectedRows.Count == 1;
        }

        private void DeleteStripButton_Click(object sender, EventArgs e)
        {
            using (var db = new HorizonsDbContext())
            {
                int.TryParse(dataGridViewExcursions.SelectedRows[0].Cells["IdColumn"].Value.ToString(), out var id);
                var excursion = db.Excursions.FirstOrDefault(x => x.Id == id);

                if (MessageBox.Show($"Вы действительно хотите удалить экскурсию - {excursion.Title}?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    db.Excursions.Remove(excursion);
                    MessageBox.Show("Запись была успешно удалена!", "Удаление экскурсии", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.SaveChanges();

                    FillTourOrders();
                };
            }
        }
    }
}
