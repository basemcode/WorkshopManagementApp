using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlQueryExcute
{
    public partial class Form2 : Form
    {

        static int i = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void ivan(object sender, EventArgs e)
        {

                i += 10;
                button1.Size = new System.Drawing.Size(100 + i, 100 + i);
/*                Thread.Sleep(500);*/
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            i += 10;
            button2.Size = new System.Drawing.Size(100 + i, 100 + i);
            /*                Thread.Sleep(500);*/


        }

        private void button1_SizeChanged(object sender, EventArgs e)
        {

             i += 10;

            //MessageBox.Show("Hi, my size changrd!");
        }
    }
}
