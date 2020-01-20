func replaceAll<T: Equatable>(array: [T], old: T, new: T) -> [T] {
  var myArray: [T] = []
  for (index, item) in array.enumerated() {
      print("Found \(item) at position \(index)")
      if(item == old)
      {
        myArray.append(new)
      }
      else
      {
        myArray.append(item)
        }
  }
  
  return myArray
}
