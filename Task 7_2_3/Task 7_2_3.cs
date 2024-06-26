﻿class BaseClass 
{
    public virtual void Display() 
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}

class DerivedClass : BaseClass 
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        var baseClass = new BaseClass();
        var derivedClass = new DerivedClass();

        //baseClass.Display();
        derivedClass.Display();
    }
}