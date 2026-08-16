package kata
 	

func Maps(x []int) []int {
  for index,element := range x{
    x[index]+= element
  }
  
  return x
}
