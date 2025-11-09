namespace Calculator;

[TestFixture]
public class CalculatorTests
{
    // Тесты для операции сложения
    [Test]
    public void Calculate_Addition_PositiveNumbers_ReturnsCorrectResult()
    {
        var calculator = new Calculator(5, 3, '+');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void Calculate_Addition_NegativeNumbers_ReturnsCorrectResult()
    {
        var calculator = new Calculator(-5, -3, '+');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(-8));
    }

    [Test]
    public void Calculate_Addition_Zero_ReturnsCorrectResult()
    {
        var calculator = new Calculator(5, 0, '+');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Calculate_Addition_DecimalNumbers_ReturnsCorrectResult()
    {
        var calculator = new Calculator(2.5, 3.7, '+');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(6.2));
    }

    [Test]
    public void Calculate_Subtraction_PositiveNumbers_ReturnsCorrectResult()
    {
        var calculator = new Calculator(10, 4, '-');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Calculate_Subtraction_NegativeNumbers_ReturnsCorrectResult()
    {
        var calculator = new Calculator(-5, -3, '-');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(-2));
    }

    [Test]
    public void Calculate_Subtraction_Zero_ReturnsCorrectResult()
    {
        var calculator = new Calculator(5, 0, '-');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Calculate_Multiplication_PositiveNumbers_ReturnsCorrectResult()
    {
        var calculator = new Calculator(6, 7, '*');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Calculate_Multiplication_ByZero_ReturnsZero()
    {
        var calculator = new Calculator(5, 0, '*');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Calculate_Multiplication_NegativeNumbers_ReturnsCorrectResult()
    {
        var calculator = new Calculator(-4, 5, '*');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(-20));
    }

    [Test]
    public void Calculate_Division_PositiveNumbers_ReturnsCorrectResult()
    {
        var calculator = new Calculator(15, 3, '/');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Calculate_Division_DecimalResult_ReturnsCorrectResult()
    {
        var calculator = new Calculator(10, 4, '/');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(2.5));
    }

    [Test]
    public void Calculate_Division_ByOne_ReturnsSameNumber()
    {
        var calculator = new Calculator(7, 1, '/');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void Calculate_Division_NegativeNumbers_ReturnsCorrectResult()
    {
        var calculator = new Calculator(-10, -2, '/');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Calculate_Division_ByZero_ThrowsDivideByZeroException()
    {
        var calculator = new Calculator(10, 0, '/');
        
        Assert.Throws<DivideByZeroException>(() => calculator.Calculate());
    }

    [Test]
    public void Calculate_InvalidOperation_ThrowsArgumentException()
    {
        var calculator = new Calculator(5, 3, '%');
        
        var ex = Assert.Throws<ArgumentException>(() => calculator.Calculate());
    }

    // Тесты на граничные значения
    [Test]
    public void Calculate_WithMaxDoubleValue_ReturnsCorrectResult()
    {
        var calculator = new Calculator(double.MaxValue, 0, '+');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(double.MaxValue));
    }

    [Test]
    public void Calculate_WithMinDoubleValue_ReturnsCorrectResult()
    {
        var calculator = new Calculator(double.MinValue, 0, '+');
        var result = calculator.Calculate();
        Assert.That(result, Is.EqualTo(double.MinValue));
    }
}