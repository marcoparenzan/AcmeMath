using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMs
{
    struct Volt
    {
        internal float value;

        public static implicit operator Volt(float v) => new Volt { value = v };

        public static bool operator <(Volt a, Volt b) => a.value < b.value;

        public static bool operator >(Volt a, Volt b) => a.value > b.value;

        public static Volt operator +(Volt a, Volt b) => a.value + b.value;

        public static Watt operator *(Volt a, Ampere b) => a.value * b.value;

        public override string ToString() => $"{value}V";
    }
}
