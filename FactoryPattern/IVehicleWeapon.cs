using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;
public interface IVehicleWeapon
{
    int TotalDamageToPlayer();
    void SetWeaponBooster(IWeaponBooster weaponBooster);
}
