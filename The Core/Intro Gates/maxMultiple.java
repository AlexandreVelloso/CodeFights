import java.util.Scanner;

public class maxMultiple{

	public static int maxMultiple(int divisor, int bound) {
		return ( bound - (bound%divisor) );
	}

	public static void main( String [] args ){
		Scanner sc = new Scanner( System.in );

		int divisor = sc.nextInt();
		int bound = sc.nextInt();
		System.out.println( maxMultiple(divisor,bound) );
	}
}
