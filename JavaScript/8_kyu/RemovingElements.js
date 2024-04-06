function removeEveryOther(arr){
  const filteredArray = arr.filter((_, index) => index % 2 === 0);
  return filteredArray;
}
