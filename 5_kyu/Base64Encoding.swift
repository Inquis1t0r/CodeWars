extension String {
	public var toBase64: String {
        guard let data = self.data(using: .ascii) else {
            return ""
        }
        return data.base64EncodedString(options: [])
	}
	
	public var fromBase64: String {
        guard let data = Data(base64Encoded: self) else {
            return ""
        }
        return String(data: data, encoding: .ascii) ?? ""
	}
}
