import java.util.Scanner;

public class lateRide{

	public static int lateRide(int n) {
		int hour = n/60;
		int minute = n%60;
				    
		return( hour/10 + hour%10 + minute/10 + minute%10);
	}

	public static void main( String [] args ){
		Scanner sc = new Scanner( System.in );

		int n = sc.nextInt();
		System.out.println( lateRide(n) );
	}
}
