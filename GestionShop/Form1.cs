using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionShop.Shop;

namespace GestionShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Shop_Click(object sender, EventArgs e)
        {
            HomePanel.Controls.Clear();
            UserControl ShopCrud = new ShopView();
            HomePanel.Controls.Add(ShopCrud);
            ShopCrud.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("heelo");
        }
    }
}
