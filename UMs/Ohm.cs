using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMs
{
    struct Ohm
    {
        internal float value;

        public static implicit operator Ohm(float v) => new Ohm { value = v };

        public static bool operator <(Ohm a, Ohm b) => a.value < b.value;

        public static bool operator >(Ohm a, Ohm b) => a.value > b.value;

        public static Ohm operator +(Ohm a, Ohm b) => a.value + b.value;

        public static Volt operator *(Ohm a, Ampere b) => a.value * b.value;

        public override string ToString() => $"{value}Ω";
    }
}
