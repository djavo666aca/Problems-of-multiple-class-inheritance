using System;

class A 
{
    public virtual void Print() 
    {
        Console.WriteLine("Inplemettacija A");
    }
}
class B : A
{
    public override void Print()
    {
        Console.WriteLine("Inplemettacija B");
    }
}
class C : A
{
    public override void Print()
    {
        Console.WriteLine("Inplemettacija C");
    }
}
class D : B ,C
{
    
}

class Program 
{
    public static void Main() 
    {
    D d = new D();
        d.Print();
    }
}
