using System;
using System.Collections.Generic;

namespace kaprekar
{
    class Program
    {
        static void Main(string[] args)
        {

            int kaprekar = 6174;

            System.Console.WriteLine("Hey this is a fun game!  Pick a 4 digit number with at least two different digits and it will eventually become 6174");

            string userInput = Console.ReadLine();

            if (userInput.Length == 4)
            {
                System.Console.WriteLine("Bad Input yo!");
            }

            int count = 0;
            int check = 0;
            while (check != kaprekar)
            {
                count++;
                if (check != 0)
                {
                    userInput = check.ToString();
                }

                int largeNumber;
                int smallNumber;


                char[] numbers = userInput.ToCharArray();
                System.Console.WriteLine("Numbers Length:" + numbers.Length);
                Array.Sort(numbers);
                var smallNumberString = String.Join("", numbers);
                Array.Reverse(numbers, 0, 3);
                var largeNumberString = String.Join("", numbers);
                int.TryParse(smallNumberString, out smallNumber);
                int.TryParse(smallNumberString, out largeNumber);

                System.Console.WriteLine("LARGE: " + largeNumber);
                System.Console.WriteLine("small: " + smallNumber);

                check = largeNumber - smallNumber;

                System.Console.WriteLine("That took " + count + " iterations");

            }














            // List<int> ln = new List<int>();
            // List<int> sn = new List<int>();





        }
    }
}


//  List<int> numbers = new List<int>();

//             var userInput = System.Console.ReadLine();
//             if (Int32.TryParse(userInput, out int choice))
//             {




//                 foreach (int item in numbers)
//                 {
//                     System.Console.WriteLine(item);
//                 }

//                 for (int i = 0; i < numbers.Count; i++)
//                 {
//                     System.Console.WriteLine(numbers[i]);
//                 }
//             }
