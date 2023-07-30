static long NextBiggerNumber(long n) {
    string numString = n.ToString();
    char[] digits = numString.ToCharArray();
    int indexCurrent, indexNext;
    long nextBiggerNumber = 0;

    for (indexCurrent = digits.Length-1; indexCurrent > 0; indexCurrent--) {
        if (digits[indexCurrent] > digits[indexCurrent-1]) break;
    }

    if (indexCurrent == 0) { return -1; }
    else {
        long x = digits[indexCurrent-1], smallest = indexCurrent;

        for (indexNext = indexCurrent + 1; indexNext < digits.Length; indexNext++) {
            if (digits[indexNext] > x && digits[indexNext] < digits[smallest]) smallest = indexNext;
        }

        (digits[smallest], digits[indexCurrent-1]) = (digits[indexCurrent-1], digits[smallest]);
        Array.Sort(digits, indexCurrent, digits.Length - indexCurrent);

        for (int k = 0; k < digits.Length; k++) nextBiggerNumber = (nextBiggerNumber * 10) + (digits[k] - '0');

        return nextBiggerNumber;
    }
}

System.Console.WriteLine(NextBiggerNumber(513));