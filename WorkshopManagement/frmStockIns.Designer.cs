namespace WorkshopManagement
{
    partial class frmStockIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockIns));
            this.dgvStockIns = new System.Windows.Forms.DataGridView();
            this.btnAddStockIn = new System.Windows.Forms.Button();
            this.btnDeleteStockIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvStockInDetails = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StockInID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCodeWithColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInDetails)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockIns
            // 
            this.dgvStockIns.AllowUserToAddRows = false;
            this.dgvStockIns.AllowUserToDeleteRows = false;
            this.dgvStockIns.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvStockIns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockIns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockIns.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStockIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockIns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockInID,
            this.Date,
            this.UserFullName,
            this.Note});
            this.dgvStockIns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockIns.Location = new System.Drawing.Point(0, 0);
            this.dgvStockIns.MultiSelect = false;
            this.dgvStockIns.Name = "dgvStockIns";
            this.dgvStockIns.ReadOnly = true;
            this.dgvStockIns.RowHeadersWidth = 51;
            this.dgvStockIns.RowTemplate.Height = 29;
            this.dgvStockIns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockIns.Size = new System.Drawing.Size(586, 506);
            this.dgvStockIns.TabIndex = 0;
            this.dgvStockIns.SelectionChanged += new System.EventHandler(this.dgvStockIns_SelectionChanged);
            // 
            // btnAddStockIn
            // 
            this.btnAddStockIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStockIn.Image = global::WorkshopManagement.Properties.Resources.icons8_add_48;
            this.btnAddStockIn.Location = new System.Drawing.Point(6, 16);
            this.btnAddStockIn.Name = "btnAddStockIn";
            this.btnAddStockIn.Size = new System.Drawing.Size(177, 97);
            this.btnAddStockIn.TabIndex = 1;
            this.btnAddStockIn.Text = "добавить приход";
            this.btnAddStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStockIn.UseVisualStyleBackColor = true;
            this.btnAddStockIn.Click += new System.EventHandler(this.btnAddStockIn_Click);
            // 
            // btnDeleteStockIn
            // 
            this.btnDeleteStockIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteStockIn.Image = global::WorkshopManagement.Properties.Resources.icons8_cancel_48;
            this.btnDeleteStockIn.Location = new System.Drawing.Point(188, 16);
            this.btnDeleteStockIn.Name = "btnDeleteStockIn";
            this.btnDeleteStockIn.Size = new System.Drawing.Size(177, 97);
            this.btnDeleteStockIn.TabIndex = 2;
            this.btnDeleteStockIn.Text = "Удалить приход";
            this.btnDeleteStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStockIn.UseVisualStyleBackColor = true;
            this.btnDeleteStockIn.Click += new System.EventHandler(this.btnDeleteStockIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Image = global::WorkshopManagement.Properties.Resources.icons8_door_closed_48;
            this.btnCancel.Location = new System.Drawing.Point(371, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 97);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvStockInDetails
            // 
            this.dgvStockInDetails.AllowUserToAddRows = false;
            this.dgvStockInDetails.AllowUserToDeleteRows = false;
            this.dgvStockInDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvStockInDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockInDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockInDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStockInDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockInDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.ItemCodeWithColor,
            this.Quantity,
            this.BoxesQuantity,
            this.ProductName,
            this.Image,
            this.Category});
            this.dgvStockInDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockInDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStockInDetails.Location = new System.Drawing.Point(595, 3);
            this.dgvStockInDetails.MultiSelect = false;
            this.dgvStockInDetails.Name = "dgvStockInDetails";
            this.dgvStockInDetails.ReadOnly = true;
            this.dgvStockInDetails.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dgvStockInDetails, 2);
            this.dgvStockInDetails.RowTemplate.Height = 100;
            this.dgvStockInDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockInDetails.Size = new System.Drawing.Size(884, 634);
            this.dgvStockInDetails.TabIndex = 0;
            this.dgvStockInDetails.TabStop = false;
            this.dgvStockInDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvStockInDetails_DataError);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvStockInDetails, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 640);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStockIns);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 506);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnDeleteStockIn);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAddStockIn);
            this.panel2.Location = new System.Drawing.Point(17, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 122);
            this.panel2.TabIndex = 2;
            // 
            // StockInID
            // 
            this.StockInID.DataPropertyName = "StockInID";
            this.StockInID.HeaderText = "ID прихода";
            this.StockInID.MinimumWidth = 6;
            this.StockInID.Name = "StockInID";
            this.StockInID.ReadOnly = true;
            this.StockInID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // UserFullName
            // 
            this.UserFullName.DataPropertyName = "UserFullName";
            this.UserFullName.HeaderText = "Пользователь";
            this.UserFullName.MinimumWidth = 6;
            this.UserFullName.Name = "UserFullName";
            this.UserFullName.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Дополнительно";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
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
            this.ItemCodeWithColor.HeaderText = "Артикул цвета ";
            this.ItemCodeWithColor.MinimumWidth = 6;
            this.ItemCodeWithColor.Name = "ItemCodeWithColor";
            this.ItemCodeWithColor.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Количество";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // BoxesQuantity
            // 
            this.BoxesQuantity.DataPropertyName = "BoxesQuantity";
            this.BoxesQuantity.HeaderText = "Количество коробок";
            this.BoxesQuantity.MinimumWidth = 6;
            this.BoxesQuantity.Name = "BoxesQuantity";
            this.BoxesQuantity.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Наименование изделия";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.DefaultCellStyle = dataGridViewCellStyle3;
            this.Image.HeaderText = "Изображение";
            this.Image.Image = global::WorkshopManagement.Properties.Resources.download;
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Раздел";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // frmStockIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmStockIns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приходы";
            this.Load += new System.EventHandler(this.frmStockIns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockInDetails)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAddStockIn;
        private Button btnDeleteStockIn;
        private Button btnCancel;
        private DataGridView dgvStockInDetails;
        public DataGridView dgvStockIns;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn StockInID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn UserFullName;
        private DataGridViewTextBoxColumn Note;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ItemCodeWithColor;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn BoxesQuantity;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn Category;
    }
}