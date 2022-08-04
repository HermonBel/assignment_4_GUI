﻿using System;
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
        Login_Page loginPage = new Login_Page();
        Class1 Class1 = new Class1();
        public Form1(string username, Login_Page login_Page)
        {
            InitializeComponent();
            lblUsername.Text = username;
            loginPage = login_Page;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Class1.number = int.Parse(txt_number.Text);
                Class1.dates = date_picker_date.Text;
                Class1.inventoryNumber = int.Parse(txt_inventory.Text);
                Class1.item = txt_item.Text;
                Class1.quantity = int.Parse(txt_quantity.Text);
                Class1.price = Double.Parse(txt_price.Text);
                Class1.option = chkBox.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            Regex r = new Regex(@"^[0-9]");
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
            if (r.IsMatch(txt_inventory.Text))
            { 
                errorProvider1.Clear();
                Class1.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Class1.getAllProducts();

                String items = " ";
                foreach (var itemList in chkBox.CheckedItems)
                {
                    items += itemList.ToString();
                }
                MessageBox.Show(items);
            }
            else
                MessageBox.Show("Entry of inventory number must not excced 9999");
                
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

        private void chkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

   
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }
    }
}
