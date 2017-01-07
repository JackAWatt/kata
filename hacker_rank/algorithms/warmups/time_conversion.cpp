#include <cmath>
#include <cstdio>
#include <vector>
#include <string>
#include <iostream>
#include <stdlib.h>
#include <algorithm>
using namespace std;


int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int hh = 0, mm = 0, ss = 0;
    bool y = 1;
    string hour = "12";
    string minute;
    string second;
    string format;
    cin >> format;
    if (format[8] != 'P') {
        if (format[0] == '1' && format[1] == '2') {
            cout << "00:";
        } else {
        cout << format[0] << format[1] << ":";
    }
        y = 0;
    } else {
        if (format[0] == '1') {
            if (format[1] == '0') {
                hh = 10;
            } else if (format[1] == '1') {
                hh = 11;
            } else {
                hh = 12;
            }
        } else if (format[0] == '0') {
            y = 0;
            if (format[1] == '1') {
                cout << "13:";
            } else if (format[1] == '2') {
                cout << "14:";
            } else if (format[1] == '3') {
                cout << "15:";
            } else if (format[1] == '4') {
                cout << "16:";
            } else if (format[1] == '5') {
                cout << "17:";
            } else if (format[1] == '6') {
                cout << "18:";
            } else if (format[1] == '7') {
                cout << "19:";
            } else if (format[1] == '8') {
                cout << "20:";
            } else if (format[1] == '9') {
                cout << "21:";
            } else {
                hh = 0;
            }
        }
        if (y) {
        hh = hh + 12;
        if (hh && hh != 24) {
            cout << hh << ":";
        } else if (hh == 24) {
            cout << "12:";
        }else {
            cout << "00:";
            
                
        }
        }
    }    
    cout << format[3] << format[4] << ":" << format[6] << format[7] ;
    return 0;
}
