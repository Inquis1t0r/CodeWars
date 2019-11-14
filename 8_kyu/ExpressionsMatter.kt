class Kata {
    companion object {
     
     fun expressionsMatter(a : Int, b : Int, c : Int) : Int {
      
         val numArray = intArrayOf(a * (b + c), a * b * c, a + b * c, (a + b) * c, a + b + c)
         return numArray.max() ?: 0
     }
     
    }
}
