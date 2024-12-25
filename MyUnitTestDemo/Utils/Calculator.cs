namespace MyUnitTestDemo.Utils;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    
    public int Multy(int a, int b)
    {
        return a * b;
    }
    
    public int Devide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Can not divide 0");
        }
        return a / b;
    }
}