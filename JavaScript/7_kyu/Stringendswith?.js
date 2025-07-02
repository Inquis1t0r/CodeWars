function solution(str, ending){
  // TODO: complete
  const endingLength = ending.length;

  const strEnding = str.substring(str.length - endingLength, str.length);
  return ending === strEnding;
}

