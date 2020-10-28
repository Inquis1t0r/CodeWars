import Foundation

func formatMoney(_ val:Double) -> String {
  let cashValue = String(format: "%.2f", val)
  return "$" + cashValue
}
