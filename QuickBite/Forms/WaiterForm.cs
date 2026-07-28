using QuickBite.Models;
using QuickBite.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickBite.Forms
{
    public partial class WaiterForm : Form
    {
        private readonly TableService _tableService = new TableService();
        public WaiterForm()
        {
            InitializeComponent();
        }
        private void WaiterForm_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        public void LoadTables()
        {
            flpTables.Controls.Clear();

            List<Table> tables = _tableService.GetTables();

            if (tables.Count == 0)
            {
                MessageBox.Show("No hay mesas disponibles.");
                return;
            }

            foreach (var table in tables)
            {
                Button tableButton = new Button();
                tableButton.Text = $"Mesa #{table.Id}";
                tableButton.Width = 130;
                tableButton.Height = 70;
                tableButton.Margin = new Padding(6);
                tableButton.Tag = table;
                tableButton.FlatStyle = FlatStyle.Flat;
                tableButton.FlatAppearance.BorderSize = 0;
                tableButton.Cursor = Cursors.Hand;

                switch (table.Status)
                {
                    case TableStatus.Available:
                        tableButton.BackColor = Color.FromArgb(210, 240, 220);
                        tableButton.ForeColor = Color.FromArgb(20, 100, 50);
                        break;
                    case TableStatus.Occupied:
                        tableButton.BackColor = Color.FromArgb(245, 210, 210);
                        tableButton.ForeColor = Color.FromArgb(150, 30, 30);
                        break;
                    case TableStatus.Reserved:
                        tableButton.BackColor = Color.FromArgb(250, 235, 200);
                        tableButton.ForeColor = Color.FromArgb(140, 100, 10);
                        break;
                }

                tableButton.Click += flpTables_Click;
                flpTables.Controls.Add(tableButton);
            }
        }
        private void flpTables_Click(object sender, EventArgs e)
        {
            if (sender is not Button tableButton || tableButton.Tag is not Table selectedTable)
            {
                return;
            }

            using var frm = new OrderModalForm();
            var result = frm.ShowDialog();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            var newTable = new Table
            {
                Status = TableStatus.Available
            };

            _tableService.AddTable(newTable);
            LoadTables();
        }

    }
}
