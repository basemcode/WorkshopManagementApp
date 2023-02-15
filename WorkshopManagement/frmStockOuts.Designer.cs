namespace WorkshopManagement
{
    partial class frmStockOuts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockOuts));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateStockOut = new System.Windows.Forms.Button();
            this.btnDeleteStockOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddStockOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStockOuts = new System.Windows.Forms.DataGridView();
            this.StockOutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStockOutDetails = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCodeWithColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOutDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdateStockOut);
            this.panel2.Controls.Add(this.btnDeleteStockOut);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAddStockOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 122);
            this.panel2.TabIndex = 2;
            // 
            // btnUpdateStockOut
            // 
            this.btnUpdateStockOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateStockOut.Image = global::WorkshopManagement.Properties.Resources.icons8_update_48;
            this.btnUpdateStockOut.Location = new System.Drawing.Point(298, 12);
            this.btnUpdateStockOut.Name = "btnUpdateStockOut";
            this.btnUpdateStockOut.Size = new System.Drawing.Size(144, 97);
            this.btnUpdateStockOut.TabIndex = 5;
            this.btnUpdateStockOut.Text = "Обновить расход";
            this.btnUpdateStockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateStockOut.UseVisualStyleBackColor = true;
            this.btnUpdateStockOut.Click += new System.EventHandler(this.btnUpdateStockOut_Click);
            // 
            // btnDeleteStockOut
            // 
            this.btnDeleteStockOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteStockOut.Image = global::WorkshopManagement.Properties.Resources.icons8_cancel_48;
            this.btnDeleteStockOut.Location = new System.Drawing.Point(159, 12);
            this.btnDeleteStockOut.Name = "btnDeleteStockOut";
            this.btnDeleteStockOut.Size = new System.Drawing.Size(132, 97);
            this.btnDeleteStockOut.TabIndex = 2;
            this.btnDeleteStockOut.Text = "Удалить расход";
            this.btnDeleteStockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStockOut.UseVisualStyleBackColor = true;
            this.btnDeleteStockOut.Click += new System.EventHandler(this.btnDeleteStockOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Image = global::WorkshopManagement.Properties.Resources.icons8_door_closed_48;
            this.btnCancel.Location = new System.Drawing.Point(448, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 97);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddStockOut
            // 
            this.btnAddStockOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStockOut.Image = global::WorkshopManagement.Properties.Resources.icons8_add_48;
            this.btnAddStockOut.Location = new System.Drawing.Point(17, 12);
            this.btnAddStockOut.Name = "btnAddStockOut";
            this.btnAddStockOut.Size = new System.Drawing.Size(137, 97);
            this.btnAddStockOut.TabIndex = 1;
            this.btnAddStockOut.Text = "Добавить расход";
            this.btnAddStockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStockOut.UseVisualStyleBackColor = true;
            this.btnAddStockOut.Click += new System.EventHandler(this.btnAddStockOut_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvStockOutDetails, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 640);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStockOuts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 506);
            this.panel1.TabIndex = 1;
            // 
            // dgvStockOuts
            // 
            this.dgvStockOuts.AllowUserToAddRows = false;
            this.dgvStockOuts.AllowUserToDeleteRows = false;
            this.dgvStockOuts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvStockOuts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockOuts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockOuts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStockOuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockOuts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockOutID,
            this.Date,
            this.UserFullName,
            this.Note});
            this.dgvStockOuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockOuts.Location = new System.Drawing.Point(0, 0);
            this.dgvStockOuts.MultiSelect = false;
            this.dgvStockOuts.Name = "dgvStockOuts";
            this.dgvStockOuts.ReadOnly = true;
            this.dgvStockOuts.RowHeadersWidth = 51;
            this.dgvStockOuts.RowTemplate.Height = 29;
            this.dgvStockOuts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockOuts.Size = new System.Drawing.Size(586, 506);
            this.dgvStockOuts.TabIndex = 0;
            this.dgvStockOuts.SelectionChanged += new System.EventHandler(this.dgvStockOuts_SelectionChanged);
            // 
            // StockOutID
            // 
            this.StockOutID.DataPropertyName = "StockOutID";
            this.StockOutID.HeaderText = "ID расхода";
            this.StockOutID.MinimumWidth = 6;
            this.StockOutID.Name = "StockOutID";
            this.StockOutID.ReadOnly = true;
            this.StockOutID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.UserFullName.HeaderText = "пользователь";
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
            // dgvStockOutDetails
            // 
            this.dgvStockOutDetails.AllowUserToAddRows = false;
            this.dgvStockOutDetails.AllowUserToDeleteRows = false;
            this.dgvStockOutDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvStockOutDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockOutDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockOutDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStockOutDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockOutDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.ItemCodeWithColor,
            this.Quantity,
            this.BoxesQuantity,
            this.ProductName,
            this.Image,
            this.Category});
            this.dgvStockOutDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockOutDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStockOutDetails.Location = new System.Drawing.Point(595, 3);
            this.dgvStockOutDetails.MultiSelect = false;
            this.dgvStockOutDetails.Name = "dgvStockOutDetails";
            this.dgvStockOutDetails.ReadOnly = true;
            this.dgvStockOutDetails.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dgvStockOutDetails, 2);
            this.dgvStockOutDetails.RowTemplate.Height = 100;
            this.dgvStockOutDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockOutDetails.Size = new System.Drawing.Size(884, 634);
            this.dgvStockOutDetails.TabIndex = 0;
            this.dgvStockOutDetails.TabStop = false;
            this.dgvStockOutDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvStockOutDetails_DataError);
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
            // frmStockOuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmStockOuts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расходы";
            this.Load += new System.EventHandler(this.frmStockOuts_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOutDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button btnDeleteStockOut;
        private Button btnCancel;
        private Button btnAddStockOut;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        public DataGridView dgvStockOuts;
        private DataGridView dgvStockOutDetails;
        private DataGridViewTextBoxColumn StockOutID;
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
        private Button btnUpdateStockOut;
    }
}