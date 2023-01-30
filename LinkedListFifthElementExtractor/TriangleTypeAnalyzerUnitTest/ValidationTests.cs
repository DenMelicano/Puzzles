namespace TriangleTypeAnalyzer.App
{
    public class ValidationTests
    {
        [Fact]
        public void ReturnFalseIfInputIsALetter()
        {
            //arrange 
            Validation _validation = new Validation();

            bool _expected = false;
            bool _actual = true;
            string _data1 = "a";
            string _data2 = "b";
            string _data3 = "c";

            //act
            _actual = _validation.InputValidation(_data1,_data2,_data3);

            Assert.Equal(_expected, _actual);
        }

        [Fact]
        public void ReturnTrueIfInputIsAnInteger()
        {
            //arrange 
            Validation _validation = new Validation();

            bool _expected = true;
            bool _actual = false;
            string _data1 = "1";
            string _data2 = "2";
            string _data3 = "-1";

            //act
            _actual = _validation.InputValidation(_data1, _data2, _data3);

            Assert.Equal(_expected, _actual);
        }
    }
}
