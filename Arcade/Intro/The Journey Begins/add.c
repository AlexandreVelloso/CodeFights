#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#include <stddef.h>
#include <string.h>
#include <stdint.h>
#include <math.h>

int add(int param1, int param2) {
	    return ( param1+param2 );
}

int main(){

	printf("%d\n", add(1,2) );

	return 0;
}
