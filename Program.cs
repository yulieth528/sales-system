using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Init            
            Product coat = new Product();
            coat.Name = "Coat";
            coat.Price = 500;

            Product sweatshirt = new Product();
            sweatshirt.Name = "Sweatshirt";
            sweatshirt.Price = 300;

            Product shoes = new Product();
            shoes.Name = " Shoes";
            shoes.Price = 150;

            Seller alejandro = new Seller();
            alejandro.name = "Alejandro";
            alejandro.age = 24;


            Seller ginna = new Seller();
            ginna.name = "Ginna";
            ginna.age = 19;


            Seller juliana = new Seller();
            juliana.name = "Juliana";
            juliana.age = 21;

            #endregion


            #region Sales
            Sales sales = new Sales();

            Sale initSale = new Sale();
            initSale.product = coat;
            initSale.seller = alejandro;
            initSale.priceSale = coat.Price;
            initSale.amount = 5;
            initSale.calculateTotal();
            coat.increaseAmount(initSale.amount);
            sales.SaveSale(initSale.product.Name, initSale.seller.name, initSale.priceSale, initSale.amount);

            Sale secondSale = new Sale();
            secondSale.product = coat;
            secondSale.seller = alejandro;
            secondSale.priceSale = coat.Price;
            secondSale.amount = 50;
            secondSale.calculateTotal();
            coat.increaseAmount(secondSale.amount);
            sales.SaveSale(secondSale.product.Name, secondSale.seller.name, secondSale.priceSale, secondSale.amount);


            Sale thirdSale = new Sale();
            thirdSale.product = shoes;
            thirdSale.seller = ginna;
            thirdSale.priceSale = shoes.Price;
            thirdSale.amount = 5;
            shoes.SaleAmount = thirdSale.amount;
            thirdSale.calculateTotal();
            sales.SaveSale(thirdSale.product.Name, thirdSale.seller.name, thirdSale.priceSale, thirdSale.amount);


            Sale fourthSale = new Sale();
            fourthSale.product = sweatshirt;
            fourthSale.seller = juliana;
            fourthSale.priceSale = sweatshirt.Price;
            fourthSale.amount = 5;
            sweatshirt.SaleAmount = fourthSale.amount;
            fourthSale.calculateTotal();
            sales.SaveSale(fourthSale.product.Name, fourthSale.seller.name, fourthSale.priceSale, fourthSale.amount);

            #endregion


            sales.GenerateSystemReports(coat, sweatshirt, shoes);
            sales.PrintSystemReports(shoes, coat, sweatshirt);









        }
    }
}