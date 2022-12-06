using System;

namespace Lab4_1;

public class Class: Program
{

    internal override void WriteInDebug(string stringParam)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Param of type " + stringParam.GetType());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Param of type " + intParam.GetType());
    }
}
