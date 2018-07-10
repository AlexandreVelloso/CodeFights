import java.util.Scanner;

public class WillYou{

    public static boolean willYou(boolean young, boolean beautiful, boolean loved) {

        return(
            ( young && beautiful && !loved ) ||
            ( loved && ( !young || !beautiful ) )
        );
    }    

    public static void main( String [] args ){

        Scanner sc = new Scanner( System.in );

        boolean young = sc.nextInt(),
            beautiful = sc.nextInt(),
            loved = sc.nextInt();

        System.out.println( willYou(young, beautiful, loved) );
    }

}