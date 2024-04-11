using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopManagement.view.Login;
using ShopManagement.model.User;
using ShopManagement.controller;

namespace ShopManagement.view.Shop
{
    public partial class ShopPlatform : UserControl
    {
        ShopController shopController = new ShopController();
        private UserModel userData = new UserModel();
        public ShopPlatform(UserModel userData)
        {
            InitializeComponent();
            this.userData = userData;

            if (userData != null) // Check if userData is available
            {
                label_user.Text = userData.Username; // Display username
                label7.Text = "Welcome To " + shopController.GetShopByID(userData.IDSHOP).NAMESHOP;
            }
            else
            {
                label_user.Text = "User data not available."; // Handle case where userData is null
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Controls.Clear();
            UserControl ProductsView = new ProductsShop(userData);
            this.Controls.Add(ProductsView);
            ProductsView.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UserControl ProductsView = new ProductsShop(userData);
            this.Controls.Add(ProductsView);
            ProductsView.Show();
        }

    }

}
