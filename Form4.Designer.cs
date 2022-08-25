namespace WindowsFormsApp1
{
    partial class Form4
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.productCard1 = new WindowsFormsApp1.productCard();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.lblProductDesc);
            this.flowLayoutPanel1.Controls.Add(this.productCard1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(54, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(622, 392);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDesc.Location = new System.Drawing.Point(3, 0);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(200, 25);
            this.lblProductDesc.TabIndex = 0;
            this.lblProductDesc.Text = "Product Description";
            this.lblProductDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // productCard1
            // 
            this.productCard1.Description = null;
            this.productCard1.Location = new System.Drawing.Point(3, 28);
            this.productCard1.Name = "productCard1";
            this.productCard1.Price = 0D;
            this.productCard1.Size = new System.Drawing.Size(143, 144);
            this.productCard1.TabIndex = 1;
            this.productCard1.Title = null;
            this.productCard1.Load += new System.EventHandler(this.productCard1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 453);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblProductDesc;
        private productCard productCard1;
    }
}