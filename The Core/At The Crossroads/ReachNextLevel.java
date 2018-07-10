import java.util.Scanner;

public class ReachNextLevel{

    public static boolean reachNextLevel(int experience, int threshold, int reward) {
        return ( experience + reward ) >= threshold;
    }

    public static void main( String [] args ){

        Scanner sc = new Scanner( System.in );

        int experience = sc.nextInt(),
            threshold = sc.nextInt(),
            reward = sc.nextInt();

        System.out.println( reachNextLevel(experience, threshold, reward) );
    }

}