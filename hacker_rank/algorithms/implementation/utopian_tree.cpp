#include <iostream>
using namespace std;

int spring = 2, summer = 1;

int height(int n) {
    int c = 1;
    int b = 0;
    for (int i = 1; i <= n; i++) {
        if (i % 2 == 0) {
            c += 1;
        } else {
            c *= 2;
        }
    }
    return c;
}
int main() {
    int T;
    cin >> T;
    while (T--) {
        int n;
        cin >> n;
        cout << height(n) << endl;
    }
}
