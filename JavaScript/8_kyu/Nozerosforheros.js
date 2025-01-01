function noBoringZeros(n) {
  // your code
  let stringFromNum = n.toString();
  while(stringFromNum.charAt(stringFromNum.length-1) == 0){
    stringFromNum = stringFromNum.slice(0,-1);
  }
  return Number(stringFromNum);
}
