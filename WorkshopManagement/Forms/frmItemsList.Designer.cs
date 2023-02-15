namespace WorkshopManagement.Forms
{
    partial class frmItemsList
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
            this.dgvItemsTable = new Krypton.Toolkit.KryptonDataGridView();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWarehouseCategoryQuantity = new System.Windows.Forms.Label();
            this.tbWarehouseAllQuantity = new System.Windows.Forms.TextBox();
            this.tbWarehouseCategoryQuantity = new System.Windows.Forms.TextBox();
            this.cboSubGroup = new System.Windows.Forms.ComboBox();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCodeWithColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemNumberOnWB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InternalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HardboardBoxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagingAndDimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GofferNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemsTable
            // 
            this.dgvItemsTable.ColumnHeadersHeight = 36;
            this.dgvItemsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemCode,
            this.ItemCodeWithColor,
            this.Barcode,
            this.ItemImage,
            this.ItemNumberOnWB,
            this.InternalCode,
            this.ProductNameCol,
            this.SubGroup,
            this.Color,
            this.HardboardBoxNumber,
            this.PackagingAndDimensions,
            this.GofferNumber,
            this.Category,
            this.Note});
            this.dgvItemsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItemsTable.Location = new System.Drawing.Point(0, 161);
            this.dgvItemsTable.Name = "dgvItemsTable";
            this.dgvItemsTable.RowHeadersWidth = 51;
            this.dgvItemsTable.RowTemplate.Height = 130;
            this.dgvItemsTable.Size = new System.Drawing.Size(1156, 537);
            this.dgvItemsTable.TabIndex = 0;
            this.dgvItemsTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvItemsTable_DataError);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Сводная",
            "НГ23",
            "Свадебная",
            "Буквы ",
            "Нова",
            "Прочее"});
            this.cboCategory.Location = new System.Drawing.Point(87, 54);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(151, 28);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.Text = "Сводная";
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(638, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество всех товаров :";
            // 
            // lblWarehouseCategoryQuantity
            // 
            this.lblWarehouseCategoryQuantity.AutoSize = true;
            this.lblWarehouseCategoryQuantity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWarehouseCategoryQuantity.Location = new System.Drawing.Point(302, 57);
            this.lblWarehouseCategoryQuantity.Name = "lblWarehouseCategoryQuantity";
            this.lblWarehouseCategoryQuantity.Size = new System.Drawing.Size(230, 20);
            this.lblWarehouseCategoryQuantity.TabIndex = 4;
            this.lblWarehouseCategoryQuantity.Text = "Количество товаров в разделе :";
            // 
            // tbWarehouseAllQuantity
            // 
            this.tbWarehouseAllQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWarehouseAllQuantity.Location = new System.Drawing.Point(836, 55);
            this.tbWarehouseAllQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWarehouseAllQuantity.Name = "tbWarehouseAllQuantity";
            this.tbWarehouseAllQuantity.Size = new System.Drawing.Size(93, 27);
            this.tbWarehouseAllQuantity.TabIndex = 5;
            // 
            // tbWarehouseCategoryQuantity
            // 
            this.tbWarehouseCategoryQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWarehouseCategoryQuantity.Location = new System.Drawing.Point(536, 56);
            this.tbWarehouseCategoryQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWarehouseCategoryQuantity.Name = "tbWarehouseCategoryQuantity";
            this.tbWarehouseCategoryQuantity.Size = new System.Drawing.Size(93, 27);
            this.tbWarehouseCategoryQuantity.TabIndex = 6;
            // 
            // cboSubGroup
            // 
            this.cboSubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSubGroup.FormattingEnabled = true;
            this.cboSubGroup.Location = new System.Drawing.Point(87, 20);
            this.cboSubGroup.Name = "cboSubGroup";
            this.cboSubGroup.Size = new System.Drawing.Size(213, 28);
            this.cboSubGroup.TabIndex = 17;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 125;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 125;
            // 
            // ItemCodeWithColor
            // 
            this.ItemCodeWithColor.DataPropertyName = "ItemCodeWithColor";
            this.ItemCodeWithColor.HeaderText = "ItemCodeWithColor";
            this.ItemCodeWithColor.MinimumWidth = 6;
            this.ItemCodeWithColor.Name = "ItemCodeWithColor";
            this.ItemCodeWithColor.Width = 125;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 125;
            // 
            // ItemImage
            // 
            this.ItemImage.DataPropertyName = "Image";
            this.ItemImage.HeaderText = "ItemImage";
            this.ItemImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ItemImage.MinimumWidth = 6;
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.ReadOnly = true;
            this.ItemImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemImage.Width = 125;
            // 
            // ItemNumberOnWB
            // 
            this.ItemNumberOnWB.DataPropertyName = "ItemNumberOnWB";
            this.ItemNumberOnWB.HeaderText = "ItemNumberOnWB";
            this.ItemNumberOnWB.MinimumWidth = 6;
            this.ItemNumberOnWB.Name = "ItemNumberOnWB";
            this.ItemNumberOnWB.ReadOnly = true;
            this.ItemNumberOnWB.Width = 125;
            // 
            // InternalCode
            // 
            this.InternalCode.DataPropertyName = "InternalCode";
            this.InternalCode.HeaderText = "InternalCode";
            this.InternalCode.MinimumWidth = 6;
            this.InternalCode.Name = "InternalCode";
            this.InternalCode.ReadOnly = true;
            this.InternalCode.Width = 125;
            // 
            // ProductNameCol
            // 
            this.ProductNameCol.DataPropertyName = "ProductName";
            this.ProductNameCol.HeaderText = "ProductNameCol";
            this.ProductNameCol.MinimumWidth = 6;
            this.ProductNameCol.Name = "ProductNameCol";
            this.ProductNameCol.ReadOnly = true;
            this.ProductNameCol.Width = 125;
            // 
            // SubGroup
            // 
            this.SubGroup.DataPropertyName = "SubGroup";
            this.SubGroup.HeaderText = "SubGroup";
            this.SubGroup.MinimumWidth = 6;
            this.SubGroup.Name = "SubGroup";
            this.SubGroup.ReadOnly = true;
            this.SubGroup.Width = 125;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 125;
            // 
            // HardboardBoxNumber
            // 
            this.HardboardBoxNumber.DataPropertyName = "HardboardBoxNumber";
            this.HardboardBoxNumber.HeaderText = "HardboardBoxNumber";
            this.HardboardBoxNumber.MinimumWidth = 6;
            this.HardboardBoxNumber.Name = "HardboardBoxNumber";
            this.HardboardBoxNumber.ReadOnly = true;
            this.HardboardBoxNumber.Width = 125;
            // 
            // PackagingAndDimensions
            // 
            this.PackagingAndDimensions.DataPropertyName = "PackagingAndDimensions";
            this.PackagingAndDimensions.HeaderText = "PackagingAndDimensions";
            this.PackagingAndDimensions.MinimumWidth = 6;
            this.PackagingAndDimensions.Name = "PackagingAndDimensions";
            this.PackagingAndDimensions.ReadOnly = true;
            this.PackagingAndDimensions.Width = 125;
            // 
            // GofferNumber
            // 
            this.GofferNumber.DataPropertyName = "GofferNumber";
            this.GofferNumber.HeaderText = "GofferNumber";
            this.GofferNumber.MinimumWidth = 6;
            this.GofferNumber.Name = "GofferNumber";
            this.GofferNumber.ReadOnly = true;
            this.GofferNumber.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 125;
            // 
            // frmItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 698);
            this.Controls.Add(this.cboSubGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWarehouseCategoryQuantity);
            this.Controls.Add(this.tbWarehouseAllQuantity);
            this.Controls.Add(this.tbWarehouseCategoryQuantity);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.dgvItemsTable);
            this.Name = "frmItemsList";
            this.Text = "frmItemsList";
            this.Load += new System.EventHandler(this.frmItemsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvItemsTable;
        private ComboBox cboCategory;
        private Label label1;
        private Label lblWarehouseCategoryQuantity;
        private TextBox tbWarehouseAllQuantity;
        private TextBox tbWarehouseCategoryQuantity;
        private ComboBox cboSubGroup;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewTextBoxColumn ItemCodeWithColor;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewImageColumn ItemImage;
        private DataGridViewTextBoxColumn ItemNumberOnWB;
        private DataGridViewTextBoxColumn InternalCode;
        private DataGridViewTextBoxColumn ProductNameCol;
        private DataGridViewTextBoxColumn SubGroup;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn HardboardBoxNumber;
        private DataGridViewTextBoxColumn PackagingAndDimensions;
        private DataGridViewTextBoxColumn GofferNumber;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Note;
    }
}