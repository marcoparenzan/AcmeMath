using GenericMathLib;
using System;
using System.Numerics;

//CurrencyDemo();
//ModBusDemo();
//FormulaDemo();

//IDoSomething e = new DoElse();

Current a = 10;
Voltage b = 20;
var c = a * b;

Console.ReadLine();

void CurrencyDemo()
{
    Money aa = (3.454M, Currency.USD);
    Money bb = (5.346M, Currency.USD);

    var discount = bb * 0.2M;

    Console.WriteLine($"{aa.Currency}{aa}*{bb.Currency}{bb}={aa * bb}");
}

void ModBusDemo()
{
    ushort[] values = new[] { (ushort)0x0001, (ushort)0x0002, (ushort)0x0003, (ushort)0x0004, (ushort)0x0005, (ushort)0x0006 };
    ModBusInt32 v = (values, 1);
    Console.WriteLine($"{v:X8}");
    values[1] = 5;
    Console.WriteLine($"{v:X8}");
}

void FormulaDemo()
{
    Acceleration a = 10;
    Speed b = 20;

    Formula<Space> c = new Func<Space>(() => a * b);
    Console.WriteLine($"{a}*{b}={c}");

    b = 30;
    Console.WriteLine($"{a}*{b}={c}");
}

