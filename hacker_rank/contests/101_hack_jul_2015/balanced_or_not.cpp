#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <string>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    string t1, t2, t3, t4, t5;
    int y = 1;
    char c1, c2, c3, c4, c5;
    
   
     cin >> t1 >> t2 >> t3 >> t4 >> t5;
    
        
    
 
        c1 = t1[0];
        c2 = t1[2];
        if (!c1 < c2) {
            y = 0;
        }
    
    c1 = t2[0];
    c2 = t2[2];
    
    if (!c1 < c2) {
        y = 0;
    }
    
    c1 = t3[0];
    c2 = t3[2];
    if (!c1 < c2) {
        y = 0;
    }
    
    c1 = t4[0];
    c2 = t4[2];
    
    if (!c1 < c2) {
        y = 0;
    }
    c1 = t5[0];
    c2 = t5[2];
    
    if (!c1 < c2) {
        y = 0;
    }
    cout << y;
    
    return 0;
}
