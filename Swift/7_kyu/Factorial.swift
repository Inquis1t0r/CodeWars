func factorial(_ n: Int) -> UInt64 {
  return 0
}

// If "random tests" exits with code 132, it likely means that
// a calculation exceeded UInt64.max
// n is chosen so n! should not exceed UInt64.max
