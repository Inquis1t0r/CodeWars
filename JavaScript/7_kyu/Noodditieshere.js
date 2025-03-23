function noOdds( values ){
  // Return all non-odd values
  return values.filter(function(number) {
    return number % 2 === 0;
  });
}
