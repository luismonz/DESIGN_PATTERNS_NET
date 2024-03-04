using DesignPatterns_Intros.FactoryPattern.SalesFactory.IProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Intros.FactoryPattern.SalesFactory.AbstractFactory
{
    public abstract class AbstractSaleFactory
    {
        public abstract ISale GetSale();
    }
}
