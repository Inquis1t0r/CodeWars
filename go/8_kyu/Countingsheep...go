package kata

func CountSheeps(numbers []bool) int {
  var count int
  for _, sheep := range numbers {
      if(sheep){
        count++;
      }
    }
  return count // your code here
}
