function invert(array) {
  let result = [];
  
  array.forEach(function(ele) {
      result.push(ele * -1);
    });
  
   return result;
}
