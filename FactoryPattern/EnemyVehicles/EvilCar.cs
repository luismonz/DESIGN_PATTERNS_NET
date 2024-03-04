using FactoryPattern.Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.EnemyVehicles;
public class EvilCar : BasicVehicleAttributes, IEnemyVehicle
{

    private IVehicleWeapon _vehicleWeapon;
    private Coordinates _vehicleCoordinates;
    private int _wheelsQuantity;

    public EvilCar(IVehicleWeapon weapon, Coordinates vehicleCoords, int WheelsQuantity) : base("EVIL CAR")
    {
        _vehicleWeapon = weapon;
        _vehicleCoordinates = vehicleCoords;
        _wheelsQuantity = WheelsQuantity;
    }

    public int AttackPlayer()
    {
        return this._vehicleWeapon.TotalDamageToPlayer() / _wheelsQuantity;
    }

    public void WalkAround()
    {
        this._vehicleCoordinates.Pos_X += 2;
    }

    public override string ToString()
    {
        return $"EVIL CAR: \n" +
            $"---- Weapon: {_vehicleWeapon.ToString()}, \n" +
            $"---- Coordinates: {_vehicleCoordinates.ToString()}, " +
            $"---- Wheels Quantity: {_wheelsQuantity}";
    }

}