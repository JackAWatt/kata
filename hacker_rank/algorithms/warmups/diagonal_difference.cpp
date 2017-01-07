#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */ 
    int n;
    cin >> n; 
    int neoX = 0;
    int neoY = 0;
    int d;
    
    for (int i = 0, j = n-1; i < n; i++,j--) {
        int t[n];
        for (int k = 0; k < n; k++) {
            cin >> t[k];
        } 
        neoX += t[i];
        neoY += t[j];
    }
    d = neoX - neoY;
    if (d < 0) {
        d = d * -1;
    }
    cout << d;
   
    return 0;
}
