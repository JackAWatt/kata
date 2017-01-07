#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    int T, a , b , N, total = 0;
    cin >> T;
    
    for (int i = 0; i < T; i++) {
        cin >> a >> b >> N;
        total += a;
        for (int j = 0; j < N; j++) {
            if (j == 0) {
                cout << (a + (1 * b))<<  " ";
            } else if (j == 1) {
                cout << (a + (1 * b) + (2 * b)) << " ";
            } else if (j == 2) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) << " ";
            } else if (j == 3) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) << " ";
            } else if (j == 4) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) << " ";
            } else if (j == 5) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) << " ";
            }else if (j == 6) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) << " ";
            } else if (j == 7) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) + (128 * b) << " ";
            } else if (j == 8) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) + (128 * b) + (256 * b) << " ";
            } else if (j == 9) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) + (128 * b) + (256 * b) + (512 * b) << " ";
            } else if (j == 10) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) + (128 * b) + (256 * b) + (512 * b) + (1024 * b) << " ";
            } else if (j == 11) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) + (128 * b) + (256 * b) + (512 * b) + (1024 * b) + (2048 * b) << " ";
            }else if (j == 12) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) + (128 * b) + (256 * b) + (512 * b) + (1024 * b) + (2048 * b) + (4096 * b) << " ";
            } else if (j == 13) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) + (128 * b) + (256 * b) + (512 * b) + (1024 * b) + (2048 * b) + (4096 * b) + (8192 * b) << " ";
            } else if (j == 14) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) + (128 * b) + (256 * b) + (512 * b) + (1024 * b) + (2048 * b) + (4096 * b) + (8192 * b) + (16384 * b) << " ";
            } else if (j == 15) {
                cout << (a + (1 * b) + (2 * b)) + (4 * b) + (8 * b) + (16 * b) + (32 * b) + (64 * b) + (128 * b) + (256 * b) + (512 * b) + (1024 * b) + (2048 * b) + (4096 * b) + (8192 * b) + (16384 * b) + (32768 * b) << " ";
            }

        }
        cout << "\n";
        total = 5;
    }
  
    return 0;
}
