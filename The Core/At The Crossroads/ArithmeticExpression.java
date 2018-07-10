import java.util.Scanner;

public class ArithmeticExpression{

    public static boolean arithmeticExpression(int a, int b, int c) {

        return(
            a + b == c ||
            a - b == c ||
            a * b == c ||
            ( a % b == 0 && a / b == c )
        );
    }    
    
    public static void main( String [] args ){
        Scanner sc = new Scanner( System.in );

        int a = sc.nextInt(),
            b = sc.nextInt(),
            c = sc.nextInt();

        System.out.println( arithmeticExpression(a, b, c) );
    }
}