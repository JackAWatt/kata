#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int n,k,l;
    string str;
    char t;
    cin >> n >> str >> k;
    for (int i = 0;i < n; i++) {
        t = str[i];
        if ((int) t >= 97 && (int) t <= 122) {
            l = (int) t +k;
            while ( l > 122) {
                l = l - 26;
            }
            t = l;
            cout << t;
        } else if ((int) t >= 65 && (int) t <= 90 ) {
            l = (int) t + k;
            while ( l > 90) {
                l = l - 26;
            }
            t = l;
            cout << t;
        }else {
            cout << str[i];
        }
    }
    return 0;
}
