static string Bmi(double weight, double height) {
    double bmi = weight / (height * height);
    if (bmi <= 18.5) return "Underweight";
    if (bmi <= 25.0) return "Normal";
    if (bmi <= 30.0) return "Overweight";
    return "Obese";
}

Console.WriteLine(Bmi(80, 1.80));
