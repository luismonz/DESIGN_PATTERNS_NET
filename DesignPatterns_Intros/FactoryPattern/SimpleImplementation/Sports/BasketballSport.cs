using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Intros.FactoryPattern.SimpleImplementation.Sports
{
    public class BasketballSport : ISport
    {
        public string GetSportName()
        {
            return "BASKEEEEEETBALL!";
        }
    }
}
