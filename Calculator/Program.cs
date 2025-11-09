namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            var calculations = new[]
            {
                new Calculator(10, 5, '+'),
                new Calculator(10, 5, '-'),
                new Calculator(10, 5, '*'),
                new Calculator(10, 5, '/'),
                new Calculator(15, 3, '+'),
                new Calculator(7.5, 2.5, '*'),
                new Calculator(100, 25, '/')
            };

            foreach (var calc in calculations)
            {
                try
                {
                    Console.WriteLine(calc.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Err: {ex.Message}");
                }
            }

            var errorCalculations = new[]
            {
                new Calculator(10, 0, '/'),
                new Calculator(5, 2, '%')
            };

            foreach (var calc in errorCalculations)
            {
                try
                {
                    Console.WriteLine(calc.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Err {calc.A} {calc.Operation} {calc.B}: {ex.Message}");
                }
            }
        }
    }
}