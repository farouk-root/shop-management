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
using ShopManagement.model.Stock;

namespace ShopManagement.view.Shop
{
    public partial class StockShop : UserControl
    {
        ShopController shopController = new ShopController();
        private UserModel userData = new UserModel();
        StockController stockController = new StockController();
        private BindingSource stockBindingSource = new BindingSource();
        public StockShop(UserModel userData)
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

            stockBindingSource.DataSource = null;
            dataGridView_Stock.DataSource = stockBindingSource;
            LoadStocksData();
        }
        private void LoadStocksData()
        {
            List<StockModel> stocks = stockController.GetAllStocks(userData.IDSHOP);
            stockBindingSource.DataSource = stocks;
        }


        private void panel3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UserControl ProductsView = new ProductsShop(userData);
            this.Controls.Add(ProductsView);
            ProductsView.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Controls.Clear();
            UserControl HomeView = new ShopPlatform(userData);
            this.Controls.Add(HomeView);
            HomeView.Show();
        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            //StockModel newstock = new StockModel(userData.IDSHOP, 144, new DateTime(2025, 06, 01), "Shelf B", new DateTime(2024, 04, 20));
            double quantity;
            if (!double.TryParse(textBox_QuantityStock.Text, out quantity))
            {
                Console.WriteLine("Invalid quantity. Please enter a number.");
                return; // Exit if conversion fails
            }

            string locationStock = textBox_locationStock.Text;

            DateTime expirationDate;
            if (!DateTime.TryParse(dateTime_Expiration.Text, out expirationDate))
            {
                Console.WriteLine("Invalid expiration date format. Please use a valid date format.");
                return; // Exit if conversion fails
            }

            DateTime receivedDate;
            if (!DateTime.TryParse(dateTime_Received.Text, out receivedDate))
            {
                Console.WriteLine("Invalid received date format. Please use a valid date format.");
                return; // Exit if conversion fails
            }

            // Create StockModel with converted values
            StockModel newStock = new StockModel(userData.IDSHOP, quantity, expirationDate, locationStock, receivedDate);

            // Call AddStock method with the newStock object
            if (stockController.AddStock(newStock))
            {
                Console.WriteLine("Stock added successfully!");
                LoadStocksData();
            }
            else
            {
                Console.WriteLine("Failed to add stock.");
            }
        }
    }
}
