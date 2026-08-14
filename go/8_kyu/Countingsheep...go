package kata

func CountSheeps(numbers []bool) int {
  count := 0
  for _, sheep := range numbers {
      if sheep{
        count++
      }
    }
  return count // your code here
}
