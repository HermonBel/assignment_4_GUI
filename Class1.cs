using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Class1
    {
        static List<Class1> class1 = new List<Class1>();
        public int number { get; set; }
        public string dates { get; set; }
        public int inventoryNumber { get; set; }
        public string item { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public void save()
        {
            class1.Add(this);
            //MessageBox.Show($"Product added: number {number}, inventrory number {inventoryNumber}, quantity {quantity}, price {price}");
        }
        public static List<Class1> getAllProducts()
        {
            return class1;
        }

    }
}
