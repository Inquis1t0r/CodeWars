#include <math.h>
#include <stdlib.h>

int multiply(int number) {
  if (number == 0) return 0;
  int base = 5;
  int digits = log10(abs(number)) + 1;

    //  <----  hajime!
  return number * (int)round(pow(base, digits));
}
