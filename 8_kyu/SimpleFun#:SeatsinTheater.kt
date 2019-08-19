fun seatsInTheater(nCols: Int, nRows: Int, col: Int, row: Int): Int {
  val total: Int = (nCols * nRows)  
  val Q1: Int = (row * (col-1))
  val Q2: Int = ((col - 1 ) * ((row+1)*2))
  val Q3: Int = (row * (nRows + 1))
  val sum: Int = (Q1+Q2+Q3)
  
  println(sum)

  
  return if (total - (sum) >= 0) total - (sum) else 0
}
