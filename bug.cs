public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        //This is a potential problem area
        int x = 10;
        int y = 0;
        int z = x / y; // Division by zero exception
        Console.WriteLine(z); 
    }
}