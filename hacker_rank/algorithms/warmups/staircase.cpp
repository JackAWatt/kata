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
    
    for (int i = 0; i < n; i++) {
        for (int j = n - i - 1; j > 0; j--) {
            cout << " ";
        }
        for (int j = n -i - 1; j < n; j++) {
            cout << "#";
        }
        cout << "\n";
    }
    return 0;
}
