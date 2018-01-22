import java.util.Scanner;
import java.util.Arrays;

public class firstNotRepeatingCharacter{

	public static char firstNotRepeatingCharacter( String s ){

		int[] occ = new int[ 26 ];

		// count the number of occurrences for each character
		for( char c : s.toCharArray() ){
			occ[ c-'a' ]++;
	  	}

		// get the first character that appears only 1 time
		for( char c : s.toCharArray() ){
			if( occ[ c-'a' ] == 1 ){
				return c;
			}
		}

		return '_';
	}

	public static void main( String [] args ){
		Scanner sc = new Scanner( System.in );

		String input;
		input = sc.nextLine();

		System.out.println( firstNotRepeatingCharacter( input ) );
	}
}
