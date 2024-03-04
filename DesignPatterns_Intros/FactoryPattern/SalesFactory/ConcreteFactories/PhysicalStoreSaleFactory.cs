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
    public class PhysicalStoreSaleFactory : AbstractSaleFactory
    {

        private decimal _extra;

        public PhysicalStoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new PhysicalStoreSale(_extra);
        }
    }
}
