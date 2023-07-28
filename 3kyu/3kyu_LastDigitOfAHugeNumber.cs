using System;

static int LastDigit(int[] array) {
    int sum = 1;
    for (int i = array.Length - 1; i >= 0; i--) {
        sum = (int)Math.Pow(i == 0 ? array[i] % 10 : array[i] < 4 ? array[i] : (array[i] % 4) + 4, sum < 4 ? sum : (sum % 4) + 4);
    }
        return sum % 10;
}