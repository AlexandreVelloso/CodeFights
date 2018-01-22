import java.util.Scanner;
import java.util.Arrays;

public class rotateImage{

	public static int[][] rotateImage(int[][] a) {

        int[][] newMatrix = new int[ a.length ][ a[0].length ];

        // coordenates of the new matrix
        int x,y = a[0].length-1;

        for( int i = 0; i < a.length; i++ ){

            x = 0; y = a[0].length - i - 1;
            for( int j = 0; j < a[0].length; j++ ){

                newMatrix[x][y] = a[i][j];
                x++;

            }
        }

        return newMatrix;
    }

	public static void main( String [] args ){
		Scanner sc = new Scanner( System.in );

		int n;
		n = sc.nextInt();

		// read matrix
		int [][] matrix = new int[ n ][ n ];
		for( int i = 0; i < n; i++ ){
			for( int j = 0; j < n; j++ ){
				matrix[i][j] = sc.nextInt();
			}
		}

		int [][] newMatrix = rotateImage( matrix );

		// show matrix
		for( int i = 0; i < n; i++ ){
			System.out.println( Arrays.toString(newMatrix[i]) );
		}
	}
}
