using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5(string name, int invNum, double price, double quantity)
            {
                InitializeComponent();
                txtboxProduct.Text = name;
                txtboxPrice.Text = price.ToString();
                txtboxQuantity.Text = quantity.ToString();


            }

        private void btnView_Click_1(object sender, EventArgs e)
        {

        }
    }

        
    }

