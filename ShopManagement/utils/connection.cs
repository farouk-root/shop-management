using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ShopManagement.utils
{
    public static class Connection
    {
        public static OleDbConnection GetConnection()
        {
            const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\farouk\\Desktop\\Emna\\ShopManagement\\ShopManagement\\NEWSHOP.accdb;Persist Security Info=False;";
            return new OleDbConnection(connectionString);
        }
    }
}
