#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#include <stddef.h>
#include <string.h>
#include <stdint.h>
#include <math.h>

int shapeArea(int n) {

    // 1 5 13 25
    // 
    // Esse problema e' a soma dos elementos dessa piramide
    // 
    // 1
    // 1 3 1
    // 1 3 5 3 1
    // 1 3 5 7 5 3 1
    // 
    // Existe uma formula matematica para resolver esse problema em O(1)
    
    int sum = 0;
    for( int i = 1; i <= n-1; i++ ){
        
        sum += ( ( i * 2 )-1 ) * 2;
    }
    
    sum += n * 2 -1;
    return sum;
}

int main(){
	printf("%d\n", shapeArea(3) );
}
