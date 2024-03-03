using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Validators;
public class DamageValidators
{
    public bool IsDamageBelowOrEqualsToZero(int CurrentDamage)
    {
        return CurrentDamage <= 0;
    }
}