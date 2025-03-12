using System;
using System.Numerics;

abstract class shape
{
    public abstract bool legal();
    public abstract double getArea();
}

class rectangle:shape
{
    public double sideA { get; set; }
    public double sideB { get; set; }
    public override bool legal()
    {
        if(sideA<=0||sideB<=0)
            return false;
        else return true;
    }
    public override double getArea()
    {
        if (!legal())
        {
            throw new Exception();
        }
        return sideA * sideB;
    }
    public rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }
}

class square : shape
{
    public double side { get; set; }
    public override bool legal()
    {
        if (side <= 0) return false;
        else return true;
    }
    public override double getArea()
    {
        if (!legal())
        {
            throw new Exception();
        }
        return side * side;
    }
    public square(double side)
    {
        this.side = side;
    }
}

class triangle : shape
{
    public double sideA { get; set; }
    public double sideB { get; set; }
    public double sideC { get; set; }
    public override bool legal()
    {
        if (sideA<=0||sideB<=0||sideC<=0||sideA+sideB<=sideC||sideA+sideC<=sideB||sideB+sideC<=sideA)return false;
        else
        {
            return true;
        }
    }
    public override double getArea()
    {
        if (!legal())
        {
            throw new Exception();
        }
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }
    public triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }
}

class ShapeFactory
{
    private static Random rand = new Random();

    public shape creatShape()
    {
        int type=rand.Next(0,3);
        switch(type)
        {
            case 0:
                shape rect = new rectangle(rand.Next(1,10),rand.Next(1,10));
                return rect;
            case 1:
                shape sq=new square(rand.Next(1,10));
                return sq;
            case 2:
                int a = rand.Next(1, 10);
                int b = rand.Next(1, a);
                int c = rand.Next(a-b+1, a + b);
                shape tri=new triangle(a,b,c);
                return tri;
            default: throw new Exception();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();
        List<shape> shapes=new List<shape>();
        for (int i = 0; i < 10; i++)
        {
            shapes.Add(factory.creatShape());
        }
        double totalArea = 0;
        foreach (shape shape in shapes)
        {
            totalArea += shape.getArea();
        }
        Console.WriteLine($"总面积为:{totalArea}");
    }
}