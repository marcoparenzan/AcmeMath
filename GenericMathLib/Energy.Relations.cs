using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericMathLib
{
    public partial struct Energy : IMultiplyOperators<Energy, Voltage, Power>
    {
        public static Power operator *(Energy left, Voltage right)
        {
            return new Power { value = left.value * right.value };
        }
    }
}
