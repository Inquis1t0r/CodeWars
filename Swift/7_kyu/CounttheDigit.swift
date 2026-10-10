func nbDig(_ n: Int, _ d: Int) -> Int {
    let target = Character(String(d))
    var count = 0
    for k in 0...n {
        count += String(k * k).filter { $0 == target }.count
    }
    return count
}
