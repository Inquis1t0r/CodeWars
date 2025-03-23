function noOdds( values ){
  // Return all non-odd values
  return values.filter(function(number) {
    return number % 2 === 0;
  });
}

//noOdds=a=>a.filter(a=>!(a%2))
