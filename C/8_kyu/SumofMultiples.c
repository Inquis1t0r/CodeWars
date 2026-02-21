//  for invalid input, return -1

int sum_mul(int n, int m) {
    if(n <= 0 || m <= 0){
      return -1;
    }
    //  <----  hajime!
    int result = n;
    
    do{
      result = result * 2;
    } while(result < m);
    return result;
}
