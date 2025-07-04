namespace MathLibrary;

public static class Calculator
{
    public static int Multiply(int a, int b) => a * b;
    
    public static int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("لا يمكن القسمة على الصفر!");
        return a / b;
    }

    public static bool IsEven(int a) => a % 2 == 0;
}