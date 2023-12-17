namespace WorkshopManagement.Forms
{
    partial class frmReportOfWarehouse
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvItemsTable = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ItemCode = new DataGridViewTextBoxColumn();
            ItemCodeWithColor = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            Image = new DataGridViewImageColumn();
            InternalCode = new DataGridViewTextBoxColumn();
            ProductNameCol = new DataGridViewTextBoxColumn();
            QuantityInStock = new DataGridViewTextBoxColumn();
            BoxesQuantity = new DataGridViewTextBoxColumn();
            MinimumQuantity = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            DifferenceFromReserve = new DataGridViewTextBoxColumn();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvItemsTable).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItemsTable
            // 
            dgvItemsTable.AllowUserToAddRows = false;
            dgvItemsTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvItemsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItemsTable.BackgroundColor = Color.WhiteSmoke;
            dgvItemsTable.ColumnHeadersHeight = 50;
            dgvItemsTable.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemCode, ItemCodeWithColor, Barcode, Image, InternalCode, ProductNameCol, QuantityInStock, BoxesQuantity, MinimumQuantity, Category, DifferenceFromReserve });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvItemsTable.DefaultCellStyle = dataGridViewCellStyle3;
            dgvItemsTable.Dock = DockStyle.Fill;
            dgvItemsTable.Location = new Point(3, 2);
            dgvItemsTable.Margin = new Padding(3, 2, 3, 2);
            dgvItemsTable.MultiSelect = false;
            dgvItemsTable.Name = "dgvItemsTable";
            dgvItemsTable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvItemsTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvItemsTable.RowTemplate.Height = 120;
            dgvItemsTable.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvItemsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemsTable.Size = new Size(1053, 544);
            dgvItemsTable.TabIndex = 1;
            dgvItemsTable.DataError += dgvItemsTable_DataError;
            dgvItemsTable.SelectionChanged += dgvItemsTable_SelectionChanged;
            // 
            // ItemID
            // 
            ItemID.DataPropertyName = "ItemID";
            ItemID.HeaderText = "ID";
            ItemID.MinimumWidth = 20;
            ItemID.Name = "ItemID";
            ItemID.ReadOnly = true;
            ItemID.Width = 50;
            // 
            // ItemCode
            // 
            ItemCode.DataPropertyName = "ItemCode";
            ItemCode.HeaderText = "Артикул";
            ItemCode.MinimumWidth = 20;
            ItemCode.Name = "ItemCode";
            ItemCode.Width = 75;
            // 
            // ItemCodeWithColor
            // 
            ItemCodeWithColor.DataPropertyName = "ItemCodeWithColor";
            ItemCodeWithColor.HeaderText = "Артикул цвета ";
            ItemCodeWithColor.MinimumWidth = 20;
            ItemCodeWithColor.Name = "ItemCodeWithColor";
            ItemCodeWithColor.Width = 175;
            // 
            // Barcode
            // 
            Barcode.DataPropertyName = "Barcode";
            Barcode.HeaderText = "Баркод";
            Barcode.MinimumWidth = 20;
            Barcode.Name = "Barcode";
            Barcode.Width = 130;
            // 
            // Image
            // 
            Image.DataPropertyName = "Image";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Image.DefaultCellStyle = dataGridViewCellStyle2;
            Image.HeaderText = "Изображение";
            Image.Image = Properties.Resources.download;
            Image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Image.MinimumWidth = 6;
            Image.Name = "Image";
            Image.Width = 110;
            // 
            // InternalCode
            // 
            InternalCode.DataPropertyName = "InternalCode";
            InternalCode.HeaderText = "Внутренний код ";
            InternalCode.MinimumWidth = 20;
            InternalCode.Name = "InternalCode";
            InternalCode.Width = 95;
            // 
            // ProductNameCol
            // 
            ProductNameCol.DataPropertyName = "ProductName";
            ProductNameCol.HeaderText = "Наименование изделия";
            ProductNameCol.MinimumWidth = 20;
            ProductNameCol.Name = "ProductNameCol";
            ProductNameCol.Width = 120;
            // 
            // QuantityInStock
            // 
            QuantityInStock.DataPropertyName = "QuantityInStock";
            QuantityInStock.HeaderText = "количество на складе";
            QuantityInStock.MinimumWidth = 20;
            QuantityInStock.Name = "QuantityInStock";
            QuantityInStock.Width = 85;
            // 
            // BoxesQuantity
            // 
            BoxesQuantity.DataPropertyName = "BoxesQuantity";
            BoxesQuantity.HeaderText = "количество коробок";
            BoxesQuantity.MinimumWidth = 20;
            BoxesQuantity.Name = "BoxesQuantity";
            BoxesQuantity.Width = 85;
            // 
            // MinimumQuantity
            // 
            MinimumQuantity.DataPropertyName = "MinimumQuantity";
            MinimumQuantity.HeaderText = "Нормативный запас";
            MinimumQuantity.MinimumWidth = 20;
            MinimumQuantity.Name = "MinimumQuantity";
            MinimumQuantity.Width = 90;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Раздел";
            Category.MinimumWidth = 20;
            Category.Name = "Category";
            Category.Width = 105;
            // 
            // DifferenceFromReserve
            // 
            DifferenceFromReserve.DataPropertyName = "DifferenceFromReserve";
            DifferenceFromReserve.HeaderText = "DifferenceFromReserve";
            DifferenceFromReserve.MinimumWidth = 6;
            DifferenceFromReserve.Name = "DifferenceFromReserve";
            DifferenceFromReserve.ReadOnly = true;
            DifferenceFromReserve.SortMode = DataGridViewColumnSortMode.Programmatic;
            DifferenceFromReserve.Width = 125;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(1067, 220);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(101, 107);
            button1.TabIndex = 3;
            button1.Text = "показывать уведомления";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(dgvItemsTable, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1177, 544);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // frmReportOfWarehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 544);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmReportOfWarehouse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report of warehouse";
            WindowState = FormWindowState.Maximized;
            Load += frmReportOfWarehouse_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItemsTable).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItemsTable;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewTextBoxColumn ItemCodeWithColor;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn InternalCode;
        private DataGridViewTextBoxColumn ProductNameCol;
        private DataGridViewTextBoxColumn QuantityInStock;
        private DataGridViewTextBoxColumn BoxesQuantity;
        private DataGridViewTextBoxColumn MinimumQuantity;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn DifferenceFromReserve;
    }
}