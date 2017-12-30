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

    public class areSimilar{

        static bool method(int[] a, int[] b)
        {

            // vetor de elementos do array a
            int[] arrayA = new int[1001];
            // vetor de elementos do array B
            int[] arrayB = new int[1001];

            // se o tamanho de A for diferente de B, ja nao podem ser iguais
            if (a.Length != b.Length)
                return false;

            int countDif = 0;

            for (int i = 0; i < a.Length; i++)
            {

                // salva o numero de vezes que cada numero aparece nos vetores
                arrayA[a[i]]++;
                arrayB[b[i]]++;

                // conta o numero de vezes que os vetores tem elementos diferentes
                if (a[i] != b[i])
                    countDif++;
            }

            bool isSimilar;

            // se o numero de erros e' menor ou igual a 1
            // o vetor talvez seja similar
            if (countDif == 0 || countDif == 2)
            {

                // se os valores de cada numero sao iguais
                // o vetor sera' similar
                isSimilar = true;

                for (int i = 0; i < 1001; i++)
                {
                    if (arrayA[i] != arrayB[i])
                    {
                        isSimilar = false;
                    }
                }

            } else {
                isSimilar = false;
            }

            return isSimilar;
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(input, Int32.Parse);

            input = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(input, Int32.Parse);

            Console.WriteLine(method(a, b));
        }
    }
}