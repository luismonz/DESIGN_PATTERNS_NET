using FactoryPattern.Space;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Boosters;
public class PizzaBooster : IWeaponBooster
{
    private int _damageToBoost;
    private int _slicesQuantity;
    private Coordinates _boosterCoordinates;

    public PizzaBooster(Coordinates CoordsInit)
    {
        _boosterCoordinates = CoordsInit;
        _damageToBoost = 15;
        _slicesQuantity = 8;
    }

    public int UpgradeDamageToGameItem()
    {
        return _damageToBoost * _slicesQuantity;
    }

    public void WalkAround()
    {
        _boosterCoordinates.Pos_X += 5;
    }
}