  
using System;
class IterationStatement{
    //PascalCase -> method name, class name
    //camelCase -> variable name 

    
    void LearnForLoops()
    {
        
        int [] numbers = {4,5,6,7,8,9,10};
        foreach(int num in numbers){
            if (num % 2 !=0){
                Console.WriteLine(num);
            }
        }

    }

    void LearnWhileLoops()
    {
        string confirm = "Y";
        while(confirm == "Y")
        {
            Console.WriteLine("HEllo");
            Console.WriteLine("Want to print more?");
            confirm = Console.ReadLine();
        }
    }
}