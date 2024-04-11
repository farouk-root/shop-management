using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopManagement.model.User;
using ShopManagement.controller;

namespace ShopManagement.view.Shop
{
    public partial class ProductsShop : UserControl
    {
        private UserModel userData = new UserModel();
        ShopController shopController = new ShopController();
        public ProductsShop(UserModel userData)
        {
            InitializeComponent();
            this.userData = userData;

            if (userData != null) // Check if userData is available
            {
                label_user.Text = userData.Username; // Display username
                //label7.Text = "Welcome To " + shopController.GetShopByID(userData.IDSHOP).NAMESHOP;
            }
            else
            {
                label_user.Text = "User data not available."; // Handle case where userData is null
            }
        }


    }
}
