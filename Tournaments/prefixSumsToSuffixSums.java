import java.util.Arrays;
import IO.IO;

public class prefixSumsToSuffixSums{

	public static int[] prefixSumsToSuffixSums( int[] prefixSums ){

		int[] initialArray = new int[ prefixSums.length ];
		
		initialArray[0] = prefixSums[0];
		for( int i = 1; i < prefixSums.length; i++ ){
			initialArray[i] = prefixSums[i] - prefixSums[i-1];
		}

		for( int i = prefixSums.length-2; i >= 0; i-- ){
			initialArray[i] += initialArray[i+1];
		}

		return initialArray;
	}

	public static void main( String [] args ){
		int[] array = {1,3,6,10,15};

		int[] newArray = prefixSumsToSuffixSums( array );

		System.out.println( Arrays.toString( newArray ) );
	}
}
