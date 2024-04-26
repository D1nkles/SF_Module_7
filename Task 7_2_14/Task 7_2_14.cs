class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }

    public int this[int index] 
    {
        get 
        {
            if (index >= 0 && index < array.Length) 
            {
                return array[index];
            }
            else 
            {
                return -1;
            }
        }

        set 
        {
            if (index >= 0 && index < array.Length) 
            {
                array[index] = value;
            }
        }
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        int[] arr = { 52, 21, 97, 165, 2, 6 };

        var indexing = new IndexingClass(arr);
        int num1 = indexing[2];
        indexing[3] = 555;
        int num2 = indexing[3];
        Console.WriteLine($"{num1} {num2}");
    }
}