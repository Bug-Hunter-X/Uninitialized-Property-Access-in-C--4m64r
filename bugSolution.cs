public class ExampleClass
{
    // Initialize MyProperty in the constructor 
    public int MyProperty { get; set; } = 0;

    public ExampleClass() //Explicitly initializing in constructor
    {
        MyProperty = 10;
    }
    public void MyMethod()
    {
        int value = MyProperty * 2; // No longer an issue
    }
}