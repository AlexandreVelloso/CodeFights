import java.util.Scanner;

public class MetroCard{

    public static int[] metroCard(int lastNumberOfDays) {
        if( lastNumberOfDays == 31 ){
            return new int[]{ 28, 30, 31 } ;
        }else{
            return new int[]{ 31 } ;
        }
    }    

    public static void main( String [] args ){

        Scanner sc = new Scanner( System.in );

        int lastNumberOfDays = sc.nextInt();

        System.out.println( metroCard(lastNumberOfDays) );
    }

}