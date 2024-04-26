class Obj
{
    public int Value;

    public static Obj operator +(Obj a, Obj b) 
    {
        return new Obj
        {
            Value = a.Value + b.Value
        };
    }

    public static Obj operator -(Obj a, Obj b) 
    {
        return new Obj
        {
            Value = a.Value - b.Value
        };
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        var obj1 = new Obj() { Value = 15 };
        var obj2 = new Obj() { Value = 7 };
        
        Obj obj3 = obj1 + obj2;
        Obj obj4 = obj1 - obj2;

        Console.WriteLine(obj3.Value + " " + obj4.Value);
    }
}
