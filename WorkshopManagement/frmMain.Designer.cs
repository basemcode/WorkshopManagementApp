
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
            menuStrip1 = new MenuStrip();
            tsmiProductsList = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            складToolStripMenuItem = new ToolStripMenuItem();
            newStockInToolStripMenuItem = new ToolStripMenuItem();
            StockInsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            NewStockOutToolStripMenuItem = new ToolStripMenuItem();
            StockOutsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            reportOfWarehouseToolStripMenuItem = new ToolStripMenuItem();
            reportAboutOneItemToolStripMenuItem3 = new ToolStripMenuItem();
            AdministrationToolStripMenuItem = new ToolStripMenuItem();
            UsersToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            AddDataFromExcelTSMI = new ToolStripMenuItem();
            tsmiDatabaseOperations = new ToolStripMenuItem();
            tsmiTestingData = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiProductsList, складToolStripMenuItem, AdministrationToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // tsmiProductsList
            // 
            resources.ApplyResources(tsmiProductsList, "tsmiProductsList");
            tsmiProductsList.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            tsmiProductsList.Name = "tsmiProductsList";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(toolStripMenuItem2, "toolStripMenuItem2");
            toolStripMenuItem2.Image = Properties.Resources.icons8_list_of_thumbnails_32;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // складToolStripMenuItem
            // 
            resources.ApplyResources(складToolStripMenuItem, "складToolStripMenuItem");
            складToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newStockInToolStripMenuItem, StockInsToolStripMenuItem, toolStripSeparator1, NewStockOutToolStripMenuItem, StockOutsToolStripMenuItem, toolStripSeparator2, reportOfWarehouseToolStripMenuItem, reportAboutOneItemToolStripMenuItem3 });
            складToolStripMenuItem.Name = "складToolStripMenuItem";
            // 
            // newStockInToolStripMenuItem
            // 
            resources.ApplyResources(newStockInToolStripMenuItem, "newStockInToolStripMenuItem");
            newStockInToolStripMenuItem.Image = Properties.Resources.icons8_Sign_In_32;
            newStockInToolStripMenuItem.Name = "newStockInToolStripMenuItem";
            newStockInToolStripMenuItem.Click += newStockInToolStripMenuItem_Click;
            // 
            // StockInsToolStripMenuItem
            // 
            resources.ApplyResources(StockInsToolStripMenuItem, "StockInsToolStripMenuItem");
            StockInsToolStripMenuItem.Name = "StockInsToolStripMenuItem";
            StockInsToolStripMenuItem.Click += поставкиToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // NewStockOutToolStripMenuItem
            // 
            resources.ApplyResources(NewStockOutToolStripMenuItem, "NewStockOutToolStripMenuItem");
            NewStockOutToolStripMenuItem.Name = "NewStockOutToolStripMenuItem";
            NewStockOutToolStripMenuItem.Click += NewStockOutToolStripMenuItem_Click;
            // 
            // StockOutsToolStripMenuItem
            // 
            resources.ApplyResources(StockOutsToolStripMenuItem, "StockOutsToolStripMenuItem");
            StockOutsToolStripMenuItem.Name = "StockOutsToolStripMenuItem";
            StockOutsToolStripMenuItem.Click += StockOutsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // reportOfWarehouseToolStripMenuItem
            // 
            resources.ApplyResources(reportOfWarehouseToolStripMenuItem, "reportOfWarehouseToolStripMenuItem");
            reportOfWarehouseToolStripMenuItem.Image = Properties.Resources.icons8_bar_chart_32;
            reportOfWarehouseToolStripMenuItem.Name = "reportOfWarehouseToolStripMenuItem";
            reportOfWarehouseToolStripMenuItem.Click += reportOfWarehouseToolStripMenuItem_Click;
            // 
            // reportAboutOneItemToolStripMenuItem3
            // 
            resources.ApplyResources(reportAboutOneItemToolStripMenuItem3, "reportAboutOneItemToolStripMenuItem3");
            reportAboutOneItemToolStripMenuItem3.Name = "reportAboutOneItemToolStripMenuItem3";
            reportAboutOneItemToolStripMenuItem3.Click += reportAboutOneItemToolStripMenuItem3_Click;
            // 
            // AdministrationToolStripMenuItem
            // 
            resources.ApplyResources(AdministrationToolStripMenuItem, "AdministrationToolStripMenuItem");
            AdministrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UsersToolStripMenuItem, toolStripSeparator3, AddDataFromExcelTSMI, tsmiDatabaseOperations, tsmiTestingData });
            AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem";
            // 
            // UsersToolStripMenuItem
            // 
            resources.ApplyResources(UsersToolStripMenuItem, "UsersToolStripMenuItem");
            UsersToolStripMenuItem.Image = Properties.Resources.icons8_male_user_32;
            UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            UsersToolStripMenuItem.Click += UsersToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
            toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // AddDataFromExcelTSMI
            // 
            resources.ApplyResources(AddDataFromExcelTSMI, "AddDataFromExcelTSMI");
            AddDataFromExcelTSMI.Name = "AddDataFromExcelTSMI";
            AddDataFromExcelTSMI.Click += AddDataFromExcelTSMI_Click;
            // 
            // tsmiDatabaseOperations
            // 
            resources.ApplyResources(tsmiDatabaseOperations, "tsmiDatabaseOperations");
            tsmiDatabaseOperations.Name = "tsmiDatabaseOperations";
            tsmiDatabaseOperations.Click += tsmiDatabaseOperations_Click;
            // 
            // tsmiTestingData
            // 
            resources.ApplyResources(tsmiTestingData, "tsmiTestingData");
            tsmiTestingData.Name = "tsmiTestingData";
            tsmiTestingData.Click += tsmiTestingData_Click;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(toolStripStatusLabel1, "toolStripStatusLabel1");
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiProductsList;
        private ToolStripMenuItem toolStripMenuItem2;
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
        private ToolStripMenuItem tsmiTestingData;
    }
}