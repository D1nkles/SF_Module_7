abstract class ComputerPart
{
    public abstract void Work();
}

class Processor : ComputerPart 
{
    public override void Work()
    {
        Console.WriteLine("Процессор работает!");
    }
}

class MotherBoard : ComputerPart 
{
    public override void Work() 
    {
        Console.WriteLine("Материнская плата работает!");
    }
}

class GraphicCard : ComputerPart 
{
    public override void Work() 
    {
        Console.WriteLine("Видеокарта работает!");
    }
}