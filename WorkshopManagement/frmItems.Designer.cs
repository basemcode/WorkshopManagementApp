
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAddItem = new Button();
            lblItemNumber = new Label();
            tbItemCode = new TextBox();
            lblItemCodeWithColor = new Label();
            tbItemCodeWithColor = new TextBox();
            lblBarcode = new Label();
            tbBarcode = new TextBox();
            lblItemNumberOnWB = new Label();
            tbItemNumberOnWB = new TextBox();
            lblInternalCode = new Label();
            tbInternalCode = new TextBox();
            lblProductName = new Label();
            tbProductName = new TextBox();
            lblColor = new Label();
            tbColor = new TextBox();
            lblHardboardBoxNumber = new Label();
            tbHardboardBoxNumber = new TextBox();
            tbPackagingAndDimensions = new TextBox();
            lblGofferNumber = new Label();
            tbGofferNumber = new TextBox();
            lblNote = new Label();
            tbNote = new TextBox();
            lblID = new Label();
            gbItem = new GroupBox();
            cboSubGroup = new ComboBox();
            pbItemImage = new PictureBox();
            btnClearControlsValues = new Button();
            btnAddImageFromWB = new Button();
            btnAddImage = new Button();
            lblImage = new Label();
            label2 = new Label();
            tbItemID = new TextBox();
            lblPackagingAndDimensions = new Label();
            btnUpdateItem = new Button();
            btnDeleteItem = new Button();
            btnClose = new Button();
            dgvItemsTable = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ItemCode = new DataGridViewTextBoxColumn();
            ItemCodeWithColor = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            ItemImage = new DataGridViewImageColumn();
            ItemNumberOnWB = new DataGridViewTextBoxColumn();
            InternalCode = new DataGridViewTextBoxColumn();
            ProductNameCol = new DataGridViewTextBoxColumn();
            SubGroup = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            HardboardBoxNumber = new DataGridViewTextBoxColumn();
            PackagingAndDimensions = new DataGridViewTextBoxColumn();
            GofferNumber = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            cmsItemsDataGrid = new ContextMenuStrip(components);
            tsmiEdit = new ToolStripMenuItem();
            tsmiUseValue = new ToolStripMenuItem();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            lblWarehouseCategoryQuantity = new Label();
            tbWarehouseCategoryQuantity = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            tbSearchByBarcode = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tbWarehouseAllQuantity = new TextBox();
            panel5 = new Panel();
            btnUpdateAllImages = new Button();
            gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbItemImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemsTable).BeginInit();
            cmsItemsDataGrid.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddItem
            // 
            resources.ApplyResources(btnAddItem, "btnAddItem");
            btnAddItem.Image = Properties.Resources.icons8_add_48;
            btnAddItem.Name = "btnAddItem";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lblItemNumber
            // 
            resources.ApplyResources(lblItemNumber, "lblItemNumber");
            lblItemNumber.Name = "lblItemNumber";
            // 
            // tbItemCode
            // 
            resources.ApplyResources(tbItemCode, "tbItemCode");
            tbItemCode.BorderStyle = BorderStyle.FixedSingle;
            tbItemCode.Name = "tbItemCode";
            // 
            // lblItemCodeWithColor
            // 
            resources.ApplyResources(lblItemCodeWithColor, "lblItemCodeWithColor");
            lblItemCodeWithColor.Name = "lblItemCodeWithColor";
            // 
            // tbItemCodeWithColor
            // 
            resources.ApplyResources(tbItemCodeWithColor, "tbItemCodeWithColor");
            tbItemCodeWithColor.BorderStyle = BorderStyle.FixedSingle;
            tbItemCodeWithColor.Name = "tbItemCodeWithColor";
            // 
            // lblBarcode
            // 
            resources.ApplyResources(lblBarcode, "lblBarcode");
            lblBarcode.Name = "lblBarcode";
            // 
            // tbBarcode
            // 
            resources.ApplyResources(tbBarcode, "tbBarcode");
            tbBarcode.BorderStyle = BorderStyle.FixedSingle;
            tbBarcode.Name = "tbBarcode";
            tbBarcode.TextChanged += tbBarcode_TextChanged;
            // 
            // lblItemNumberOnWB
            // 
            resources.ApplyResources(lblItemNumberOnWB, "lblItemNumberOnWB");
            lblItemNumberOnWB.Name = "lblItemNumberOnWB";
            // 
            // tbItemNumberOnWB
            // 
            resources.ApplyResources(tbItemNumberOnWB, "tbItemNumberOnWB");
            tbItemNumberOnWB.BorderStyle = BorderStyle.FixedSingle;
            tbItemNumberOnWB.Name = "tbItemNumberOnWB";
            // 
            // lblInternalCode
            // 
            resources.ApplyResources(lblInternalCode, "lblInternalCode");
            lblInternalCode.Name = "lblInternalCode";
            // 
            // tbInternalCode
            // 
            resources.ApplyResources(tbInternalCode, "tbInternalCode");
            tbInternalCode.BorderStyle = BorderStyle.FixedSingle;
            tbInternalCode.Name = "tbInternalCode";
            // 
            // lblProductName
            // 
            resources.ApplyResources(lblProductName, "lblProductName");
            lblProductName.Name = "lblProductName";
            // 
            // tbProductName
            // 
            resources.ApplyResources(tbProductName, "tbProductName");
            tbProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbProductName.BorderStyle = BorderStyle.FixedSingle;
            tbProductName.Name = "tbProductName";
            // 
            // lblColor
            // 
            resources.ApplyResources(lblColor, "lblColor");
            lblColor.Name = "lblColor";
            // 
            // tbColor
            // 
            resources.ApplyResources(tbColor, "tbColor");
            tbColor.BorderStyle = BorderStyle.FixedSingle;
            tbColor.Name = "tbColor";
            // 
            // lblHardboardBoxNumber
            // 
            resources.ApplyResources(lblHardboardBoxNumber, "lblHardboardBoxNumber");
            lblHardboardBoxNumber.Name = "lblHardboardBoxNumber";
            // 
            // tbHardboardBoxNumber
            // 
            resources.ApplyResources(tbHardboardBoxNumber, "tbHardboardBoxNumber");
            tbHardboardBoxNumber.BorderStyle = BorderStyle.FixedSingle;
            tbHardboardBoxNumber.Name = "tbHardboardBoxNumber";
            // 
            // tbPackagingAndDimensions
            // 
            resources.ApplyResources(tbPackagingAndDimensions, "tbPackagingAndDimensions");
            tbPackagingAndDimensions.BorderStyle = BorderStyle.FixedSingle;
            tbPackagingAndDimensions.Name = "tbPackagingAndDimensions";
            // 
            // lblGofferNumber
            // 
            resources.ApplyResources(lblGofferNumber, "lblGofferNumber");
            lblGofferNumber.Name = "lblGofferNumber";
            // 
            // tbGofferNumber
            // 
            resources.ApplyResources(tbGofferNumber, "tbGofferNumber");
            tbGofferNumber.BorderStyle = BorderStyle.FixedSingle;
            tbGofferNumber.Name = "tbGofferNumber";
            // 
            // lblNote
            // 
            resources.ApplyResources(lblNote, "lblNote");
            lblNote.Name = "lblNote";
            // 
            // tbNote
            // 
            resources.ApplyResources(tbNote, "tbNote");
            tbNote.BorderStyle = BorderStyle.FixedSingle;
            tbNote.Name = "tbNote";
            // 
            // lblID
            // 
            resources.ApplyResources(lblID, "lblID");
            lblID.Name = "lblID";
            // 
            // gbItem
            // 
            resources.ApplyResources(gbItem, "gbItem");
            gbItem.Controls.Add(cboSubGroup);
            gbItem.Controls.Add(pbItemImage);
            gbItem.Controls.Add(lblID);
            gbItem.Controls.Add(tbNote);
            gbItem.Controls.Add(lblItemNumber);
            gbItem.Controls.Add(btnClearControlsValues);
            gbItem.Controls.Add(tbGofferNumber);
            gbItem.Controls.Add(btnAddImageFromWB);
            gbItem.Controls.Add(btnAddImage);
            gbItem.Controls.Add(tbPackagingAndDimensions);
            gbItem.Controls.Add(lblItemCodeWithColor);
            gbItem.Controls.Add(tbHardboardBoxNumber);
            gbItem.Controls.Add(lblBarcode);
            gbItem.Controls.Add(tbColor);
            gbItem.Controls.Add(lblItemNumberOnWB);
            gbItem.Controls.Add(tbProductName);
            gbItem.Controls.Add(lblInternalCode);
            gbItem.Controls.Add(tbInternalCode);
            gbItem.Controls.Add(lblProductName);
            gbItem.Controls.Add(tbItemNumberOnWB);
            gbItem.Controls.Add(lblColor);
            gbItem.Controls.Add(tbBarcode);
            gbItem.Controls.Add(lblHardboardBoxNumber);
            gbItem.Controls.Add(lblImage);
            gbItem.Controls.Add(label2);
            gbItem.Controls.Add(lblNote);
            gbItem.Controls.Add(tbItemID);
            gbItem.Controls.Add(tbItemCode);
            gbItem.Controls.Add(tbItemCodeWithColor);
            gbItem.Controls.Add(lblPackagingAndDimensions);
            gbItem.Controls.Add(lblGofferNumber);
            gbItem.Name = "gbItem";
            gbItem.TabStop = false;
            // 
            // cboSubGroup
            // 
            resources.ApplyResources(cboSubGroup, "cboSubGroup");
            cboSubGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSubGroup.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboSubGroup.FormattingEnabled = true;
            cboSubGroup.Name = "cboSubGroup";
            // 
            // pbItemImage
            // 
            resources.ApplyResources(pbItemImage, "pbItemImage");
            pbItemImage.BorderStyle = BorderStyle.FixedSingle;
            pbItemImage.Name = "pbItemImage";
            pbItemImage.TabStop = false;
            // 
            // btnClearControlsValues
            // 
            resources.ApplyResources(btnClearControlsValues, "btnClearControlsValues");
            btnClearControlsValues.Image = Properties.Resources.icons8_broom_32;
            btnClearControlsValues.Name = "btnClearControlsValues";
            btnClearControlsValues.UseVisualStyleBackColor = true;
            btnClearControlsValues.Click += btnClearControlsValues_Click;
            // 
            // btnAddImageFromWB
            // 
            resources.ApplyResources(btnAddImageFromWB, "btnAddImageFromWB");
            btnAddImageFromWB.Image = Properties.Resources.icons8_download_from_cloud_32;
            btnAddImageFromWB.Name = "btnAddImageFromWB";
            btnAddImageFromWB.UseVisualStyleBackColor = true;
            btnAddImageFromWB.Click += btnAddImageFromWB_Click;
            // 
            // btnAddImage
            // 
            resources.ApplyResources(btnAddImage, "btnAddImage");
            btnAddImage.Image = Properties.Resources.icons8_image_file_add_32;
            btnAddImage.Name = "btnAddImage";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // lblImage
            // 
            resources.ApplyResources(lblImage, "lblImage");
            lblImage.Name = "lblImage";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // tbItemID
            // 
            resources.ApplyResources(tbItemID, "tbItemID");
            tbItemID.BorderStyle = BorderStyle.FixedSingle;
            tbItemID.Name = "tbItemID";
            // 
            // lblPackagingAndDimensions
            // 
            resources.ApplyResources(lblPackagingAndDimensions, "lblPackagingAndDimensions");
            lblPackagingAndDimensions.Name = "lblPackagingAndDimensions";
            // 
            // btnUpdateItem
            // 
            resources.ApplyResources(btnUpdateItem, "btnUpdateItem");
            btnUpdateItem.Image = Properties.Resources.icons8_update_48;
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // btnDeleteItem
            // 
            resources.ApplyResources(btnDeleteItem, "btnDeleteItem");
            btnDeleteItem.Image = Properties.Resources.icons8_cancel_48;
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Image = Properties.Resources.icons8_door_closed_48;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvItemsTable
            // 
            resources.ApplyResources(dgvItemsTable, "dgvItemsTable");
            dgvItemsTable.AllowUserToAddRows = false;
            dgvItemsTable.AllowUserToDeleteRows = false;
            dgvItemsTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dgvItemsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItemsTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvItemsTable.BorderStyle = BorderStyle.Fixed3D;
            dgvItemsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItemsTable.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemCode, ItemCodeWithColor, Barcode, ItemImage, ItemNumberOnWB, InternalCode, ProductNameCol, SubGroup, Color, HardboardBoxNumber, PackagingAndDimensions, GofferNumber, Category, Note });
            dgvItemsTable.ContextMenuStrip = cmsItemsDataGrid;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItemsTable.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItemsTable.MultiSelect = false;
            dgvItemsTable.Name = "dgvItemsTable";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvItemsTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvItemsTable.RowTemplate.Height = 150;
            dgvItemsTable.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvItemsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemsTable.CellMouseEnter += dgvItemsTable_CellMouseEnter;
            dgvItemsTable.DataError += dgvItemsTable_DataError;
            // 
            // ItemID
            // 
            ItemID.DataPropertyName = "ItemID";
            ItemID.FillWeight = 2F;
            resources.ApplyResources(ItemID, "ItemID");
            ItemID.Name = "ItemID";
            ItemID.ReadOnly = true;
            // 
            // ItemCode
            // 
            ItemCode.DataPropertyName = "ItemCode";
            ItemCode.FillWeight = 7F;
            resources.ApplyResources(ItemCode, "ItemCode");
            ItemCode.Name = "ItemCode";
            // 
            // ItemCodeWithColor
            // 
            ItemCodeWithColor.DataPropertyName = "ItemCodeWithColor";
            ItemCodeWithColor.FillWeight = 7F;
            resources.ApplyResources(ItemCodeWithColor, "ItemCodeWithColor");
            ItemCodeWithColor.Name = "ItemCodeWithColor";
            // 
            // Barcode
            // 
            Barcode.DataPropertyName = "Barcode";
            Barcode.FillWeight = 7F;
            resources.ApplyResources(Barcode, "Barcode");
            Barcode.Name = "Barcode";
            // 
            // ItemImage
            // 
            ItemImage.DataPropertyName = "Image";
            ItemImage.FillWeight = 7F;
            resources.ApplyResources(ItemImage, "ItemImage");
            ItemImage.Image = Properties.Resources.download;
            ItemImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ItemImage.Name = "ItemImage";
            // 
            // ItemNumberOnWB
            // 
            ItemNumberOnWB.DataPropertyName = "ItemNumberOnWB";
            ItemNumberOnWB.FillWeight = 7F;
            resources.ApplyResources(ItemNumberOnWB, "ItemNumberOnWB");
            ItemNumberOnWB.Name = "ItemNumberOnWB";
            // 
            // InternalCode
            // 
            InternalCode.DataPropertyName = "InternalCode";
            InternalCode.FillWeight = 7F;
            resources.ApplyResources(InternalCode, "InternalCode");
            InternalCode.Name = "InternalCode";
            // 
            // ProductNameCol
            // 
            ProductNameCol.DataPropertyName = "ProductName";
            ProductNameCol.FillWeight = 7F;
            resources.ApplyResources(ProductNameCol, "ProductNameCol");
            ProductNameCol.Name = "ProductNameCol";
            // 
            // SubGroup
            // 
            SubGroup.DataPropertyName = "SubGroup";
            resources.ApplyResources(SubGroup, "SubGroup");
            SubGroup.Name = "SubGroup";
            // 
            // Color
            // 
            Color.DataPropertyName = "Color";
            Color.FillWeight = 7F;
            resources.ApplyResources(Color, "Color");
            Color.Name = "Color";
            // 
            // HardboardBoxNumber
            // 
            HardboardBoxNumber.DataPropertyName = "HardboardBoxNumber";
            HardboardBoxNumber.FillWeight = 7F;
            resources.ApplyResources(HardboardBoxNumber, "HardboardBoxNumber");
            HardboardBoxNumber.Name = "HardboardBoxNumber";
            // 
            // PackagingAndDimensions
            // 
            PackagingAndDimensions.DataPropertyName = "PackagingAndDimensions";
            PackagingAndDimensions.FillWeight = 7F;
            resources.ApplyResources(PackagingAndDimensions, "PackagingAndDimensions");
            PackagingAndDimensions.Name = "PackagingAndDimensions";
            // 
            // GofferNumber
            // 
            GofferNumber.DataPropertyName = "GofferNumber";
            GofferNumber.FillWeight = 7F;
            resources.ApplyResources(GofferNumber, "GofferNumber");
            GofferNumber.Name = "GofferNumber";
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.FillWeight = 7F;
            resources.ApplyResources(Category, "Category");
            Category.Name = "Category";
            // 
            // Note
            // 
            Note.DataPropertyName = "Note";
            Note.FillWeight = 7F;
            resources.ApplyResources(Note, "Note");
            Note.Name = "Note";
            // 
            // cmsItemsDataGrid
            // 
            resources.ApplyResources(cmsItemsDataGrid, "cmsItemsDataGrid");
            cmsItemsDataGrid.ImageScalingSize = new Size(20, 20);
            cmsItemsDataGrid.Items.AddRange(new ToolStripItem[] { tsmiEdit, tsmiUseValue });
            cmsItemsDataGrid.Name = "btnContextMenuStrip1";
            // 
            // tsmiEdit
            // 
            resources.ApplyResources(tsmiEdit, "tsmiEdit");
            tsmiEdit.Image = Properties.Resources.icons8_update_48;
            tsmiEdit.Name = "tsmiEdit";
            tsmiEdit.Click += toolStripMenuItem1_Click;
            // 
            // tsmiUseValue
            // 
            resources.ApplyResources(tsmiUseValue, "tsmiUseValue");
            tsmiUseValue.Image = Properties.Resources.icons8_left_32;
            tsmiUseValue.Name = "tsmiUseValue";
            tsmiUseValue.Click += toolStripMenuItem2_Click;
            // 
            // cboCategory
            // 
            resources.ApplyResources(cboCategory, "cboCategory");
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { resources.GetString("cboCategory.Items"), resources.GetString("cboCategory.Items1"), resources.GetString("cboCategory.Items2"), resources.GetString("cboCategory.Items3"), resources.GetString("cboCategory.Items4"), resources.GetString("cboCategory.Items5") });
            cboCategory.Name = "cboCategory";
            cboCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            resources.ApplyResources(lblCategory, "lblCategory");
            lblCategory.Name = "lblCategory";
            // 
            // lblWarehouseCategoryQuantity
            // 
            resources.ApplyResources(lblWarehouseCategoryQuantity, "lblWarehouseCategoryQuantity");
            lblWarehouseCategoryQuantity.Name = "lblWarehouseCategoryQuantity";
            // 
            // tbWarehouseCategoryQuantity
            // 
            resources.ApplyResources(tbWarehouseCategoryQuantity, "tbWarehouseCategoryQuantity");
            tbWarehouseCategoryQuantity.BorderStyle = BorderStyle.FixedSingle;
            tbWarehouseCategoryQuantity.Name = "tbWarehouseCategoryQuantity";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(gbItem);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(btnUpdateItem);
            panel1.Controls.Add(btnDeleteItem);
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel5);
            panel2.Name = "panel2";
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.Controls.Add(dgvItemsTable);
            panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Controls.Add(tbSearchByBarcode);
            panel3.Controls.Add(lblCategory);
            panel3.Controls.Add(cboCategory);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblWarehouseCategoryQuantity);
            panel3.Controls.Add(tbWarehouseAllQuantity);
            panel3.Controls.Add(tbWarehouseCategoryQuantity);
            panel3.Name = "panel3";
            // 
            // tbSearchByBarcode
            // 
            resources.ApplyResources(tbSearchByBarcode, "tbSearchByBarcode");
            tbSearchByBarcode.BorderStyle = BorderStyle.FixedSingle;
            tbSearchByBarcode.Name = "tbSearchByBarcode";
            tbSearchByBarcode.TextChanged += tbSearchByBarcode_TextChanged;
            tbSearchByBarcode.KeyDown += tbSearchByBarcode_KeyDown;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // tbWarehouseAllQuantity
            // 
            resources.ApplyResources(tbWarehouseAllQuantity, "tbWarehouseAllQuantity");
            tbWarehouseAllQuantity.BorderStyle = BorderStyle.FixedSingle;
            tbWarehouseAllQuantity.Name = "tbWarehouseAllQuantity";
            // 
            // panel5
            // 
            resources.ApplyResources(panel5, "panel5");
            panel5.Controls.Add(btnClose);
            panel5.Controls.Add(btnUpdateAllImages);
            panel5.Name = "panel5";
            // 
            // btnUpdateAllImages
            // 
            resources.ApplyResources(btnUpdateAllImages, "btnUpdateAllImages");
            btnUpdateAllImages.Name = "btnUpdateAllImages";
            btnUpdateAllImages.UseVisualStyleBackColor = true;
            btnUpdateAllImages.Click += btnUpdateAllImages_Click;
            // 
            // frmItems
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmItems";
            Load += frmItems_Load;
            Shown += frmItems_Shown;
            gbItem.ResumeLayout(false);
            gbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbItemImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItemsTable).EndInit();
            cmsItemsDataGrid.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
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

        private System.Windows.Forms.TextBox tbPackagingAndDimensions;
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
        private ComboBox cboCategory;
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
        private Label label1;
        private TextBox tbWarehouseAllQuantity;
        private Button btnUpdateAllImages;
        private Button button1;
        private ComboBox cboSubGroup;
        private Label label2;
        private Label lblPackagingAndDimensions;
        private TextBox tbSearchByBarcode;
        private Label label3;
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