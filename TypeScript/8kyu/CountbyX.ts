export function countBy(x: number, n: number): number[] {
  return Array.from({ length: n }, (_, index) => x * (index + 1));
}
