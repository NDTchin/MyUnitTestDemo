using MyUnitTestDemo.Utils;

namespace UnitTestDemo.Utils;

public class CaculatorTests
{
    [Fact]
    public void Add()
    {
        Calculator calculator = new Calculator();
        var result = calculator.Add(3, 5);
        Assert.Equal(8, result);
    }
    
    [Fact]
    public void AddWrong()
    {
        Calculator calculator = new Calculator();
        var result = calculator.Add(3, 5);
        Assert.NotEqual(9, result);
        Assert.True(result == 8);
    }
    
    [Fact]
    public void DivideZero()
    {
        Calculator calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Devide(3, 0));
    }
}