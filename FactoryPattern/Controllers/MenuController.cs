using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Controllers
{
    public class MenuController
    {

        private IDictionary<int, Action> _menuOptions;

        public MenuController() {
            _menuOptions = new Dictionary<int, Action>
            {
                { 1, RandomMode },
                { 2, SelectDifficultyMode },
                { 3, ByEnemyTypesMode },
                { 0, () => Console.WriteLine("Exiting...") }
            };
        }

        public void ShowMenu()
        {
            int option;

            do
            {
                Console.WriteLine("WELCOME TO EVIL VEHICLES");
                Console.WriteLine("1. RANDOM MODE");
                Console.WriteLine("2. SELECT DIFFICULT MODE");
                Console.WriteLine("3. BY ENEMY TYPES");
                Console.WriteLine("0. EXIT");
                Console.Write("Please select an option: ");

                option = int.Parse(Console.ReadLine());

                if (_menuOptions.ContainsKey(option))
                {
                    _menuOptions[option]();
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

                Console.WriteLine();

            } while (option != 0);
        }

        private void RandomMode()
        {
            Console.WriteLine("Entering Random Mode...\n");
            DirtyRandomController controller = new DirtyRandomController(); // CHANGE WITH RANDOM MODE AFTER IMPLEMENTING FACTORY
            controller.RandomEnemiesMode(100);
        }

        private void SelectDifficultyMode()
        {
            int difficultyOption;

            Console.WriteLine("Select Difficulty Mode");
            Console.WriteLine("1. EASY");
            Console.WriteLine("2. MEDIUM");
            Console.WriteLine("3. HARD");
            Console.Write("Please select a difficulty level: ");
            difficultyOption = int.Parse(Console.ReadLine());

            // CODE
        }

        private void ByEnemyTypesMode()
        {
            int enemyTypeOption;

            Console.WriteLine("Select Enemy Type");
            Console.WriteLine("1. EVIL CAR");
            Console.WriteLine("2. EVIL HELICOPTER");
            Console.Write("Please select an enemy type: ");
            enemyTypeOption = int.Parse(Console.ReadLine());

            // CODE
        }

    }
}
