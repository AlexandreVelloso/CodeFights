import java.util.Scanner;

public class KnapsackLight{

    public static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW) {
    
        if( weight1 + weight2 <= maxW ){
            return value1 + value2;
        }else if( value1 >= value2 ){
            
            if( weight1 <= maxW ){
                return value1;
            }else if( weight2 <= maxW ){
                return value2;
            }
            
        }else{
            
            if( weight2 <= maxW ){
                return value2;
            }else if( weight1 <= maxW ){
                return value1;
            }
            
        }
        
        return 0;
    }    

    public static void main( String [] args ){
        Scanner sc = new Scanner( System.in );

        int value1 = sc.nextInt(),
            weight1 = sc.nextInt(),
            value2 = sc.nextInt(),
            weight2 = sc.nextInt(),
            maxW = sc.nextInt();

        System.out.println( knapsackLight(value1, weight1, value2, weight2, maxW) );
    }
}