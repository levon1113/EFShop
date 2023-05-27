using EFShop.Data.Context;
using EFShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFShop.UI
{
    public partial class Form1 : Form
    {
        FormAdd formAdd = new FormAdd();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            formAdd.ShowDialog();
            formAdd.FormClosed += MyFormClosed;
        }
        private void MyFormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateList();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            int index = this.comboBox1.SelectedIndex + 1;
            if (index != -1)
            {
                using (EFShopDbContext context = new EFShopDbContext())
                {
                    var shop = context.Shops.Find(index);
                    if (shop != null)
                        context.Entry(shop).Collection(b => b.Products).Load();
                    var sortedProducts = shop.Products;
                    this.listBox1.Items.Clear();
                    foreach (var item in sortedProducts)
                    {
                        this.listBox1.Items.Add(item);
                    }
                }

            }
            
        }

        public void UpdateList()
        {
            this.listBox1.Items.Clear();
            this.comboBox1.Items.Clear();
            using (EFShopDbContext db = new EFShopDbContext())
            {
                var products = db.Products.Include(b => b.Shop);
                foreach (var item in products)
                {
                    this.listBox1.Items.Add(item);
                }

                var shops = db.Shops.ToList();
                foreach (var item in shops)
                {
                    this.comboBox1.Items.Add(item);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select product");

            }
            else
            {
                var prod = this.listBox1.SelectedItem as Product;
                
                using (EFShopDbContext context = new EFShopDbContext())
                {
                    Product? product = context.Products.Find(prod?.Id);
                    if (product != null)
                        context.Products.Remove(product);
                    context.SaveChanges();
                }
                UpdateList();
            }
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select product");
            }
            else
            {
                UpdateForm updateForm = new UpdateForm();
                var prod = this.listBox1.SelectedItem as Product;
                using (EFShopDbContext context = new EFShopDbContext())
                {
                    Product? product = context.Products.Find(prod?.Id);
                    if (product != null)
                        updateForm.Product = product;
                }
                updateForm.ShowDialog();
                updateForm.FormClosed += MyFormClosed;
            }
            

        }
    }
}