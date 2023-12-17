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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            txtItemID = new TextBox();
            dgvStockInDetails = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            ItemCodeWithColor = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            plusBtnCol = new DataGridViewButtonColumn();
            minusBtnCol = new DataGridViewButtonColumn();
            BoxesQuantity = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txtQuantity = new TextBox();
            label3 = new Label();
            txtItemName = new TextBox();
            label4 = new Label();
            txtBarcode = new TextBox();
            cboBarcode = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            label5 = new Label();
            btnShowItem = new Button();
            groupBox1 = new GroupBox();
            picItemPhoto = new PictureBox();
            btnAddItemToDGV = new Button();
            txtNote = new TextBox();
            txtBoxesQuantity = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            txtSearchItemName = new TextBox();
            label10 = new Label();
            picSearchItemPhoto = new PictureBox();
            grpUser = new GroupBox();
            txtLoggedUser = new TextBox();
            label7 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAmountInWarehouse = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStockInDetails).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItemPhoto).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchItemPhoto).BeginInit();
            grpUser.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 27);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // txtItemID
            // 
            txtItemID.BorderStyle = BorderStyle.FixedSingle;
            txtItemID.Enabled = false;
            txtItemID.Location = new Point(199, 25);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(98, 27);
            txtItemID.TabIndex = 1;
            txtItemID.TabStop = false;
            // 
            // dgvStockInDetails
            // 
            dgvStockInDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvStockInDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStockInDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockInDetails.BackgroundColor = SystemColors.ButtonHighlight;
            dgvStockInDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockInDetails.Columns.AddRange(new DataGridViewColumn[] { ItemID, Barcode, ItemCodeWithColor, ProductName, Quantity, plusBtnCol, minusBtnCol, BoxesQuantity, Category });
            dgvStockInDetails.Dock = DockStyle.Fill;
            dgvStockInDetails.Location = new Point(13, 233);
            dgvStockInDetails.MultiSelect = false;
            dgvStockInDetails.Name = "dgvStockInDetails";
            dgvStockInDetails.ReadOnly = true;
            dgvStockInDetails.RowHeadersWidth = 51;
            dgvStockInDetails.RowTemplate.Height = 29;
            dgvStockInDetails.Size = new Size(1104, 498);
            dgvStockInDetails.TabIndex = 17;
            dgvStockInDetails.TabStop = false;
            dgvStockInDetails.CellClick += dgvStockInDetails_CellClick;
            dgvStockInDetails.DataError += dgvStockInDetails_DataError;
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
            // plusBtnCol
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 192);
            plusBtnCol.DefaultCellStyle = dataGridViewCellStyle2;
            plusBtnCol.HeaderText = "+";
            plusBtnCol.MinimumWidth = 6;
            plusBtnCol.Name = "plusBtnCol";
            plusBtnCol.ReadOnly = true;
            plusBtnCol.Text = "+";
            plusBtnCol.UseColumnTextForButtonValue = true;
            // 
            // minusBtnCol
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 128);
            minusBtnCol.DefaultCellStyle = dataGridViewCellStyle3;
            minusBtnCol.HeaderText = "-";
            minusBtnCol.MinimumWidth = 6;
            minusBtnCol.Name = "minusBtnCol";
            minusBtnCol.ReadOnly = true;
            minusBtnCol.Text = "-";
            minusBtnCol.UseColumnTextForButtonValue = true;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(445, 97);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 0;
            label2.Text = "Количество изделий :";
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.None;
            txtQuantity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtQuantity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(605, 97);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(156, 27);
            txtQuantity.TabIndex = 1;
            txtQuantity.KeyDown += txtQuantity_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 61);
            label3.Name = "label3";
            label3.Size = new Size(184, 20);
            label3.TabIndex = 0;
            label3.Text = "Наименование изделия :";
            // 
            // txtItemName
            // 
            txtItemName.BorderStyle = BorderStyle.FixedSingle;
            txtItemName.Location = new Point(199, 61);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(239, 27);
            txtItemName.TabIndex = 1;
            txtItemName.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(445, 27);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 0;
            label4.Text = "Баркод:";
            // 
            // txtBarcode
            // 
            txtBarcode.Anchor = AnchorStyles.None;
            txtBarcode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBarcode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBarcode.BorderStyle = BorderStyle.FixedSingle;
            txtBarcode.Location = new Point(605, 25);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(156, 27);
            txtBarcode.TabIndex = 0;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // cboBarcode
            // 
            cboBarcode.FormattingEnabled = true;
            cboBarcode.Location = new Point(33, 62);
            cboBarcode.Name = "cboBarcode";
            cboBarcode.Size = new Size(185, 28);
            cboBarcode.TabIndex = 3;
            cboBarcode.SelectedIndexChanged += cboBarcode_SelectedIndexChanged;
            cboBarcode.KeyDown += cboBarcode_KeyDown;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Image = Properties.Resources.icons8_save_32;
            btnSave.Location = new Point(39, 586);
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
            btnCancel.Location = new Point(39, 649);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 40);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 20;
            label5.Text = "Поиск продукта :";
            // 
            // btnShowItem
            // 
            btnShowItem.Location = new Point(33, 96);
            btnShowItem.Name = "btnShowItem";
            btnShowItem.Size = new Size(185, 40);
            btnShowItem.TabIndex = 4;
            btnShowItem.Text = "Использовать";
            btnShowItem.UseVisualStyleBackColor = true;
            btnShowItem.Click += btnShowItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picItemPhoto);
            groupBox1.Controls.Add(btnAddItemToDGV);
            groupBox1.Controls.Add(txtNote);
            groupBox1.Controls.Add(txtBoxesQuantity);
            groupBox1.Controls.Add(txtItemName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
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
            // picItemPhoto
            // 
            picItemPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picItemPhoto.BorderStyle = BorderStyle.FixedSingle;
            picItemPhoto.Location = new Point(876, 28);
            picItemPhoto.Name = "picItemPhoto";
            picItemPhoto.Size = new Size(213, 166);
            picItemPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picItemPhoto.TabIndex = 2;
            picItemPhoto.TabStop = false;
            // 
            // btnAddItemToDGV
            // 
            btnAddItemToDGV.Anchor = AnchorStyles.None;
            btnAddItemToDGV.Location = new Point(605, 61);
            btnAddItemToDGV.Name = "btnAddItemToDGV";
            btnAddItemToDGV.Size = new Size(156, 30);
            btnAddItemToDGV.TabIndex = 4;
            btnAddItemToDGV.Text = "Добавить";
            btnAddItemToDGV.UseVisualStyleBackColor = true;
            btnAddItemToDGV.Click += btnAddItemToDGV_Click;
            // 
            // txtNote
            // 
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.Location = new Point(199, 98);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(239, 96);
            txtNote.TabIndex = 2;
            txtNote.TabStop = false;
            txtNote.KeyDown += txtQuantity_KeyDown;
            // 
            // txtBoxesQuantity
            // 
            txtBoxesQuantity.Anchor = AnchorStyles.None;
            txtBoxesQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtBoxesQuantity.Location = new Point(605, 131);
            txtBoxesQuantity.Name = "txtBoxesQuantity";
            txtBoxesQuantity.Size = new Size(156, 27);
            txtBoxesQuantity.TabIndex = 2;
            txtBoxesQuantity.KeyDown += txtQuantity_KeyDown;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(445, 134);
            label8.Name = "label8";
            label8.Size = new Size(160, 20);
            label8.TabIndex = 0;
            label8.Text = "Количество коробок :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 97);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 0;
            label9.Text = "Примечание :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(772, 27);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 0;
            label6.Text = "Изображение :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(grpUser);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1130, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 744);
            panel1.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAmountInWarehouse);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtSearchItemName);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(picSearchItemPhoto);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cboBarcode);
            groupBox2.Controls.Add(btnShowItem);
            groupBox2.Location = new Point(6, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 459);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Поиск";
            // 
            // txtSearchItemName
            // 
            txtSearchItemName.BorderStyle = BorderStyle.FixedSingle;
            txtSearchItemName.Location = new Point(33, 352);
            txtSearchItemName.Name = "txtSearchItemName";
            txtSearchItemName.Size = new Size(185, 27);
            txtSearchItemName.TabIndex = 5;
            txtSearchItemName.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 325);
            label10.Name = "label10";
            label10.Size = new Size(184, 20);
            label10.TabIndex = 5;
            label10.Text = "Наименование изделия :";
            // 
            // picSearchItemPhoto
            // 
            picSearchItemPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picSearchItemPhoto.BorderStyle = BorderStyle.FixedSingle;
            picSearchItemPhoto.Location = new Point(33, 153);
            picSearchItemPhoto.Name = "picSearchItemPhoto";
            picSearchItemPhoto.Size = new Size(185, 166);
            picSearchItemPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picSearchItemPhoto.TabIndex = 5;
            picSearchItemPhoto.TabStop = false;
            // 
            // grpUser
            // 
            grpUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grpUser.Controls.Add(txtLoggedUser);
            grpUser.Controls.Add(label7);
            grpUser.Location = new Point(6, 478);
            grpUser.Name = "grpUser";
            grpUser.Size = new Size(242, 93);
            grpUser.TabIndex = 22;
            grpUser.TabStop = false;
            grpUser.Text = "Пользователь";
            // 
            // txtLoggedUser
            // 
            txtLoggedUser.BorderStyle = BorderStyle.FixedSingle;
            txtLoggedUser.Enabled = false;
            txtLoggedUser.Location = new Point(12, 54);
            txtLoggedUser.Name = "txtLoggedUser";
            txtLoggedUser.Size = new Size(219, 27);
            txtLoggedUser.TabIndex = 3;
            txtLoggedUser.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(11, 25);
            label7.Name = "label7";
            label7.Size = new Size(219, 23);
            label7.TabIndex = 0;
            label7.Text = "Операция пользователем:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dgvStockInDetails, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1130, 744);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAmountInWarehouse
            // 
            txtAmountInWarehouse.BorderStyle = BorderStyle.FixedSingle;
            txtAmountInWarehouse.Location = new Point(33, 416);
            txtAmountInWarehouse.Name = "txtAmountInWarehouse";
            txtAmountInWarehouse.Size = new Size(185, 27);
            txtAmountInWarehouse.TabIndex = 23;
            txtAmountInWarehouse.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 389);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 24;
            label12.Text = "На складе :";
            // 
            // frmStockInDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1390, 744);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            MinimumSize = new Size(1408, 791);
            Name = "frmStockInDetails";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новый приход";
            Load += frmStockInDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStockInDetails).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItemPhoto).EndInit();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchItemPhoto).EndInit();
            grpUser.ResumeLayout(false);
            grpUser.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox txtAmountInWarehouse;
        private Label label12;
    }
}