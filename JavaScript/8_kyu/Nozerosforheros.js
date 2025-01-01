function noBoringZeros(n) {
  let stringFromNum = n.toString();
  while(stringFromNum.charAt(stringFromNum.length-1) == 0 && stringFromNum.length > 1){
    stringFromNum = stringFromNum.slice(0,-1);
  }
  return Number(stringFromNum);
}
