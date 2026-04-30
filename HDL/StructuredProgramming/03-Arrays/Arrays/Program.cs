using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        Console.WriteLine(string.Join(", ", numbers));

        var numbersVar = new int[5]
        {
            1,2,3,4,5
        };

        Console.WriteLine(string.Join(", ", numbersVar));

        Console.WriteLine(numbers[2]);
    }
}