func vaporcode(_ str: String) -> String {
    let noWhitespace = str.replacingOccurrences(of: " ", with: "") 
    let uppercased = noWhitespace.uppercased() 
    let spacedOut = uppercased.map { "\($0)  " }.joined()
    return spacedOut.trimmingCharacters(in: .whitespaces) 
}
