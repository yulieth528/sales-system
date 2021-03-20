using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    class Sales
    {
        #region Mat
        private double less = 9999999999.0;// 50.0
        private string vendorname;
        private double halfprice;
        private double higher;
        private string majorname;
        private string majorpname;



        string[] matrizProd = new string[4] { "null", "null", "null", "null" };
        string[] matrizSell = new string[4] { "null", "null", "null", "null" };
        double[] matrizPrice = new double[4] { 0.0, 0.0, 0.0, 0.0 };
        int[] matrizAmount = new int[4] { 0, 0, 0, 0 };

        #endregion

        #region Metodos

        public void SaveSale(string prod, string Sell, double unitPrice, int amountSell)

        {
            for (int i = 0; i < matrizProd.Length; i++)
            {
                if (matrizProd[i] == "null")
                {
                    matrizProd[i] = prod;
                    matrizSell[i] = Sell;
                    matrizPrice[i] = unitPrice;
                    matrizAmount[i] = amountSell;
                    break;
                }
            }
        }

        public void VerifyMinor()
        {
            for (int i = 0; i < matrizPrice.Length; i++)
            {
                if (matrizPrice[i] < less)
                {
                    less = matrizPrice[i];
                    vendorname = matrizSell[i];
                }

            }
        }
        public void VerifyMajor()
        {
            for (int i = 0; i < matrizPrice.Length; i++)
            {
                if (matrizPrice[i] > higher)
                {
                    higher = matrizPrice[i];
                    majorname = matrizSell[i];
                    majorpname = matrizProd[i];

                }

            }
        }

        public void CalcularPrecioMedio(Product first, Product second, Product third)
        {

            halfprice = ((first.Price + second.Price + third.Price) / 3);

        }


        public void GenerateSystemReports(Product first, Product second, Product third)
        {
            VerifyMinor();
            VerifyMajor();
            CalcularPrecioMedio(first, second, third);

        }


        public void PrintSystemReports(Product shoes, Product coat, Product sweatshirt)
        {
            Console.WriteLine("What is the name of the seller who made the sale of the cheapest product?");
            Console.WriteLine("Answer: the seller was {0} and the product value is {1}", vendorname, less);
            Console.WriteLine("What is the average price of the products?");
            Console.WriteLine("Answer: The average price of the products is {0} ", halfprice);
            Console.WriteLine("How many units of the product have been sold?  ");
            Console.WriteLine("Shoes = {0}  Coat = {1}  Sweatshirt = {2}", shoes.SaleAmount, coat.SaleAmount, sweatshirt.SaleAmount);
            Console.WriteLine("What is the most expensive product?");
            Console.WriteLine("The most expensive product was sold for {0} the product name is {2} and its value is {1}", majorname, higher, majorpname);





        }

        #endregion
    }
}