namespace WorkshopManagement.Forms
{
    partial class frmDatabaseOperations
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
            this.dgvExcelDataToAdd = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRowsNum = new System.Windows.Forms.TextBox();
            this.cboPeriodID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelDataToAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExcelDataToAdd
            // 
            this.dgvExcelDataToAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExcelDataToAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcelDataToAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.QuantityInStock});
            this.dgvExcelDataToAdd.Location = new System.Drawing.Point(38, 33);
            this.dgvExcelDataToAdd.Name = "dgvExcelDataToAdd";
            this.dgvExcelDataToAdd.RowHeadersWidth = 51;
            this.dgvExcelDataToAdd.RowTemplate.Height = 29;
            this.dgvExcelDataToAdd.Size = new System.Drawing.Size(298, 667);
            this.dgvExcelDataToAdd.TabIndex = 0;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Баркод";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 88;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "Quantity";
            this.QuantityInStock.HeaderText = "кол-во издел.";
            this.QuantityInStock.MinimumWidth = 6;
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.Width = 132;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(1029, 33);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(140, 95);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "open file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1029, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRowsNum
            // 
            this.txtRowsNum.Location = new System.Drawing.Point(1029, 134);
            this.txtRowsNum.Name = "txtRowsNum";
            this.txtRowsNum.Size = new System.Drawing.Size(140, 27);
            this.txtRowsNum.TabIndex = 3;
            // 
            // cboPeriodID
            // 
            this.cboPeriodID.FormattingEnabled = true;
            this.cboPeriodID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboPeriodID.Location = new System.Drawing.Point(872, 33);
            this.cboPeriodID.Name = "cboPeriodID";
            this.cboPeriodID.Size = new System.Drawing.Size(151, 28);
            this.cboPeriodID.TabIndex = 4;
            this.cboPeriodID.Text = "1";
            // 
            // frmDatabaseOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 732);
            this.Controls.Add(this.cboPeriodID);
            this.Controls.Add(this.txtRowsNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.dgvExcelDataToAdd);
            this.Name = "frmDatabaseOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatabaseOperations";
            this.Load += new System.EventHandler(this.frmDatabaseOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelDataToAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvExcelDataToAdd;
        private Button btnChooseFile;
        private Button button1;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn QuantityInStock;
        private TextBox txtRowsNum;
        private ComboBox cboPeriodID;
    }
}