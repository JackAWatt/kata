#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */  
    int N,x;
    cin >> N;
    vector<int>v_sort;
    int size = v_sort.size();
    for (int i = 0; i < N; i++) {
        cin >> x;
        v_sort.push_back(x);
    }
    sort(v_sort.begin(), v_sort.end());
    for (int i = 0; i < v_sort.size(); i++) {
        cout << v_sort[i] << " ";
    }
    return 0;
}
