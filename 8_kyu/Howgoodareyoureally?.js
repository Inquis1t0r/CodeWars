function betterThanAverage(classPoints, yourPoints) {
  // Your code here
  const average = classPoints.reduce((a, b) => a + b, 0) / classPoints.length;
  return yourPoints > average;
}
