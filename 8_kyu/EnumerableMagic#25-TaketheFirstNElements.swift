func take(_ arr: [Int], _ n: Int) -> [Int] {
  return arr.count == 0 ? [] : Array(arr[..<n])
}

