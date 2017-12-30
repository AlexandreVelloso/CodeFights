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

namespace CodeFights{

    public class palindromeRearranging{

        static bool method(string inputString)
        {
            // count the number of occurrences of each character
            int[] countLetters = new int[26];

            // count the occurrences
            for (int i = 0; i < inputString.Length; i++)
            {
                countLetters[inputString[i] - 'a']++;
            }

            // verify if only exists 1 or none odd number
            int numOdd = 0;

            // count the number of odd numbers
            for (int i = 0; i < 26; i++)
            {
                if( countLetters[i] % 2 == 1)
                {
                    numOdd++;
                }
            }

            return (numOdd <= 1);
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(method(input));
            Console.ReadLine();
        }
    }
}