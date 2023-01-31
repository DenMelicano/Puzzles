namespace WordReversing.App
{
    public class WordStackTest
    {
        [Fact]
        public void MustReturnCorrectStackWordCount()
        {
            //Arrange
            WordStack _wordStack = new WordStack();
            string _inputWord = "cat and dog";
            int _expectedCount = 3;
            int _actualCount = 0;

            //Act
            _wordStack.AggregateWords(_inputWord);
            _actualCount = _wordStack.WordCount;

            //Assert

            Assert.Equal(_expectedCount, _actualCount);
        }
    }
}
