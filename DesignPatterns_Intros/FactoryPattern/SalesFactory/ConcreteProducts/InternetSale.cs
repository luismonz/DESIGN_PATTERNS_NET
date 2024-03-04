using DesignPatterns_Intros.FactoryPattern.SalesFactory.IProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Intros.FactoryPattern.SalesFactory.ConcreteProducts
{
    public class InternetSale : ISale
    {

        private decimal _discount;

        public InternetSale(decimal discount) { 
            this._discount = discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"INTERNET SALE HAS AN AMOUNT OF {total} - {_discount} =  {total - _discount}");
        }

    }
}
