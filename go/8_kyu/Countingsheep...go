package kata

func CountSheeps(numbers []bool) int {
  var i int
  for x:=0; x < len(numbers); x++{
      if(numbers[x] == true){
        i++;
      }
    }
  return i // your code here
}
