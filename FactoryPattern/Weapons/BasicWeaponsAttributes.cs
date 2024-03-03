using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Weapons;
public abstract class BasicWeaponsAttributes
{
    private readonly string _weaponName;
    private int _defaultDamage;
    protected BasicWeaponsAttributes(string weaponName, int defaultDamage)
    {
        _weaponName = weaponName;
        _defaultDamage = defaultDamage;
    }
    public void UpgradeWeaponDamage(int newDamage) => _defaultDamage += newDamage;
    public void SetNewDamage(int newDamage) => _defaultDamage = newDamage;

    public string WeaponName => _weaponName;
    public int DefaultDamage => _defaultDamage;

}