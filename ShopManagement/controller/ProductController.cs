using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopManagement.utils;
using System.Data.OleDb;
using ShopManagement.model.Product;


namespace ShopManagement.controller
{
    class ProductController
    {
        public bool AddProduct(ProductModel product)
        {
            bool successful = false;

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string insertQuery = @"
      INSERT INTO PRODUIT (IDSTOCK, NOMPRODUIT, PRIXPRODUIT, DESCRIPTIONPRODUIT, CATEGORYPRODUIT)
      VALUES (@IDStock, @NomProduit, @PrixProduit, @DescriptionProduit, @CategoryProduit)";

                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@IDStock", product.IDSTOCK);
                    command.Parameters.AddWithValue("@NomProduit", product.NOMPRODUIT);
                    command.Parameters.AddWithValue("@PrixProduit", product.PRIXPRODUIT);
                    command.Parameters.AddWithValue("@DescriptionProduit", product.DESCRIPTIONPRODUIT);
                    command.Parameters.AddWithValue("@CategoryProduit", product.CATEGORYPRODUIT);

                    int rowsAffected = command.ExecuteNonQuery();
                    successful = (rowsAffected == 1); // Successful if 1 row affected (newly inserted product)
                }
            }

            return successful;
        }

        public List<ProductModel> GetAllProductsByShop(long shopID)
        {
            List<ProductModel> products = new List<ProductModel>();

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string selectQuery = @"
      SELECT p.*
      FROM PRODUIT p
      INNER JOIN STOCK s ON p.IDSTOCK = s.IDSTOCK
      WHERE s.IDSHOP = @ShopID"; // Filter by shop ID
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@ShopID", shopID);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long idProduit = Convert.ToInt64(reader["IDPRODUIT"]);
                            long idStock = Convert.ToInt64(reader["IDSTOCK"]);
                            string nomProduit = reader["NOMPRODUIT"].ToString();
                            long prixProduit = Convert.ToInt64(reader["PRIXPRODUIT"]);
                            string descriptionProduit = reader["DESCRIPTIONPRODUIT"].ToString();
                            string categoryProduit = reader["CATEGORYPRODUIT"].ToString();

                            ProductModel product = new ProductModel(idProduit, idStock, nomProduit, prixProduit, descriptionProduit, categoryProduit);
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        public ProductModel GetProductByID(long productID)
        {
            ProductModel product = null; // Initialize to null if not found

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM PRODUIT WHERE IDPRODUIT = @ProductID";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productID);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            long idProduit = Convert.ToInt64(reader["IDPRODUIT"]);
                            long idStock = Convert.ToInt64(reader["IDSTOCK"]);
                            string nomProduit = reader["NOMPRODUIT"].ToString();
                            long prixProduit = Convert.ToInt64(reader["PRIXPRODUIT"]);
                            string descriptionProduit = reader["DESCRIPTIONPRODUIT"].ToString();
                            string categoryProduit = reader["CATEGORYPRODUIT"].ToString();

                            product = new ProductModel(idProduit, idStock, nomProduit, prixProduit, descriptionProduit, categoryProduit);
                        }
                    }
                }
            }

            return product;
        }

        public bool UpdateProduct(ProductModel product)
        {
            bool successful = false;

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string updateQuery = @"
      UPDATE PRODUIT
      SET IDSTOCK = @IDStock, NOMPRODUIT = @NomProduit, PRIXPRODUIT = @PrixProduit,
          DESCRIPTIONPRODUIT = @DescriptionProduit, CATEGORYPRODUIT = @CategoryProduit
      WHERE IDPRODUIT = @ProductID";

                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@IDStock", product.IDSTOCK);
                    command.Parameters.AddWithValue("@NomProduit", product.NOMPRODUIT);
                    command.Parameters.AddWithValue("@PrixProduit", product.PRIXPRODUIT);
                    command.Parameters.AddWithValue("@DescriptionProduit", product.DESCRIPTIONPRODUIT);
                    command.Parameters.AddWithValue("@CategoryProduit", product.CATEGORYPRODUIT);
                    command.Parameters.AddWithValue("@ProductID", product.IDPRODUIT);

                    int rowsAffected = command.ExecuteNonQuery();
                    successful = (rowsAffected == 1); // Successful if 1 row affected (updated product)
                }
            }

            return successful;
        }

        public bool DeleteProduct(long productID)
        {
            bool successful = false;

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string deleteQuery = "DELETE FROM PRODUIT WHERE IDPRODUIT = @ProductID";
                using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productID);
                    int rowsAffected = command.ExecuteNonQuery();
                    successful = (rowsAffected == 1); // Successful if 1 row affected (deleted product)
                }
            }

            return successful;
        }





    }
}
