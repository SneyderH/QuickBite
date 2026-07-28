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
    public partial class OrderModalForm : Form
    {
        private readonly ProductService _productService = new ProductService();
        private readonly OrderItem _orderItem = new OrderItem();
        private List<OrderItem> _orderItemList = new List<OrderItem>();
        public OrderModalForm()
        {
            InitializeComponent();
        }

        private void AvailableProducts(ProductCategory category)
        {
            List<Product> products = _productService.GetProductsByCategory(category);

            dgvAvailableProducts.DataSource = null;
            dgvAvailableProducts.DataSource = products;

            if (!dgvAvailableProducts.Columns.Contains("btnAgregar"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "btnAddProduct";
                btnColumn.Text = "+ Agregar";
                btnColumn.UseColumnTextForButtonValue = true;
                dgvAvailableProducts.Columns.Add(btnColumn);
            }
        }

        private void AddProductToOrder(Product product)
        {
            var existingItem = _orderItemList.FirstOrDefault(i => i.ProductId == product.Id);

            if (existingItem != null)
            {
                existingItem.Quantity += 1;
            }
            else
            {
                _orderItemList.Add(new OrderItem
                {
                    ProductId = product.Id,
                    UnitPrice = product.Price,
                    Quantity = 1
                });
            }

            RefreshOrder();
        }

        private void RefreshOrder()
        {
            dgvCurrentOrder.DataSource = null;
            dgvCurrentOrder.DataSource = _orderItemList;

            decimal total = _orderItemList.Sum(i => i.Quantity * i.UnitPrice);
            lblTotalOrder.Text = total.ToString("C0");
        }

        private void dgvAvalaibleProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvAvailableProducts.Columns[e.ColumnIndex].Name != "btnAddProduct")
            {
                return;
            }

            if (dgvAvailableProducts.Rows[e.RowIndex].DataBoundItem is not Product selectedProduct)
            {
                return;
            }

            AddProductToOrder(selectedProduct);
        }

        private void rbDishes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDishes.Checked)
            {
                AvailableProducts(ProductCategory.Dishes);
            }
        }

        private void rbDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDrinks.Checked)
            {
                AvailableProducts(ProductCategory.Drinks);
            }
        }
    }
}
