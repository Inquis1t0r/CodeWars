function isPrime(num) {
  // negative numbers, 0, and 1 are not prime
  if (num <= 1) {
    return false;
  }
  
  // check if num is divisible by any number from 2 to the square root of num
  for (let i = 2; i <= Math.sqrt(num); i++) {
    if (num % i === 0) {
      return false;
    }
  }
  
  // if we haven't returned false yet, num is prime
  return true;
}
