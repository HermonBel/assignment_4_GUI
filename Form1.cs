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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Product added: number {txt_number}, inventrory number {txt_inventory}, quantity {txt_quantity}, price {txt_price}");
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
    }
}
