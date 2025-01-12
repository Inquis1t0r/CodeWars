function remainder(n, m){
  // Divide the larger argument by the smaller argument and return the remainder
    if (n === 0 || m === 0) {
        return NaN;
    }

    const larger = Math.max(n, m);
    const smaller = Math.min(n, m);

    return larger % smaller;
}
