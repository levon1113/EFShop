using EFShop.Data.Context;
using EFShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFShop.UI
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            this.FormClosed += MyFormClosed;
            using (EFShopDbContext context = new EFShopDbContext())
            {
                var shops = context.Shops;
                
                foreach (var item in shops)
                {
                    this.Shops.Items.Add(item);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
                   
            if (this.NameBox.Text == "" || this.Shops.SelectedIndex == -1)
            {
                MessageBox.Show("Input Name!");
            }
            else
            {
                using (EFShopDbContext context = new EFShopDbContext())
                {
                    int i = this.Shops.SelectedIndex + 1;
                    Product product = new Product()
                    {
                        Name = this.NameBox.Text,
                        ShopId = i
                    };

                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            
            
            this.Close();
        }
        private void MyFormClosed(object sender, FormClosedEventArgs e)
        {
            this.NameBox.Text = "";
            this.Shops.SelectedIndex = -1;
            this.Shops.Items.Clear();
        }
    }
}
