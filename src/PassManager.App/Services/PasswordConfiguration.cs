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
        public bool IncludeSpecialCharacter { get; set; } = true;

        /// <summary>
        /// Indicates whether to include a minus character.
        /// </summary>       
        public bool IncludeMinus { get; set; }

        /// <summary>
        /// Indicates whether to include an underscore character.
        /// </summary>
        public bool IncludeUnderscore { get; set; }

        //todo comment me
        public bool IncludeSpace { get; set; }

        //todo comment me
        public bool IncludeBrackets { get; set; }  

    }
}