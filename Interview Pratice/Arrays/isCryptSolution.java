import java.util.Map;
import java.util.HashMap;
import java.util.Scanner;

public class isCryptSolution{

    public static String toNumber( String str, Map<Character,Integer> solution ){

        String number = "";

        for( int i = 0; i < str.length(); i++ ){
            number += solution.get( str.charAt(i) );
        }

        return number;
    }

    public static boolean isCryptSolution( String[] crypt, char[][] solution ){
        Map<Character,Character> dictionary = new HashMap<Character,Character>();

        // fill the dictionary
        for( int i = 0; i < solution.length; i++ ){
            dictionary.put( solution[i][0], solution[i][1] );
        }

        String number1 = toNumber( crypt[0], dictionary );
        String number2 = toNumber( crypt[1], dictionary );
        String number3 = toNumber( crypt[2], dictionary );

        // true if no one have leading zeros
        return
            (Long.parseLong(number1) + Long.parseLong(number2) == Long.parseLong(number3)) &&
            (number1.charAt(0) != '0' || number1.length() == 1) &&
            (number2.charAt(0) != '0' || number2.length() == 1) &&
            (number3.charAt(0) != '0' || number3.length() == 1);
    }

    public static void main( String [] args ){
        Scanner sc = new Scanner( System.in );

        String [] crypt = { sc.next(), sc.next(), sc.next() };

        // size of solution
        int size = sc.nextInt();

        char[][] solution = new char[ size ][2];
        // read all solution
        for( int i = 0; i < size; i++ ){
            solution[i][0] = sc.next().charAt(0);
            solution[i][1] = sc.next().charAt(0);
        }

        System.out.println( isCryptSolution(crypt, solution) );

    }

}
