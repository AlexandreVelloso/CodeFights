import java.util.Scanner;

public class ExtraNumber{

    public static int extraNumber(int a, int b, int c) {
        if( a != c && a != b ){
            return a;
        }else if( b != a && b != c ){
            return b;
        }else{
            return c;
        }
    }
    
    public static void main( String [] args ){
        Scanner sc = new Scanner( System.in );

        int a = sc.nextInt(),
            b = sc.nextInt(),
            c = sc.nextInt();

        System.out.println( extraNumber(a, b, c) );
    }
}