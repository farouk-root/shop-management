using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.OleDb;

namespace GestionShop.Utils
{
    public static class connection
    {
        public static OleDbConnection GetConnection()
        {
            const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\farouk\\Desktop\\ShopDB\\MLR21DB.accdb;Persist Security Info=False;";
            return new OleDbConnection(connectionString);
        }
    }
}

