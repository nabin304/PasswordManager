using System.Text;

namespace PassManager.App.Services
{
    /// <summary>
    ///  A generator service to generate a password.
    /// </summary>
    public class PasswordGenerator
    {
        private const string Digits = "0123456789";
        private const string LowerCaseAlphabets = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCaseAlphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SpecialChars = "!@#$%^&*";
        private const string Minus = "-";
        private const string Underscore = "_";
        private const string Space = " ";
        private const string Brackets = "()[]{}";
        private const int DefaultPasswordLength = 10;


        /// <summary>
        /// Creates a password based on the designated password preferences <paramref name="passwordConfig"/>.
        /// </summary>
        /// <param name="passwordConfig">The password passwordConfig/preferences</param>
        /// <remarks>
        /// The generated password will consist of 10 characters, comprising of uppercase and lowercase letters, digits, and special characters as the default.
        /// </remarks>
        /// <returns>A password</returns>
        public string Generate(PasswordConfiguration passwordConfig)
        {
            var builder = new StringBuilder(passwordConfig.Length);
            var random = new Random();


            var allowedCharSet = GetAllowedCharSet(passwordConfig);
            if (allowedCharSet.Length == 0)
            {
                allowedCharSet = DefaultPasswordCharSet();
                for (var i = 0; i < DefaultPasswordLength; i++)
                {
                    builder.Append(allowedCharSet[random.Next(allowedCharSet.Length)]);
                }
            }
            else
            {
                for (var i = 0; i < passwordConfig.Length; i++)
                {
                    builder.Append(allowedCharSet[random.Next(allowedCharSet.Length)]);
                }
            }

            return builder.ToString();
        }

        /// <summary>
        /// todo document me?
        /// </summary>
        /// <param name="passwordConfig"></param>
        /// <returns></returns>
        private static string GetAllowedCharSet(PasswordConfiguration passwordConfig)
        {
            var allowedCharSet = new StringBuilder();

            if (passwordConfig.IncludeLowerCaseLetter)
            {
                allowedCharSet.Append(LowerCaseAlphabets);
            }

            if (passwordConfig.IncludeUpperCaseLetter)
            {
                allowedCharSet.Append(UpperCaseAlphabets);
            }

            if (passwordConfig.IncludeDigits)
            {
                allowedCharSet.Append(Digits);
            }

            if (passwordConfig.IncludeSpecialCharacter)
            {
                allowedCharSet.Append(SpecialChars);
            }

            if (passwordConfig.IncludeMinus)
            {
                allowedCharSet.Append(Minus);
            }

            if (passwordConfig.IncludeUnderscore)
            {
                allowedCharSet.Append(Underscore);
            }

            if (passwordConfig.IncludeSpace)
            {
                allowedCharSet.Append(Space);
            }           

            if (passwordConfig.IncludeBrackets)
            {
                allowedCharSet.Append(Brackets);
            }

            return allowedCharSet.ToString();
        }

        // document me ?
        private static string DefaultPasswordCharSet()
        {
            return string.Join("", LowerCaseAlphabets, UpperCaseAlphabets, Digits, SpecialChars);
        }
    }
}










