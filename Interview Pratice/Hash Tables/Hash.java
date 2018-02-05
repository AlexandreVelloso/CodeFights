import java.util.*;

public class Hash{
	public static void main(String [] args){
		Map<Integer,String> dic = new HashMap<Integer,String>();

		String[] str = {"Alexandre","Velloso","Pinheiro","Filho","Alexandre1","banana","batata"};

		for( String s : str ){
			dic.put( s.hashCode(),s );
		}

		System.out.println( dic.size() );
	}
}
