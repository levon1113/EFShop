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
    public partial class AddShopForm : Form
    {
        public AddShopForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" )
            {
                MessageBox.Show("Input Name!");
            }
            else
            {
                using (EFShopDbContext context = new EFShopDbContext())
                {
                    Shop shop = new Shop()
                    {
                        Name = textBox1.Text,
                    };
                    context.Shops.Add(shop) ;
                    textBox1.Text = "";

                    context.SaveChanges();
                }
                this.Close();
            }
        }
        
    }
}
