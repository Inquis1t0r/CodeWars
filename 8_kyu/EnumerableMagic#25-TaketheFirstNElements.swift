func take(_ arr: [Int], _ n: Int) -> [Int] {
  if(arr.count == 0){
    return []
  }else{
    return Array(arr[..<n])
  }
}
