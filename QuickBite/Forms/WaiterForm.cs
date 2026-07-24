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
            if (flpTables.Controls.Count < 0)
            {
                List<Table> tables = _tableService.GetTables();
                foreach (var table in tables)
                {
                    Button tableButton = new Button();
                    tableButton.Text = $"Table {table.Id}";
                    tableButton.Width = 100;
                    tableButton.Height = 50;
                    tableButton.Tag = table;

                    switch (table.Status)
                    {
                        case TableStatus.Available:
                            tableButton.BackColor = Color.Green;
                            break;

                        case TableStatus.Occupied:
                            tableButton.BackColor = Color.Red;
                            break;

                        case TableStatus.Reserved:
                            tableButton.BackColor = Color.Yellow;
                            break;
                    }
                    // Add click event handler for the button
                    tableButton.Click += btnAddTable_Click;
                    flpTables.Controls.Add(tableButton);
                }
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            var newTable = new Table
            {
                Status = TableStatus.Available
            };

            _tableService.AddTable(newTable);
        }
    }
}
