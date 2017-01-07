#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* doesn't pass all test cases */   
    int T;
 
    string one, two;
    cin >> T >> one >> two;
    for (int k = 0; k < T; k++) {
        bool common = 0;
        for (int i = 0; i < one.length(); i++) {
            for (int j = 0; j < two.length();j++) {
                if (one[i] == two[j]) {
                    common = 1;
                }
            } 
        }
    
        if (common) {
            cout << "YES\n";
        } else {
            cout << "NO\n";
        }
        cin >> one >> two;
    }
    return 0;
}
