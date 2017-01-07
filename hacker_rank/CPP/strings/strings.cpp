#include <iostream>
#include <string>
using namespace std;

int main() {
   // Complete the program
    string a,b;
    char t;
    cin >> a >> b;
    cout << a.length() << " " << b.length() << "\n";
    cout << a << b << "\n";
    t = a[0];
    a[0] = b[0];
    b[0] = t;
    cout << a << " " << b;
    
    
  
    return 0;
}
