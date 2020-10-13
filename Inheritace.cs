using System;

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public virtual void PrintDetails()
    {
        Console.WriteLine("Printing details for shape..");
    }

}

public interface IDiagonalComputable
{
    public double GetDiagonalLength();
}

// public class Square : Shape
// {
//     public double Side {get; set; }
//     public override double GetArea() => Side * Side;

//     public override double GetPerimeter() => 4 * Side;
// }

public class Rectangle : Shape, IDiagonalComputable
{
    public Rectangle() {}
    public Rectangle(double l, double b)
    {
        this.Length = l;
        this.Breadth = b;
        
    }
    public double Length {get; set; }
    public double Breadth {get; set; }
    public override double GetArea() => Length * Breadth;

    public double GetDiagonalLength() => Math.Sqrt(Length*Length + Breadth*Breadth);
    
    public override double GetPerimeter() => 2 * (Length + Breadth);

    public override void PrintDetails()
    {
        Console.WriteLine("Printing details for Rectangle: ");
        Console.WriteLine($"Length : {Length}, Breadth : {Breadth}");
        Console.WriteLine($"Area : {this.GetArea()}, Perimeter: {this.GetPerimeter()}");
    }
}

public class Square : Rectangle
{
    // public Square(double s)
    // {
    //     this.Side = s;
    // }
    // public double Side {get; set; }

    public Square(double s) : base(s,s)
    {

    }
}


public class Circle : Shape
{
    public Circle(double r)
    {
        Radius = r;
    }
    public double Radius {get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;

    public override double GetPerimeter() => 2 * Math.PI * Radius; 
}

//Single inheritance 
class A 
{

}

class B : A
{

}

class C : B
{

}

class D : A, IX, IY
{

}

interface IX
{

}
interface IY
{

}