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
    int a[n];
 
    double pos = 0;
    double neg = 0;
    double zero = 0;

 
    for (int i = 0; i < n; i++) {
        cin >> a[i];
        if (a[i] < 0) {
            neg++;
        } else if (a[i] > 0) {
            pos++;
        } else {
            zero++;
        }
    }
    pos = pos / n;
    neg = neg / n;
    zero = zero / n;
    cout << pos << "\n";
    cout << neg << "\n";
    cout << zero << "\n";
    return 0;
}
