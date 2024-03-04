using DesignPatterns_Intros.FactoryPattern;

namespace DesignPatterns_Intros;


public static class Program
{
    public static void Main(string[] args)
    {
        FactoryPatternDemo();
    }

    public static void FactoryPatternDemo()
    {
        FactoyPatternController controller = new FactoyPatternController();
        //controller.SimpleFactoryDemo();
        controller.SalesFactoryDemo(10);
        Console.ReadLine();
    }

}
