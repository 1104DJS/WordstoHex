using System.Text;

Expand("(-x-2)^2");
// (A+B)^C

static void Expand(string expr){
    List<char> exprList = expr.ToList<char>();
    int locationOfMainOperator;
    int locationOfClosedBracket = expr.IndexOf(')');
    int locationOfPower = expr.IndexOf('^');
    int locationOfSignOfA = 0;
    string valueOfA = string.Empty;
    string valueOfB = string.Empty;
    string valueOfC = string.Empty;
    char signOfA = ' ';
    bool? isAnegative = null;
    bool? propertyOfMainOperator = null; // (T = +)(F = -)

    if (expr[1] == '-') { isAnegative = true; exprList.RemoveAt(1); } // find if A is negative
    if (expr.Contains('+')) { propertyOfMainOperator = true; locationOfMainOperator = exprList.IndexOf('+') + 1;} // find if main operator is positive
    else { propertyOfMainOperator = false; locationOfMainOperator = exprList.IndexOf('-') + 1;} // find location of main operator if negative

    // gets location of sign of A and sign of A
    for (int i = 1; i < locationOfMainOperator; i++) {
        if (char.IsLetter(exprList[i])) { signOfA = exprList[i]; locationOfSignOfA = i + 1; }
    }

    // gets value of A (if A > 1)
    for (int i = 1; i < locationOfSignOfA; i++) {
        if (char.IsNumber(exprList[i])) { valueOfA += exprList[i];}
    }
    // if string is still empty assume A = 1
    if (valueOfA == string.Empty) {valueOfA += 1;}

    // gets value of B
    for (int i = locationOfMainOperator; i < locationOfClosedBracket; i++){
        if (char.IsNumber(exprList[i])) { valueOfB += exprList[i]; }
    }

    // gets value of power 
    for (int i = locationOfPower; i < expr.Length - 1; i++){
        if (char.IsNumber(exprList[i])) { valueOfC += exprList[i];}
    }

    // expand binomial expression
    StringBuilder expandedExpression = new StringBuilder();
    int a, b, c;
    if (isAnegative == true) { a = -(int.Parse(valueOfA)); }
    if (propertyOfMainOperator == false) { b = -(int.Parse(valueOfB)); }
    else { b = int.Parse(valueOfB); }
    c = int.Parse(valueOfC);
}