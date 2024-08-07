using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        string answer;
        int number;

        while (true)
        {
            Console.Write("\nEnter an integer to be added into the list. Enter 'x' to finish adding : ");
            answer = Console.ReadLine();
            if (answer == "x")
            {
                break;
            }

            if (!int.TryParse(answer, out number))
            {
                Console.WriteLine("This is not a valid input.");
            }
            else
            {
                numberList.Add(number);
                Console.WriteLine($"Added {number} to the list.");
            }

        }

        int length = numberList.Count;

        Console.WriteLine("\nThe integers in the list right now : ");
        Console.Write("\nIntegers     : [ ");
        for (int i = 0; i < length; i++)
        {
            Console.Write($" {numberList[i]} ");
        }
        Console.Write(" ]");
        Console.Write("\nIndex        : [ ");
        for (int i = 0; i < length; i++)
        {
            Console.Write($" {i + 1} ");
        }
        Console.Write(" ]");

        int sum;

        Console.Write("\n\nEnter the total sum you want to get : ");
        while (!int.TryParse(Console.ReadLine(), out sum))
        {
            Console.WriteLine("\nThis is not a valid input.");
            Console.WriteLine("\nEnter the total sum you want to get : ");
        }

        int stat = 0;
        int sum2;

        //List<Tuple<int, int>> pairI = new List<Tuple<int, int>>();
        //List<Tuple<int, int>> pairJ = new List<Tuple<int, int>>();

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                sum2 = numberList[i] + numberList[j];

                if (sum2 == sum)
                {

                   // pairI.Add(new Tuple<int, int>(i, j));
                   // pairJ.Add(new Tuple<int, int>(j, i));

                    if (i != j)
                    {
                        Console.WriteLine($"\nFirst integer {numberList[i]} and Second integer {numberList[j]}");
                        Console.WriteLine($"The index are {i + 1} and {j + 1}");
                        stat = 1;
                    }

                }
            }
            /*int size;
            Console.Write("\nHow many number do you want to enter : ");
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.Write("This is not a valid input.");
                Console.Write("\nHow many number do you want to enter : ");
            }*/

            /*int[] num = new int[size];
            for (int i = 0; i < size; i++)
            {
                  Console.Write($"Enter number for index {i + 1} : ");
                  //num[i] = Convert.ToInt32(Console.ReadLine());

                while (!int.TryParse(Console.ReadLine(), out num[i]))
                {
                    Console.WriteLine("This is not a valid input.");
                    Console.Write($"Enter number for index {i + 1} : ");
                }
            }*/

            /*for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"The numbers for index {i + 1} : {num[i]}");
            }*/

            /*int sum;

            Console.Write("Enter the total sum you want to get : ");
            while (!int.TryParse(Console.ReadLine(), out sum))
            {
                Console.Write("This is not a valid input.");
                Console.Write("Enter the total sum you want to get : ");
            }*/

            /*int sum2, stat=0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                { 
                    sum2 = num[i] + num[j];

                    if (sum2 == sum)
                    {
                        Console.WriteLine($"First number {num[i]} and Second number {num[j]}");
                        Console.WriteLine($"The index are {i-1} and {j-1}");
                        stat = 1;

                    }

                }
            }
            if (stat != 1)
            {
                Console.WriteLine("There's no possible summation");
            }*/


        }
        if (stat != 1)
        {
            Console.WriteLine("There's no possible summation");
        }
    }
}