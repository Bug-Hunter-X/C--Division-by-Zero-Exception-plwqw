public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 10;
        int y = 0;
        int z = 0;
        if (y != 0) 
        {
            z = x / y;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        Console.WriteLine(z); 
    }
}