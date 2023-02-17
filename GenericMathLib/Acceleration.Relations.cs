using System.Numerics;

namespace GenericMathLib
{
    public partial struct Acceleration : IMultiplyOperators<Acceleration, Speed, Space>
    {
        public static Space operator *(Acceleration left, Speed right)
        {
            return new Space { value = left.value * right.value };
        }
    }
}
