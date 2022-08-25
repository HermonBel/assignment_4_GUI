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
    public partial class Form4 : Form
    {
        string Names;
        int Nums;
        double Prices;
        double Quantitys;
        public Form4(string name, int invNum, double price, double quantity)
        {
            InitializeComponent();
            Names = name;
            Nums = invNum;
            Prices = price;
            Quantitys = quantity;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            // List<Items> items = new List<Items>();

            foreach (var myItem in Class1.getAllProducts())
            {
                productCard card = new productCard();
                card.Title = myItem.item;
                card.Description = myItem.inventoryNumber.ToString();
                card.Price = myItem.price;
                card.Click += productCard1_Click;


                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void productCard1_Click(object sender, EventArgs e)
        {
            Form5 page = new Form5(Names, Nums, Prices, Quantitys);
            page.Show();

        }
    }
}