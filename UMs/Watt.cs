using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMs
{
    struct Watt
    {
        internal float value;

        public static implicit operator Watt(float v) => new Watt { value = v };

        public static bool operator <(Watt a, Watt b) => a.value < b.value;

        public static bool operator >(Watt a, Watt b) => a.value > b.value;

        public static Watt operator +(Watt a, Watt b) => a.value + b.value;

        public override string ToString() => $"{value}W";
    }
}
