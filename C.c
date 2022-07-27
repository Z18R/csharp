#include<stdio.h>

void main(){
    int x = 10;
    int y = 20;
    int z = 30;
        x = ++y+z;
        printf("x: %d\n",x);
        printf("y: %d\n",y);
        printf("z: %d\n",(z++));
}