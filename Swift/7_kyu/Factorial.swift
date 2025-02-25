func factorial(_ n: Int) -> UInt64 {
  var result = 0
  for i in 1...n {
      result = result * i
  }
  return UInt64(result)
}

// If "random tests" exits with code 132, it likely means that
// a calculation exceeded UInt64.max
// n is chosen so n! should not exceed UInt64.max
