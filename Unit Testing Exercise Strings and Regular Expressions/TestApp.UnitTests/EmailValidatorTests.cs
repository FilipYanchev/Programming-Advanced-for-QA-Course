using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
   
    [TestCase("fili.v.yanchev@gmail.com")]
    [TestCase("filipyanchev@students.softuni.bg")]
    [TestCase("fvy2180@gmail.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange


        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    
    [TestCase("invalid mail@valid.domain")]
    [TestCase("valid%mail@in_valid.domain")]
    [TestCase("invakid/mail@invalid.d")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
