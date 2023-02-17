using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericMathLib
{
    public partial struct Current : IMultiplyOperators<Current, Voltage, Power>
    {
        public static Power operator *(Current left, Voltage right)
        {
            return new Power { value = left.value * right.value };
        }
    }
}
