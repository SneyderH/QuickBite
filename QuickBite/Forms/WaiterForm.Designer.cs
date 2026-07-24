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
            btnAddTable = new Button();
            flpTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderProgress).BeginInit();
            SuspendLayout();
            // 
            // flpTables
            // 
            flpTables.Controls.Add(btnAddTable);
            flpTables.Dock = DockStyle.Top;
            flpTables.Location = new Point(0, 0);
            flpTables.Name = "flpTables";
            flpTables.Size = new Size(1443, 214);
            flpTables.TabIndex = 0;
            // 
            // dgvOrderProgress
            // 
            dgvOrderProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderProgress.Dock = DockStyle.Fill;
            dgvOrderProgress.Location = new Point(0, 214);
            dgvOrderProgress.Name = "dgvOrderProgress";
            dgvOrderProgress.RowHeadersWidth = 51;
            dgvOrderProgress.Size = new Size(1443, 300);
            dgvOrderProgress.TabIndex = 1;
            // 
            // btnAddTable
            // 
            btnAddTable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddTable.Location = new Point(3, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(113, 205);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "+";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // WaiterForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 514);
            Controls.Add(dgvOrderProgress);
            Controls.Add(flpTables);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "WaiterForm";
            Text = "WaiterForm";
            Load += WaiterForm_Load;
            flpTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderProgress).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTables;
        private DataGridView dgvOrderProgress;
        private Button btnAddTable;
    }
}