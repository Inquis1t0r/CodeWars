function remainder(n, m){
  // Divide the larger argument by the smaller argument and return the remainder
    const larger = Math.max(Math.abs(n), Math.abs(m));
    const smaller = Math.min(Math.abs(n), Math.abs(m));
  
    if(smaller === 0){
       return NaN;
    }

    return larger % smaller;
}
