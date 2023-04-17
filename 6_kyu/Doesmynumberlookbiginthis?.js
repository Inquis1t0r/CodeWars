function narcissistic(value) {
  const digits = value.toString().split("");
  const power = digits.length;
  const sum = digits.reduce((acc, digit) => {
    return acc + Math.pow(parseInt(digit), power);
  }, 0);
  return sum === value;
}
