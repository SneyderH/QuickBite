namespace QuickBite.Forms
{
    partial class WaiterForm
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
            flpTables = new FlowLayoutPanel();
            dgvOrderProgress = new DataGridView();
            pnlTablesHeader = new Panel();
            lblTables = new Label();
            btnAddTable = new Button();
            lblOrders = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderProgress).BeginInit();
            pnlTablesHeader.SuspendLayout();
            SuspendLayout();
            // 
            // flpTables
            // 
            flpTables.AutoScroll = true;
            flpTables.Dock = DockStyle.Top;
            flpTables.Location = new Point(0, 150);
            flpTables.Margin = new Padding(0, 0, 0, 15);
            flpTables.Name = "flpTables";
            flpTables.Size = new Size(1443, 250);
            flpTables.TabIndex = 0;
            flpTables.Click += flpTables_Click;
            // 
            // dgvOrderProgress
            // 
            dgvOrderProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderProgress.Dock = DockStyle.Fill;
            dgvOrderProgress.Location = new Point(0, 427);
            dgvOrderProgress.Name = "dgvOrderProgress";
            dgvOrderProgress.RowHeadersWidth = 51;
            dgvOrderProgress.Size = new Size(1443, 87);
            dgvOrderProgress.TabIndex = 1;
            // 
            // pnlTablesHeader
            // 
            pnlTablesHeader.Controls.Add(lblTables);
            pnlTablesHeader.Controls.Add(btnAddTable);
            pnlTablesHeader.Dock = DockStyle.Top;
            pnlTablesHeader.Location = new Point(0, 0);
            pnlTablesHeader.Name = "pnlTablesHeader";
            pnlTablesHeader.Size = new Size(1443, 150);
            pnlTablesHeader.TabIndex = 0;
            // 
            // lblTables
            // 
            lblTables.BackColor = SystemColors.Control;
            lblTables.Dock = DockStyle.Left;
            lblTables.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTables.Location = new Point(0, 0);
            lblTables.Margin = new Padding(0, 0, 0, 10);
            lblTables.Name = "lblTables";
            lblTables.Padding = new Padding(10, 0, 0, 0);
            lblTables.Size = new Size(150, 150);
            lblTables.TabIndex = 2;
            lblTables.Text = "Mesas";
            lblTables.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddTable
            // 
            btnAddTable.BackColor = SystemColors.ButtonHighlight;
            btnAddTable.Dock = DockStyle.Right;
            btnAddTable.FlatAppearance.BorderColor = Color.Silver;
            btnAddTable.FlatStyle = FlatStyle.Flat;
            btnAddTable.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTable.Location = new Point(1321, 0);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(122, 150);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Agregar mesa";
            btnAddTable.UseVisualStyleBackColor = false;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // lblOrders
            // 
            lblOrders.BackColor = SystemColors.Control;
            lblOrders.Dock = DockStyle.Top;
            lblOrders.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrders.Location = new Point(0, 400);
            lblOrders.Margin = new Padding(10, 0, 0, 10);
            lblOrders.Name = "lblOrders";
            lblOrders.Padding = new Padding(10, 0, 0, 0);
            lblOrders.Size = new Size(1443, 27);
            lblOrders.TabIndex = 3;
            lblOrders.Text = "Pedidos en proceso";
            lblOrders.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WaiterForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 514);
            Controls.Add(dgvOrderProgress);
            Controls.Add(lblOrders);
            Controls.Add(flpTables);
            Controls.Add(pnlTablesHeader);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "WaiterForm";
            Text = "WaiterForm";
            Load += WaiterForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderProgress).EndInit();
            pnlTablesHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTables;
        private DataGridView dgvOrderProgress;
        private Button btnAddTable;
        private Label lblTables;
        private Label lblOrders;
        private Panel pnlTablesHeader;
    }
}