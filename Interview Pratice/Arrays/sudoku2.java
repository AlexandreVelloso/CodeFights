import java.util.Scanner;
import java.util.Arrays;

public class sudoku2{

    public static boolean testGrid( char[][] grid, int beginI, int beginJ ){

        // number of occurrences of each number
        int[] occ = new int[10];

        for( int i = beginI; i <= beginI + 2; i++ ){
            for( int j = beginJ; j <= beginJ + 2; j++ ){

                if( grid[i][j] != '.' ){

                    int number = Integer.parseInt( ""+grid[i][j] );
                    if( occ[ number ] != 0 ){
                        return false;
                    }else{
                        occ[ number ]++;
                    }
                }
            }
        }

        return true;
    }

    public static boolean testLinesAndColumns( char[][] grid ){

        int[] occLine;
        int[] occColumn;
        for( int j = 0; j < grid[0].length; j++ ){
            occLine = new int[ 10 ];
            occColumn = new int[ 10] ;
            for( int i = 0; i < grid.length; i++ ){

                // test line
                if( grid[i][j] != '.' ){

                    int numberL = Integer.parseInt( ""+grid[i][j] );
                    if( occLine[ numberL ] != 0 ){
                        return false;
                    }else{
                        occLine[ numberL ]++;
                    }
                }

                // test column
                if( grid[j][i] != '.' ){
                    int numberC = Integer.parseInt( ""+grid[j][i] );
                    if( occColumn[ numberC ] != 0 ){
                        return false;
                    }else{
                        occColumn[ numberC ]++;
                    }
                }
            }
        }
        return true;
    }

    public static boolean sudoku2( char[][] grid ){

        // test all grids
        boolean valid =
        testGrid( grid,0,0 ) &&
        testGrid( grid,0,3 ) &&
        testGrid( grid,0,6 ) &&
        testGrid( grid,3,0 ) &&
        testGrid( grid,3,3 ) &&
        testGrid( grid,3,6 ) &&
        testGrid( grid,6,0 ) &&
        testGrid( grid,6,3 ) &&
        testGrid( grid,6,6 ) &&
        testLinesAndColumns( grid );

        return valid;
    }

    public static void main( String [] args ){
        Scanner sc = new Scanner( System.in );

        char[][] grid = new char[9][9];
        for( int i = 0; i < 9; i++){
            for( int j = 0; j < 9; j++ ){
                grid[i][j] = sc.next().charAt(0);
            }
        }

        System.out.println( sudoku2(grid) );
    }
}
