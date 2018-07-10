import java.util.Scanner;

public class largestNumber{

	public static int largestNumber(int n) {
		return (int)( Math.pow(10,n) -1 );
	}

	public static void main( String [] args ){
		Scanner sc = new Scanner( System.in );

		int n = sc.nextInt();
		System.out.println( largestNumber(n) );
	}
}
