using System.Text;

namespace PassManager.App.Services
{
    /// <inheritdoc />
    public class PasswordGenerator : IPasswordGenerator
    {
        private const string Digits = "0123456789";
        private const string LowerCaseAlphabets = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCaseAlphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SpecialChars = "!@#$%^&*";
        private const int DefaultPasswordLength = 10;



        /// <inheritdoc cref="IPasswordGenerator.Generate"/>
        public string Generate(PasswordConfiguration passwordConfig)
        {
            var builder = new StringBuilder(DefaultPasswordLength);
            var random = new Random();

            // generate a default password
            var allowedCharSet = DefaultPasswordCharSet();
            for (var i = 0; i < DefaultPasswordLength; i++)
            {
                builder.Append(allowedCharSet[random.Next(allowedCharSet.Length)]);
            }

            //todo do yourself when you gent different password configuration 


            return builder.ToString();
        }


        private static string DefaultPasswordCharSet()
        {
            return string.Join("", LowerCaseAlphabets, UpperCaseAlphabets, Digits, SpecialChars);
        }
        
    }
}
