using Xunit;
using MathLibrary;

namespace MathLibrary.Tests;

public class CalculatorTests
{
   [Fact]
public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
{
    // Arrange
    int a = 5, b = 4;
    
    // Act
    int result = Calculator.Multiply(a, b);
    
    // Assert
    Assert.Equal(20, result);
}

[Fact]
public void Multiply_PositiveAndNegative_ReturnsNegative()
{
    // Arrange
    int a = 3, b = -2;
    
    // Act
    int result = Calculator.Multiply(a, b);
    
    // Assert
    Assert.Equal(-6, result);
}
[Fact]
public void Multiply_TowNegative_ReturnsNegative()
{
    // Arrange
    int a = -3, b = -2;
    
    // Act
    int result = Calculator.Multiply(a, b);
    
    // Assert
    Assert.Equal(6, result);
}

[Fact]
public void Multiply_ByZero_ReturnsZero()
{
    // Arrange
    int a = 7, b = 0;
    
    // Act
    int result = Calculator.Multiply(a, b);
    
    // Assert
    Assert.Equal(0, result);
}
[Fact]
public void Divide_TwoPositiveNumbers_ReturnsCorrectResult()
{
    // Arrange
    int a = 10, b = 2;
    
    // Act
    int result = Calculator.Divide(a, b);
    
    // Assert
    Assert.Equal(5, result);
}

[Fact]
public void Divide_NegativeByPositive_ReturnsNegative()
{
    // Arrange
    int a = -8, b = 4;
    
    // Act
    int result = Calculator.Divide(a, b);
    
    // Assert
    Assert.Equal(-2, result);
}
[Fact]
public void Divide_TowNegative_ReturnsNegative()
{
    // Arrange
    int a = -8, b =-4;
    
    // Act
    int result = Calculator.Divide(a, b);
    
    // Assert
    Assert.Equal(2, result);
}


[Fact]
public void Divide_ByZero_ThrowsException()
{
    // Arrange
    int a = 5, b = 0;
    
    // Act & Assert
    Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
}
[Fact]
public void IsEven_EvenNumber_ReturnsTrue()
{
    // Arrange
    int a = 4;
    
    // Act
    bool result = Calculator.IsEven(a);
    
    // Assert
    Assert.True(result);
}

[Fact]
public void IsEven_OddNumber_ReturnsFalse()
{
    // Arrange
    int a = 3;
    
    // Act
    bool result = Calculator.IsEven(a);
    
    // Assert
    Assert.False(result);
}

[Fact]
public void IsEven_Zero_ReturnsTrue()
{
    // Arrange
    int a = 0;
    
    // Act
    bool result = Calculator.IsEven(a);
    
    // Assert
    Assert.True(result);
}
}