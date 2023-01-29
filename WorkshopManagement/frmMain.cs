using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Data;
using DataAccess.DbAccess;
using DataAccess.Models;
using WorkshopManagement.Forms;
using WorkshopManagement.Helpers;

namespace WorkshopManagement;

public partial class frmMain : Form
{
    public frmMain()
    {
        Thread.CurrentThread.CurrentUICulture=new System.Globalization.CultureInfo("ru-RU");
        InitializeComponent();
    }

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {


        /*frmLoading frmLoadingOfItems = new frmLoading(); 
        frmLoadingOfItems.Show();  */
        //new Thread(() => new frmLoading().ShowDialog()).Start();
        if (!Utilities.FormIsOpen("frmItems"))
        {
            frmItems frmItems = new frmItems();
            frmItems.MdiParent = this;
            frmItems.Show();
        }
        else
        {
            Application.OpenForms["frmItems"].Activate();
        }
        
    }

    private void newStockInToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!Utilities.FormIsOpen("frmStockInDetails"))
        {
            frmStockInDetails frmStockInDetails = new frmStockInDetails();
            frmStockInDetails.MdiParent = this;
            frmStockInDetails.Show();
        }
        else
        {
            Application.OpenForms["frmStockInDetails"].Activate();
        }
    }

    private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!Utilities.FormIsOpen("frmStockIns"))
        {
            frmStockIns frmStockIns = new frmStockIns();
            frmStockIns.MdiParent = this;
            frmStockIns.Show();
        }
        else
        {
            Application.OpenForms["frmStockIns"].Activate();
        }
    }

    private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!Utilities.FormIsOpen("frmUsers"))
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.MdiParent = this;
            frmUsers.Show();
        }
        else
        {
            Application.OpenForms["frmUsers"].Activate();
        }
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        SetPrivileges();
        ChangeMdiBackgroundColor();
        toolStripStatusLabel1.Text = $"Здравствуй {SessionHelper.loggedUser.FirstName}!";
    }

    private void SetPrivileges()
    {
        switch (SessionHelper.loggedUser.Privileges)
        {
            case "Admin":
                AdministrationToolStripMenuItem.Enabled= true;
                AddDataFromExcelTSMI.Enabled = true;
                break;
            default:
                break;
        }
    }

    private void ChangeMdiBackgroundColor()
    {
        foreach (Control control in this.Controls)
        {

            MdiClient client = control as MdiClient;
            if (!(client == null))
            {
                client.BackColor = Color.White;
                //client.BackgroundImage = global::WorkshopManagement.Properties.Resources.background;
                break;
            }
        }
    }
    private void NewStockOutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!Utilities.FormIsOpen("frmStockOutDetails"))
        {
            frmStockOutDetails frmStockOutDetails = new frmStockOutDetails();
            frmStockOutDetails.MdiParent = this;
            frmStockOutDetails.Show();
        }
        else
        {
            Application.OpenForms["frmStockOutDetails"].Activate();
        }
    }

    private void StockOutsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!Utilities.FormIsOpen("frmStockOuts"))
        {
            frmStockOuts frmStockOuts = new frmStockOuts();
            frmStockOuts.MdiParent = this;
            frmStockOuts.Show();
        }
        else
        {
            Application.OpenForms["frmStockOuts"].Activate();
        }
    }

    private void reportOfWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!Utilities.FormIsOpen("frmReportOfWarehouse"))
        {
            frmReportOfWarehouse frmReportOfWarehouse = new frmReportOfWarehouse();
            frmReportOfWarehouse.MdiParent = this;
            frmReportOfWarehouse.Show();
        }
        else
        {
            Application.OpenForms["frmReportOfWarehouse"].Activate();
        }
    }

    private void AddDataFromExcelTSMI_Click(object sender, EventArgs e)
    {
        if (!Utilities.FormIsOpen("frmAddItemsDataFromExcel"))
        {
            frmAddItemsDataFromExcel frmAddItemsDataFromExcel = new frmAddItemsDataFromExcel();
            frmAddItemsDataFromExcel.MdiParent = this;
            frmAddItemsDataFromExcel.Show();
        }
        else
        {
            Application.OpenForms["frmAddItemsDataFromExcel"].Activate();
        }
    }

    private void reportAboutOneItemToolStripMenuItem3_Click(object sender, EventArgs e)
    {
        if (!Utilities.FormIsOpen("frmReportOfOneProduct"))
        {
            frmReportOfOneProduct frmReportOfOneProduct = new frmReportOfOneProduct();
            frmReportOfOneProduct.MdiParent = this;
            frmReportOfOneProduct.Show();
        }
        else
        {
            Application.OpenForms["frmReportOfOneProduct"].Activate();
        }
    }

    private void tsmiDatabaseOperations_Click(object sender, EventArgs e)
    {
        if (!Utilities.FormIsOpen("frmDatabaseOperations"))
        {
            frmDatabaseOperations frmDatabaseOperations = new frmDatabaseOperations();
            frmDatabaseOperations.MdiParent = this;
            frmDatabaseOperations.Show();
        }
        else
        {
            Application.OpenForms["frmDatabaseOperations"].Activate();
        }
    }
}
