using FactoryPattern.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Weapons;
public class EvilWings : BasicWeaponsAttributes, IVehicleWeapon
{
    private IWeaponBooster _weaponBooster;
    private DamageValidators _damageValidator;

    public EvilWings() : base(weaponName: "Evil Wings", defaultDamage: 15)
    {
        _damageValidator = new DamageValidators();
    }

    public EvilWings(IWeaponBooster weaponBooster) : base(weaponName: "Evil Wings", defaultDamage: 15)
    {
        _damageValidator = new DamageValidators();
        SetWeaponBooster(weaponBooster);
    }

    public void SetWeaponBooster(IWeaponBooster weaponBooster)
    {
        _weaponBooster = weaponBooster;
        this.UpgradeWeaponDamage(_weaponBooster.UpgradeDamageToGameItem());
    }

    private void FlapWings()
    {
        if (this._damageValidator.IsDamageBelowOrEqualsToZero(this.DefaultDamage))
        {
            this.SetNewDamage(0);
            return;
        }
        this.UpgradeWeaponDamage(-2);
    }

    public int TotalDamageToPlayer()
    {
        FlapWings();
        return DefaultDamage;
    }

    public override string ToString()
    {
        string boosterInfo = _weaponBooster != null ? $", Booster: {_weaponBooster}" : "";
        return $"Evil Parachute - Damage: {DefaultDamage}{boosterInfo}";
    }

}
