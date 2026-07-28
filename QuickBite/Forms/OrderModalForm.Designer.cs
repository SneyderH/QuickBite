namespace QuickBite.Forms
{
    partial class OrderModalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNewCommand = new Label();
            rbDishes = new RadioButton();
            pnlOrderCategory = new Panel();
            rbDrinks = new RadioButton();
            pnlOrderTotal = new Panel();
            btnSendKitchen = new Button();
            lblTotalOrder = new Label();
            label1 = new Label();
            dgvCurrentOrder = new DataGridView();
            lblAvalaibleProducts = new Label();
            dgvAvailableProducts = new DataGridView();
            label3 = new Label();
            pnlOrderCategory.SuspendLayout();
            pnlOrderTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableProducts).BeginInit();
            SuspendLayout();
            // 
            // lblNewCommand
            // 
            lblNewCommand.AutoSize = true;
            lblNewCommand.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewCommand.Location = new Point(12, 9);
            lblNewCommand.Name = "lblNewCommand";
            lblNewCommand.Size = new Size(220, 27);
            lblNewCommand.TabIndex = 0;
            lblNewCommand.Text = "NUEVA COMANDA";
            // 
            // rbDishes
            // 
            rbDishes.AutoSize = true;
            rbDishes.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDishes.Location = new Point(17, 73);
            rbDishes.Name = "rbDishes";
            rbDishes.Size = new Size(119, 25);
            rbDishes.TabIndex = 1;
            rbDishes.TabStop = true;
            rbDishes.Text = "PLATILLOS";
            rbDishes.UseVisualStyleBackColor = true;
            rbDishes.CheckedChanged += rbDishes_CheckedChanged;
            // 
            // pnlOrderCategory
            // 
            pnlOrderCategory.Controls.Add(rbDrinks);
            pnlOrderCategory.Controls.Add(rbDishes);
            pnlOrderCategory.Dock = DockStyle.Top;
            pnlOrderCategory.Location = new Point(0, 0);
            pnlOrderCategory.Name = "pnlOrderCategory";
            pnlOrderCategory.Size = new Size(913, 119);
            pnlOrderCategory.TabIndex = 2;
            // 
            // rbDrinks
            // 
            rbDrinks.AutoSize = true;
            rbDrinks.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbDrinks.Location = new Point(164, 73);
            rbDrinks.Name = "rbDrinks";
            rbDrinks.Size = new Size(103, 25);
            rbDrinks.TabIndex = 2;
            rbDrinks.TabStop = true;
            rbDrinks.Text = "BEBIDAS";
            rbDrinks.UseVisualStyleBackColor = true;
            rbDrinks.CheckedChanged += rbDrinks_CheckedChanged;
            // 
            // pnlOrderTotal
            // 
            pnlOrderTotal.Controls.Add(btnSendKitchen);
            pnlOrderTotal.Controls.Add(lblTotalOrder);
            pnlOrderTotal.Controls.Add(label1);
            pnlOrderTotal.Dock = DockStyle.Bottom;
            pnlOrderTotal.Location = new Point(0, 382);
            pnlOrderTotal.Name = "pnlOrderTotal";
            pnlOrderTotal.Size = new Size(913, 125);
            pnlOrderTotal.TabIndex = 3;
            // 
            // btnSendKitchen
            // 
            btnSendKitchen.Location = new Point(669, 40);
            btnSendKitchen.Name = "btnSendKitchen";
            btnSendKitchen.Size = new Size(217, 54);
            btnSendKitchen.TabIndex = 2;
            btnSendKitchen.Text = "Enviar a cocina";
            btnSendKitchen.UseVisualStyleBackColor = true;
            // 
            // lblTotalOrder
            // 
            lblTotalOrder.AutoSize = true;
            lblTotalOrder.Location = new Point(111, 46);
            lblTotalOrder.Name = "lblTotalOrder";
            lblTotalOrder.Size = new Size(20, 27);
            lblTotalOrder.TabIndex = 1;
            lblTotalOrder.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(84, 27);
            label1.TabIndex = 0;
            label1.Text = "TOTAL:";
            // 
            // dgvCurrentOrder
            // 
            dgvCurrentOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentOrder.Dock = DockStyle.Fill;
            dgvCurrentOrder.Location = new Point(0, 266);
            dgvCurrentOrder.Name = "dgvCurrentOrder";
            dgvCurrentOrder.RowHeadersWidth = 51;
            dgvCurrentOrder.Size = new Size(913, 116);
            dgvCurrentOrder.TabIndex = 4;
            // 
            // lblAvalaibleProducts
            // 
            lblAvalaibleProducts.AutoSize = true;
            lblAvalaibleProducts.BackColor = Color.Transparent;
            lblAvalaibleProducts.Dock = DockStyle.Top;
            lblAvalaibleProducts.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvalaibleProducts.Location = new Point(0, 119);
            lblAvalaibleProducts.Name = "lblAvalaibleProducts";
            lblAvalaibleProducts.Padding = new Padding(0, 10, 0, 0);
            lblAvalaibleProducts.Size = new Size(188, 29);
            lblAvalaibleProducts.TabIndex = 0;
            lblAvalaibleProducts.Text = "Productos disponibles";
            // 
            // dgvAvailableProducts
            // 
            dgvAvailableProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableProducts.Dock = DockStyle.Top;
            dgvAvailableProducts.Location = new Point(0, 148);
            dgvAvailableProducts.Name = "dgvAvailableProducts";
            dgvAvailableProducts.RowHeadersWidth = 51;
            dgvAvailableProducts.Size = new Size(913, 89);
            dgvAvailableProducts.TabIndex = 1;
            dgvAvailableProducts.CellContentClick += dgvAvalaibleProducts_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 237);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 10, 0, 0);
            label3.Size = new Size(148, 29);
            label3.TabIndex = 5;
            label3.Text = "Comanda actual";
            // 
            // OrderModalForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 507);
            Controls.Add(dgvCurrentOrder);
            Controls.Add(label3);
            Controls.Add(dgvAvailableProducts);
            Controls.Add(lblAvalaibleProducts);
            Controls.Add(pnlOrderTotal);
            Controls.Add(lblNewCommand);
            Controls.Add(pnlOrderCategory);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "OrderModalForm";
            Text = "OrderModalForm";
            pnlOrderCategory.ResumeLayout(false);
            pnlOrderCategory.PerformLayout();
            pnlOrderTotal.ResumeLayout(false);
            pnlOrderTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewCommand;
        private RadioButton rbDishes;
        private Panel pnlOrderCategory;
        private RadioButton rbDrinks;
        private Panel pnlOrderTotal;
        private Label lblTotalOrder;
        private Label label1;
        private DataGridView dgvCurrentOrder;
        private Button btnSendKitchen;
        private DataGridView dgvAvailableProducts;
        private Label lblAvalaibleProducts;
        private Label label3;
    }
}