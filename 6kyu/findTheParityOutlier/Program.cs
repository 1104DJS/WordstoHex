int[] integers = { 5, 3 ,4 ,2, 12 };
Console.WriteLine(Find(integers));

static int Find(int[] integers)
{
    int ECount = 0; int OCount = 0;

    for (int i = 0; i < integers.Length; i++) {
        if (integers[i] % 2 == 0) { ECount++; }
        else { OCount++; }
    }

    if (ECount > OCount) { return CheckInts(integers, 0); } // Check for Odd and return value
    else if (OCount > ECount) { return CheckInts(integers, 1); } // Check for Even and return value

    return 0;
}

static int CheckInts(int[] intsArr, int state)
{
    for (int i = 0; i < intsArr.Length; i++) {
        if (state == 0) { if (intsArr[i] % 2 == 1) { return intsArr[i]; } }
        else { if (intsArr[i] % 2 == 0) { return intsArr[i]; } }
    }

    return 0;
}