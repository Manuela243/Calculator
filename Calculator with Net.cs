using System;

namespace DotNetCalculator
{
    public class Calculator
    {
        // Performs calculation based on the operation type
        public double Calculate(double a, double b, OperationType operation)
        {
            return operation switch
            {
                OperationType.Add => a + b,
                OperationType.Subtract => a - b,
                OperationType.Multiply => a * b,
                OperationType.Divide => b != 0 ? a / b : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Invalid operation type.")
            };
        }
    }
}
