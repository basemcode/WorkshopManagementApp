namespace WorkshopManagement
{
    partial class frmStockInDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.dgvStockInDetails = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCodeWithColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plusBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.minusBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BoxesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.cboBarcode = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picItemPhoto = new System.Windows.Forms.PictureBox();
            this.btnAddItemToDGV = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtBoxesQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchItemName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.picSearchItemPhoto = new System.Windows.Forms.PictureBox();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.txtLoggedUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchItemPhoto)).BeginInit();
            this.grpUser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(199, 25);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(98, 27);
            this.txtItemID.TabIndex = 1;
            this.txtItemID.TabStop = false;
            // 
            // dgvStockInDetails
            // 
            this.dgvStockInDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStockInDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockInDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockInDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStockInDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockInDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.Barcode,
            this.ItemCodeWithColor,
            this.ProductName,
            this.Quantity,
            this.plusBtnCol,
            this.minusBtnCol,
            this.BoxesQuantity,
            this.Category});
            this.dgvStockInDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockInDetails.Location = new System.Drawing.Point(13, 233);
            this.dgvStockInDetails.MultiSelect = false;
            this.dgvStockInDetails.Name = "dgvStockInDetails";
            this.dgvStockInDetails.ReadOnly = true;
            this.dgvStockInDetails.RowHeadersWidth = 51;
            this.dgvStockInDetails.RowTemplate.Height = 29;
            this.dgvStockInDetails.Size = new System.Drawing.Size(1104, 498);
            this.dgvStockInDetails.TabIndex = 17;
            this.dgvStockInDetails.TabStop = false;
            this.dgvStockInDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockInDetails_CellClick);
            this.dgvStockInDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvStockInDetails_DataError);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ID товара";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Баркод";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // ItemCodeWithColor
            // 
            this.ItemCodeWithColor.DataPropertyName = "ItemCodeWithColor";
            this.ItemCodeWithColor.HeaderText = "Артикул цвета";
            this.ItemCodeWithColor.MinimumWidth = 6;
            this.ItemCodeWithColor.Name = "ItemCodeWithColor";
            this.ItemCodeWithColor.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Наименование изделия";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Количество";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // plusBtnCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plusBtnCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.plusBtnCol.HeaderText = "+";
            this.plusBtnCol.MinimumWidth = 6;
            this.plusBtnCol.Name = "plusBtnCol";
            this.plusBtnCol.ReadOnly = true;
            this.plusBtnCol.Text = "+";
            this.plusBtnCol.UseColumnTextForButtonValue = true;
            // 
            // minusBtnCol
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.minusBtnCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.minusBtnCol.HeaderText = "-";
            this.minusBtnCol.MinimumWidth = 6;
            this.minusBtnCol.Name = "minusBtnCol";
            this.minusBtnCol.ReadOnly = true;
            this.minusBtnCol.Text = "-";
            this.minusBtnCol.UseColumnTextForButtonValue = true;
            // 
            // BoxesQuantity
            // 
            this.BoxesQuantity.DataPropertyName = "BoxesQuantity";
            this.BoxesQuantity.HeaderText = "Количество коробок";
            this.BoxesQuantity.MinimumWidth = 6;
            this.BoxesQuantity.Name = "BoxesQuantity";
            this.BoxesQuantity.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Раздел";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(605, 97);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(156, 27);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Наименование изделия :";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(199, 61);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(239, 27);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Баркод:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Location = new System.Drawing.Point(605, 25);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(156, 27);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // cboBarcode
            // 
            this.cboBarcode.FormattingEnabled = true;
            this.cboBarcode.Location = new System.Drawing.Point(33, 62);
            this.cboBarcode.Name = "cboBarcode";
            this.cboBarcode.Size = new System.Drawing.Size(185, 28);
            this.cboBarcode.TabIndex = 3;
            this.cboBarcode.SelectedIndexChanged += new System.EventHandler(this.cboBarcode_SelectedIndexChanged);
            this.cboBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboBarcode_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Image = global::WorkshopManagement.Properties.Resources.icons8_save_32;
            this.btnSave.Location = new System.Drawing.Point(39, 586);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 55);
            this.btnSave.TabIndex = 16;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Сохранить";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Image = global::WorkshopManagement.Properties.Resources.icons8_unavailable_32;
            this.btnCancel.Location = new System.Drawing.Point(39, 649);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 55);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Поиск продукта :";
            // 
            // btnShowItem
            // 
            this.btnShowItem.Location = new System.Drawing.Point(33, 96);
            this.btnShowItem.Name = "btnShowItem";
            this.btnShowItem.Size = new System.Drawing.Size(185, 40);
            this.btnShowItem.TabIndex = 4;
            this.btnShowItem.Text = "Использовать";
            this.btnShowItem.UseVisualStyleBackColor = true;
            this.btnShowItem.Click += new System.EventHandler(this.btnShowItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picItemPhoto);
            this.groupBox1.Controls.Add(this.btnAddItemToDGV);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtBoxesQuantity);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.txtItemID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1104, 214);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товар";
            // 
            // picItemPhoto
            // 
            this.picItemPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picItemPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItemPhoto.Location = new System.Drawing.Point(876, 28);
            this.picItemPhoto.Name = "picItemPhoto";
            this.picItemPhoto.Size = new System.Drawing.Size(213, 166);
            this.picItemPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItemPhoto.TabIndex = 2;
            this.picItemPhoto.TabStop = false;
            // 
            // btnAddItemToDGV
            // 
            this.btnAddItemToDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItemToDGV.Location = new System.Drawing.Point(605, 61);
            this.btnAddItemToDGV.Name = "btnAddItemToDGV";
            this.btnAddItemToDGV.Size = new System.Drawing.Size(156, 30);
            this.btnAddItemToDGV.TabIndex = 4;
            this.btnAddItemToDGV.Text = "Добавить";
            this.btnAddItemToDGV.UseVisualStyleBackColor = true;
            this.btnAddItemToDGV.Click += new System.EventHandler(this.btnAddItemToDGV_Click);
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(199, 98);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(239, 96);
            this.txtNote.TabIndex = 2;
            this.txtNote.TabStop = false;
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // txtBoxesQuantity
            // 
            this.txtBoxesQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxesQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxesQuantity.Location = new System.Drawing.Point(605, 131);
            this.txtBoxesQuantity.Name = "txtBoxesQuantity";
            this.txtBoxesQuantity.Size = new System.Drawing.Size(156, 27);
            this.txtBoxesQuantity.TabIndex = 2;
            this.txtBoxesQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Количество коробок :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Примечание :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(772, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Изображение :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grpUser);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1130, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 744);
            this.panel1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchItemName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.picSearchItemPhoto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboBarcode);
            this.groupBox2.Controls.Add(this.btnShowItem);
            this.groupBox2.Location = new System.Drawing.Point(6, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 420);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // txtSearchItemName
            // 
            this.txtSearchItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchItemName.Location = new System.Drawing.Point(33, 352);
            this.txtSearchItemName.Name = "txtSearchItemName";
            this.txtSearchItemName.Size = new System.Drawing.Size(185, 27);
            this.txtSearchItemName.TabIndex = 5;
            this.txtSearchItemName.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Наименование изделия :";
            // 
            // picSearchItemPhoto
            // 
            this.picSearchItemPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearchItemPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSearchItemPhoto.Location = new System.Drawing.Point(33, 153);
            this.picSearchItemPhoto.Name = "picSearchItemPhoto";
            this.picSearchItemPhoto.Size = new System.Drawing.Size(185, 166);
            this.picSearchItemPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchItemPhoto.TabIndex = 5;
            this.picSearchItemPhoto.TabStop = false;
            // 
            // grpUser
            // 
            this.grpUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpUser.Controls.Add(this.txtLoggedUser);
            this.grpUser.Controls.Add(this.label7);
            this.grpUser.Location = new System.Drawing.Point(6, 439);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(242, 132);
            this.grpUser.TabIndex = 22;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Пользователь";
            // 
            // txtLoggedUser
            // 
            this.txtLoggedUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoggedUser.Enabled = false;
            this.txtLoggedUser.Location = new System.Drawing.Point(12, 63);
            this.txtLoggedUser.Name = "txtLoggedUser";
            this.txtLoggedUser.Size = new System.Drawing.Size(219, 27);
            this.txtLoggedUser.TabIndex = 3;
            this.txtLoggedUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Операция пользователем:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dgvStockInDetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 744);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmStockInDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1390, 744);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1408, 791);
            this.Name = "frmStockInDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый приход";
            this.Load += new System.EventHandler(this.frmStockInDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchItemPhoto)).EndInit();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txtItemID;
        private DataGridView dgvStockInDetails;
        private Label label2;
        private TextBox txtQuantity;
        private Label label3;
        private TextBox txtItemName;
        private Label label4;
        private TextBox txtBarcode;
        private ComboBox cboBarcode;
        private Button btnSave;
        private Button btnCancel;
        private Label label5;
        private Button btnShowItem;
        private GroupBox groupBox1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picItemPhoto;
        private Label label6;
        private GroupBox grpUser;
        private Label label7;
        private TextBox txtLoggedUser;
        private TextBox txtBoxesQuantity;
        private Label label8;
        private Label label9;
        private TextBox txtNote;
        private Button btnAddItemToDGV;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ItemCodeWithColor;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewButtonColumn plusBtnCol;
        private DataGridViewButtonColumn minusBtnCol;
        private DataGridViewTextBoxColumn BoxesQuantity;
        private DataGridViewTextBoxColumn Category;
        private GroupBox groupBox2;
        private TextBox txtSearchItemName;
        private Label label10;
        private PictureBox picSearchItemPhoto;
    }
}