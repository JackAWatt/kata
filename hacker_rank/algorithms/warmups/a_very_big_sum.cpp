#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int ceiling;
    long long totsMagoats = 0;
    cin >> ceiling;
    long long shitToAddTogether[ceiling];
    
    for (int i=0; i<ceiling; i++) {
        int shit;
        cin >> shit;
        shitToAddTogether[i] = shit;
        totsMagoats += shitToAddTogether[i];
    }
    cout << totsMagoats;
    return 0;
}
