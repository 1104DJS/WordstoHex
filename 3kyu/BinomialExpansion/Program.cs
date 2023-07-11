//KataSolution.Expand("(x+1)^2");      // returns "x^2+2x+1"
//no negative powers
//x is left side always
//
Expand("(-x-2)^2");

static void Expand(string expr){

    int signMain; // SM 0 = -, SM 1 = +
    int locationP = 0, locationS = 0;
    string numA = string.Empty, numB = string.Empty;
    string rewrite = expr;

    locationP = expr.IndexOf('^') + 1;

    if (expr[1] == '-') { rewrite.Remove(1); } 
    if (expr.Contains('+')){ locationS = expr.IndexOf('+');}
    else if (expr.Contains('-')){ locationS = expr.IndexOf('-'); }

    for (int i = 1; i < 3; i++) { numA += expr[i]; }
    for (int j = locationS; j < expr.IndexOf(')'); j++) { numB += expr[j];}

    Console.WriteLine(numA);
    Console.WriteLine(locationS); Console.WriteLine(expr.IndexOf("+"));
    Console.WriteLine(expr[locationP] + "yes" + expr[locationS]);
    

    


}