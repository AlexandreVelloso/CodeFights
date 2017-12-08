#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#include <stddef.h>
#include <string.h>
#include <stdint.h>
#include <math.h>

bool checkPalindrome(char * inputString) {
    int size = strlen( inputString );
    int i = 0;
    int j = size-1;
    
    while( i < j ){
        if( inputString[i] != inputString[j] ){
            return false;
        }
        
        i++;
        j--;
    }
    
    return true;
}

int main(){

	printf("%s\n", checkPalindrome("arara") ? "true" : "false");
	return 0;
}
