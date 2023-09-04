func bmi(_ weight: Int, _ height: Double) -> String {
    
    var result: String
    var BMI = Double(weight) / pow(height, 2)

    if BMI <= 18.5 {
        result = "Underweight"
    } 
    else if BMI <= 25.0 {
        result = "Normal"
    } 
    else if BMI <= 30.0  {
        result = "Overweight"
    }
    else {
        result = "Obese"
    }
    return result
}
