#include <map>
#include <set>
#include <list>
#include <cmath>
#include <ctime>
#include <deque>
#include <queue>
#include <stack>
#include <string>
#include <bitset>
#include <cstdio>
#include <limits>
#include <vector>
#include <climits>
#include <cstring>
#include <cstdlib>
#include <fstream>
#include <numeric>
#include <sstream>
#include <iostream>
#include <algorithm>
using namespace std;


int main(){
    int n;
    cin >> n;
    if (n % 2 == 1) {
        cout << "Weird";
    } else if (n >= 2 && n <= 5 && n % 2 ==0) {
        cout << "Not Weird";
    } else if (n >= 6 && n <= 20 && n % 2 ==0) {
        cout << "Weird";
    } else if (n > 20 && n % 2 == 0) {
        cout << "Not Weird";
    } else {
        cout << "Weird";
    }
   /*    If N is odd, print "Weird".
If N is even and, in between the range of 2 and 5(inclusive), print "Not Weird".
If N is even and, in between the range of 6 and 20(inclusive), print "Weird".
If N is even and N>20, print "Not Weird".*/
    return 0;
}
