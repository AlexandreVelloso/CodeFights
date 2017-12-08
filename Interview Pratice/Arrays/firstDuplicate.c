#include <stdio.h>
#include <stdlib.h>

// Definition for arrays:
 typedef struct arr_integer {
   int size;
   int *arr;
 } arr_integer;

 arr_integer alloc_arr_integer(int len) {
   arr_integer a = {len, len > 0 ? malloc(sizeof(int) * len) : NULL};
   return a;
 }


int firstDuplicate(arr_integer a) {
	int* occ = calloc( a.size+1, sizeof(int) );
	
	// initialize the vector occ with 0's
	for( int i = 0; i < a.size; i++ ) occ[i] = 0;

	for( int i = 0; i < a.size; i++ ){

		// first occurrence
		if( occ[ a.arr[i] ] == 0 ){
								            
			occ[ a.arr[i] ] = 1;
		}else{
			return a.arr[i];
		}
	}
				    
	return -1;
}

int main(){
	int array[10] = {10,6,8,4,9,1,7,2,5,3};

	arr_integer a = alloc_arr_integer(10);
	a.arr = array;
	a.size = 10;

	printf("%d\n", firstDuplicate( a ) );
}
