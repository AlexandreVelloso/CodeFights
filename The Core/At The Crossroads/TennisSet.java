import java.util.Scanner;

public class TennisSet{

    public static boolean tennisSet(int score1, int score2) {

        if( score1 < 5 || score2 < 5 ){
            return score1 == 6 || score2 == 6;
        }else{
            
            return ( score1 == 7 && score2 < 7 ) || 
                   ( score2 == 7 && score1 < 7 );
            
        }
        
    }
    
    public static void main( String [] args ){
        Scanner sc = new Scanner( System.in );

        int score1 = sc.nextInt(),
            score2 = sc.nextInt();

        System.out.println( tennisSet(score1, score2) );
    }
}