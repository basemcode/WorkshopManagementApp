
namespace WorkshopManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiProductsList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockInsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewStockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockOutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reportOfWarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAboutOneItemToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AddDataFromExcelTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatabaseOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmlFasterList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProductsList,
            this.складToolStripMenuItem,
            this.AdministrationToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tsmiProductsList
            // 
            resources.ApplyResources(this.tsmiProductsList, "tsmiProductsList");
            this.tsmiProductsList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.tsmlFasterList});
            this.tsmiProductsList.Name = "tsmiProductsList";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // складToolStripMenuItem
            // 
            resources.ApplyResources(this.складToolStripMenuItem, "складToolStripMenuItem");
            this.складToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStockInToolStripMenuItem,
            this.StockInsToolStripMenuItem,
            this.toolStripSeparator1,
            this.NewStockOutToolStripMenuItem,
            this.StockOutsToolStripMenuItem,
            this.toolStripSeparator2,
            this.reportOfWarehouseToolStripMenuItem,
            this.reportAboutOneItemToolStripMenuItem3});
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            // 
            // newStockInToolStripMenuItem
            // 
            resources.ApplyResources(this.newStockInToolStripMenuItem, "newStockInToolStripMenuItem");
            this.newStockInToolStripMenuItem.Name = "newStockInToolStripMenuItem";
            this.newStockInToolStripMenuItem.Click += new System.EventHandler(this.newStockInToolStripMenuItem_Click);
            // 
            // StockInsToolStripMenuItem
            // 
            resources.ApplyResources(this.StockInsToolStripMenuItem, "StockInsToolStripMenuItem");
            this.StockInsToolStripMenuItem.Name = "StockInsToolStripMenuItem";
            this.StockInsToolStripMenuItem.Click += new System.EventHandler(this.поставкиToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // NewStockOutToolStripMenuItem
            // 
            resources.ApplyResources(this.NewStockOutToolStripMenuItem, "NewStockOutToolStripMenuItem");
            this.NewStockOutToolStripMenuItem.Name = "NewStockOutToolStripMenuItem";
            this.NewStockOutToolStripMenuItem.Click += new System.EventHandler(this.NewStockOutToolStripMenuItem_Click);
            // 
            // StockOutsToolStripMenuItem
            // 
            resources.ApplyResources(this.StockOutsToolStripMenuItem, "StockOutsToolStripMenuItem");
            this.StockOutsToolStripMenuItem.Name = "StockOutsToolStripMenuItem";
            this.StockOutsToolStripMenuItem.Click += new System.EventHandler(this.StockOutsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // reportOfWarehouseToolStripMenuItem
            // 
            resources.ApplyResources(this.reportOfWarehouseToolStripMenuItem, "reportOfWarehouseToolStripMenuItem");
            this.reportOfWarehouseToolStripMenuItem.Name = "reportOfWarehouseToolStripMenuItem";
            this.reportOfWarehouseToolStripMenuItem.Click += new System.EventHandler(this.reportOfWarehouseToolStripMenuItem_Click);
            // 
            // reportAboutOneItemToolStripMenuItem3
            // 
            resources.ApplyResources(this.reportAboutOneItemToolStripMenuItem3, "reportAboutOneItemToolStripMenuItem3");
            this.reportAboutOneItemToolStripMenuItem3.Name = "reportAboutOneItemToolStripMenuItem3";
            this.reportAboutOneItemToolStripMenuItem3.Click += new System.EventHandler(this.reportAboutOneItemToolStripMenuItem3_Click);
            // 
            // AdministrationToolStripMenuItem
            // 
            resources.ApplyResources(this.AdministrationToolStripMenuItem, "AdministrationToolStripMenuItem");
            this.AdministrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersToolStripMenuItem,
            this.toolStripSeparator3,
            this.AddDataFromExcelTSMI,
            this.tsmiDatabaseOperations});
            this.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem";
            // 
            // UsersToolStripMenuItem
            // 
            resources.ApplyResources(this.UsersToolStripMenuItem, "UsersToolStripMenuItem");
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // AddDataFromExcelTSMI
            // 
            resources.ApplyResources(this.AddDataFromExcelTSMI, "AddDataFromExcelTSMI");
            this.AddDataFromExcelTSMI.Name = "AddDataFromExcelTSMI";
            this.AddDataFromExcelTSMI.Click += new System.EventHandler(this.AddDataFromExcelTSMI_Click);
            // 
            // tsmiDatabaseOperations
            // 
            resources.ApplyResources(this.tsmiDatabaseOperations, "tsmiDatabaseOperations");
            this.tsmiDatabaseOperations.Name = "tsmiDatabaseOperations";
            this.tsmiDatabaseOperations.Click += new System.EventHandler(this.tsmiDatabaseOperations_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // tsmlFasterList
            // 
            resources.ApplyResources(this.tsmlFasterList, "tsmlFasterList");
            this.tsmlFasterList.Name = "tsmlFasterList";
            this.tsmlFasterList.Click += new System.EventHandler(this.tsmlFasterList_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductsList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem складToolStripMenuItem;
        private ToolStripMenuItem newStockInToolStripMenuItem;
        private ToolStripMenuItem NewStockOutToolStripMenuItem;
        private ToolStripMenuItem StockInsToolStripMenuItem;
        private ToolStripMenuItem AdministrationToolStripMenuItem;
        private ToolStripMenuItem UsersToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem StockOutsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem reportOfWarehouseToolStripMenuItem;
        private ToolStripMenuItem AddDataFromExcelTSMI;
        private ToolStripMenuItem reportAboutOneItemToolStripMenuItem3;
        private ToolStripMenuItem tsmiDatabaseOperations;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsmlFasterList;
    }
}