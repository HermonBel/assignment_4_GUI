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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void productCard1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Honeydew;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            panel2.BackColor = Color.Honeydew;
            panel3.BackColor = Color.Honeydew;
            panel3.Top = 57;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Beige;
            label1.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            panel2.BackColor= Color.Beige;
            panel3.BackColor = Color.Beige;
            panel3.Top = 114;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Gray;
            label2.BackColor = Color.White;
            label1.BackColor = Color.White;
            label4.BackColor = Color.White;
            panel2.BackColor = Color.Gray;
            panel3.BackColor = Color.Gray;
            panel3.Top = 180;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.BurlyWood; 
            label2.BackColor = Color.White;
            label1.BackColor = Color.White;
            label3.BackColor = Color.White;
            panel2.BackColor = Color.BurlyWood;
            panel3.BackColor = Color.BurlyWood;
            panel3.Top = 244;
        }

        private void productCard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
