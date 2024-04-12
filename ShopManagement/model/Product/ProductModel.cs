using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopManagement.model.Product
{
    public class ProductModel
    {
        public long IDPRODUIT { get; set; }
        public long IDSTOCK { get; set; }
        public string NOMPRODUIT { get; set; }
        public long PRIXPRODUIT { get; set; }
        public string DESCRIPTIONPRODUIT { get; set; }
        public string CATEGORYPRODUIT { get; set; }

        public ProductModel()
        {
        }
        public ProductModel(long idP, long idS, string name, long price, string desc, string category)
        {
            this.IDPRODUIT = idP;
            this.IDSTOCK = idS;
            this.NOMPRODUIT = name;
            this.PRIXPRODUIT = price;
            this.DESCRIPTIONPRODUIT = desc;
            this.CATEGORYPRODUIT = category;
        }
        public ProductModel( long idS, string name, long price, string desc, string category)
        {
            this.IDSTOCK = idS;
            this.NOMPRODUIT = name;
            this.PRIXPRODUIT = price;
            this.DESCRIPTIONPRODUIT = desc;
            this.CATEGORYPRODUIT = category;
        }

    }
}
