namespace WorkshopManagement
{
    partial class frmStockOutDetails
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvStockOutDetails = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            ItemCodeWithColor = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            BoxesQuantity = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnAddItemToDGV = new Button();
            txtNote = new TextBox();
            picItemPhoto = new PictureBox();
            label9 = new Label();
            txtBoxesQuantity = new TextBox();
            txtItemName = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtQuantity = new TextBox();
            label1 = new Label();
            txtBarcode = new TextBox();
            txtItemID = new TextBox();
            label2 = new Label();
            txtLoggedUser = new TextBox();
            grpUser = new GroupBox();
            label7 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            txtSearchItemName = new TextBox();
            label11 = new Label();
            picSearchItemPhoto = new PictureBox();
            label5 = new Label();
            cboBarcode = new ComboBox();
            btnShowItem = new Button();
            txtSumOfAllProducts = new TextBox();
            label10 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label12 = new Label();
            txtAmountInWarehouse = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockOutDetails).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItemPhoto).BeginInit();
            grpUser.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchItemPhoto).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dgvStockOutDetails, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1126, 784);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // dgvStockOutDetails
            // 
            dgvStockOutDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvStockOutDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStockOutDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockOutDetails.BackgroundColor = SystemColors.ButtonHighlight;
            dgvStockOutDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockOutDetails.Columns.AddRange(new DataGridViewColumn[] { ItemID, Barcode, ItemCodeWithColor, ProductName, Quantity, BoxesQuantity, Category });
            dgvStockOutDetails.Dock = DockStyle.Fill;
            dgvStockOutDetails.Location = new Point(13, 233);
            dgvStockOutDetails.MultiSelect = false;
            dgvStockOutDetails.Name = "dgvStockOutDetails";
            dgvStockOutDetails.ReadOnly = true;
            dgvStockOutDetails.RowHeadersWidth = 51;
            dgvStockOutDetails.RowTemplate.Height = 29;
            dgvStockOutDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockOutDetails.Size = new Size(1104, 538);
            dgvStockOutDetails.TabIndex = 29;
            dgvStockOutDetails.TabStop = false;
            // 
            // ItemID
            // 
            ItemID.DataPropertyName = "ItemID";
            ItemID.HeaderText = "ID товара";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            ItemID.ReadOnly = true;
            // 
            // Barcode
            // 
            Barcode.DataPropertyName = "Barcode";
            Barcode.HeaderText = "Баркод";
            Barcode.MinimumWidth = 6;
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            // 
            // ItemCodeWithColor
            // 
            ItemCodeWithColor.DataPropertyName = "ItemCodeWithColor";
            ItemCodeWithColor.HeaderText = "Артикул цвета";
            ItemCodeWithColor.MinimumWidth = 6;
            ItemCodeWithColor.Name = "ItemCodeWithColor";
            ItemCodeWithColor.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Наименование изделия";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Количество";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // BoxesQuantity
            // 
            BoxesQuantity.DataPropertyName = "BoxesQuantity";
            BoxesQuantity.HeaderText = "Количество коробок";
            BoxesQuantity.MinimumWidth = 6;
            BoxesQuantity.Name = "BoxesQuantity";
            BoxesQuantity.ReadOnly = true;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Раздел";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddItemToDGV);
            groupBox1.Controls.Add(txtNote);
            groupBox1.Controls.Add(picItemPhoto);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBoxesQuantity);
            groupBox1.Controls.Add(txtItemName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Controls.Add(txtItemID);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1104, 214);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Товар";
            // 
            // btnAddItemToDGV
            // 
            btnAddItemToDGV.Anchor = AnchorStyles.None;
            btnAddItemToDGV.Location = new Point(603, 63);
            btnAddItemToDGV.Name = "btnAddItemToDGV";
            btnAddItemToDGV.Size = new Size(156, 30);
            btnAddItemToDGV.TabIndex = 28;
            btnAddItemToDGV.Text = "Добавить";
            btnAddItemToDGV.UseVisualStyleBackColor = true;
            btnAddItemToDGV.Click += btnAddItemToDGV_Click;
            // 
            // txtNote
            // 
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.Location = new Point(195, 104);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(230, 96);
            txtNote.TabIndex = 27;
            txtNote.TabStop = false;
            // 
            // picItemPhoto
            // 
            picItemPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picItemPhoto.BorderStyle = BorderStyle.FixedSingle;
            picItemPhoto.Location = new Point(869, 27);
            picItemPhoto.Name = "picItemPhoto";
            picItemPhoto.Size = new Size(213, 166);
            picItemPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picItemPhoto.TabIndex = 2;
            picItemPhoto.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 103);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 26;
            label9.Text = "Примечание :";
            // 
            // txtBoxesQuantity
            // 
            txtBoxesQuantity.Anchor = AnchorStyles.None;
            txtBoxesQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtBoxesQuantity.Location = new Point(603, 139);
            txtBoxesQuantity.Name = "txtBoxesQuantity";
            txtBoxesQuantity.Size = new Size(156, 27);
            txtBoxesQuantity.TabIndex = 2;
            txtBoxesQuantity.KeyDown += txtQuantity_txtBoxesQuantity_KeyDown;
            // 
            // txtItemName
            // 
            txtItemName.BorderStyle = BorderStyle.FixedSingle;
            txtItemName.Location = new Point(195, 63);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(230, 27);
            txtItemName.TabIndex = 1;
            txtItemName.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(443, 142);
            label8.Name = "label8";
            label8.Size = new Size(160, 20);
            label8.TabIndex = 0;
            label8.Text = "Количество коробок :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 66);
            label3.Name = "label3";
            label3.Size = new Size(184, 20);
            label3.TabIndex = 0;
            label3.Text = "Наименование изделия :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(766, 27);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 0;
            label6.Text = "изображение :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(443, 27);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 0;
            label4.Text = "Баркод :";
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.None;
            txtQuantity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtQuantity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(603, 101);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(156, 27);
            txtQuantity.TabIndex = 1;
            txtQuantity.KeyDown += txtQuantity_txtBoxesQuantity_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 27);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = " ID :";
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.None;
            txtBarcode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBarcode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBarcode.BorderStyle = BorderStyle.FixedSingle;
            txtBarcode.Location = new Point(603, 25);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(156, 27);
            txtBarcode.TabIndex = 0;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // txtItemID
            // 
            txtItemID.BorderStyle = BorderStyle.FixedSingle;
            txtItemID.Enabled = false;
            txtItemID.Location = new Point(195, 25);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(145, 27);
            txtItemID.TabIndex = 1;
            txtItemID.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(443, 103);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 0;
            label2.Text = "Количество изделий :";
            // 
            // txtLoggedUser
            // 
            txtLoggedUser.BorderStyle = BorderStyle.FixedSingle;
            txtLoggedUser.Enabled = false;
            txtLoggedUser.Location = new Point(12, 63);
            txtLoggedUser.Name = "txtLoggedUser";
            txtLoggedUser.Size = new Size(219, 27);
            txtLoggedUser.TabIndex = 3;
            txtLoggedUser.TextAlign = HorizontalAlignment.Center;
            // 
            // grpUser
            // 
            grpUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grpUser.Controls.Add(txtLoggedUser);
            grpUser.Controls.Add(label7);
            grpUser.Location = new Point(6, 465);
            grpUser.Name = "grpUser";
            grpUser.Size = new Size(242, 107);
            grpUser.TabIndex = 22;
            grpUser.TabStop = false;
            grpUser.Text = "Пользователь";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(11, 34);
            label7.Name = "label7";
            label7.Size = new Size(219, 23);
            label7.TabIndex = 0;
            label7.Text = "Операция пользователем:";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(txtSumOfAllProducts);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(grpUser);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1126, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 784);
            panel1.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAmountInWarehouse);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtSearchItemName);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(picSearchItemPhoto);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboBarcode);
            groupBox2.Controls.Add(btnShowItem);
            groupBox2.Location = new Point(6, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 446);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск";
            // 
            // txtSearchItemName
            // 
            txtSearchItemName.BorderStyle = BorderStyle.FixedSingle;
            txtSearchItemName.Location = new Point(33, 344);
            txtSearchItemName.Name = "txtSearchItemName";
            txtSearchItemName.Size = new Size(185, 27);
            txtSearchItemName.TabIndex = 21;
            txtSearchItemName.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 317);
            label11.Name = "label11";
            label11.Size = new Size(184, 20);
            label11.TabIndex = 22;
            label11.Text = "Наименование изделия :";
            // 
            // picSearchItemPhoto
            // 
            picSearchItemPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSearchItemPhoto.BorderStyle = BorderStyle.FixedSingle;
            picSearchItemPhoto.Location = new Point(33, 145);
            picSearchItemPhoto.Name = "picSearchItemPhoto";
            picSearchItemPhoto.Size = new Size(185, 166);
            picSearchItemPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picSearchItemPhoto.TabIndex = 23;
            picSearchItemPhoto.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 38);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 20;
            label5.Text = "Поиск продукта :";
            // 
            // cboBarcode
            // 
            cboBarcode.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboBarcode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboBarcode.FormattingEnabled = true;
            cboBarcode.Location = new Point(33, 60);
            cboBarcode.Name = "cboBarcode";
            cboBarcode.Size = new Size(185, 28);
            cboBarcode.TabIndex = 3;
            cboBarcode.SelectedIndexChanged += cboBarcode_SelectedIndexChanged;
            cboBarcode.KeyDown += cboBarcode_KeyDown;
            // 
            // btnShowItem
            // 
            btnShowItem.Location = new Point(33, 94);
            btnShowItem.Name = "btnShowItem";
            btnShowItem.Size = new Size(185, 40);
            btnShowItem.TabIndex = 4;
            btnShowItem.Text = "Использовать";
            btnShowItem.UseVisualStyleBackColor = true;
            btnShowItem.Click += btnShowItem_Click;
            // 
            // txtSumOfAllProducts
            // 
            txtSumOfAllProducts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtSumOfAllProducts.Location = new Point(18, 605);
            txtSumOfAllProducts.Name = "txtSumOfAllProducts";
            txtSumOfAllProducts.Size = new Size(219, 27);
            txtSumOfAllProducts.TabIndex = 23;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(16, 575);
            label10.Name = "label10";
            label10.Size = new Size(191, 23);
            label10.TabIndex = 0;
            label10.Text = "Cумма всех продуктов:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Image = Properties.Resources.icons8_save_32;
            btnSave.Location = new Point(39, 641);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(184, 55);
            btnSave.TabIndex = 16;
            btnSave.TabStop = false;
            btnSave.Text = "Сохранить";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Image = Properties.Resources.icons8_unavailable_32;
            btnCancel.Location = new Point(39, 704);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(184, 55);
            btnCancel.TabIndex = 16;
            btnCancel.TabStop = false;
            btnCancel.Text = "Отмена";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 377);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 22;
            label12.Text = "На складе :";
            // 
            // txtAmountInWarehouse
            // 
            txtAmountInWarehouse.BorderStyle = BorderStyle.FixedSingle;
            txtAmountInWarehouse.Location = new Point(32, 404);
            txtAmountInWarehouse.Name = "txtAmountInWarehouse";
            txtAmountInWarehouse.Size = new Size(185, 27);
            txtAmountInWarehouse.TabIndex = 21;
            txtAmountInWarehouse.TabStop = false;
            // 
            // frmStockOutDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1386, 784);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            MinimumSize = new Size(1404, 794);
            Name = "frmStockOutDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новый расход";
            Load += frmStockOutDetails_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockOutDetails).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItemPhoto).EndInit();
            grpUser.ResumeLayout(false);
            grpUser.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchItemPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private PictureBox picItemPhoto;
        private TextBox txtBoxesQuantity;
        private TextBox txtItemName;
        private Label label8;
        private Label label3;
        private Label label6;
        private Label label4;
        private TextBox txtQuantity;
        private Label label1;
        private TextBox txtBarcode;
        private TextBox txtItemID;
        private Label label2;
        private TextBox txtLoggedUser;
        private GroupBox grpUser;
        private Label label7;
        private Panel panel1;
        private Button btnShowItem;
        private Button btnSave;
        private Button btnCancel;
        private Label label5;
        private ComboBox cboBarcode;
        private TextBox txtNote;
        private Label label9;
        private TextBox txtSumOfAllProducts;
        private Label label10;
        private GroupBox groupBox2;
        private TextBox txtSearchItemName;
        private Label label11;
        private PictureBox picSearchItemPhoto;
        private Button btnAddItemToDGV;
        private DataGridView dgvStockOutDetails;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ItemCodeWithColor;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewButtonColumn plusBtnCol;
        private DataGridViewButtonColumn minusBtnCol;
        private DataGridViewTextBoxColumn BoxesQuantity;
        private DataGridViewTextBoxColumn Category;
        private TextBox txtAmountInWarehouse;
        private Label label12;
    }
}