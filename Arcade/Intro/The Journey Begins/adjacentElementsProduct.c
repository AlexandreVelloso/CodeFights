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

int adjacentElementsProduct(arr_integer inputArray) {
    int largest = inputArray.arr[0] * inputArray.arr[1];
    int mult;
    
    for( int i = 1; i < inputArray.size -1; i++ ){
        mult = inputArray.arr[i] * inputArray.arr[i+1];
        
        if( mult > largest )
            largest = mult;
    }
    
    return largest;
}

int main(){
	arr_integer input = alloc_arr_integer(6);
	
	input.arr[0] = 3;	input.arr[1] = 6;	input.arr[2] = -2;
	input.arr[3] = -5;	input.arr[4] = 7;	input.arr[5] = 3;

	printf("%d\n", adjacentElementsProduct( input ) );

	return 0;
}
