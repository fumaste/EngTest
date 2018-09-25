using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngTest;

namespace UnitTest
{
    [TestClass]
    public class EngTestTest
    {
        [TestMethod]
        public void Input1()
        {
            Shop shop = new Shop();
            shop.AddToCart("book", 12.49, false, Categories.Books, 1);
            shop.AddToCart("music CD", 14.99, false, Categories.Multimedia, 1);
            shop.AddToCart("chocolate", 0.85, false, Categories.Foods, 1);

            string result = shop.GetReceiptDetails();

            string expected= "1 book: 12.49\r\n1 music CD: 16.49\r\n1 chocolate: 0.85\r\nSales Taxes: 1.50\r\nTotal: 29.83";


            Assert.IsTrue(result.Equals(expected));
        }

        [TestMethod]
        public void Input2()
        {
            Shop shop = new Shop();
            shop.AddToCart("imported box of chocolates", 10.00, true, Categories.Foods, 1);
            shop.AddToCart("imported bottle of perfume", 47.50, true, Categories.Beauty, 1);

            string result = shop.GetReceiptDetails();

            string expected = "1 imported box of chocolates: 10.50\r\n1 imported bottle of perfume: 54.65\r\nSales Taxes: 7.65\r\nTotal: 65.15";

            Assert.IsTrue(result.Equals(expected));
        }

        [TestMethod]
        public void Input3()
        {
            Shop shop = new Shop();
            shop.AddToCart("imported bottle of perfume", 27.99, true, Categories.Beauty, 1);
            shop.AddToCart("bottle of perfume", 18.99, false, Categories.Beauty, 1);
            shop.AddToCart("packet of headache pills", 9.75, false, Categories.Medical, 1);
            shop.AddToCart("imported box of chocolates", 11.25, true, Categories.Foods, 1);

            string result = shop.GetReceiptDetails();

            string expected = "1 imported bottle of perfume: 32.19\r\n1 bottle of perfume: 20.89\r\n1 packet of headache pills: 9.75\r\n1 imported box of chocolates: 11.85\r\nSales Taxes: 6.70\r\nTotal: 74.68";

            Assert.IsTrue(result.Equals(expected));
        }

    }
}
