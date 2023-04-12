func removNb(_ n: Int) -> [(Int,Int)] {
    let sum = (1...n).reduce(0, +)
    var result = [(Int, Int)]()
    for a in 1...n {
        let b = (sum - a) / (a + 1)
        if a * b + a + b == sum && b <= n {
            result.append((a, b))
        }
    }
    return result
}
