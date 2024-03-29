﻿using DataAccess.Data;
using DataAccess.Models;
using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace WorkshopManagement;

public partial class frmStockInDetails : Form
{
    public bool editMode;
    public int StockInID;
    int NewStockInID = 1;
    //List<StockInDetailModel> ToAddStockInDetailsList = new List<StockInDetailModel>();
    DataTable ToAddStockInDetailsTable= new DataTable();
    DataTable ToEditStockInDetailsTable = new DataTable();
    IEnumerable<string> BarcodesDataTable;

    public frmStockInDetails()
    {
        InitializeComponent();
        dgvStockInDetails.AutoGenerateColumns = false;
    }

    private void frmStockInDetails_Load(object sender, EventArgs e)
    {
        BarcodesDataTable = ItemData.GetAllBarcodes();
        AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();

        foreach (var item in BarcodesDataTable)
        {
            autoCompleteStringCollection.Add(item);
        }
        txtBarcode.AutoCompleteCustomSource = autoCompleteStringCollection;
        cboBarcode.DataSource = autoCompleteStringCollection;
        cboBarcode.Text = string.Empty;
         
        ToAddStockInDetailsTable.Columns.AddRange(new DataColumn[] 
        {   new DataColumn { ColumnName = "StockInID",DataType =typeof(Int32)},
            new DataColumn { ColumnName = "ItemID" ,DataType =typeof(Int32)},
            new DataColumn { ColumnName = "ItemCodeWithColor",DataType =typeof(string) },
            new DataColumn { ColumnName = "ProductName" ,DataType =typeof(string)},
            new DataColumn { ColumnName = "Barcode" ,DataType =typeof(string)},
            new DataColumn { ColumnName = "Quantity" ,DataType =typeof(Int32)},
            new DataColumn { ColumnName = "BoxesQuantity" ,DataType =typeof(Int32)},
            new DataColumn { ColumnName = "Category" ,DataType =typeof(string)}
        });
        
        //show user name
        txtLoggedUser.Text = $"{SessionHelper.loggedUser?.FirstName} {SessionHelper.loggedUser?.MiddleName}";
        txtSearchItemName.Text = string.Empty;
        picSearchItemPhoto.Image= null;
        if (editMode)
        {
            ToEditStockInDetailsTable = DataHelper.ToDataTable<StockInDetailModel>(
                    StockInDetailData.GetAllDetailsOfStockIn(StockInID));
            ToAddStockInDetailsTable = ToEditStockInDetailsTable.Copy();
        }
        dgvStockInDetails.DataSource = ToAddStockInDetailsTable;
    }

    private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            AddItemToDataGridView(txtBarcode.Text);
            System.Media.SystemSounds.Beep.Play();              
        } 
        else
        {
           
        }
    }

    void AddItemToDataGridView(string Barcode)
    {
        ItemModel itemToAdd = ItemData.GetItemByBarcode(Barcode);
        if (itemToAdd != null)
        {
            bool founded = false;
            int rowIndex = -1;
            txtItemID.Text = itemToAdd.ItemID.ToString();
            txtItemName.Text = itemToAdd.ProductName;
            picItemPhoto.Image= displayImage((byte[])itemToAdd.Image);
            foreach (DataGridViewRow item in dgvStockInDetails.Rows)
            {
                if (Convert.ToInt32(item.Cells["ItemID"].Value) == itemToAdd.ItemID)
                {
                    founded = true;
                    rowIndex = item.Index;
                }
            }
            if (founded)
            { 
                if (int.TryParse(txtQuantity.Text,out int quantity))
                {
                    if (quantity>=0)
                    {
                        dgvStockInDetails.Rows[rowIndex].Cells["Quantity"].Value = quantity;
                       
                    }
                    txtQuantity.Text = String.Empty;
                }
                else
                {
                    dgvStockInDetails.Rows[rowIndex].Cells["Quantity"].Value = Convert.ToInt32(dgvStockInDetails.Rows[rowIndex].Cells["Quantity"].Value) + 1;
                }

                if (int.TryParse(txtBoxesQuantity.Text, out int result))
                {
                    if (result>=0)
                    {
                        dgvStockInDetails.Rows[rowIndex].Cells["BoxesQuantity"].Value = result;
                    }
                   
                }
                
            }
            else
            {
                txtBoxesQuantity.Text = "0";
                DataRow newRow = ToAddStockInDetailsTable.NewRow();
                newRow["StockInID"] = NewStockInID;
                newRow["ItemID"] = itemToAdd.ItemID;
                newRow["ItemCodeWithColor"] = itemToAdd.ItemCodeWithColor;
                newRow["ProductName"] = itemToAdd.ProductName;
                newRow["Barcode"] = itemToAdd.Barcode;
                newRow["Category"] = itemToAdd.Category;
                newRow["Quantity"] = 1;
                
                if (int.TryParse(txtQuantity.Text, out int quantity))
                {
                    if (quantity >= 0)
                    {
                        newRow["Quantity"] = quantity;
                    }
                    txtQuantity.Text = String.Empty;
                }
                else
                {
                    txtQuantity.Text = String.Empty;
                }
                if (int.TryParse(txtBoxesQuantity.Text, out int result))
                {
                    if (result>=0)
                    {
                        newRow["BoxesQuantity"] = result;
                    }
                    
                }
                else
                {
                    newRow["BoxesQuantity"] = 0;
                }  
                ToAddStockInDetailsTable.Rows.InsertAt(newRow,0);
                
            }
            CheckBoxesQuantityInDGV();
        }
        else
        {
            MessageBox.Show("Такого товара нет в базе данных!");
        }
    }
    private void CheckBoxesQuantityInDGV()
    {
        foreach (DataGridViewRow item in dgvStockInDetails.Rows)
        {
            if ((int)item.Cells["BoxesQuantity"].Value == 0)
            {
                item.Cells["BoxesQuantity"].Style.BackColor = Color.Yellow;
            }
            else
            {
                item.Cells["BoxesQuantity"].Style.BackColor = item.DefaultCellStyle.BackColor;
            }
        }
    }
    private void cboBarcode_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            
                IEnumerable<string> NewDataTable = new List<string>();
                NewDataTable = BarcodesDataTable.Where((item) => item.Contains(cboBarcode.Text)).ToList<string>();
                AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                for (int i = 0; i < NewDataTable.Count(); i++)
                {
                    autoCompleteStringCollection.Add(NewDataTable.ToList<string>()[i]);
                }
                cboBarcode.DataSource = autoCompleteStringCollection;
            
            if (cboBarcode.Items.Count == 1)
            {
                AddItemToDataGridView(cboBarcode.Text);
                txtBarcode.Text = cboBarcode.Text;
                txtBarcode.Focus();
            }

            if (cboBarcode.Items.Count>1)
            {
                cboBarcode.BackColor = Color.Yellow;
            }
            else
            {
                cboBarcode.BackColor = Color.White;
            }
        }
    }

   
    private void btnShowItem_Click(object sender, EventArgs e)
    {
        AddItemToDataGridView(cboBarcode.Text);
        txtBarcode.Focus();
    }

    private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue == 13)
        {
            txtBarcode.Focus();
            System.Media.SystemSounds.Beep.Play();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            //do nothing if there is nothing to add
            if (dgvStockInDetails.Rows.Count == 0)
            {
                return;
            }
            //if the edit mode is active we delete old data and we insert new ones
            if (editMode)
            {
                foreach (DataRow item in ToEditStockInDetailsTable.Rows)
                {
                    int StockInDetailIDToDelete = Convert.ToInt32(item["StockInDetailID"]);
                    StockInDetailData.DeleteStockInDetail(StockInDetailIDToDelete); 
                }
                foreach (DataGridViewRow row in dgvStockInDetails.Rows)
                {
                    StockInDetailData.InsertStockInDetail(new() {
                        ItemID = (int)row.Cells["ItemID"].Value
                       ,StockInID = StockInID
                       ,Quantity = (int)row.Cells["Quantity"].Value
                       ,BoxesQuantity = (int)row.Cells["BoxesQuantity"].Value });
                }
            }
            //if the edit mode not active we create a new stockIn operation and we add all from the dgv
            else
            {
                int newStockInID = StockInData.InsertStockIn(new() {
                    Date = DateTime.Now
                   ,UserID = SessionHelper.loggedUser.UserID
                   ,Note = txtNote.Text });
                foreach (DataGridViewRow row in dgvStockInDetails.Rows)
                {
                    StockInDetailData.InsertStockInDetail(new() {
                        ItemID = (int)row.Cells["ItemID"].Value
                        , StockInID = newStockInID
                        , Quantity = (int)row.Cells["Quantity"].Value
                        , BoxesQuantity = (int)row.Cells["BoxesQuantity"].Value });
                }
            }   
            MessageBox.Show("Успешно!");
            this.Close();   
        }
        catch (Exception addingStockinDetailsError)
        {
            MessageBox.Show($"Ошибка {addingStockinDetailsError.Message}");
        }   
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    public Image displayImage(byte[]? photo)
    {
        if (photo != null)
        {
            try
            {
                MemoryStream ms = new MemoryStream(photo);
                return System.Drawing.Image.FromStream(ms);
            }
            catch (Exception)
            {
                return null;
            }
        }
        return null;
    }

    private void dgvStockInDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        dgvStockInDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = global::WorkshopManagement.Properties.Resources.download;

    }

    private void btnAddItemToDGV_Click(object sender, EventArgs e)
    {
        AddItemToDataGridView(txtBarcode.Text);
        txtBarcode.Focus();
    }

    private void dgvStockInDetails_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == dgvStockInDetails.Columns["plusBtnCol"].Index & e.RowIndex >= 0)
        {
            int newValue = Convert.ToInt32(dgvStockInDetails.Rows[e.RowIndex].Cells["Quantity"].Value);
            dgvStockInDetails.Rows[e.RowIndex].Cells["Quantity"].Value = newValue + 1;
        }
        if (e.ColumnIndex == dgvStockInDetails.Columns["minusBtnCol"].Index & e.RowIndex >= 0)
        {
            int newValue = Convert.ToInt32(dgvStockInDetails.Rows[e.RowIndex].Cells["Quantity"].Value);
            dgvStockInDetails.Rows[e.RowIndex].Cells["Quantity"].Value = newValue - 1;
        }
    }

    private void cboBarcode_SelectedIndexChanged(object sender, EventArgs e)
    {
        ItemModel itemToAdd = ItemData.GetItemByBarcode(cboBarcode.Text);
        txtSearchItemName.Text = itemToAdd.ProductName;
        picSearchItemPhoto.Image = displayImage((byte[])itemToAdd.Image);
    }
}
