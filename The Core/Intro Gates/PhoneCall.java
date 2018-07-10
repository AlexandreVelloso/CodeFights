import java.util.Scanner;

public class PhoneCall{

    private static int phoneCall(int min1, int min2_10, int min11, int s) {
    
        int duration = 0;
        
        if( s - min1 >= 0 ){
            duration += 1;
            s -= min1;
        }
        
        for( int i = 2; i <= 10; i++ ){
            
            if( s - min2_10 >= 0 ){
                duration += 1;
                s -= min2_10;
            }
            
        }
        
        if( s > min11 ){
            duration += (int)( s / min11 );
        }
        
        return duration;
    }

    public static void main( String [] args ){
        Scanner sc = new Scanner(System.in);

        int min1 = sc.nextInt(),
            min2_10 = sc.nextInt(),
            min11 = sc.nextInt(),
            s = sc.nextInt();

        System.out.println( phoneCall( min1, min2_10, min11, s ) );
    }

}