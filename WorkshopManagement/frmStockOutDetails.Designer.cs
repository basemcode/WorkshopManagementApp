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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvStockOutDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.picItemPhoto = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxesQuantity = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoggedUser = new System.Windows.Forms.TextBox();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSumOfAllProducts = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShowItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBarcode = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOutDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPhoto)).BeginInit();
            this.grpUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dgvStockOutDetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1126, 747);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // dgvStockOutDetails
            // 
            this.dgvStockOutDetails.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStockOutDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStockOutDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockOutDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStockOutDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockOutDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockOutDetails.Location = new System.Drawing.Point(13, 233);
            this.dgvStockOutDetails.MultiSelect = false;
            this.dgvStockOutDetails.Name = "dgvStockOutDetails";
            this.dgvStockOutDetails.RowHeadersWidth = 51;
            this.dgvStockOutDetails.RowTemplate.Height = 29;
            this.dgvStockOutDetails.Size = new System.Drawing.Size(1104, 501);
            this.dgvStockOutDetails.TabIndex = 17;
            this.dgvStockOutDetails.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.picItemPhoto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBoxesQuantity);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label8);
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
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(195, 104);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(230, 96);
            this.txtNote.TabIndex = 27;
            this.txtNote.TabStop = false;
            // 
            // picItemPhoto
            // 
            this.picItemPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picItemPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItemPhoto.Location = new System.Drawing.Point(869, 27);
            this.picItemPhoto.Name = "picItemPhoto";
            this.picItemPhoto.Size = new System.Drawing.Size(213, 166);
            this.picItemPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItemPhoto.TabIndex = 2;
            this.picItemPhoto.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Примечание :";
            // 
            // txtBoxesQuantity
            // 
            this.txtBoxesQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxesQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxesQuantity.Location = new System.Drawing.Point(603, 101);
            this.txtBoxesQuantity.Name = "txtBoxesQuantity";
            this.txtBoxesQuantity.Size = new System.Drawing.Size(156, 27);
            this.txtBoxesQuantity.TabIndex = 2;
            this.txtBoxesQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_txtBoxesQuantity_KeyDown);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(195, 63);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(230, 27);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Количество коробок :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Наименование изделия :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "изображение :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Баркод :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(603, 63);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(156, 27);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_txtBoxesQuantity_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " ID :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Location = new System.Drawing.Point(603, 25);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(156, 27);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // txtItemID
            // 
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(195, 25);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(145, 27);
            this.txtItemID.TabIndex = 1;
            this.txtItemID.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Колечество :";
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
            // grpUser
            // 
            this.grpUser.Controls.Add(this.txtLoggedUser);
            this.grpUser.Controls.Add(this.label7);
            this.grpUser.Location = new System.Drawing.Point(6, 291);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(242, 133);
            this.grpUser.TabIndex = 22;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Пользователь";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSumOfAllProducts);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.grpUser);
            this.panel1.Controls.Add(this.btnShowItem);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboBarcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1126, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 747);
            this.panel1.TabIndex = 25;
            // 
            // txtSumOfAllProducts
            // 
            this.txtSumOfAllProducts.Location = new System.Drawing.Point(18, 464);
            this.txtSumOfAllProducts.Name = "txtSumOfAllProducts";
            this.txtSumOfAllProducts.Size = new System.Drawing.Size(219, 27);
            this.txtSumOfAllProducts.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cумма всех продуктов:";
            // 
            // btnShowItem
            // 
            this.btnShowItem.Location = new System.Drawing.Point(39, 91);
            this.btnShowItem.Name = "btnShowItem";
            this.btnShowItem.Size = new System.Drawing.Size(185, 40);
            this.btnShowItem.TabIndex = 4;
            this.btnShowItem.Text = "Использовать";
            this.btnShowItem.UseVisualStyleBackColor = true;
            this.btnShowItem.Click += new System.EventHandler(this.btnShowItem_Click);
            // 
            // btnSave
            // 
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
            this.label5.Location = new System.Drawing.Point(39, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Поиск продукта :";
            // 
            // cboBarcode
            // 
            this.cboBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBarcode.FormattingEnabled = true;
            this.cboBarcode.Location = new System.Drawing.Point(39, 57);
            this.cboBarcode.Name = "cboBarcode";
            this.cboBarcode.Size = new System.Drawing.Size(185, 28);
            this.cboBarcode.TabIndex = 3;
            this.cboBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboBarcode_KeyDown);
            // 
            // frmStockOutDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1386, 747);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1404, 794);
            this.Name = "frmStockOutDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый расход";
            this.Load += new System.EventHandler(this.frmStockOutDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOutDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPhoto)).EndInit();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvStockOutDetails;
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
    }
}