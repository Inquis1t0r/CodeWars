func findMissingTerm(_ l: [Int]) -> Int? {
    let n = l.count
    let commonDiff = (l[n-1] - l[0]) / n // calculate common difference

    for i in 0..<n-1 {
        let expectedNext = l[i] + commonDiff // calculate what the next number should be
        if l[i+1] != expectedNext {
            return expectedNext // return the missing number
        }
    }
    return nil // return nil if no missing number is found
}
