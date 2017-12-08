#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#include <stddef.h>
#include <string.h>
#include <stdint.h>
#include <math.h>

int centuryFromYear(int year) {
	int century = year/100;
			    
	if( year % 100 > 0 ){
		century += 1;
	}
														    
	return century;
}

int main(){
	printf("%d\n", centuryFromYear(2005) );
}
