using System;
using System.Linq;

namespace PasswordGenerator.Models
{
    public class PasswordGenerator
    {
        private const string AllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[]{}|;:,.<>?";

        public string GeneratePassword(int length)
        {
            var random = new Random();
            var passwordChars = Enumerable.Repeat(AllowedChars, length)
                .Select(s => s[random.Next(s.Length)]);

            return new string(passwordChars.ToArray());
        }
    }
}

#This class defines a method called GeneratePassword, which generates a random password of a given length.

