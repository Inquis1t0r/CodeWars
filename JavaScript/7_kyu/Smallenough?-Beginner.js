function smallEnough(a, limit){
  let result = true;
  
  a.forEach(function(element) {
    if(element > limit){
      result = false;
    }
  });
  
  return result;
}
