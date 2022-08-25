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
    public partial class productCard : UserControl
    {
        public productCard()
        {
            InitializeComponent();
        }

        private string _title, _description;
        private double _price;
        public string Title{
            get { return _title; }
            set { _title = value;
                 lblTitle.Text = _title;
            }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value;
                lblDescription.Text = _description;
            }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value;
                lblPrice.Text = _price.ToString();
            }
        }

        private void productCard1_Load_1(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            var product = new System.Collections.ArrayList();
            foreach (var myvar in Class1.getAllProducts())
            {
                product.Add(myvar);
                lblTitle.Text = c.item;
                lblDescription.Text = c.option;
                lblPrice.Text = c.price.ToString();
            }

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

    }
}
