#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#include <stddef.h>
#include <string.h>
#include <stdint.h>
#include <math.h>


// Definition for arrays:
typedef struct arr_integer {
  int size;
  int *arr;
} arr_integer;

arr_integer alloc_arr_integer(int len) {
  arr_integer a = {len, len > 0 ? malloc(sizeof(int) * len) : NULL};
  return a;
}

void insertionSort( arr_integer array ){
    
    for( int i = 1; i < array.size; i++ ){
        
				int key = array.arr[i];
        int j = i-1;
        while( j >= 0 && array.arr[j] > key ){
            
						array.arr[j+1] = array.arr[j];
            j--;
        }

				array.arr[j+1] = key;
    }
    
}

void print( arr_integer array ){
	printf("[ ");
	for( int i = 0; i < array.size; i++ ) printf("%d ",array.arr[i] );
	printf("];\n");
}

int makeArrayConsecutive2(arr_integer statues) {

    // sort the statues array, using insertion sort
    insertionSort( statues );
    print( statues );
		int sum = 0;

		for( int i = 1; i < statues.size; i++ ){
			sum += statues.arr[i] - statues.arr[i-1] -1;
		}

		return sum;
}

int main(){
	
	arr_integer statues = alloc_arr_integer( 4 );
  statues.arr[0] = 6; statues.arr[1] = 2;
  statues.arr[2] = 3; statues.arr[3] = 8;

//	print( statues );

	printf("\n%d\n", makeArrayConsecutive2( statues ) );

	return 0;
}
