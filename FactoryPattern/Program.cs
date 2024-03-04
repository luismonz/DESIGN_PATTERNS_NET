using FactoryPattern.Controllers;
using FactoryPattern.Space;
using FactoryPattern.Weapons;

namespace FactoryPattern;


public static class Program
{
    public static void Main(string[] args)
    {
        MenuController menu = new MenuController();
        menu.ShowMenu();        
    }

    public static MetricSpace SetMetricSpace()
    {
        Coordinates MinCoords = new Coordinates(0, 0);
        Coordinates MaxCoords = new Coordinates(100, 100);
        MetricSpace Space = new MetricSpace(MinCoords, MaxCoords);
        return Space;
    }

}
