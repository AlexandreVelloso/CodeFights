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

    public class minesweeper{

        static int[][] method(bool[][] matrix) {

            int height = matrix.Length;
            int width = matrix[0].Length;

            // create the result matrix
            int[][] result = new int[ height ][];
            for( int i = 0; i < height; i++ ){
                result[i] = new int[ width ];
            }

            // walk in the matrix
            for( int i = 0; i < height; i++ ){
                for( int j = 0; j < width; j++ ){

                    // walk in the 8 neighborhood
                    for( int x = i-1; x <= i+1; x++ ){
                        for( int y = j-1; y <= j+1; y++ ){

                            // if have a mine in this position
                            // if X and Y are not the mine position
                            // if X is valid
                            // if Y is valid
                            if( (matrix[i][j] == true) &&
                                (i != x || j != y) &&
                                (x >= 0 && x < height) &&
                                (y >= 0 && y < width) ){

                                    result[x][y]++;
                             }
                        }
                    }

                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int numLinhas = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[numLinhas];

            // le o vetor
            for( int i = 0; i < numLinhas; i++)
            {
                vetor[i] = Array.ConvertAll( Console.ReadLine().Split(' '), Int32.Parse);
            }

            // Executa o metodo
            int[][] result = method( vetor );

            for( int i = 0; i < result.Length; i++ ){
                for( int j = 0; j < result[0].Length; j++ ){
                    Console.Write( result[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
}
