namespace WorkshopManagement.Forms
{
    partial class frmAddItemsDataFromExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.dgvExcelDataToAdd = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCodeWithColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemNumberOnWB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InternalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HardboardBoxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GofferNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToDataBase = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAddToDatabase = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelDataToAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(1148, 66);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(140, 95);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "open file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // dgvExcelDataToAdd
            // 
            this.dgvExcelDataToAdd.AllowUserToAddRows = false;
            this.dgvExcelDataToAdd.AllowUserToDeleteRows = false;
            this.dgvExcelDataToAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExcelDataToAdd.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExcelDataToAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcelDataToAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemCodeWithColor,
            this.Barcode,
            this.ItemImage,
            this.ItemNumberOnWB,
            this.InternalCode,
            this.ProductName,
            this.Color,
            this.HardboardBoxNumber,
            this.Unit,
            this.GofferNumber,
            this.Category,
            this.MinimumQuantity,
            this.Note});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcelDataToAdd.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExcelDataToAdd.Location = new System.Drawing.Point(8, 12);
            this.dgvExcelDataToAdd.MultiSelect = false;
            this.dgvExcelDataToAdd.Name = "dgvExcelDataToAdd";
            this.dgvExcelDataToAdd.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcelDataToAdd.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExcelDataToAdd.RowTemplate.Height = 150;
            this.dgvExcelDataToAdd.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcelDataToAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcelDataToAdd.Size = new System.Drawing.Size(1097, 395);
            this.dgvExcelDataToAdd.TabIndex = 2;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemCode.DataPropertyName = "Артикул";
            this.ItemCode.FillWeight = 7F;
            this.ItemCode.HeaderText = "Артикул";
            this.ItemCode.MinimumWidth = 20;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 94;
            // 
            // ItemCodeWithColor
            // 
            this.ItemCodeWithColor.DataPropertyName = "Артикул цвета";
            this.ItemCodeWithColor.FillWeight = 7F;
            this.ItemCodeWithColor.HeaderText = "Артикул цвета ";
            this.ItemCodeWithColor.MinimumWidth = 6;
            this.ItemCodeWithColor.Name = "ItemCodeWithColor";
            this.ItemCodeWithColor.Width = 129;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Баркод";
            this.Barcode.FillWeight = 7F;
            this.Barcode.HeaderText = "Баркод";
            this.Barcode.MinimumWidth = 20;
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 88;
            // 
            // ItemImage
            // 
            this.ItemImage.DataPropertyName = "Картинки";
            this.ItemImage.FillWeight = 7F;
            this.ItemImage.HeaderText = "Изображение";
            this.ItemImage.Image = global::WorkshopManagement.Properties.Resources.download;
            this.ItemImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ItemImage.MinimumWidth = 20;
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Width = 113;
            // 
            // ItemNumberOnWB
            // 
            this.ItemNumberOnWB.DataPropertyName = "Артикул WB";
            this.ItemNumberOnWB.FillWeight = 7F;
            this.ItemNumberOnWB.HeaderText = "Артикул WB";
            this.ItemNumberOnWB.MinimumWidth = 20;
            this.ItemNumberOnWB.Name = "ItemNumberOnWB";
            this.ItemNumberOnWB.Width = 111;
            // 
            // InternalCode
            // 
            this.InternalCode.DataPropertyName = "Внутренний код ";
            this.InternalCode.FillWeight = 7F;
            this.InternalCode.HeaderText = "Внутренний код ";
            this.InternalCode.MinimumWidth = 20;
            this.InternalCode.Name = "InternalCode";
            this.InternalCode.Width = 141;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Наименование изделия";
            this.ProductName.FillWeight = 7F;
            this.ProductName.HeaderText = "Наименование изделия";
            this.ProductName.MinimumWidth = 20;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 188;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "ЦВЕТ";
            this.Color.FillWeight = 7F;
            this.Color.HeaderText = "Цвет ";
            this.Color.MinimumWidth = 20;
            this.Color.Name = "Color";
            this.Color.Width = 75;
            // 
            // HardboardBoxNumber
            // 
            this.HardboardBoxNumber.DataPropertyName = "ОРГАЛИТ           № коробки";
            this.HardboardBoxNumber.FillWeight = 7F;
            this.HardboardBoxNumber.HeaderText = "Оргалит № коробки";
            this.HardboardBoxNumber.MinimumWidth = 20;
            this.HardboardBoxNumber.Name = "HardboardBoxNumber";
            this.HardboardBoxNumber.Width = 164;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.FillWeight = 7F;
            this.Unit.HeaderText = "Единица измерения";
            this.Unit.MinimumWidth = 20;
            this.Unit.Name = "Unit";
            this.Unit.Width = 164;
            // 
            // GofferNumber
            // 
            this.GofferNumber.DataPropertyName = "ГОФРА, №";
            this.GofferNumber.FillWeight = 7F;
            this.GofferNumber.HeaderText = "Гофра №";
            this.GofferNumber.MinimumWidth = 20;
            this.GofferNumber.Name = "GofferNumber";
            this.GofferNumber.Width = 94;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.FillWeight = 7F;
            this.Category.HeaderText = "Раздел";
            this.Category.MinimumWidth = 20;
            this.Category.Name = "Category";
            this.Category.Visible = false;
            this.Category.Width = 85;
            // 
            // MinimumQuantity
            // 
            this.MinimumQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinimumQuantity.DataPropertyName = "Нормативные запасы";
            this.MinimumQuantity.FillWeight = 2F;
            this.MinimumQuantity.HeaderText = "Нормативные запасы";
            this.MinimumQuantity.MinimumWidth = 20;
            this.MinimumQuantity.Name = "MinimumQuantity";
            this.MinimumQuantity.ReadOnly = true;
            this.MinimumQuantity.Width = 174;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.FillWeight = 7F;
            this.Note.HeaderText = "Дополнительно";
            this.Note.MinimumWidth = 20;
            this.Note.Name = "Note";
            this.Note.Width = 149;
            // 
            // btnAddToDataBase
            // 
            this.btnAddToDataBase.Location = new System.Drawing.Point(1148, 167);
            this.btnAddToDataBase.Name = "btnAddToDataBase";
            this.btnAddToDataBase.Size = new System.Drawing.Size(140, 95);
            this.btnAddToDataBase.TabIndex = 0;
            this.btnAddToDataBase.Text = "Add to database";
            this.btnAddToDataBase.UseVisualStyleBackColor = true;
            this.btnAddToDataBase.Click += new System.EventHandler(this.btnAddToDataBase_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Сводная",
            "НГ23",
            "Свадебная",
            "Буквы ",
            "Нова",
            "Прочее",
            "А"});
            this.cbCategory.Location = new System.Drawing.Point(1148, 23);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(151, 28);
            this.cbCategory.TabIndex = 3;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ProductNameCol,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.Location = new System.Drawing.Point(8, 435);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.RowTemplate.Height = 150;
            this.dgvResults.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(1097, 354);
            this.dgvResults.TabIndex = 4;
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.FillWeight = 2F;
            this.ItemID.HeaderText = "ID";
            this.ItemID.MinimumWidth = 20;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn1.FillWeight = 7F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 94;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemCodeWithColor";
            this.dataGridViewTextBoxColumn2.FillWeight = 7F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Артикул цвета ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 129;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn3.FillWeight = 7F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Баркод";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.FillWeight = 7F;
            this.dataGridViewImageColumn1.HeaderText = "Изображение";
            this.dataGridViewImageColumn1.Image = global::WorkshopManagement.Properties.Resources.download;
            this.dataGridViewImageColumn1.MinimumWidth = 20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 113;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ItemNumberOnWB";
            this.dataGridViewTextBoxColumn4.FillWeight = 7F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Артикул WB";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 111;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "InternalCode";
            this.dataGridViewTextBoxColumn5.FillWeight = 7F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Внутренний код ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 141;
            // 
            // ProductNameCol
            // 
            this.ProductNameCol.DataPropertyName = "ProductName";
            this.ProductNameCol.FillWeight = 7F;
            this.ProductNameCol.HeaderText = "Наименование изделия";
            this.ProductNameCol.MinimumWidth = 20;
            this.ProductNameCol.Name = "ProductNameCol";
            this.ProductNameCol.Width = 188;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn6.FillWeight = 7F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Цвет ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HardboardBoxNumber";
            this.dataGridViewTextBoxColumn7.FillWeight = 7F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Оргалит № коробки";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 164;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn8.FillWeight = 7F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Единица измерения";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 164;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "GofferNumber";
            this.dataGridViewTextBoxColumn9.FillWeight = 7F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Гофра №";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 94;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn10.FillWeight = 7F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Раздел";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 85;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn11.FillWeight = 7F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Дополнительно";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 149;
            // 
            // chkAddToDatabase
            // 
            this.chkAddToDatabase.AutoSize = true;
            this.chkAddToDatabase.Location = new System.Drawing.Point(1148, 268);
            this.chkAddToDatabase.Name = "chkAddToDatabase";
            this.chkAddToDatabase.Size = new System.Drawing.Size(142, 24);
            this.chkAddToDatabase.TabIndex = 5;
            this.chkAddToDatabase.Text = "Add to database";
            this.chkAddToDatabase.UseVisualStyleBackColor = true;
            // 
            // frmAddItemsDataFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 801);
            this.Controls.Add(this.chkAddToDatabase);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.dgvExcelDataToAdd);
            this.Controls.Add(this.btnAddToDataBase);
            this.Controls.Add(this.btnChooseFile);
            this.Name = "frmAddItemsDataFromExcel";
            this.Text = "frmAddItemsDataFromExcel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelDataToAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChooseFile;
        private DataGridView dgvExcelDataToAdd;
        private Button btnAddToDataBase;
        private ComboBox cbCategory;
        
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn ProductNameCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private CheckBox chkAddToDatabase;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewTextBoxColumn ItemCodeWithColor;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewImageColumn ItemImage;
        private DataGridViewTextBoxColumn ItemNumberOnWB;
        private DataGridViewTextBoxColumn InternalCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn HardboardBoxNumber;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn GofferNumber;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn MinimumQuantity;
        private DataGridViewTextBoxColumn Note;
    }
}