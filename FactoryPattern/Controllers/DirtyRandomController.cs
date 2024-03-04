using FactoryPattern.Boosters;
using FactoryPattern.EnemyVehicles;
using FactoryPattern.Space;
using FactoryPattern.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Controllers
{
    public class DirtyRandomController
    {

        private List<IEnemyVehicle> _enemies;

        public DirtyRandomController() {
            this._enemies = new List<IEnemyVehicle>();
        }

        public void RandomEnemiesMode(int enemiesToGenerate)
        {
            if (enemiesToGenerate <= 0) throw new Exception("NOT ALLOWED NUMBER OF ENEMIES TO GENERATE");
            for (int i = 0; i < enemiesToGenerate; i++) GenerateEnemyRandomly();
            ListRandomEnemies();
        }

        private void ListRandomEnemies()
        {
            _enemies.ForEach(vehicle =>
            {
                Console.WriteLine(vehicle.ToString()+"\n");
            });
        }

        private void GenerateEnemyRandomly()
        {
            int randomNumber = GenerateRandomNumber(MaxNumber: 2);
            if(randomNumber == 1)
            {
                IEnemyVehicle evilCar = BuildEnemy(typeof(EvilCar));
                _enemies.Add(evilCar);
                return;
            }
            if(randomNumber == 2)
            {
                IEnemyVehicle evilHelicopter = BuildEnemy(typeof(EvilHelicopter));
                _enemies.Add(evilHelicopter);
                return;
            }
        }

        private IEnemyVehicle BuildEnemy(Type type)
        {
            IEnemyVehicle vehicleToReturn;
            if(type == typeof(EvilCar))
            {
                Coordinates carCoords = new Coordinates(50, 10);
                IVehicleWeapon vehicleWeapon = new EvilWings();
                IWeaponBooster booster = GetRandomWeaponBooster();
                if(booster != null) vehicleWeapon.SetWeaponBooster(booster);
                vehicleToReturn = new EvilCar(vehicleWeapon, carCoords, 4);
                return vehicleToReturn;
            }
            if (type == typeof(EvilHelicopter))
            {
                Coordinates carCoords = new Coordinates(50, 20);
                IVehicleWeapon vehicleWeapon = new EvilParachute();
                IWeaponBooster booster = GetRandomWeaponBooster();
                if (booster != null) vehicleWeapon.SetWeaponBooster(booster);
                vehicleToReturn = new EvilHelicopter(vehicleWeapon, carCoords);
                return vehicleToReturn;
            }
            throw new Exception("ENEMY NOT ALLOWED");
        }

        private IWeaponBooster GetRandomWeaponBooster()
        {
            IWeaponBooster booster = null;
            int randomNumber = GenerateRandomNumber(MaxNumber: 3);
            if (randomNumber == 1)
            {
                booster = new MushroomBooster();
            }
            if (randomNumber == 2)
            {
                booster = new PizzaBooster();
            }
            return booster;
        }

        private int GenerateRandomNumber(int MaxNumber)
        {
            Random randomObj = new Random();
            int randomNumber = randomObj.Next(1, MaxNumber + 1);
            return randomNumber;
        }

    }
}
