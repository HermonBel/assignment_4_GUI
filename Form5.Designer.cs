namespace WindowsFormsApp1
{
    partial class Form5
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtboxQuantity = new System.Windows.Forms.TextBox();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.txtboxProduct = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblProduct, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtboxProduct, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtboxPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtboxQuantity, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(162, 56);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(75, 24);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(169, 193);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 25);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(154, 327);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(92, 25);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtboxQuantity
            // 
            this.txtboxQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtboxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxQuantity.Location = new System.Drawing.Point(403, 324);
            this.txtboxQuantity.Name = "txtboxQuantity";
            this.txtboxQuantity.Size = new System.Drawing.Size(166, 31);
            this.txtboxQuantity.TabIndex = 5;
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtboxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPrice.Location = new System.Drawing.Point(403, 190);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(166, 31);
            this.txtboxPrice.TabIndex = 4;
            // 
            // txtboxProduct
            // 
            this.txtboxProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtboxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxProduct.Location = new System.Drawing.Point(403, 53);
            this.txtboxProduct.Name = "txtboxProduct";
            this.txtboxProduct.Size = new System.Drawing.Size(166, 31);
            this.txtboxProduct.TabIndex = 3;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtboxProduct;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.TextBox txtboxQuantity;
    }
}