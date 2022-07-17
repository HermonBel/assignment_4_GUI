namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_inventory_number = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_inventory = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.date_picker_date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(68, 47);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(44, 13);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Number";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(220, 47);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_inventory_number
            // 
            this.lbl_inventory_number.AutoSize = true;
            this.lbl_inventory_number.Location = new System.Drawing.Point(452, 47);
            this.lbl_inventory_number.Name = "lbl_inventory_number";
            this.lbl_inventory_number.Size = new System.Drawing.Size(91, 13);
            this.lbl_inventory_number.TabIndex = 2;
            this.lbl_inventory_number.Text = "Inventoty Number";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Location = new System.Drawing.Point(68, 124);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(27, 13);
            this.lbl_item.TabIndex = 3;
            this.lbl_item.Text = "Item";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(68, 195);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 4;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(220, 195);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Price";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(71, 282);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(194, 282);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(306, 282);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(71, 83);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 20);
            this.txt_number.TabIndex = 9;
            this.txt_number.TextChanged += new System.EventHandler(this.txt_number_TextChanged);
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(71, 153);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(100, 20);
            this.txt_item.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(223, 228);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 11;
            // 
            // txt_inventory
            // 
            this.txt_inventory.Location = new System.Drawing.Point(455, 83);
            this.txt_inventory.Name = "txt_inventory";
            this.txt_inventory.Size = new System.Drawing.Size(100, 20);
            this.txt_inventory.TabIndex = 12;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(71, 228);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 13;
            // 
            // date_picker_date
            // 
            this.date_picker_date.Location = new System.Drawing.Point(223, 83);
            this.date_picker_date.Name = "date_picker_date";
            this.date_picker_date.Size = new System.Drawing.Size(194, 20);
            this.date_picker_date.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 181);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.date_picker_date);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_inventory);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.lbl_inventory_number);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_number);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_inventory_number;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_inventory;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.DateTimePicker date_picker_date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

