#include <vector>
#include <cmath>

int square_sum(const std::vector<int>& numbers)
{
  int sum = 0;
  for(int number : numbers)
    {
      sum += pow(number, 2);
    }
  
    return sum;
}
