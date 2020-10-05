#include <vector>

int square_sum(const std::vector<int>& numbers)
{
  int sum = 0;
  for(int number : numbers)
    {
      sum += number ^ 2;
    }
  
    return sum;
}
