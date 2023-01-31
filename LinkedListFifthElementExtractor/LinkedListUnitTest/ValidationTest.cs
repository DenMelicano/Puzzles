namespace LinkedListFifthElementExtractor.App
{
    public class ValidationTest
    {
        [Fact]
        public void WhenInputIsLetter()
        {
            /* the function should return "Non-Numerical" if the input is any alphabetical or non-numeral character except 'x' and 'q'
             */

            //Arrange
            Validation _validation = new Validation();

            string _actualStatusCode = string.Empty;
            string _expectedStatusCode = "Non-Numerical";
            string _sampleInput = "A";

            //Act
            _actualStatusCode = _validation.InputValidation(_sampleInput);


            //Assert
            Assert.Contains(_expectedStatusCode, _actualStatusCode);
           

        }

        [Fact]
        public void WhenInputIsLessThanFive()
        {
            /* the function should return "Insufficient Node" if the input count (minimum input count) and 'q' is entered.
             */

            //Arrange
            Validation _validation = new Validation();

            string _actualStatusCode = string.Empty;
            string _expectedStatusCode = "Insufficient Node";



            //Act
            _validation.InputValidation("1");
            _validation.InputValidation("1");
            _validation.InputValidation("1");
            _validation.InputValidation("1");
            _actualStatusCode = _validation.InputValidation("q");
           

            //Assert
            Assert.Contains(_expectedStatusCode, _actualStatusCode);


        }

        [Fact]
        public void WhenInputIsCorrect()
        {
            /* the function should return "Success" if the minimum input count is reached, and "q" is pressed.
             */

            //Arrange
            Validation _validation = new Validation();

            string _actualStatusCode = string.Empty;
            string _expectedStatusCode = "Success";



            //Act
            _validation.InputValidation("1");
            _validation.InputValidation("1");
            _validation.InputValidation("1");
            _validation.InputValidation("1");
            _validation.InputValidation("1");
            _actualStatusCode = _validation.InputValidation("q");


            //Assert
            Assert.Contains(_expectedStatusCode, _actualStatusCode);


        }

        [Fact]
        public void WhenValidNodeIsAdded()
        {
            /* the function should return "Node Added" if the input is a numerical number
             */

            //Arrange
            Validation _validation = new Validation();

            string _actualStatusCode = string.Empty;
            string _expectedStatusCode = "Node Added";



            //Act
            _actualStatusCode = _validation.InputValidation("1");
        

            //Assert
            Assert.Contains(_expectedStatusCode, _actualStatusCode);


        }

        [Fact]
        public void WhenXIsPressed()
        {
            /* the function should return "Node Added" if the input is a numerical number
             */

            //Arrange
            Validation _validation = new Validation();

            string _actualStatusCode = string.Empty;
            string _expectedStatusCode = "Program Terminated";



            //Act
            _actualStatusCode = _validation.InputValidation("x");


            //Assert
            Assert.Contains(_expectedStatusCode, _actualStatusCode);


        }
    }
}
