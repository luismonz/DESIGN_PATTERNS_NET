using FactoryPattern.Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.EnemyVehicles;
public class EvilHelicopter : BasicVehicleAttributes, IEnemyVehicle
{

    private IVehicleWeapon _vehicleWeapon;
    private Coordinates _vehicleCoordinates;

    public EvilHelicopter(IVehicleWeapon weapon, Coordinates vehicleCoords) : base("EVIL HELICOOOPTER")
    {
        _vehicleWeapon = weapon;
        _vehicleCoordinates = vehicleCoords;
    }

    public int AttackPlayer()
    {
        return this._vehicleWeapon.TotalDamageToPlayer() * 2;
    }

    public void WalkAround()
    {
        this._vehicleCoordinates.Pos_X += 2;
    }
}