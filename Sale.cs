using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    class Sale
    {
        public Product product;
        public double priceSale;
        public double totalPrice;
        public int amount;
        public Seller seller;
        public string Comments;
        Product[] Sales = new Product[10];

        public void calculateTotal()
        {
            totalPrice = priceSale * amount;

        }
    }
}
