using PassManager.App.Services;

namespace PassManager.App.Test
{
    public class PasswordGeneratorTest
    {
        [Fact(DisplayName = "Should generate default password of lenght 10")]
        public void GeneratePassoword_Should_Generate_DefaultPassword_Of_10_Character()
        {
            // arrange 
            var sut = new PasswordGenerator();

            // act

            var config = new PasswordConfiguration
            {
                Length = 0
            };

            var password = sut.Generate(config);

            // assert default passowrd lenght = 10

            Assert.Equal(10, password.Length);
        }

        [Fact(DisplayName = "Should generate password length of user choice")]
       
        public void GeneratePassoword_Should_Generate_Password_Of_UserChoice()
        {
            // arrange 
            var sut = new PasswordGenerator();

            // act

            var config = new PasswordConfiguration
            {
                Length = 15
            };

            var password = sut.Generate(config);

            // assert default passowrd lenght = 10

            Assert.Equal(15, password.Length);
        }
    }
}