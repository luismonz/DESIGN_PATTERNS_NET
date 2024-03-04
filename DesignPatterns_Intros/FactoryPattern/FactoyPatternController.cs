using DesignPatterns_Intros.FactoryPattern.SalesFactory.AbstractFactory;
using DesignPatterns_Intros.FactoryPattern.SalesFactory.ConcreteFactories;
using DesignPatterns_Intros.FactoryPattern.SalesFactory.ConcreteProducts;
using DesignPatterns_Intros.FactoryPattern.SalesFactory.IProducts;
using DesignPatterns_Intros.FactoryPattern.SimpleImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Intros.FactoryPattern
{
    public class FactoyPatternController
    {
        private Random _randomNumGenerator;
        public FactoyPatternController() { 
            _randomNumGenerator = new Random();
        }

        public void SimpleFactoryDemo()
        {
            SimpleSportFactory simpleSportFactory = new SimpleSportFactory();
            simpleSportFactory.CreateSport("football");
            simpleSportFactory.CreateSport("basketball");
        }

        public void SalesFactoryDemo(int randomSalesToGenerate)
        {
            for (int i = 0; i < randomSalesToGenerate; i++)
            {
                decimal total = (decimal)_randomNumGenerator.Next(1, 1000);
                int randomNumber = _randomNumGenerator.Next(1, 3);

                if (randomNumber == 1)
                {
                    decimal randomDiscount = (decimal)_randomNumGenerator.Next(1, 100);
                    GenerateInternetSale(randomDiscount, total);
                }
                if (randomNumber == 2)
                {
                    decimal extraAmount = (decimal)_randomNumGenerator.Next(1, 100);
                    GeneratePhysicalStoreSale(extraAmount, total);
                }
            }
        }

        private void GenerateInternetSale(decimal discount, decimal total)
        {
            AbstractSaleFactory abstractSaleFactory = new InternetSaleFactory(discount);
            ISale internetSale = abstractSaleFactory.GetSale();
            internetSale.Sell(total);
        }

        private void GeneratePhysicalStoreSale(decimal extraAmount, decimal total)
        {
            AbstractSaleFactory abstractSaleFactory = new PhysicalStoreSaleFactory(extra: extraAmount);
            ISale internetSale = abstractSaleFactory.GetSale();
            internetSale.Sell(total);
        }

    }
}
