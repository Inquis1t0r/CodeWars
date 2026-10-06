export function cubeChecker(volume: number, side: number): boolean {
  if (!Number.isFinite(volume) || !Number.isFinite(side)) return false;
  if (volume <= 0 || side <= 0) return false;
  return side ** 3 === volume;
}
