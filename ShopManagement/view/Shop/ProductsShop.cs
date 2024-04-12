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
using ShopManagement.model.Product;

namespace ShopManagement.view.Shop
{
    public partial class ProductsShop : UserControl
    {
        private UserModel userData = new UserModel();
        ShopController shopController = new ShopController();
        StockController stockController = new StockController();
        ProductController productController = new ProductController();
        private BindingSource ProductsBindingSource = new BindingSource();
        
        //Product Data 
        public long IDPRODUIT { get; set; }

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
            FillShopComboBox();
            comboBox_Stocks.SelectedIndex = 0;
            comboBox_categoryP.SelectedIndex = 0;
            ProductsBindingSource.DataSource = null;
            dataGridView_Products.DataSource = ProductsBindingSource;
            LoadData();
        }
        private void LoadData()
        {
            List<ProductModel> products = productController.GetAllProductsByShop(userData.IDSHOP);
            ProductsBindingSource.DataSource = products;
        }

        private void FillShopComboBox()
        {
            ShopController shopController = new ShopController();

            List<StockModel> stocks = stockController.GetAllStocks(userData.IDSHOP);

            comboBox_Stocks.Items.Clear();

            foreach (StockModel stock in stocks)
            {
                comboBox_Stocks.Items.Add(stock.LOCATIONSTOCK); // Assuming ShopModel has a Name property
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UserControl StockView = new StockShop(userData);
            this.Controls.Add(StockView);
            StockView.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //StockModel s = stockController.GetStockByLocation("Bizerte");
            //Console.WriteLine(s.IDSTOCK);
            string nameProduit = textBox_nameP.Text; 
            int price;
            if (!int.TryParse(textBox_priceP.Text, out price))
            {
                Console.WriteLine("Invalid quantity. Please enter a number.");
                return; // Exit if conversion fails
            }
            string category = comboBox_categoryP.Text;
            long idStock = stockController.GetStockByLocation(comboBox_Stocks.Text).IDSTOCK;
            string Description = richTextBox_decriptionP.Text;

            ProductModel newProduct = new ProductModel(idStock, nameProduit, price, Description, category);
            if (productController.AddProduct(newProduct))
            {
                Console.WriteLine("Product Added !");
                LoadData();
                ClearProductDetails();
            }

        }

        private void ClearProductDetails()
        {
            //this.ID = 0;
            //this.name = "";
            //this.location = "";
            //this.contact = "";
            textBox_nameP.Text = "";
            textBox_priceP.Text = "";
            comboBox_Stocks.SelectedIndex = 0;
            comboBox_categoryP.SelectedIndex = 0;
            richTextBox_decriptionP.Text = "";
        }

        private void FillProductDetails(ProductModel p)
        {
            textBox_nameP.Text = p.NOMPRODUIT;
            textBox_priceP.Text = p.PRIXPRODUIT.ToString();
            comboBox_Stocks.Text = stockController.GetStockByID(p.IDSTOCK).LOCATIONSTOCK;
            comboBox_categoryP.Text = p.CATEGORYPRODUIT;
            richTextBox_decriptionP.Text = p.DESCRIPTIONPRODUIT;
        }

        private void dataGridView_Products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Products.Rows[e.RowIndex];
                IDPRODUIT = Convert.ToInt64(row.Cells[0].Value);
                ProductModel getPdata = productController.GetProductByID(IDPRODUIT);
                FillProductDetails(getPdata);
                //Console.WriteLine(stockController.GetStockByID(p.IDSTOCK).LOCATIONSTOCK);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string nameProduit = textBox_nameP.Text;
            int price;
            if (!int.TryParse(textBox_priceP.Text, out price))
            {
                Console.WriteLine("Invalid quantity. Please enter a number.");
                return; // Exit if conversion fails
            }
            string category = comboBox_categoryP.Text;
            long idStock = stockController.GetStockByLocation(comboBox_Stocks.Text).IDSTOCK;
            string Description = richTextBox_decriptionP.Text;

            ProductModel newProduct = new ProductModel(IDPRODUIT,idStock, nameProduit, price, Description, category);
            if (productController.UpdateProduct(newProduct))
            {
                Console.WriteLine("Product Updated !");
                LoadData();
                ClearProductDetails();
            }
            else
                Console.WriteLine("no update");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            if (productController.DeleteProduct(IDPRODUIT))
            {
                Console.WriteLine("Product Updated !");
                LoadData();
                ClearProductDetails();
            }
        }


    }
}
