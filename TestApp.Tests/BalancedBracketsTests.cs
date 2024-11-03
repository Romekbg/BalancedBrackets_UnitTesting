using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        //Arrange
        string[] arr = Array.Empty<string>();

        //Act
        bool output = BalancedBrackets.IsBalanced(arr); 


        //Assert
        Assert.That(output, Is.True);
    }

    [Test]
    public void Test_IsBalanced_DoubleBalancedBrackets_ShouldReturnTrue()
    {
        //Arrange
        string[] arr = new string[] { "(", ")", "(", ")" };


        //Act
        bool output = BalancedBrackets.IsBalanced(arr);


        //Assert
        Assert.That(output, Is.True);
    }

    [Test]
    public void Test_IsBalanced_NoBrackets_ShouldReturnTrue()
    {
        // Arrange
        string[] arr = new string[] { "No Brackets added" }; 

        // Act
        bool output = BalancedBrackets.IsBalanced(arr);

        // Assert
        Assert.That(output, Is.True);
    }


    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        //Arrange
        string[] arr = new string[] { "(", ")" };
        

        //Act
        bool output = BalancedBrackets.IsBalanced(arr);


        //Assert
        Assert.That(output, Is.True);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        //Arrange
        string[] arr = new string[] { ")", "(" };
        

        //Act
        bool output = BalancedBrackets.IsBalanced(arr);


        //Assert
        Assert.That(output, Is.False);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        //Arrange
        string[] arr = new string[] { "(", ")", "(", ")", ")" };
        

        //Act
        bool output = BalancedBrackets.IsBalanced(arr);


        //Assert
        Assert.That(output, Is.False);
    }

    [Test]
    public void Test_IsBalanced_SpecialCharacters_ShouldReturnTrue()
    {
        //Arrange
        string[] arr = new string[] { "[", ",", "]" };
        


        //Act
        bool output = BalancedBrackets.IsBalanced(arr);


        //Assert
        Assert.That(output, Is.True);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        //Arrange
        string[] arr = new string[] { ")", "(", ")" };


        //Act
        bool output = BalancedBrackets.IsBalanced(arr);


        //Assert
        Assert.That(output, Is.False);
    }
}
