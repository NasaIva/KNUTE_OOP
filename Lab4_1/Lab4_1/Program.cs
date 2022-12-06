using System;
using System.Diagnostics;

namespace Lab4_1;

public class Program
{

    virtual internal void WriteinDebug(string stringParam, int intParam)
    {
        Debug.WriteLine(message: "String parameter: " + stringParam);
        Debug.WriteLine(message: "Int parameter: " + intParam);

    }

}

