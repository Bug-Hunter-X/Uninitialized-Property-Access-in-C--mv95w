public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-initialized property can lead to unexpected behavior.
        int value = MyProperty; // This could be 0, but you might expect a different default
    }
}