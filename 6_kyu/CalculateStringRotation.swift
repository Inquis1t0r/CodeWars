func shiftedDiff(_ first: String, _ second: String) -> Int? {
    guard first.count == second.count else {
        return nil
    }
    
    let combined = first + first
    for i in 0..<first.count {
        let index = combined.index(combined.startIndex, offsetBy: i)
        let substring = String(combined[index..<combined.index(index, offsetBy: first.count)])
        
        if substring == second {
            return i
        }
    }
    
    return nil
}
