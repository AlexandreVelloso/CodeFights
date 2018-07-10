import java.util.Scanner;

public class IsInfiniteProcess{

    public static boolean isInfiniteProcess(int a, int b) {
    
        return ! ( a <= b && ( a % 2 == b % 2 ) );
    }
    
    public static void main( String [] args ){
        Scanner sc = new Scanner( System.in );

        int a = sc.nextInt(),
            b = sc.nextInt();

        System.out.println( isInfiniteProcess(a, b) );
    }
}