#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void swap(int x, int y);

int main() {

int a = 10, b = 20;

swap(a, b);

printf("%d%d", a, b);

return 0;

}

void swap(int x, int y) {

x = x + y;

y = x - y;

x = x - y;

}