import java.util.Scanner;

public class seatsInTheater{

	public static int seatsInTheater(int nCols, int nRows, int col, int row) {
		return ( (nRows-row) * (nCols-col+1) );
	}

	public static void main( String [] args ){
		Scanner sc = new Scanner( System.in );

		int nCols = sc.nextInt();
		int nRows = sc.nextInt();
		int col = sc.nextInt();
		int row = sc.nextInt();
		System.out.println( seatsInTheater(nCols,nRows,col,row) );
	}
}
