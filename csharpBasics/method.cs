using System;
using System.Linq;

class Method
{
    void PrintInfo()
    {
        Console.WriteLine("Printing something...");
        Multiply(23.22f, 224.55f);
        Multiply(23.22f, 22.55f, 5.55f);
        Sum(2.3, 45.5, 20.6);
        Greet("Sobit", "Hi");
        Greet("Sobit");
        byte[] numbers = {2 ,8, 5, 50, 4, 50};
        (byte Min, byte Max) result = FindMinMax(numbers);
        //(_, byte Max) result = FindMinMax(numbers);
        //named arguments
        PrintCustomerDetails(age:20, name: "Sobit", isMale: true, address: "Lamjung Nepal");
    }
    
    void PrintSomething(string message)
    {
        Console.WriteLine("message");
    }
    float Multiply(float firstNum, float secondNum)
    {
        float product = firstNum * secondNum;
        return product;
    }

    float Multiply(float firstNum, float secondNum, float thirdNum)//funcion overloading,
    {
        float product = firstNum * secondNum+thirdNum;
        return product;
    }

    //variables number of arguments
    double Sum(params double[] numbers)
    { 
        double sum = 0;
        foreach (double num in numbers)
        {
            sum = sum + num;
        }
        return sum;
    }
    //Optional Arguments
    string Greet(string name, string prefix = "Miss.")
    {
        //string fullName = prefix + "," + name;
        string fullName = $"{prefix}, {name}";//string interpolation
        return fullName;
    }

    //Returing multipe values :using tuples
    (byte, byte) FindMinMax(byte[] numbers)
    {
        byte max = numbers.Max();
        byte min = numbers.Min();
        return(min,max);
    }

    void PrintCustomerDetails(string name, string address, byte age, bool isMale)
    {
        Console.WriteLine($"{name}, {address}, [{age}]");
    }

    //Expression bodied method syntax
    float Subtract(float firstNum, float secondNum) =>firstNum - secondNum;

}