using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Weapons;
public class EvilParachute : BasicWeaponsAttributes, IVehicleWeapon
{
    private IWeaponBooster _weaponBooster;

    public EvilParachute() : base(weaponName: "Evil Parachute", defaultDamage: 25)
    {
    }

    public EvilParachute(IWeaponBooster weaponBooster) : base(weaponName: "Evil Parachute", defaultDamage: 25)
    {
        SetWeaponBooster(weaponBooster);
    }

    public void SetWeaponBooster(IWeaponBooster weaponBooster)
    {
        _weaponBooster = weaponBooster;
        this.UpgradeWeaponDamage(_weaponBooster.UpgradeDamageToGameItem());
    }

    private void FallingWithStyle()
    {
        this.UpgradeWeaponDamage(4);
    }

    public int TotalDamageToPlayer()
    {
        FallingWithStyle();
        return DefaultDamage;
    }
}