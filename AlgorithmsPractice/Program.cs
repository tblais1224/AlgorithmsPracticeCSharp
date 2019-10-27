using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the stepPerms function below.
    static int stepPerms(int n)
    {


    }

    static void Main(string[] args)
    {
        int s = Convert.ToInt32(Console.ReadLine());

        for (int sItr = 0; sItr < s; sItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int res = stepPerms(n);

            Console.WriteLine(res);
        }
    }
}