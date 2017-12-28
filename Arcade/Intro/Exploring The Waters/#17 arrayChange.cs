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

    public class arrayChange{

        static int method(int[] inputArray)
        {
            int count = 0;

            // 1 1 1
            for( int i = 1; i < inputArray.Length; i++)
            {
                // diferenca entre o numero atual e o anterior
                int difference = inputArray[i] - inputArray[i - 1];

                // se o numero atual for menor ou igual ao anterior
                if( difference <= 0)
                {
                    count += Math.Abs(difference) + 1;

                    // atualiza essa posicao para o proximo numero,
                    // esse numero vai ser o anterior + 1
                    inputArray[i] = inputArray[i-1] + 1;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] inputArray = Array.ConvertAll(input, Int32.Parse);

            Console.WriteLine(method(inputArray));
            Console.ReadLine();
        }
    }
}