import java.util.Scanner;
import java.util.Arrays;

public class containsDuplicates{

    public static boolean containsDuplicates( int[] a ){

        // Quick sort
        Arrays.sort( a );

        boolean contain = false;
        for( int i = 0; i < a.length-1; i++ ){
            if( a[i] == a[i+1] ){
                contain = true;
                break;
            }
        }

        return contain;
    }

    public static void main( String [] args ){
        Scanner sc = new Scanner( System.in );

        int size = sc.nextInt();
        int[] a = new int[ size ];

        for( int i = 0; i < size; i++){
            a[i] = sc.nextInt();
        }

        System.out.println( containsDuplicates(a) );

    }
}
