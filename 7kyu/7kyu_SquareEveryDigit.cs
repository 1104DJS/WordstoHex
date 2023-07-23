Console.WriteLine(SquareDigits(5));

 static int SquareDigits(int n)
  {
            string stringNum = n.ToString(); // Number to string
            int[] ints = new int[stringNum.Length]; // initialising int array to length of stringNum
            string[] intTostring = new string[stringNum.Length]; // initialising string array to length of stringNum
            for (int i = 0 ; i < stringNum.Length; i++) // For loop
            {
                ints[i] = int.Parse(Convert.ToString(stringNum[i])); // index i = char index of stringNum
                ints[i] *= ints[i]; // multiply num by itself (aka ^ 2)
                intTostring[i] = Convert.ToString(ints[i]); // add to string array
            }
            string final = string.Concat(intTostring); // join the array
            int finalnum = int.Parse(final); // convert to int

            return finalnum;  // output int
  }