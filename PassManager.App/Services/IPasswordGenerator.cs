namespace PassManager.App.Services
{
    /// <summary>
    ///  A generator service to generate a password.
    /// </summary>
    public interface IPasswordGenerator
    {
        /// <summary>
        /// Creates a password based on the designated password preferences <paramref name="passwordConfig"/>.
        /// </summary>
        /// <param name="passwordConfig">The password passwordConfig/preferences</param>
        /// <remarks>
        /// The generated password will consist of 10 characters, comprising of uppercase and lowercase letters, digits, and special characters as the default.
        /// </remarks>
        /// <returns>A password</returns>
        string Generate(PasswordConfiguration passwordConfig);
    }
}