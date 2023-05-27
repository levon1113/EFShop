namespace EFShop.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.EditProduct = new System.Windows.Forms.Button();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SortBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.AddShopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 364);
            this.listBox1.TabIndex = 0;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(253, 15);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(131, 22);
            this.AddProduct.TabIndex = 1;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // EditProduct
            // 
            this.EditProduct.Location = new System.Drawing.Point(253, 78);
            this.EditProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(131, 22);
            this.EditProduct.TabIndex = 2;
            this.EditProduct.Text = "Edit Product";
            this.EditProduct.UseVisualStyleBackColor = true;
            this.EditProduct.Click += new System.EventHandler(this.EditProduct_Click);
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.Location = new System.Drawing.Point(253, 111);
            this.RemoveProduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(131, 22);
            this.RemoveProduct.TabIndex = 3;
            this.RemoveProduct.Text = "Remove Product";
            this.RemoveProduct.UseVisualStyleBackColor = true;
            this.RemoveProduct.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 147);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(253, 178);
            this.SortBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(130, 22);
            this.SortBtn.TabIndex = 5;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(253, 211);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(131, 22);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // AddShopBtn
            // 
            this.AddShopBtn.Location = new System.Drawing.Point(253, 41);
            this.AddShopBtn.Name = "AddShopBtn";
            this.AddShopBtn.Size = new System.Drawing.Size(130, 23);
            this.AddShopBtn.TabIndex = 7;
            this.AddShopBtn.Text = "Add Shop";
            this.AddShopBtn.UseVisualStyleBackColor = true;
            this.AddShopBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 366);
            this.Controls.Add(this.AddShopBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RemoveProduct);
            this.Controls.Add(this.EditProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button AddProduct;
        private Button EditProduct;
        private Button RemoveProduct;
        private ComboBox comboBox1;
        private Button SortBtn;
        private Button ResetBtn;
        private Button AddShopBtn;
    }
}