using EFShop.Data.Context;
using EFShop.Data.Entities;

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
                    var sortedProducts = context.Products.Where(b => b.ShopId == index);
                    this.listBox1.Items.Clear();
                    Shop? shop = context.Shops.Where(b => b.Id == index).FirstOrDefault();
                    if (shop != null)
                        foreach (var item in sortedProducts)
                        {
                            this.listBox1.Items.Add($"{item.Name}: {shop.Name}");
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
                var products = db.Products.ToList();
                foreach (var item in products)
                {
                    Shop? shop = db.Shops.Where(b => b.Id == item.ShopId).FirstOrDefault() as Shop;
                    if (shop != null)
                        this.listBox1.Items.Add($"{item.Name}: {shop.Name}");
                    else
                        this.listBox1.Items.Add($"{item.Name}: X");

                }

                var shops = db.Shops.ToList();
                foreach (var item in shops)
                {
                    this.comboBox1.Items.Add(item.Name);
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
                string name = this.listBox1.SelectedItem.ToString().Split(":")[0].Trim();
                using (EFShopDbContext context = new EFShopDbContext())
                {
                    Product? product = context.Products.Where(b => b.Name == name).FirstOrDefault();
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
                string name = this.listBox1.SelectedItem.ToString().Split(":")[0].Trim();
                using (EFShopDbContext context = new EFShopDbContext())
                {
                    Product? product = context.Products.Where(b => b.Name == name).FirstOrDefault();
                    if (product != null)
                        updateForm.Product = product;
                }
                updateForm.ShowDialog();
                updateForm.FormClosed += MyFormClosed;
            }
            

        }
    }
}