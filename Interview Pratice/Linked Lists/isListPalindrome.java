import java.util.Scanner;
import java.util.Random;

class ListNode<T>{
    ListNode(T x) {
        value = x;
    }

    T value;
    ListNode<T> next;
}

public class isListPalindrome{

    public static void print( ListNode<Integer> l ){

        System.out.print("Array [");

        while( l != null ){

            if( l.value != null )
                System.out.print( " "+l.value.toString() );

            l = l.next;
        }
        System.out.println(" ];");

    }

    public static ListNode<Integer> add( ListNode<Integer> l, Integer value ){

        if( l == null ){
            l = new ListNode<>( value );
        }else{
            ListNode<Integer> aux = l;

            while( aux.next != null ){
                aux = aux.next;
            }

            aux.next = new ListNode<>(value);
        }

        return l;
    }

    public static int getSize( ListNode<Integer> l ){
        int size = 0;

        while( l != null ){
            size++;
            l = l.next;
        }

        return size;
    }

    public static ListNode<Integer> reverse( ListNode<Integer> l ){

        ListNode<Integer> newList = l;

        ListNode<Integer> prev = null;
        ListNode<Integer> current = newList;
        ListNode<Integer> next;

        while( current != null ){
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        newList = prev;

        return newList;
    }

    public static boolean isListPalindrome( ListNode<Integer> l ){

        ListNode<Integer> halfRight = l;

        int size = getSize( l );
        int halfSize = size/2;

        for( int i = 0; i < halfSize; i++ ){
            halfRight = halfRight.next;
        }

        // this method removes the halfRight of the L list
        halfRight = reverse( halfRight );

        // print( l );
        // print( halfRight );

        boolean result = true;
        for( int i = 0; i < halfSize; i++, l = l.next, halfRight = halfRight.next ){

            if( l.value.equals( halfRight.value ) == false ){
                result = false;
                break;
            }
        }

        return result;
    }

    public static void main( String [] args ){

        int size, value;
        Scanner sc = new Scanner( System.in );

        size = sc.nextInt();

        ListNode<Integer> l = null;

        for( int i = 0; i < size; i++ ){
            value = sc.nextInt();

            l = add( l, new Integer(value) );
        }

        print( l );

        System.out.println( isListPalindrome( l ) );
    }
}
