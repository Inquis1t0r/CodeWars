package kata

import "fmt"

func HowMuchILoveYou(i int) string {
  phrases := [6]string{
		"I love you",
		"a little",
		"a lot",
		"passionately",
		"madly",
		"not at all",
	}
  
  fmt.Println(i)
  if(i>5){
    i-=6
  }
  return phrases[i]
}
