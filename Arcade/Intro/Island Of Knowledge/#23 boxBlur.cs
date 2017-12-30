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

    public class boxBlur
    {

     /**
     * Calcula a media da matriz 3x3 em volta do numero
     */
    public static int average( int[][] picture, int i, int j ){
        int sum = 0;

        for( int x = i-1; x <= i+1; x++ ){
            for( int y = j-1; y <= j+1; y++ ){
                sum += picture[x][y];
            }
        }

        return ( sum/9 );
    }

    public static int[][] method( int[][] picture ){

        // altura da nova imagem
        int height = picture.Length-2;
        // largura da nova imagem
        int width = picture[0].Length-2;

        // cria o vetor da imagem nova
        int[][] newPicture = new int[ height ] [];
        for( int i = 0; i < height; i++ ){
            newPicture[i] = new int[ width ];
        }

        // anda pela matriz
        for( int i = 1; i <= height; i++ ){
            for( int j = 1; j <= width; j++ ){

                newPicture[i-1][j-1] = average( picture, i, j );
            }
        }

        return newPicture;
    }

    public static void Main(string[] args)
    {

        int numLinhas = Convert.ToInt32(Console.ReadLine());
        int[] vetor = new int[numLinhas];

        // le o vetor
        for( int i = 0; i < numLinhas; i++)
        {
            vetor[i] = Array.ConvertAll( Console.ReadLine().Split(' '), Int32.Parse);
        }

        // Executa o metodo
        int[][] newPicture = method( vetor );

        for( int i = 0; i < newPicture.Length; i++ ){
            for( int j = 0; j < newPicture[0].Length; j++ ){
                Console.Write( newPicture[i][j]+" ");
            }
            Console.WriteLine();
        }

    }
}
