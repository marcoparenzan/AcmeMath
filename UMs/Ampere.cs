using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMs
{
    struct Ampere
    {
        internal float value;

        public static implicit operator Ampere(float v) => new Ampere { value = v };

        public static bool operator <(Ampere a, Ampere b) => a.value < b.value;

        public static bool operator >(Ampere a, Ampere b) => a.value > b.value;

        public static Ampere operator +(Ampere a, Ampere b) => a.value + b.value;

        public static Volt operator *(Ampere b, Ohm a) => a.value * b.value;

        public override string ToString() => $"{value}A";
    }
}
