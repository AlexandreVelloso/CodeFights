import java.util.Scanner;

public class addTwoDigits{

	public static int addTwoDigits( int n ){
		return( n/10 + n%10 );
	}

	public static void main( String [] args ){
		Scanner sc = new Scanner( System.in );

		int n = sc.nextInt();
		System.out.println( addTwoDigits(n) );
	}
}
