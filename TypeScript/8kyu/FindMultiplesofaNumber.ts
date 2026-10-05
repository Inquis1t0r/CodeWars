export function findMultiples(integer: number, limit: number): number[] {
    const result: number[] = [];
    for (let i = integer; i <= limit; i += integer) {
      result.push(i);
    }
    return result;
}
