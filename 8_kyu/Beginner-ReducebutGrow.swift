func grow(_ arr: [Int]) -> Int {
  var result = 1
  for num in arr {
    result *= num 
  }
  return result
}
