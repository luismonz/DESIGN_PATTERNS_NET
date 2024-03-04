using DesignPatterns_Intros.FactoryPattern.SalesFactory.IProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Intros.FactoryPattern.SalesFactory.ConcreteProducts
{
    public class PhysicalStoreSale : ISale
    {
        private decimal _extra;
        
        public PhysicalStoreSale(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"STORE SALE HAS AN AMOUNT OF {total} + {_extra} = {total + _extra}");
        }
    }
}
