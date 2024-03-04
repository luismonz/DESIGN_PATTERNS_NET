using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Intros.FactoryPattern.SalesFactory.IProducts
{
    public interface ISale
    {
        void Sell(decimal total);
    }
}
