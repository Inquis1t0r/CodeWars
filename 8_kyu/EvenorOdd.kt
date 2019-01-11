fun evenOrOdd(number: Int): String {
 //code here
 val test = number % 2 == 0
 val result: String = if (test) "Even" else "Odd"
 return result
}
