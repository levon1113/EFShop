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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(433, 772);
            this.listBox1.TabIndex = 0;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(469, 32);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(244, 46);
            this.AddProduct.TabIndex = 1;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // EditProduct
            // 
            this.EditProduct.Location = new System.Drawing.Point(469, 110);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(244, 46);
            this.EditProduct.TabIndex = 2;
            this.EditProduct.Text = "Edit Product";
            this.EditProduct.UseVisualStyleBackColor = true;
            this.EditProduct.Click += new System.EventHandler(this.EditProduct_Click);
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.Location = new System.Drawing.Point(469, 182);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(244, 46);
            this.RemoveProduct.TabIndex = 3;
            this.RemoveProduct.Text = "Remove Product";
            this.RemoveProduct.UseVisualStyleBackColor = true;
            this.RemoveProduct.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(469, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 40);
            this.comboBox1.TabIndex = 4;
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(469, 324);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(242, 46);
            this.SortBtn.TabIndex = 5;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(469, 395);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(244, 46);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 789);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RemoveProduct);
            this.Controls.Add(this.EditProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
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
    }
}