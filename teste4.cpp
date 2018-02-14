/*
 * @Author: Marcos ABS (desouza.marcos@uol.com.br) 
 * @Date: 2018-02-08 19:24:59 
 * @Last Modified by: Marcos ABS (desouza.marcos@uol.com.br)
 * @Last Modified time: 2018-02-08 19:25:42
 */
#include <iostream.h>

using namespace std;


int main() {
    int n = 0;
    while(n<=100) {
        n++;
        if(n % 2 != 0) {
            continue;
        }
        cout << n;
        cout << " ";
    }
        cout << "" << endl;
    return 0;
}