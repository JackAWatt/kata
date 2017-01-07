#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int n, x, to_delete, lower, upper;
    vector<int> v;
    cin >> n;
    for (int i = 0; i < n; i++) {
        cin >> x;
        v.push_back(x);
    }
    cin >> to_delete;
    v.erase(v.begin()+to_delete -1);
    cin >> lower >> upper;
    v.erase(v.begin()+lower - 1,v.begin()+upper - 1);
    cout << v.size() << std::endl;
    for (int i = 0; i < v.size(); i++) {
        cout << v[i] << " ";
    }
    cout << std::endl;
    return 0;
}
