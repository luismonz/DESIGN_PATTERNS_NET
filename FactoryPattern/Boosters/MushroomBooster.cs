using FactoryPattern.Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Boosters;
public class MushroomBooster : IWeaponBooster
{

    private int _damageToBoost;
    private Coordinates _boosterCoordinates;

    public MushroomBooster(Coordinates CoordsInit)
    {
        _boosterCoordinates = CoordsInit;
        _damageToBoost = 10;
    }

    public MushroomBooster()
    {
        _damageToBoost = 10;
    }

    public int UpgradeDamageToGameItem()
    {
        return _damageToBoost;
    }

    public void WalkAround()
    {
        _boosterCoordinates.Pos_X += 3;
    }

    public override string ToString()
    {
        string coordinatesInfo = _boosterCoordinates != null ? $", Coordinates: {_boosterCoordinates}" : "";
        return $"Mushroom Booster - Damage Boost: {_damageToBoost}{coordinatesInfo}";
    }

}