import java.util.Scanner;

public class circleOfNumbers{

	public static int circleOfNumbers(int n, int firstNumber) {
		return ( firstNumber + ( n/2 ) ) % n;
	}

	public static void main( String [] args ){
		Scanner sc = new Scanner( System.in );

		int n = sc.nextInt();
		int firstNumber = sc.nextInt();
		System.out.println( circleOfNumbers(n,firstNumber) );
	}
}
