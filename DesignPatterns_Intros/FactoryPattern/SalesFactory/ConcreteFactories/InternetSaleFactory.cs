using DesignPatterns_Intros.FactoryPattern.SalesFactory.AbstractFactory;
using DesignPatterns_Intros.FactoryPattern.SalesFactory.ConcreteProducts;
using DesignPatterns_Intros.FactoryPattern.SalesFactory.IProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Intros.FactoryPattern.SalesFactory.ConcreteFactories
{
    public class InternetSaleFactory : AbstractSaleFactory
    {

        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }
}
