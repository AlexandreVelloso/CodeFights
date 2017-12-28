using System;
using System.IO;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using SimpleJson.Reflection;
using System.Text.RegularExpressions;
using System.Linq;

namespace CodeFights
{

    public class avoidObstacles
    {

        static int method(int[] inputArray)
        {

            int jump = 1;
            bool fail = true;

            while (fail)
            {
                jump++;
                fail = false;
                for (int i = 0; i < inputArray.Length; i++)
                    if (inputArray[i] % jump == 0)
                    {
                        fail = true;
                        break;
                    }
            }

            return jump;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(input, Int32.Parse);

            Console.WriteLine(method(array));
        }
    }
}