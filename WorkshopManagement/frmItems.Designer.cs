
namespace WorkshopManagement
{
    partial class frmItems
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.tbItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCodeWithColor = new System.Windows.Forms.Label();
            this.tbItemCodeWithColor = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lblItemNumberOnWB = new System.Windows.Forms.Label();
            this.tbItemNumberOnWB = new System.Windows.Forms.TextBox();
            this.lblInternalCode = new System.Windows.Forms.Label();
            this.tbInternalCode = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.lblHardboardBoxNumber = new System.Windows.Forms.Label();
            this.tbHardboardBoxNumber = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.lblGofferNumber = new System.Windows.Forms.Label();
            this.tbGofferNumber = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.cboSubGroup = new System.Windows.Forms.ComboBox();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.btnClearControlsValues = new System.Windows.Forms.Button();
            this.btnAddImageFromWB = new System.Windows.Forms.Button();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvItemsTable = new System.Windows.Forms.DataGridView();
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
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GofferNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsItemsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUseValue = new System.Windows.Forms.ToolStripMenuItem();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblWarehouseCategoryQuantity = new System.Windows.Forms.Label();
            this.tbWarehouseCategoryQuantity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWarehouseAllQuantity = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpdateAllImages = new System.Windows.Forms.Button();
            this.gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsTable)).BeginInit();
            this.cmsItemsDataGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            resources.ApplyResources(this.btnAddItem, "btnAddItem");
            this.btnAddItem.Image = global::WorkshopManagement.Properties.Resources.icons8_add_48;
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblItemNumber
            // 
            resources.ApplyResources(this.lblItemNumber, "lblItemNumber");
            this.lblItemNumber.Name = "lblItemNumber";
            // 
            // tbItemCode
            // 
            resources.ApplyResources(this.tbItemCode, "tbItemCode");
            this.tbItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemCode.Name = "tbItemCode";
            // 
            // lblItemCodeWithColor
            // 
            resources.ApplyResources(this.lblItemCodeWithColor, "lblItemCodeWithColor");
            this.lblItemCodeWithColor.Name = "lblItemCodeWithColor";
            // 
            // tbItemCodeWithColor
            // 
            resources.ApplyResources(this.tbItemCodeWithColor, "tbItemCodeWithColor");
            this.tbItemCodeWithColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemCodeWithColor.Name = "tbItemCodeWithColor";
            // 
            // lblBarcode
            // 
            resources.ApplyResources(this.lblBarcode, "lblBarcode");
            this.lblBarcode.Name = "lblBarcode";
            // 
            // tbBarcode
            // 
            resources.ApplyResources(this.tbBarcode, "tbBarcode");
            this.tbBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.TextChanged += new System.EventHandler(this.tbBarcode_TextChanged);
            // 
            // lblItemNumberOnWB
            // 
            resources.ApplyResources(this.lblItemNumberOnWB, "lblItemNumberOnWB");
            this.lblItemNumberOnWB.Name = "lblItemNumberOnWB";
            // 
            // tbItemNumberOnWB
            // 
            resources.ApplyResources(this.tbItemNumberOnWB, "tbItemNumberOnWB");
            this.tbItemNumberOnWB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemNumberOnWB.Name = "tbItemNumberOnWB";
            // 
            // lblInternalCode
            // 
            resources.ApplyResources(this.lblInternalCode, "lblInternalCode");
            this.lblInternalCode.Name = "lblInternalCode";
            // 
            // tbInternalCode
            // 
            resources.ApplyResources(this.tbInternalCode, "tbInternalCode");
            this.tbInternalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInternalCode.Name = "tbInternalCode";
            // 
            // lblProductName
            // 
            resources.ApplyResources(this.lblProductName, "lblProductName");
            this.lblProductName.Name = "lblProductName";
            // 
            // tbProductName
            // 
            resources.ApplyResources(this.tbProductName, "tbProductName");
            this.tbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbProductName.Name = "tbProductName";
            // 
            // lblColor
            // 
            resources.ApplyResources(this.lblColor, "lblColor");
            this.lblColor.Name = "lblColor";
            // 
            // tbColor
            // 
            resources.ApplyResources(this.tbColor, "tbColor");
            this.tbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbColor.Name = "tbColor";
            // 
            // lblHardboardBoxNumber
            // 
            resources.ApplyResources(this.lblHardboardBoxNumber, "lblHardboardBoxNumber");
            this.lblHardboardBoxNumber.Name = "lblHardboardBoxNumber";
            // 
            // tbHardboardBoxNumber
            // 
            resources.ApplyResources(this.tbHardboardBoxNumber, "tbHardboardBoxNumber");
            this.tbHardboardBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHardboardBoxNumber.Name = "tbHardboardBoxNumber";
            // 
            // lblUnit
            // 
            resources.ApplyResources(this.lblUnit, "lblUnit");
            this.lblUnit.Name = "lblUnit";
            // 
            // tbUnit
            // 
            resources.ApplyResources(this.tbUnit, "tbUnit");
            this.tbUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUnit.Name = "tbUnit";
            // 
            // lblGofferNumber
            // 
            resources.ApplyResources(this.lblGofferNumber, "lblGofferNumber");
            this.lblGofferNumber.Name = "lblGofferNumber";
            // 
            // tbGofferNumber
            // 
            resources.ApplyResources(this.tbGofferNumber, "tbGofferNumber");
            this.tbGofferNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGofferNumber.Name = "tbGofferNumber";
            // 
            // lblNote
            // 
            resources.ApplyResources(this.lblNote, "lblNote");
            this.lblNote.Name = "lblNote";
            // 
            // tbNote
            // 
            resources.ApplyResources(this.tbNote, "tbNote");
            this.tbNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNote.Name = "tbNote";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // gbItem
            // 
            resources.ApplyResources(this.gbItem, "gbItem");
            this.gbItem.Controls.Add(this.cboSubGroup);
            this.gbItem.Controls.Add(this.pbItemImage);
            this.gbItem.Controls.Add(this.lblID);
            this.gbItem.Controls.Add(this.tbNote);
            this.gbItem.Controls.Add(this.lblItemNumber);
            this.gbItem.Controls.Add(this.btnClearControlsValues);
            this.gbItem.Controls.Add(this.tbGofferNumber);
            this.gbItem.Controls.Add(this.btnAddImageFromWB);
            this.gbItem.Controls.Add(this.btnAddImage);
            this.gbItem.Controls.Add(this.tbUnit);
            this.gbItem.Controls.Add(this.lblItemCodeWithColor);
            this.gbItem.Controls.Add(this.tbHardboardBoxNumber);
            this.gbItem.Controls.Add(this.lblBarcode);
            this.gbItem.Controls.Add(this.tbColor);
            this.gbItem.Controls.Add(this.lblItemNumberOnWB);
            this.gbItem.Controls.Add(this.tbProductName);
            this.gbItem.Controls.Add(this.lblInternalCode);
            this.gbItem.Controls.Add(this.tbInternalCode);
            this.gbItem.Controls.Add(this.lblProductName);
            this.gbItem.Controls.Add(this.tbItemNumberOnWB);
            this.gbItem.Controls.Add(this.lblColor);
            this.gbItem.Controls.Add(this.tbBarcode);
            this.gbItem.Controls.Add(this.lblHardboardBoxNumber);
            this.gbItem.Controls.Add(this.lblImage);
            this.gbItem.Controls.Add(this.label2);
            this.gbItem.Controls.Add(this.lblNote);
            this.gbItem.Controls.Add(this.tbItemID);
            this.gbItem.Controls.Add(this.tbItemCode);
            this.gbItem.Controls.Add(this.tbItemCodeWithColor);
            this.gbItem.Controls.Add(this.lblUnit);
            this.gbItem.Controls.Add(this.lblGofferNumber);
            this.gbItem.Name = "gbItem";
            this.gbItem.TabStop = false;
            // 
            // cboSubGroup
            // 
            resources.ApplyResources(this.cboSubGroup, "cboSubGroup");
            this.cboSubGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSubGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSubGroup.FormattingEnabled = true;
            this.cboSubGroup.Name = "cboSubGroup";
            // 
            // pbItemImage
            // 
            resources.ApplyResources(this.pbItemImage, "pbItemImage");
            this.pbItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.TabStop = false;
            // 
            // btnClearControlsValues
            // 
            resources.ApplyResources(this.btnClearControlsValues, "btnClearControlsValues");
            this.btnClearControlsValues.Image = global::WorkshopManagement.Properties.Resources.icons8_broom_32;
            this.btnClearControlsValues.Name = "btnClearControlsValues";
            this.btnClearControlsValues.UseVisualStyleBackColor = true;
            this.btnClearControlsValues.Click += new System.EventHandler(this.btnClearControlsValues_Click);
            // 
            // btnAddImageFromWB
            // 
            resources.ApplyResources(this.btnAddImageFromWB, "btnAddImageFromWB");
            this.btnAddImageFromWB.Image = global::WorkshopManagement.Properties.Resources.icons8_download_from_cloud_32;
            this.btnAddImageFromWB.Name = "btnAddImageFromWB";
            this.btnAddImageFromWB.UseVisualStyleBackColor = true;
            this.btnAddImageFromWB.Click += new System.EventHandler(this.btnAddImageFromWB_Click);
            // 
            // btnAddImage
            // 
            resources.ApplyResources(this.btnAddImage, "btnAddImage");
            this.btnAddImage.Image = global::WorkshopManagement.Properties.Resources.icons8_image_file_add_32;
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lblImage
            // 
            resources.ApplyResources(this.lblImage, "lblImage");
            this.lblImage.Name = "lblImage";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbItemID
            // 
            resources.ApplyResources(this.tbItemID, "tbItemID");
            this.tbItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemID.Name = "tbItemID";
            // 
            // btnUpdateItem
            // 
            resources.ApplyResources(this.btnUpdateItem, "btnUpdateItem");
            this.btnUpdateItem.Image = global::WorkshopManagement.Properties.Resources.icons8_update_48;
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnDeleteItem
            // 
            resources.ApplyResources(this.btnDeleteItem, "btnDeleteItem");
            this.btnDeleteItem.Image = global::WorkshopManagement.Properties.Resources.icons8_cancel_48;
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Image = global::WorkshopManagement.Properties.Resources.icons8_door_closed_48;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvItemsTable
            // 
            resources.ApplyResources(this.dgvItemsTable, "dgvItemsTable");
            this.dgvItemsTable.AllowUserToAddRows = false;
            this.dgvItemsTable.AllowUserToDeleteRows = false;
            this.dgvItemsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemsTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.Unit,
            this.GofferNumber,
            this.Category,
            this.Note});
            this.dgvItemsTable.ContextMenuStrip = this.cmsItemsDataGrid;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemsTable.MultiSelect = false;
            this.dgvItemsTable.Name = "dgvItemsTable";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemsTable.RowTemplate.Height = 150;
            this.dgvItemsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemsTable_CellMouseEnter);
            this.dgvItemsTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvItemsTable_DataError);
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.FillWeight = 2F;
            resources.ApplyResources(this.ItemID, "ItemID");
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.FillWeight = 7F;
            resources.ApplyResources(this.ItemCode, "ItemCode");
            this.ItemCode.Name = "ItemCode";
            // 
            // ItemCodeWithColor
            // 
            this.ItemCodeWithColor.DataPropertyName = "ItemCodeWithColor";
            this.ItemCodeWithColor.FillWeight = 7F;
            resources.ApplyResources(this.ItemCodeWithColor, "ItemCodeWithColor");
            this.ItemCodeWithColor.Name = "ItemCodeWithColor";
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.FillWeight = 7F;
            resources.ApplyResources(this.Barcode, "Barcode");
            this.Barcode.Name = "Barcode";
            // 
            // ItemImage
            // 
            this.ItemImage.DataPropertyName = "Image";
            this.ItemImage.FillWeight = 7F;
            resources.ApplyResources(this.ItemImage, "ItemImage");
            this.ItemImage.Image = global::WorkshopManagement.Properties.Resources.download;
            this.ItemImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ItemImage.Name = "ItemImage";
            // 
            // ItemNumberOnWB
            // 
            this.ItemNumberOnWB.DataPropertyName = "ItemNumberOnWB";
            this.ItemNumberOnWB.FillWeight = 7F;
            resources.ApplyResources(this.ItemNumberOnWB, "ItemNumberOnWB");
            this.ItemNumberOnWB.Name = "ItemNumberOnWB";
            // 
            // InternalCode
            // 
            this.InternalCode.DataPropertyName = "InternalCode";
            this.InternalCode.FillWeight = 7F;
            resources.ApplyResources(this.InternalCode, "InternalCode");
            this.InternalCode.Name = "InternalCode";
            // 
            // ProductNameCol
            // 
            this.ProductNameCol.DataPropertyName = "ProductName";
            this.ProductNameCol.FillWeight = 7F;
            resources.ApplyResources(this.ProductNameCol, "ProductNameCol");
            this.ProductNameCol.Name = "ProductNameCol";
            // 
            // SubGroup
            // 
            this.SubGroup.DataPropertyName = "SubGroup";
            resources.ApplyResources(this.SubGroup, "SubGroup");
            this.SubGroup.Name = "SubGroup";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.FillWeight = 7F;
            resources.ApplyResources(this.Color, "Color");
            this.Color.Name = "Color";
            // 
            // HardboardBoxNumber
            // 
            this.HardboardBoxNumber.DataPropertyName = "HardboardBoxNumber";
            this.HardboardBoxNumber.FillWeight = 7F;
            resources.ApplyResources(this.HardboardBoxNumber, "HardboardBoxNumber");
            this.HardboardBoxNumber.Name = "HardboardBoxNumber";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.FillWeight = 7F;
            resources.ApplyResources(this.Unit, "Unit");
            this.Unit.Name = "Unit";
            // 
            // GofferNumber
            // 
            this.GofferNumber.DataPropertyName = "GofferNumber";
            this.GofferNumber.FillWeight = 7F;
            resources.ApplyResources(this.GofferNumber, "GofferNumber");
            this.GofferNumber.Name = "GofferNumber";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.FillWeight = 7F;
            resources.ApplyResources(this.Category, "Category");
            this.Category.Name = "Category";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.FillWeight = 7F;
            resources.ApplyResources(this.Note, "Note");
            this.Note.Name = "Note";
            // 
            // cmsItemsDataGrid
            // 
            resources.ApplyResources(this.cmsItemsDataGrid, "cmsItemsDataGrid");
            this.cmsItemsDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsItemsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiUseValue});
            this.cmsItemsDataGrid.Name = "btnContextMenuStrip1";
            // 
            // tsmiEdit
            // 
            resources.ApplyResources(this.tsmiEdit, "tsmiEdit");
            this.tsmiEdit.Image = global::WorkshopManagement.Properties.Resources.icons8_update_48;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiUseValue
            // 
            resources.ApplyResources(this.tsmiUseValue, "tsmiUseValue");
            this.tsmiUseValue.Image = global::WorkshopManagement.Properties.Resources.icons8_left_32;
            this.tsmiUseValue.Name = "tsmiUseValue";
            this.tsmiUseValue.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cbCategory
            // 
            resources.ApplyResources(this.cbCategory, "cbCategory");
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            resources.GetString("cbCategory.Items"),
            resources.GetString("cbCategory.Items1"),
            resources.GetString("cbCategory.Items2"),
            resources.GetString("cbCategory.Items3"),
            resources.GetString("cbCategory.Items4"),
            resources.GetString("cbCategory.Items5")});
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // lblWarehouseCategoryQuantity
            // 
            resources.ApplyResources(this.lblWarehouseCategoryQuantity, "lblWarehouseCategoryQuantity");
            this.lblWarehouseCategoryQuantity.Name = "lblWarehouseCategoryQuantity";
            // 
            // tbWarehouseCategoryQuantity
            // 
            resources.ApplyResources(this.tbWarehouseCategoryQuantity, "tbWarehouseCategoryQuantity");
            this.tbWarehouseCategoryQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWarehouseCategoryQuantity.Name = "tbWarehouseCategoryQuantity";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.gbItem);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.btnUpdateItem);
            this.panel1.Controls.Add(this.btnDeleteItem);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.dgvItemsTable);
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.lblCategory);
            this.panel3.Controls.Add(this.cbCategory);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblWarehouseCategoryQuantity);
            this.panel3.Controls.Add(this.tbWarehouseAllQuantity);
            this.panel3.Controls.Add(this.tbWarehouseCategoryQuantity);
            this.panel3.Name = "panel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbWarehouseAllQuantity
            // 
            resources.ApplyResources(this.tbWarehouseAllQuantity, "tbWarehouseAllQuantity");
            this.tbWarehouseAllQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWarehouseAllQuantity.Name = "tbWarehouseAllQuantity";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Controls.Add(this.btnUpdateAllImages);
            this.panel5.Name = "panel5";
            // 
            // btnUpdateAllImages
            // 
            resources.ApplyResources(this.btnUpdateAllImages, "btnUpdateAllImages");
            this.btnUpdateAllImages.Name = "btnUpdateAllImages";
            this.btnUpdateAllImages.UseVisualStyleBackColor = true;
            this.btnUpdateAllImages.Click += new System.EventHandler(this.btnUpdateAllImages_Click);
            // 
            // frmItems
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmItems";
            this.Load += new System.EventHandler(this.frmAddItems_Load);
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsTable)).EndInit();
            this.cmsItemsDataGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.TextBox tbItemCode;
        private System.Windows.Forms.Label lblItemCodeWithColor;
        private System.Windows.Forms.TextBox tbItemCodeWithColor;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label lblItemNumberOnWB;
        private System.Windows.Forms.TextBox tbItemNumberOnWB;
        private System.Windows.Forms.Label lblInternalCode;
        private System.Windows.Forms.TextBox tbInternalCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label lblHardboardBoxNumber;
        private System.Windows.Forms.TextBox tbHardboardBoxNumber;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label lblGofferNumber;
        private System.Windows.Forms.TextBox tbGofferNumber;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lblID;
        private GroupBox gbItem;
        private Button btnUpdateItem;
        private Button btnDeleteItem;
        private Button btnClose;
        private DataGridView dgvItemsTable;
        private PictureBox pbItemImage;
        private Button btnAddImage;
        private Label lblImage;
        private TextBox tbItemID;
        private Button btnAddImageFromWB;
        private ComboBox cbCategory;
        private Label lblCategory;
        private Button btnClearControlsValues;
        private Label lblWarehouseCategoryQuantity;
        private TextBox tbWarehouseCategoryQuantity;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private ContextMenuStrip cmsItemsDataGrid;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiUseValue;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewTextBoxColumn ItemCodeWithColor;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewImageColumn ItemImage;
        private DataGridViewTextBoxColumn ItemNumberOnWB;
        private DataGridViewTextBoxColumn InternalCode;
        private DataGridViewTextBoxColumn ProductNameCol;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn HardboardBoxNumber;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn GofferNumber;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Note;
        private Label label1;
        private TextBox tbWarehouseAllQuantity;
        private Button btnUpdateAllImages;
        private Button button1;
        private ComboBox cboSubGroup;
        private Label label2;
        private DataGridViewTextBoxColumn SubGroup;
    }
}