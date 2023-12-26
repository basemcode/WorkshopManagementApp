using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement.Forms.Testing;

public partial class test : Form
{
    string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
    public test()
    {
        InitializeComponent();

        var ItemsTable = DataHelper.ToDataTable(ItemData.GetAllItems());
        InitializeDataGridViews(dataGridView1, ItemsTable);
        InitializeDataGridViews(dataGridView2, ItemsTable);

    }

    private void InitializeDataGridViews(DataGridView dataGridView, DataTable itemsTable)
    {
        dataGridView.AlternatingRowsDefaultCellStyle.BackColor=Color.AliceBlue;
        dataGridView.Dock = DockStyle.Fill;
        dataGridView.Columns.AddRange(new DataGridViewColumn[] {
            new DataGridViewTextBoxColumn { Name = "ItemBarcode", HeaderText = "Barcode" , DataPropertyName="Barcode"},
            new DataGridViewImageColumn { Name = "ItemImage",HeaderText = "Image" , DataPropertyName="Image"}
        });
        foreach (string monthName in monthNames)
        {
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = monthName, HeaderText = monthName, DataPropertyName = monthName });
        }
        dataGridView.AutoGenerateColumns = false;
        dataGridView.RowTemplate.Height = 100;
        ((DataGridViewImageColumn)dataGridView.Columns["ItemImage"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

        dataGridView.DataSource = itemsTable;
        dataGridView.DataError += DataGridView1_DataError;

    }

    private void DataGridView1_DataError(object? sender, DataGridViewDataErrorEventArgs e)
    {

    }

    private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            ContextMenuStrip m = new ContextMenuStrip();
            m.Items.Add(new ToolStripMenuItem("Cut"));
            m.Items.Add(new ToolStripMenuItem("Copy"));
            m.Items.Add(new ToolStripMenuItem("Paste"));

            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            if (currentMouseOverRow >= 0)
            {
                m.Items.Add(new ToolStripMenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
            }

            m.Show(dataGridView1, new Point(e.X, e.Y));

        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            foreach (var month in monthNames)
            {
                row.Cells[month].Value = new Random().Next(150);
            }
        }
        foreach (DataGridViewRow row in dataGridView2.Rows)
        {
            foreach (var month in monthNames)
            {
                row.Cells[month].Value = new Random().Next(150);
            }
        }

    }
}
