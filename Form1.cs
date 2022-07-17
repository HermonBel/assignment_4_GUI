using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{4}");
            Class1 cls = new Class1();
            if (string.IsNullOrEmpty(txt_number.Text))
            {
                errorProvider1.SetError(txt_number, "This field can not be empty");
            }
            else
            { 
                errorProvider1.Clear();
                cls.number = int.Parse(txt_number.Text);
            }
            if (!(r.IsMatch(txt_inventory.Text)))
                MessageBox.Show("Entry of inventory number must not excced 9999");
            else
                cls.inventoryNumber = int.Parse(txt_inventory.Text);
                
            cls.dates = date_picker_date.Text;
            cls.item = txt_item.Text;
            try
            {
                cls.quantity = int.Parse(txt_quantity.Text);
            }
            catch(Exception exp)
            {
                MessageBox.Show("ERROR IN QUANTITY!");
            }
            cls.price = double.Parse(txt_price.Text);
            cls.save();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Class1.getAllProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_inventory.Text = "";
            txt_item.Text = "";
            txt_number.Text = "";
            txt_price.Text = "";
            txt_quantity.Text = "";
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
