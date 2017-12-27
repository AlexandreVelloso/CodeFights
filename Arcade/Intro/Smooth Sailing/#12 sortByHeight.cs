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

    public class sortByHeight{

        /*
        * Como esse vetor e' pequeno, tem no ma'ximo 100 de tamanho
        * eu fiz uma versao alterada do selection sort O(n^2).
        */
        public static int[] method(int[] a) {

            for( int i = 0; i < a.Length; i++ ){

                // menor elemento na parte desordenada do array
                int min = a[i];
                // posicao do menor elemento
                int posMin = i;

                for( int j = i+1; j < a.Length; j++ ){

                    // se essa posicao for uma arvore, ignore
                    if( min == -1 )
                        break;

                    // se essa posicao nao for uma arvore
                    if( a[j] != -1 ){

                        // pega o menor elemento
                        if( a[j] < min ){
                            min = a[j];
                            posMin = j;
                        }
                    }
                }

                // swap
                int aux = a[i];
                a[i] = min;
                a[posMin] = aux;
            }

            return a;
        }

        public static void Main( string[] args ){

            string[] input = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll( input, Int32.Parse );

            // chama o metodo, aqui o vetor e' passado
            // como referencia, entao as alteracoes feitas
            // nele vao poder ser vistas aqui
            method( array );

            // mostra o array na tela
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine( array[i]+" ");
            }
        }

    }
}
