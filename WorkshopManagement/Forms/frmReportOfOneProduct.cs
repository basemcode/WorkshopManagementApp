using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement.Forms
{
    public partial class frmReportOfOneProduct : Form
    {
        IEnumerable<string> BarcodesDataTable;
        public frmReportOfOneProduct()
        {
            InitializeComponent();
        }
        private void frmReportOfOneProduct_Load(object sender, EventArgs e)
        {
            BarcodesDataTable = ItemData.GetAllBarcodes();
        }
        private void cboBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                IEnumerable<string> NewDataTable = new List<string>();
                NewDataTable = BarcodesDataTable.Where((item) => item.Contains(cboBarcode.Text)).ToList<string>();
                cboBarcode.DataSource = NewDataTable;
                AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
                /*foreach (var row in NewDataTable)
                {

                }*/
                for (int i = 0; i < NewDataTable.Count(); i++)
                {
                    autoCompleteStringCollection.Add(NewDataTable.ToList<string>()[i]);
                }
                cboBarcode.DataSource = autoCompleteStringCollection;
                if (cboBarcode.Items.Count == 1)
                {
                    ItemModel itemToAdd = ItemData.GetItemByBarcode(cboBarcode.Text);

                    tbItemID.Text = itemToAdd.ItemID.ToString();
                    tbItemCode.Text = itemToAdd.ItemCode?.ToString();
                    tbItemCodeWithColor.Text = itemToAdd.ItemCodeWithColor?.ToString();
                    tbBarcode.Text = itemToAdd.Barcode?.ToString();
                    tbItemNumberOnWB.Text = itemToAdd.ItemNumberOnWB?.ToString();
                    tbInternalCode.Text = itemToAdd.InternalCode?.ToString();
                    tbProductName.Text = itemToAdd.ProductName?.ToString();
                    tbColor.Text = itemToAdd.Color?.ToString();
                    tbHardboardBoxNumber.Text = itemToAdd.HardboardBoxNumber?.ToString();
                    tbUnit.Text = itemToAdd.Unit?.ToString();
                    tbGofferNumber.Text = itemToAdd.GofferNumber?.ToString();
                    tbNote.Text = itemToAdd.Note?.ToString();
                    pbItemImage.Image = DataHelper.displayImage(itemToAdd.Image);
                    txtQuantityInStock.Text=itemToAdd.QuantityInStock.ToString();
                    txtBoxesQuantity.Text = itemToAdd.BoxesQuantity.ToString();
                    txtMinimumQuantity.Text = itemToAdd.MinimumQuantity.ToString();

                    //txtBarcode.Focus();
                }
                if (cboBarcode.Items.Count > 1)
                {
                    cboBarcode.BackColor = Color.Yellow;
                }
                else
                {
                    cboBarcode.BackColor = Color.White;
                }
            }
        }

        
    }
}
