package kata
 	
import "fmt"

func Maps(x []int) []int {
  //var result = [3]int
  for index,element := range x{
    x[index]+= element*2
    println(x[index])
  }
  fmt.Println(x)
  return x
}
