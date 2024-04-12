using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopManagement.utils;
using System.Data.OleDb;
using ShopManagement.model.Stock;
namespace ShopManagement.controller
{
    class StockController
    {
        public bool AddStock(StockModel stock)
        {
            bool successful = false;

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string insertQuery = @"
                      INSERT INTO STOCK (IDSHOP, QUANTITY, EXPIRATIONDATE, LOCATIONSTOCK, RECEIVEDAT)
                      VALUES (@IDShop, @Quantity, @ExpirationDate, @Location, @ReceivedDate)";

                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    
                    command.Parameters.AddWithValue("@IDShop", stock.IDSHOP);
                    command.Parameters.AddWithValue("@Quantity", stock.QUANTITY);
                    command.Parameters.AddWithValue("@ExpirationDate", stock.EXPIRATIONDATE);
                    command.Parameters.AddWithValue("@Location", stock.LOCATIONSTOCK);
                    command.Parameters.AddWithValue("@ReceivedDate", stock.RECEIVEDAT);

                    int rowsAffected = command.ExecuteNonQuery();
                    successful = (rowsAffected == 1); // Successful if 1 row affected (newly inserted stock)
                }
            }

            return successful;
        }

        public List<StockModel> GetAllStocks(long IDSHOP)
        {
            List<StockModel> stocks = new List<StockModel>();

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM STOCK WHERE IDSHOP = @IDSHOP";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@IDSHOP", IDSHOP);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long idStock = Convert.ToInt64(reader["IDSTOCK"]);
                            long idShop = Convert.ToInt64(reader["IDSHOP"]);
                            double quantity = Convert.ToDouble(reader["QUANTITY"]);
                            DateTime expirationDate = Convert.ToDateTime(reader["EXPIRATIONDATE"]);
                            string locationStock = reader["LOCATIONSTOCK"].ToString();
                            DateTime receivedDate = Convert.ToDateTime(reader["RECEIVEDAT"]); // Assuming RECEIVEDAT is a typo for RECEIVEDDATE

                            StockModel stock = new StockModel(idStock, idShop, quantity, expirationDate, locationStock, receivedDate);
                            stocks.Add(stock);
                        }
                    }
                }
            }

            return stocks;
        }

        public StockModel GetStockByLocation(string locationStock)
        {
            StockModel stock = null; // Initialize to null if not found

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM STOCK WHERE LOCATIONSTOCK = @Location";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Location", locationStock);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            long idStock = Convert.ToInt64(reader["IDSTOCK"]);
                            long idShop = Convert.ToInt64(reader["IDSHOP"]);
                            double quantity = Convert.ToDouble(reader["QUANTITY"]);
                            DateTime expirationDate = Convert.ToDateTime(reader["EXPIRATIONDATE"]);
                            string location = reader["LOCATIONSTOCK"].ToString(); // Assuming no typo here
                            DateTime receivedDate = Convert.ToDateTime(reader["RECEIVEDAT"]);

                            stock = new StockModel(idStock, idShop, quantity, expirationDate, location, receivedDate);
                        }
                    }
                }
            }

            return stock;
        }

        public StockModel GetStockByID(long stockID)
        {
            StockModel stock = null; // Initialize to null if not found

            using (OleDbConnection connection = Connection.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM STOCK WHERE IDSTOCK = @StockID";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@StockID", stockID);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            long idStock = Convert.ToInt64(reader["IDSTOCK"]);
                            long idShop = Convert.ToInt64(reader["IDSHOP"]);
                            double quantity = Convert.ToDouble(reader["QUANTITY"]);
                            DateTime expirationDate = Convert.ToDateTime(reader["EXPIRATIONDATE"]);
                            string locationStock = reader["LOCATIONSTOCK"].ToString();
                            DateTime receivedDate = Convert.ToDateTime(reader["RECEIVEDAT"]);

                            stock = new StockModel(idStock, idShop, quantity, expirationDate, locationStock, receivedDate);
                        }
                    }
                }
            }

            return stock;
        }



    }
}
