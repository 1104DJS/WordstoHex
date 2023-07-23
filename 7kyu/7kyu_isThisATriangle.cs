Console.WriteLine(IsTriangle(5, 5, 5));

static bool IsTriangle(int a, int b, int c)
{
        double semiPermiter = 0.5 * (a + b + c);
        if (a <= 0 || b <= 0 || c <= 0) { return false; }
        return Math.Sqrt(semiPermiter * ((semiPermiter - a) * (semiPermiter - b) * (semiPermiter - c))) > 0;
}
