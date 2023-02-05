using System;

public class Program

{

    public static void Main()

    {
        Console.WriteLine("Input the number of elements to be stored in the array :");
        int num = Convert.ToInt32(Console.ReadLine());

        int i;

        List<int> oddNums = new List<int>(0) {};
        List<int> evenNums = new List<int>(0) { };


        for (i=0; i<num; i++)
        {
            Console.WriteLine("element - " + i + ":");
            int addNum = Convert.ToInt32(Console.ReadLine());

            if(addNum%2 == 0) 
            {
                evenNums.Add(addNum);
            } else
            {
                oddNums.Add(addNum);
            }
        }

        Console.WriteLine("The even numbers are:");
        for(i=0; i<evenNums.Count; i++)
        {
            Console.WriteLine(evenNums[i]);
        }

        Console.WriteLine("The odd numbers are:");
        for (i = 0; i < oddNums.Count; i++)
        {
            Console.WriteLine(oddNums[i]);
        }
    }

}