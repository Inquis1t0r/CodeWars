func RentalCarCost(_ days: Int) -> Int {
  var discount = 0
  
  if(days >= 7 ){
    discount += 50
  }else if(days >= 3){
    discount += 20
  }
  
  return (days * 40) - discount
}
