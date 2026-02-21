//  for invalid input, return -1

int sum_mul(int n, int m) {
    if(n <= 0 || m <= 0){
      return -1;
    }
    //  <----  hajime!
    int result = 0;
    int multiplier = 0;

    while (n * multiplier < m) {
      result += n * multiplier;
      multiplier += 1;
    }
    return result;
}
