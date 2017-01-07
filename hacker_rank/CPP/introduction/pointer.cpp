#include <stdio.h>
#include <iostream>
using namespace std;

void update(int *a,int *b) {
    // Complete this function 
    int t = *a;
    *a = *a + *b;
    if (*b > t) {
        *b = *b - t;
    } else {
        *b = t - *b;
    }
  
}

int main() {
    int a, b;
    int *pa = &a, *pb = &b;
    
    scanf("%d %d", &a, &b);
    update(pa, pb);
    printf("%d\n%d", a, b);

    return 0;
}
