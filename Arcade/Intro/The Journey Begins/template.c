#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#include <stddef.h>
#include <string.h>
#include <stdint.h>
#include <math.h>

int method( int param ){
	return param;
}

int main(){

	printf("%d\n", method(5) );

	return 0;
}
