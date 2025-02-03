public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass()  //Constructor to initialize the property
    {
        MyProperty = 10; //Initialize MyProperty in the constructor
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now MyProperty is initialized
    }
}