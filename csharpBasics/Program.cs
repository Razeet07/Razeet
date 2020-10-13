using System;
//using AccessModifierAndMethods;
using LearningClasses;
//using P = LearningClasses.Person;
// namespace CSharpBasics
// {
//     class Program
//     {
//         static void Main()
//         {
//             SelectionStatement selectionStatement = new SelectionStatement();
//             selectionStatement.LearnIfElse();
//             selectionStatement.LearnSwitchCases();
//         }
//     }
// }
class Program
{
    // static void Main2342()
    // {
    //     //IterationStatement iterationStatement = new IterationStatement();
    //     //iterationStatement.LearnForLoops();
    //     AccessModifier accessModifier = new AccessModifier();
    //     accessModifier.DoSomething();

    //     Human human = new Human();
    //     human.name = "Bishnu";
    //     human.Age = 179;

    //     var x = human.Address;
    // }
    static void Main()
    {
    
        var person1 = new Person("Rajesh", "ktm", 23);
        var person2 = new Person("Ram", "lalitpur", 20);
        var person3 = new Person("Syam", "Bhaktapur", 40);
        var person4 = new Person();
        
        var x = Person.ScientificName;

        //Person.Do();

        var y = Math.Sqrt(25);

        var s = Calculator.Sum<int>(23, 24);
        var t = Calculator.Sum<decimal>(233454.23m, 244514.23m);

        // Rectangle rectangle1 = new Rectangle();
        // rectangle1.Length = 23.6;
        // rectangle1.Breadth = 6.32;
        // var result = rectangle1.GetArea();

        Shape r = new Rectangle(23.6, 6.32);
        Rectangle r1 = new Rectangle(278.6, 61.32);
        r.PrintDetails();
        r1.PrintDetails();

        Shape s1 = new Square(34.5);        
        s1.PrintDetails();

        Shape c = new Circle(23.4);
        c.PrintDetails();

    }
}