#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    double price = 0, sem;
    int tip = 0, tax = 0, total = 0;
    
    cin >> price >> tip >> tax;
    if (tip) {sem  = (price * tip) / 100; }
    
    sem += price + ((price * tax) / 100);
    sem = round(sem);
    cout << "The final price of the meal is $" << sem << ".";
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    return 0;
}
