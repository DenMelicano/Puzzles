namespace WordReversing.App
{
    public class WordReverserTest
    {

        [Fact]
        public void MustReverseAWord() 
        {
            //Arrange
            WordReverser _wordReverser = new WordReverser();
            string _inputString = "whatever";
            string _actual = string.Empty;
            string _expected = "revetahw";

            //Act
            _actual = _wordReverser.ReverseString(_inputString);    

            //Assert
            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void MustReverseNumbers()
        {
            //Arrange
            WordReverser _wordReverser = new WordReverser();
            string _inputString = "1234567890";
            string _actual = string.Empty;
            string _expected = "0987654321";

            //Act
            _actual = _wordReverser.ReverseString(_inputString);

            //Assert
            Assert.Equal(_expected, _actual);
        }
    }
}
