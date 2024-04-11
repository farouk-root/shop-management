using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopManagement.controller;
using ShopManagement.model.Shop;

namespace ShopManagement.view.Shop
{
    public partial class ShopAdmin : UserControl
    {
        private ShopController shopController; 
        private BindingSource shopsBindingSource = new BindingSource();

        // This will store data  after click on data grid row :
        private long ID = 0;
        private string name = "";
        private string location = "";
        private string contact = "";

        public ShopAdmin()
        {
            InitializeComponent();
            shopController = new ShopController(); 
            shopsBindingSource.DataSource = null; 
            dataGridView_Shops.DataSource = shopsBindingSource; 
            LoadShopsData(); 
        }

        private void ClearShopDetails()
        {
            this.ID = 0;
            this.name = "";
            this.location = "";
            this.contact = "";
            textBox_nameShop.Text = "";
            textBox_locationShop.Text = "";
            textBox_contactShop.Text = "";
        }

        private void LoadShopsData()
        {
            List<ShopModel> shops = shopController.GetAllShops();
            shopsBindingSource.DataSource = shops;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string name = textBox_nameShop.Text;
            string location = textBox_locationShop.Text;
            string contact = textBox_contactShop.Text;
            ShopModel newshop = new ShopModel(name, location, contact);
            if (shopController.AddShop(newshop))
            {
                MessageBox.Show("Shop added successfully!", "Shop Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadShopsData();
            }
            else
            {
                MessageBox.Show("Failed to add shop. Please try again.", "Shop Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Shops_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView_Shops.Rows[e.RowIndex];

                // Get data from selected row cells
                ID = Convert.ToInt64(row.Cells[0].Value); // Assuming ID is in column 0
                name = row.Cells[1].Value.ToString();
                location = row.Cells[2].Value.ToString();
                contact = row.Cells[3].Value.ToString();

                // Update your UI or perform actions with retrieved data 
                textBox_nameShop.Text = name;
                textBox_locationShop.Text = location;
                textBox_contactShop.Text = contact;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (ID > 0) // Check if a shop is selected (ID should be greater than 0)
            {
                string name = textBox_nameShop.Text;
                string location = textBox_locationShop.Text;
                string contact = textBox_contactShop.Text;

                ShopModel updatedShop = new ShopModel(ID, name, location, contact);

                if (shopController.UpdateShop(updatedShop))
                {
                    MessageBox.Show("Shop updated successfully!", "Shop Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadShopsData(); // Refresh data grid to reflect changes
                }
                else
                {
                    MessageBox.Show("Failed to update shop. Please try again.", "Shop Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a shop to update.", "Shop Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (ID > 0) // Check if a shop is selected (ID should be greater than 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this shop?", "Shop Management", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (shopController.DeleteShop(ID))
                    {
                        MessageBox.Show("Shop deleted successfully!", "Shop Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadShopsData(); // Refresh data grid to reflect changes
                        ClearShopDetails(); // Optionally clear shop details from UI after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete shop. Please try again.", "Shop Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a shop to delete.", "Shop Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            string criteria = comboBox_critere.SelectedItem.ToString();

            Console.WriteLine(criteria);

            // Call the search function from controller and update data grid
            List<ShopModel> searchedShops = shopController.SearchShops(criteria, searchText);
            shopsBindingSource.DataSource = searchedShops; // Update data source for the grid
            LoadShopsData(); 
        }
    }
}
