import java.util.Scanner;

class ListNode<T>{
    ListNode(T x) {
        value = x;
    }

    T value;
    ListNode<T> next;
}

public class removeKFromList{

    private static ListNode<Integer> l = null;

    public static void print( ListNode<Integer> l ){

        System.out.print("Array [");

        while( l != null ){

            if( l.value != null )
                System.out.print( " "+l.value.toString() );

            l = l.next;
        }
        System.out.println(" ];");

    }

    public static void add( Integer value ){

        if( l == null ){
            l = new ListNode<>( value );
        }else{
            ListNode<Integer> aux = l;

            while( aux.next != null ){
                aux = aux.next;
            }

            aux.next = new ListNode<>(value);
        }
    }

    public static ListNode<Integer> removeKFromList( ListNode<Integer> l, int k ){

        ListNode<Integer> aux = l;

        while( aux != null && aux.value == k ){
            aux = aux.next;
        }

        l = aux;

        while( aux != null ){
            if( aux.next != null && aux.next.value == k ){
                aux.next = aux.next.next;
            }else{
                aux = aux.next;
            }
        }

        return l;
    }

    public static void main( String [] args ){

        int size, value;
        Scanner sc = new Scanner( System.in );

        size = sc.nextInt();

        for( int i = 0; i < size; i++ ){
            value = sc.nextInt();

            add( new Integer(value) );
        }

        print( l );

        l = removeKFromList( l, 3 );

        print( l );
    }
}
