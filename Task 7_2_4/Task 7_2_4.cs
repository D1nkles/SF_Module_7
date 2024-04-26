class BaseClass
{
    public virtual int Counter
    {
        get;
        set;
    }
}

class DerivedClass : BaseClass
{
    public override int Counter 
    {
        get 
        {
            return Counter;
        }
        set 
        {
            if (value < 0) 
            {
                Console.WriteLine("Число меньше 0!");
            }
            else 
            {
                Counter = value;
            }
        }
    }
}