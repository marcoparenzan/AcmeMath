using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericMathLib
{
    public partial struct Space : IDivisionOperators<Space, Speed, Acceleration>
    {
        public static Acceleration operator /(Space left, Speed right)
        {
            return new Acceleration { value = left.value / right.value };
        }
    }
}
