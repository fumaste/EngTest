using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngTest
{
    public class Shop
    {
        private const double importedTax = 0.05;

        private Dictionary<Item,Int32> cart;

        public Shop()
        {

            cart = new Dictionary<Item,Int32>();

        }

        public void AddToCart(string name,double price,bool imported,ItemCategory category, int quantity)
        {
            cart.Add(new Item(name, category, price, imported),quantity);
        }

        public string GetReceiptDetails()
        {
            string receiptDetails = "";
            double total = 0;
            double totalTaxes = 0;

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            if (cart.Count > 0)
            {
                foreach (var item in cart)
                {
                    Item currentItem = item.Key;
                    int quantity = item.Value;

                    double subTotalTaxes = quantity * currentItem.GetPrice() * currentItem.GetCategory().GetSalesTax();
                    if (currentItem.GetImported())
                    {
                        subTotalTaxes += quantity * currentItem.GetPrice() * importedTax;
                    }

                    subTotalTaxes = Math.Round(subTotalTaxes * 20,MidpointRounding.AwayFromZero) / 20;

                    double subTotal = quantity * currentItem.GetPrice() + subTotalTaxes;

                    totalTaxes += subTotalTaxes;
                    total += subTotal;

                    receiptDetails += String.Format("{0} {1}: {2}{3}", quantity, currentItem.GetName(), subTotal.ToString("0.00", nfi), System.Environment.NewLine);

                }

                receiptDetails += String.Format("Sales Taxes: {0}{1}", totalTaxes.ToString("0.00", nfi), System.Environment.NewLine);
                receiptDetails += String.Format("Total: {0}", total.ToString("0.00", nfi));
            }
            else
            {
                receiptDetails = "No Items in the Cart";
            }

            return receiptDetails;
        }

    }

}
