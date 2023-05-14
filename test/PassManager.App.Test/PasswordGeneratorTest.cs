using PassManager.App.Services;

namespace PassManager.App.Test
{
    public class PasswordGeneratorTest
    {
        [Fact(DisplayName ="Should generate default password of lenght 10")]  
        public void GeneratePassoword_DefaultPassword_Should_Have_10_Character()
        {
            // arrange 
            var sut = new PasswordGenerator();

            // act

            var config = new PasswordConfiguration
            {                
            };

            var password = sut.Generate(config);

            // assert default passowrd lenght = 10

            Assert.Equal(10, password.Length);
        }
    }
}