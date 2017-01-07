#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    
    int mi,m,di,d,yi,y;
    
    cin >> di >> mi >> yi >> d >> m >> y;
    if (y == yi) {
        if (m == mi) {
            if (di > d) {
                int a = di - d;
                a = a * 15;
                cout << a;
            } else {
                cout << "0";
            }
        }  else if (mi < m) {
            cout << "0";
        }else {
            if (mi > m) {
                
            
            int a = mi - m;
            a = a * 500;
            if (di < di) {
                a = a - 500;
            }
            
            cout << a;
            }
        }
    } else if (yi < y) {
        cout << "0";
    }else {
        cout << "10000";
    }
    return 0;
}
