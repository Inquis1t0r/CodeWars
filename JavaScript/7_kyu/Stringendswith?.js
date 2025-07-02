function solution(str, ending){
  // TODO: complete
  const endingLength = ending.length;

  const strEnding = str.substring(endingLength-1, str.length);
  return ending === strEnding;
}
