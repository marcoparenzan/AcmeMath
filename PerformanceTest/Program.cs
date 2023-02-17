var totalElapsed = 0.0;
var count = 10000;
for (var j = 0; j<count; j++)
{
    var start = DateTime.Now;
    Console.Write($"Elapsed: ");
    for (float i = 0.0f; i < 50.0f; i += 1.0f)
    {
        Console.Write($".");
    }
    var end = DateTime.Now;
    var thatElapse = (end - start).TotalMilliseconds;
    totalElapsed += thatElapse;
    Console.WriteLine($"{thatElapse}");
}

Console.WriteLine($"Average: {totalElapsed / count}");

struct FloatValue
{
    float value;

    public static implicit operator FloatValue(float v) => new FloatValue{ value = v };

    public static bool operator <(FloatValue a, FloatValue b) => a.value < b.value;

    public static bool operator >(FloatValue a, FloatValue b) => a.value > b.value;

    public static FloatValue operator +(FloatValue a, FloatValue b) => a.value + b.value;
}