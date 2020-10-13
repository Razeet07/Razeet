  
using System;
class IterationStatement
{
    //Pascal case: ItrationStatement (class, methods)
    //Camel case: iterationStement(variables)
    static void Main()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoops();
    }

    void LearnForLoops()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello World!");
        }

        int[] numbers = { 4,5,23,45,67,12};
        //for(int x = 0; x < numbers.Length; x++)
        //{
        //    Console.WriteLine(numbers[x]);
       // }

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }

    void LearnWhileLoops()
    {
        //int i = 0;
        //while (i < 10)
        //{
            //Console.WriteLine("Hello World!");
           // i++;
        //}
        string confirm = "Y";
        while (confirm == "Y")
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Want to print again?");
            confirm = Console.ReadLine();
        }

        string confirm1 = "Y";
        do
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Do you want to print again?");
            confirm1 = Console.ReadLine();
        }
        while (confirm1 == "Y");
        
    }
}
