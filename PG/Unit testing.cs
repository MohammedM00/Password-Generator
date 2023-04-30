using NUnit.Framework;
using PasswordGeneratorMVC.Models;

namespace PasswordGeneratorMVC.Tests
{
    [TestFixture]
    public class PasswordGeneratorTests
    {
        [Test]
        public void GeneratePassword_ReturnsCorrectLength()
        {
            // Arrange
            PasswordGenerator passwordGenerator = new PasswordGenerator();

            // Act
            string password = passwordGenerator.GeneratePassword(10);

            // Assert
            Assert.AreEqual(10, password.Length);
        }

        [Test]
        public void GeneratePassword_ContainsUpperCase()
        {
            // Arrange
            PasswordGenerator passwordGenerator = new PasswordGenerator();

            // Act
            string password = passwordGenerator.GeneratePassword(10);

            // Assert
            StringAssert.IsMatch("[A-Z]", password);
        }

        [Test]
        public void GeneratePassword_ContainsLowerCase()
        {
            // Arrange
            PasswordGenerator passwordGenerator = new PasswordGenerator();

            // Act
            string password = passwordGenerator.GeneratePassword(10);

            // Assert
            StringAssert.IsMatch("[a-z]", password);
        }

        [Test]
        public void GeneratePassword_ContainsNumber()
        {
            // Arrange
            PasswordGenerator passwordGenerator = new PasswordGenerator();

            // Act
            string password = passwordGenerator.GeneratePassword(10);

            // Assert
            StringAssert.IsMatch("[0-9]", password);
        }

        [Test]
        public void GeneratePassword_ContainsSymbol()
        {
            // Arrange
            PasswordGenerator passwordGenerator = new PasswordGenerator();

            // Act
            string password = passwordGenerator.GeneratePassword(10);

            // Assert
            StringAssert.IsMatch("[!@#$%^&*()_+]", password);
        }
    }
}
