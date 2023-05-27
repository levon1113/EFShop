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
    public partial class UpdateForm : Form
    {
        public Product Product { get; set; }
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.NameBox.Text = Product.Name;
            using (EFShopDbContext context = new EFShopDbContext())
            {
                var prod = context.Products.Find(Product.Id);
                var shops = context.Shops.ToList();
                foreach (var item in shops)
                {
                    this.comboBox1.Items.Add(item);
                }
                this.comboBox1.SelectedItem = prod?.Shop;

            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            
            using (EFShopDbContext context = new EFShopDbContext())
            {
                var p = context.Products.Find(Product.Id);
                p.Name = this.NameBox.Text;
                var shop = this.comboBox1.SelectedItem as Shop;
                p.ShopId = shop.Id;
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
