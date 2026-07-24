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
            panel1 = new Panel();
            rbDrinks = new RadioButton();
            panel2 = new Panel();
            label1 = new Label();
            lblTotalOrder = new Label();
            dgvOrderList = new DataGridView();
            btnSendKitchen = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // lblNewCommand
            // 
            lblNewCommand.AutoSize = true;
            lblNewCommand.Location = new Point(12, 9);
            lblNewCommand.Name = "lblNewCommand";
            lblNewCommand.Size = new Size(227, 27);
            lblNewCommand.TabIndex = 0;
            lblNewCommand.Text = "NUEVA COMANDA";
            // 
            // rbDishes
            // 
            rbDishes.AutoSize = true;
            rbDishes.Location = new Point(201, 85);
            rbDishes.Name = "rbDishes";
            rbDishes.Size = new Size(145, 31);
            rbDishes.TabIndex = 1;
            rbDishes.TabStop = true;
            rbDishes.Text = "PLATILLOS";
            rbDishes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbDrinks);
            panel1.Controls.Add(rbDishes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 146);
            panel1.TabIndex = 2;
            // 
            // rbDrinks
            // 
            rbDrinks.AutoSize = true;
            rbDrinks.Location = new Point(570, 85);
            rbDrinks.Name = "rbDrinks";
            rbDrinks.Size = new Size(122, 31);
            rbDrinks.TabIndex = 2;
            rbDrinks.TabStop = true;
            rbDrinks.Text = "BEBIDAS";
            rbDrinks.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSendKitchen);
            panel2.Controls.Add(lblTotalOrder);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 382);
            panel2.Name = "panel2";
            panel2.Size = new Size(913, 125);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 0;
            label1.Text = "TOTAL:";
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
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Dock = DockStyle.Fill;
            dgvOrderList.Location = new Point(0, 146);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.Size = new Size(913, 236);
            dgvOrderList.TabIndex = 4;
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
            // OrderModalForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 507);
            Controls.Add(dgvOrderList);
            Controls.Add(panel2);
            Controls.Add(lblNewCommand);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "OrderModalForm";
            Text = "OrderModalForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewCommand;
        private RadioButton rbDishes;
        private Panel panel1;
        private RadioButton rbDrinks;
        private Panel panel2;
        private Label lblTotalOrder;
        private Label label1;
        private DataGridView dgvOrderList;
        private Button btnSendKitchen;
    }
}