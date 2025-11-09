namespace Calculator;

public class Calculator
{
    public double A { get; }
    public double B { get; }
    public char Operation { get; }

    public Calculator(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Calculate()
    {
        return Operation switch
        {
            '+' => Add(),
            '-' => Subtract(),
            '*' => Multiply(),
            '/' => Divide(),
            _ => throw new ArgumentException($"err: {Operation}")
        };
    }

    private double Add()
    {
        return A + B;
    }

    private double Subtract()
    {
        return A - B;
    }

    private double Multiply()
    {
        return A * B;
    }

    private double Divide()
    {
        if (B == 0)
        {
            throw new DivideByZeroException("err");
        }

        return A / B;
    }

    public override string ToString()
    {
        return $"{A} {Operation} {B} = {Calculate()}";
    }
}