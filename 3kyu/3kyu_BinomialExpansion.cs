using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections.Generic;

//Console.WriteLine(Expand("(-x-2)^2"));
//Console.WriteLine(Expand("(x-2)^2"));
//Console.WriteLine(Expand("(p-1)^3"));
//System.Console.WriteLine(Expand("(-5m+3)^4"));
//System.Console.WriteLine(Expand("(-7x-7)^0"));
//System.Console.WriteLine(Expand("(-11x+0)^2")); // 121x^2
//System.Console.WriteLine(Expand("(-q+19)^3"));
//System.Console.WriteLine(Expand("(-3l+0)^5")); //-243l^5
System.Console.WriteLine(Expand("(-4s+15)^8"));
// (A+B)^C

static string Expand(string expr){
    List<char> exprList = expr.ToList();
    List<BigInteger> coefficientList = new();
    int locationOfMainOperator;
    int locationOfClosedBracket = expr.IndexOf(')');
    int locationOfPower = expr.IndexOf('^');
    int locationOfSignOfA = 0;
    string valueOfA = string.Empty;
    string valueOfB = string.Empty;
    string valueOfC = string.Empty;
    char signOfA = ' ';
    bool? isAnegative = null;
    bool propertyOfMainOperator; // (T = +)(F = -)

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
    if (valueOfA?.Length == 0) {valueOfA += 1;}

    // gets value of B
    for (int i = locationOfMainOperator; i < locationOfClosedBracket; i++){
        if (char.IsNumber(exprList[i])) { valueOfB += exprList[i]; }
    }

    // gets value of power 
    for (int i = locationOfPower; i <= expr.Length - 1; i++){
        if (char.IsNumber(expr[i])) { valueOfC += expr[i];}
    }

    if (valueOfC == "0") { return "1";}

    // expand binomial expression
    int a, b, c;
    if (isAnegative == true) { a = -(int.Parse(valueOfA!)); }
    else { a = int.Parse(valueOfA!); }
    if (!propertyOfMainOperator) { b = -(int.Parse(valueOfB)); }
    else { b = int.Parse(valueOfB); }
    c = int.Parse(valueOfC);

    for (int i = 0; i <= c; i++)
    {
        coefficientList.Add((BigInteger)(BinomialCoefficient(c, i) * (BigInteger)Math.Pow(a, c - i) * (BigInteger)Math.Pow(b, i)));
    }

    return finalExpression(coefficientList, c, signOfA);
}

// NCR
static BigInteger BinomialCoefficient(int n, int k)
{
    BigInteger result = BigInteger.One;

    for (int i = 1; i <= k; i++)
    {
        result = result * (n - i + 1) / i;
    }

    return result;
}

static string finalExpression(List<BigInteger> ints, int power, char symbol) {
    StringBuilder expr = new();
    for (int i = 0; i <= power; i++){
        if (i < power - 1) {
            if (ints[i] > 0) {
                    if (ints[i] == 1) { expr.Append(symbol).Append('^').Append(power - i); }
                    else if (ints[i] == 0) { continue; }
                    else { expr.Append(ints[i]).Append(symbol).Append('^').Append(power - i); }
                    if (ints[i+1] > 0) { expr.Append('+');}
            }
            else {
                    if (ints[i] == 1) { expr.Append(symbol).Append('^').Append(power - i); }
                    else if (ints[i] == -1) { expr.Append('-').Append(symbol).Append('^').Append(power - i);}
                    else if (ints[i] == 0) { continue; }
                    else { expr.Append(ints[i]).Append(symbol).Append('^').Append(power - i);}
                    if (ints[i+1] > 0) { expr.Append('+');}
            }
        }
        else if (i == power - 1) {
            if (ints[i] > 0) {
                    if (ints[i] == 1) { expr.Append(symbol); }
                    else if (ints[i] == 0) { continue; }
                    else { expr.Append(ints[i]).Append(symbol); }
            }
            else {
                    if (ints[i] == 1) { expr.Append(symbol); }
                    else if (ints[i] == 0) { continue; }
                    else { expr.Append(ints[i]).Append(symbol);}
            }
        }
        else if (i == power) {
            if (ints[i] > 0) { expr.Append('+'); expr.Append(ints[i]);}
            else if (ints[i] < 0) { expr.Append(ints[i]); }
        }
    }
    return expr.ToString();
}