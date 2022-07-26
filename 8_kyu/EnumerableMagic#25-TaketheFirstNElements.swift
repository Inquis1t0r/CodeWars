func take(_ arr: [Int], _ n: Int) -> [Int] {
  if arr.count < n{
    return arr
  }else{
    return arr.count == 0 || arr.count < n ? [] : Array(arr[..<n])
  }
}

