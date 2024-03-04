using DesignPatterns_Intros.FactoryPattern.SimpleImplementation.Sports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Intros.FactoryPattern.SimpleImplementation
{
    public class SimpleSportFactory
    {
        public ISport CreateSport(string sport)
        {
            sport = sport.ToLower();
            if (sport == "football") return new FootballSport();
            if (sport == "basketball") return new BasketballSport();
            throw new NotSupportedException("SPORT NOT SUPPORTED");
        }
    }
}
