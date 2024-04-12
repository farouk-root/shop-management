using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopManagement.model.Stock
{
    public class StockModel
    {
        public long IDSTOCK { get; set; }
        public long IDSHOP { get; set; }
        public double QUANTITY { get; set; } 
        public DateTime EXPIRATIONDATE { get; set; }
        public string LOCATIONSTOCK { get; set; }
        public DateTime RECEIVEDAT { get; set; }

        public StockModel(long idStock, long idShop, double quantity, DateTime expirationDate, string location, DateTime receivedDate)
        {
            this.IDSTOCK = idStock;
            this.IDSHOP = idShop;
            this.QUANTITY = quantity;
            this.EXPIRATIONDATE = expirationDate;
            this.LOCATIONSTOCK = location;
            this.RECEIVEDAT = receivedDate;
        }

        public StockModel( long idShop, double quantity, DateTime expirationDate, string location, DateTime receivedDate)
        {
            this.IDSHOP = idShop;
            this.QUANTITY = quantity;
            this.EXPIRATIONDATE = expirationDate;
            this.LOCATIONSTOCK = location;
            this.RECEIVEDAT = receivedDate;
        }

        // You can add additional methods here if needed (e.g., methods for calculating remaining stock, checking for expired items)
    }

}
