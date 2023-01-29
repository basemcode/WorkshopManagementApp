using DataAccess.Data;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkshopManagement.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WorkshopManagement
{
    public partial class frmItems : Form
    {
        //List<ItemModel> ItemsList = new List<ItemModel>();
        static DataTable ItemsTable = DataHelper.ToDataTable(ItemData.GetAllItems());
        DataView dataView ;
        public frmItems()
        {
            InitializeComponent();
        }

        private void frmAddItems_Load(object sender, EventArgs e)
        {
            dgvItemsTable.AutoGenerateColumns = false;
            dgvItemsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            // or even better, use .DisableResizing. Most time consuming enum is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

            // set it to false if not needed
            dgvItemsTable.RowHeadersVisible = false;
            cbCategory.SelectedIndex=0;

            LoadDataToDGV(cbCategory.Text);
            /*frmLoading obj = (frmLoading)Application.OpenForms["frmLoading"];
            obj.Close();*/
        }

        private void LoadDataToDGV(string category)
        {
            //dgvItemsTable.Rows.Clear();
            //dgvItemsTable.AutoGenerateColumns=true;
            //ItemsTable = DataHelper.ToDataTable(ItemData.GetItemsOfCategory(category));
            ItemsTable = DataHelper.ToDataTable(ItemData.GetAllItems());
            string s = @"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";
            byte[] newBytes = Convert.FromBase64String(s);
            for (int i = 0; i < ItemsTable.Rows.Count; i++)
            {
                object a = ItemsTable.Rows[i]["Image"];
                if (ItemsTable.Rows[i]["Image"] == DBNull.Value)
                {
                    
                    
                    ItemsTable.Rows[i]["Image"] = newBytes;
                }
            }
            /*ItemsList = ItemData.GetItemsOfCategory(category).ToList();
            if (ItemsList != null&& ItemsList.Count!=0)
            {
                //dgvItemsTable.DataSource= ItemsList;
                foreach (var item in ItemsList)
                {
                    try
                    {
                        DataGridViewRow newRow = new DataGridViewRow();

                        //newRow.CreateCells(dgvItemsTable);
                        //newRow.Cells.Add()
                        //newRow.Cells[dgvItemsTable.Columns["ItemID"].Name].Value = item.ItemID;
                        //newRow.Cells["ItemNumber"].Value = item.ItemNumber;
                        //newRow.Cells["ItemImage"].Value = displayImage((byte[])item.Image);
                        //dgvItemsTable.Rows.Add(newRow);

                        int rowIndex = this.dgvItemsTable.Rows.Add();

                        //Obtain a reference to the newly created DataGridViewRow 
                        var row = this.dgvItemsTable.Rows[rowIndex];
                        row.Cells["ItemID"].Value = item.ItemID;
                        row.Cells["ItemCode"].Value = item.ItemCode;
                        row.Cells["ItemCodeWithColor"].Value = item.ItemCodeWithColor;
                        row.Cells["Barcode"].Value = item.Barcode;
                        row.Cells["ItemImage"].Value = displayImage((byte[])item.Image);
                        row.Cells["ItemNumberOnWB"].Value = item.ItemNumberOnWB;
                        row.Cells["InternalCode"].Value = item.InternalCode;
                        row.Cells["ProductNameCol"].Value = item.ProductName;
                        row.Cells["Color"].Value = item.Color;
                        row.Cells["HardboardBoxNumber"].Value = item.HardboardBoxNumber;
                        row.Cells["Unit"].Value = item.Unit;
                        row.Cells["GofferNumber"].Value = item.GofferNumber;
                        row.Cells["Category"].Value = item.Category;
                        row.Cells["Note"].Value = item.Note;
                        dgvItemsTable.Sort(ItemID, ListSortDirection.Descending);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }*/
            try
            {
                dgvItemsTable.DataSource = ItemsTable;
                DataView dataView = ItemsTable.DefaultView;
            }
            catch (Exception e3)
            {

                MessageBox.Show(e3.Message);
            }
            ItemsTable.DefaultView.RowFilter = "[Category] = '" + cbCategory.Text + "'";
            tbWarehouseCategoryQuantity.Text = ItemsTable.DefaultView.Count.ToString();
            tbWarehouseAllQuantity.Text = ItemsTable.Rows.Count.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                MessageBox.Show("Enter key pressed!!");
            /*else
            {
                MessageBox.Show(e.KeyValue.ToString()); 
            }*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image|*.jpg;*.png;*.jpeg" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string CurrentFilePath = Path.GetFullPath(openFileDialog.FileName);
                    try
                    {
                        pbItemImage.Image = ImageData.GetImage(CurrentFilePath);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }
        
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (tbBarcode.Text != String.Empty)
            {
                if (canAdd)
                {
                    ItemModel newItem = new ItemModel();
                    newItem.ItemCode = tbItemCode.Text;
                    newItem.ItemCodeWithColor = tbItemCodeWithColor.Text;
                    newItem.Barcode = tbBarcode.Text;
                    newItem.Image = SaveImage(pbItemImage);
                    newItem.ItemNumberOnWB = tbItemNumberOnWB.Text;
                    newItem.InternalCode = tbInternalCode.Text;
                    newItem.ProductName = tbProductName.Text;
                    newItem.Color = tbColor.Text;
                    newItem.HardboardBoxNumber = tbHardboardBoxNumber.Text;
                    newItem.Unit = tbUnit.Text;
                    newItem.GofferNumber = tbGofferNumber.Text;
                    newItem.Category = cbCategory.Text;
                    newItem.Note = tbNote.Text;
                    newItem.QuantityInStock = 0;
                    newItem.MinimumQuantity = 0;
                    newItem.BoxesQuantity = 0;
                    ItemData.InsertItem(newItem);
                    LoadDataToDGV(cbCategory.Text);
                    ClearControlsValues();
                }
                else
                {
                    MessageBox.Show("Баркод уже есть в базе данных.");
                }
            }
            else
            {
                MessageBox.Show("Баркод недействителен.");
            }
        }
        public static byte[] SaveImage(PictureBox pb)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                if (pb.Image!=null)
                {
                    pb.Image.Save(ms, ImageFormat.Jpeg);
                }  
                return ms.GetBuffer();
            }
            catch (Exception)
            {
                return null;
            }
            
        }
        public Image displayImage(byte[]? photo)
        {
            if (photo!=null)
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
        
        private void btnAddImageFromWB_Click(object sender, EventArgs e)
        {
            DownloadDataCompletedEventHandler WhenDownloadComplete=new DownloadDataCompletedEventHandler(ShowImage);
            InternetAccess.GetImageFromInternet(tbItemNumberOnWB.Text, WhenDownloadComplete);
            WhenDownloadComplete.Invoke(this, null);
            ShowImage(null, null);
        }

        private void ShowImage(object sender, DownloadDataCompletedEventArgs e)
        {
            string path = @"Data\img\big\" + tbItemNumberOnWB.Text.ToString() + "-1.jpg";
            pbItemImage.Invoke((MethodInvoker)delegate {
                pbItemImage.Image = ImageData.GetImage(path);
            });
            pbItemImage.Image = ImageData.GetImage(path);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string message = $"Вы хотите удалить товар с ID: {dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value} ?";
            string title = "Удалить товара";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                if (dgvItemsTable.SelectedRows.Count != 0 && dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value != null)
                {
                    if (dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value != null)
                        ItemData.DeleteItem(Convert.ToInt32(dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value));
                    LoadDataToDGV(cbCategory.Text);
                    ClearControlsValues();
                }
            }
            else
            {
                // Do something  
            }


            
        }
        //update the item values in the database
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (tbItemID.Text!=String.Empty)
            {
                    btnAddItem.Enabled = true;
                    ItemModel newItem = new ItemModel();
                    newItem.ItemID = Convert.ToInt32(tbItemID.Text);
                    newItem.ItemCode = tbItemCode.Text;
                    newItem.ItemCodeWithColor = tbItemCodeWithColor.Text;
                    newItem.Barcode = tbBarcode.Text;
                    newItem.Image = SaveImage(pbItemImage);
                    newItem.ItemNumberOnWB = tbItemNumberOnWB.Text;
                    newItem.InternalCode = tbInternalCode.Text;
                    newItem.ProductName = tbProductName.Text;
                    newItem.Color = tbColor.Text;
                    newItem.HardboardBoxNumber = tbHardboardBoxNumber.Text;
                    newItem.Unit = tbUnit.Text;
                    newItem.GofferNumber = tbGofferNumber.Text;
                    newItem.Category = cbCategory.Text;
                    newItem.Note = tbNote.Text;
                    ItemData.UpdateItem(newItem);
                    LoadDataToDGV(cbCategory.Text);
            }
            else
            {
                MessageBox.Show("Выберите артикул пожалуйста!");
            }
           
        }

        //clear the content of all controls of the group item
        private void ClearControlsValues()
        {
            tbItemID.Text = string.Empty;
            tbItemCode.Text = string.Empty;
            tbItemCodeWithColor.Text = string.Empty;
            tbBarcode.Text = string.Empty;
            pbItemImage.Image = displayImage(null);
            tbItemNumberOnWB.Text = string.Empty;
            tbInternalCode.Text = string.Empty;
            tbProductName.Text = string.Empty;
            tbColor.Text = string.Empty;
            tbHardboardBoxNumber.Text = string.Empty;
            tbUnit.Text = string.Empty;
            tbGofferNumber.Text = string.Empty;
            tbNote.Text = string.Empty;
        }

        //change the category
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        { 
            ItemsTable.DefaultView.RowFilter= "[Category] = '" + cbCategory.Text + "'";
            tbWarehouseCategoryQuantity.Text = ItemsTable.DefaultView.Count.ToString();
            /*dataView = ItemsTable.DefaultView;
            string category= cbCategory.Text;
            if (!string.IsNullOrEmpty(category))
            {
                dataView.RowFilter = "[Category] = '" + category + "'";
            }*/
            //dgvItemsTable.DataSource =dataView ;
            //LoadDataToDGV(cbCategory.Text);
        }

        //button function to clear the content of all controls in item group
        private void btnClearControlsValues_Click(object sender, EventArgs e)
        {
            ClearControlsValues();
            btnAddItem.Enabled = true;
        }
        //row number and column index of the clicked cell 
        private DataGridViewCellEventArgs mouseLocation=new DataGridViewCellEventArgs(-1,-1);
        private bool canAdd=false;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemsTable.SelectedRows.Count != 0 && dgvItemsTable.SelectedRows[0].Cells["ItemID"].Value != null)
                {
                    btnAddItem.Enabled = false;
                    //tbWarehouseCategoryQuantity.Text = dgvItemsTable.RowCount.ToString();
                    tbItemID.Text = dgvItemsTable.Rows[ mouseLocation.RowIndex].Cells["ItemID"].Value.ToString();
                    tbItemCode.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ItemCode"].Value.ToString();
                    tbItemCodeWithColor.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ItemCodeWithColor"].Value.ToString();
                    tbBarcode.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["Barcode"].Value.ToString();
                    
                    tbItemNumberOnWB.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ItemNumberOnWB"].Value.ToString();
                    tbInternalCode.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["InternalCode"].Value.ToString();
                    tbProductName.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ProductNameCol"].Value.ToString();
                    tbColor.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["Color"].Value?.ToString();
                    tbHardboardBoxNumber.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["HardboardBoxNumber"].Value.ToString();
                    tbUnit.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["Unit"].Value.ToString();
                    tbGofferNumber.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["GofferNumber"].Value.ToString();
                    tbNote.Text = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["Note"].Value.ToString();
                    pbItemImage.Image = displayImage((byte[])dgvItemsTable.Rows[mouseLocation.RowIndex].Cells["ItemImage"].Value);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);

            }
        }
        //this function only get the cell coordinate where the mouse is located to use it when the click is happening
        private void dgvItemsTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try {
                //check if the click is inside the table content
                if (mouseLocation.ColumnIndex >= 0 && mouseLocation.RowIndex >= 0)
                {
                    //get the cell value
                    string? choice = dgvItemsTable.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex].Value.ToString();
                    if (choice != null) {
                        switch (mouseLocation.ColumnIndex)
                        {
                            case 1:
                                tbItemCode.Text = choice;
                                break;
                            case 2:
                                tbItemCodeWithColor.Text = choice;
                                break;
                            case 3:
                                tbBarcode.Text = choice;
                                break;
                            case 4:
                                pbItemImage.Image = displayImage((byte[])dgvItemsTable.Rows[mouseLocation.RowIndex].Cells[mouseLocation.ColumnIndex].Value);
                                break;
                            case 5:
                                tbItemNumberOnWB.Text = choice;
                                break;
                            case 6:
                                tbInternalCode.Text = choice;
                                break;
                            case 7:
                                tbProductName.Text = choice;
                                break;
                            case 8:
                                tbColor.Text = choice;
                                break;
                            case 9:
                                tbHardboardBoxNumber.Text = choice;
                                break;
                            case 10:
                                tbUnit.Text = choice;
                                break;
                            case 11:
                                tbGofferNumber.Text = choice;
                                break;
                            case 13:
                                tbNote.Text = choice;
                                break;
                        }
                    }
                }
            }catch(Exception ex4) 
            {
                MessageBox.Show(ex4.Message);
            }
            }
        
        private void tbBarcode_TextChanged(object sender, EventArgs e)
        {
           var itemToCheck=ItemData.GetItemByBarcode(tbBarcode.Text);
            if (itemToCheck ==null)
            {
                tbBarcode.BackColor= System.Drawing.Color.White;
                canAdd = true;
            }
            else
            {
                tbBarcode.BackColor = System.Drawing.Color.Red;
                canAdd = false;
            }
        }

        private void dgvItemsTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgvItemsTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = global::WorkshopManagement.Properties.Resources.download;
        }

        private void btnUpdateAllImages_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvItemsTable.Rows)
            {
                DownloadDataCompletedEventHandler WhenDownloadComplete = new DownloadDataCompletedEventHandler(ShowImageFromFile);
                InternetAccess.GetImageFromInternet(item.Cells["ItemNumberOnWB"].Value?.ToString(), WhenDownloadComplete);
               
                //creating new item
                ItemModel newItem = new ItemModel();
                newItem.ItemID = (int)item.Cells["ItemID"].Value;
                
                //processing the image
                string path = @"Data\img\big\" + item.Cells["ItemNumberOnWB"].Value?.ToString() + "-1.jpg";
                MemoryStream ms = new MemoryStream();
                if (ImageData.GetImage(path) != null)
                {
                    ImageData.GetImage(path).Save(ms, ImageFormat.Jpeg);
                } 
                newItem.Image = ms.GetBuffer();
                ItemData.UpdateItemImage(newItem);
               
            }
        }

        private void ShowImageFromFile(object sender, DownloadDataCompletedEventArgs e)
        {
            
        }
    }
}
