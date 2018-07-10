import java.util.Scanner;

public class candies{

	public static int candies(int n, int m) {
		return ( m/n * n );
	}

	public static void main( String [] args ){
		Scanner sc = new Scanner( System.in );

		int n = sc.nextInt();
		int m = sc.nextInt();
		System.out.println( candies(n,m) );
	}
}
