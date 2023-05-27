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
                var shops = context.Shops.ToList();
                foreach (var item in shops)
                {
                    this.comboBox1.Items.Add(item);
                }
            }
            this.comboBox1.SelectedIndex = (int)Product.ShopId - 1;

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            
            using (EFShopDbContext context = new EFShopDbContext())
            {
                var p = context.Products.Where(b => b.Name == Product.Name).FirstOrDefault();
                p.Name = this.NameBox.Text;
                p.ShopId = this.comboBox1.SelectedIndex + 1;
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
