namespace WorkshopManagement.Forms
{
    partial class frmExcelOperations
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
            this.dgvDataFromExcel = new System.Windows.Forms.DataGridView();
            this.btnLoadDataFromExcel = new System.Windows.Forms.Button();
            this.cmbSheetName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataFromExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataFromExcel
            // 
            this.dgvDataFromExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataFromExcel.Location = new System.Drawing.Point(12, 12);
            this.dgvDataFromExcel.Name = "dgvDataFromExcel";
            this.dgvDataFromExcel.RowHeadersWidth = 51;
            this.dgvDataFromExcel.RowTemplate.Height = 29;
            this.dgvDataFromExcel.Size = new System.Drawing.Size(1428, 648);
            this.dgvDataFromExcel.TabIndex = 0;
            // 
            // btnLoadDataFromExcel
            // 
            this.btnLoadDataFromExcel.Location = new System.Drawing.Point(12, 666);
            this.btnLoadDataFromExcel.Name = "btnLoadDataFromExcel";
            this.btnLoadDataFromExcel.Size = new System.Drawing.Size(94, 29);
            this.btnLoadDataFromExcel.TabIndex = 1;
            this.btnLoadDataFromExcel.Text = "Load";
            this.btnLoadDataFromExcel.UseVisualStyleBackColor = true;
            this.btnLoadDataFromExcel.Click += new System.EventHandler(this.btnLoadDataFromExcel_Click);
            // 
            // cmbSheetName
            // 
            this.cmbSheetName.FormattingEnabled = true;
            this.cmbSheetName.Items.AddRange(new object[] {
            "Сводная"});
            this.cmbSheetName.Location = new System.Drawing.Point(111, 670);
            this.cmbSheetName.Name = "cmbSheetName";
            this.cmbSheetName.Size = new System.Drawing.Size(151, 28);
            this.cmbSheetName.TabIndex = 2;
            this.cmbSheetName.Text = "sheet1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(265, 669);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmExcelOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 707);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSheetName);
            this.Controls.Add(this.btnLoadDataFromExcel);
            this.Controls.Add(this.dgvDataFromExcel);
            this.Name = "frmExcelOperations";
            this.Text = "frmExcelOperations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataFromExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDataFromExcel;
        private Button btnLoadDataFromExcel;
        private ComboBox cmbSheetName;
        private Button btnSave;
    }
}