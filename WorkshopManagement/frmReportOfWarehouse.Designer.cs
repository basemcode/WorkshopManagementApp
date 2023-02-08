namespace WorkshopManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvItemsTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCodeWithColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.InternalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsTable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvItemsTable
            // 
            this.dgvItemsTable.AllowUserToAddRows = false;
            this.dgvItemsTable.AllowUserToDeleteRows = false;
            this.dgvItemsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItemsTable.ColumnHeadersHeight = 50;
            this.dgvItemsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemCode,
            this.ItemCodeWithColor,
            this.Barcode,
            this.Image,
            this.InternalCode,
            this.ProductNameCol,
            this.dataGridViewTextBoxColumn1,
            this.QuantityInStock,
            this.BoxesQuantity,
            this.MinimumQuantity,
            this.Category});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemsTable.Location = new System.Drawing.Point(3, 3);
            this.dgvItemsTable.MultiSelect = false;
            this.dgvItemsTable.Name = "dgvItemsTable";
            this.dgvItemsTable.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemsTable.RowTemplate.Height = 120;
            this.dgvItemsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsTable.Size = new System.Drawing.Size(1204, 726);
            this.dgvItemsTable.TabIndex = 1;
            this.dgvItemsTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvItemsTable_DataError);
            this.dgvItemsTable.SelectionChanged += new System.EventHandler(this.dgvItemsTable_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(1220, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 143);
            this.button1.TabIndex = 3;
            this.button1.Text = "показывать уведомления";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.dgvItemsTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1345, 726);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ID";
            this.ItemID.MinimumWidth = 20;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "Артикул";
            this.ItemCode.MinimumWidth = 20;
            this.ItemCode.Name = "ItemCode";
            // 
            // ItemCodeWithColor
            // 
            this.ItemCodeWithColor.DataPropertyName = "ItemCodeWithColor";
            this.ItemCodeWithColor.HeaderText = "Артикул цвета ";
            this.ItemCodeWithColor.MinimumWidth = 20;
            this.ItemCodeWithColor.Name = "ItemCodeWithColor";
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Баркод";
            this.Barcode.MinimumWidth = 20;
            this.Barcode.Name = "Barcode";
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Image.DefaultCellStyle = dataGridViewCellStyle1;
            this.Image.HeaderText = "Изображение";
            this.Image.Image = global::WorkshopManagement.Properties.Resources.download;
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            // 
            // InternalCode
            // 
            this.InternalCode.DataPropertyName = "InternalCode";
            this.InternalCode.HeaderText = "Внутренний код ";
            this.InternalCode.MinimumWidth = 20;
            this.InternalCode.Name = "InternalCode";
            // 
            // ProductNameCol
            // 
            this.ProductNameCol.DataPropertyName = "ProductName";
            this.ProductNameCol.HeaderText = "Наименование изделия";
            this.ProductNameCol.MinimumWidth = 20;
            this.ProductNameCol.Name = "ProductNameCol";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn1.HeaderText = "Раздел";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "количество на складе";
            this.QuantityInStock.MinimumWidth = 20;
            this.QuantityInStock.Name = "QuantityInStock";
            // 
            // BoxesQuantity
            // 
            this.BoxesQuantity.DataPropertyName = "BoxesQuantity";
            this.BoxesQuantity.HeaderText = "количество коробок";
            this.BoxesQuantity.MinimumWidth = 20;
            this.BoxesQuantity.Name = "BoxesQuantity";
            // 
            // MinimumQuantity
            // 
            this.MinimumQuantity.DataPropertyName = "MinimumQuantity";
            this.MinimumQuantity.HeaderText = "Нормативный запас";
            this.MinimumQuantity.MinimumWidth = 20;
            this.MinimumQuantity.Name = "MinimumQuantity";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Раздел";
            this.Category.MinimumWidth = 20;
            this.Category.Name = "Category";
            // 
            // frmReportOfWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 726);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmReportOfWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportOfWarehouse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportOfWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsTable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvItemsTable;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewTextBoxColumn ItemCodeWithColor;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn InternalCode;
        private DataGridViewTextBoxColumn ProductNameCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn QuantityInStock;
        private DataGridViewTextBoxColumn BoxesQuantity;
        private DataGridViewTextBoxColumn MinimumQuantity;
        private DataGridViewTextBoxColumn Category;
    }
}