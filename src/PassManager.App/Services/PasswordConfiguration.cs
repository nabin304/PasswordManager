namespace PassManager.App.Services
{
    /// <summary>
    ///The options for configuring password preferences.
    /// </summary>
    public class PasswordConfiguration
    {

        /// <summary>
        /// The length of the generated password.
        /// </summary>
        /// <remarks>Default is 10.</remarks>
        public int Length { get; set; } = 10;

        /// <summary>
        /// Indicates whether to include a lower case letter.
        /// </summary>
        /// <remarks>Default is true.</remarks>
        public bool IncludeLowerCaseLetter { get; set; } = true;

        /// <summary>
        /// Indicates whether to include an upper case letter.
        /// </summary>
        /// <remarks>Default is true.</remarks>
        public bool IncludeUpperCaseLetter { get; set; } = true;

        /// <summary>
        /// Indicates whether to include digit.
        /// </summary>
        /// <remarks>Default is true.</remarks>
        public bool IncludeDigits { get; set; } = true;

        /// <summary>
        /// Indicates whether to include special characters.
        /// </summary>
        /// <remarks>Default is true.</remarks>
        public bool IncludeSpecialChar { get; set; } = true;


        //todo do yourself, add more config options (like Minus, Underline, space, brackets)
    }
}