namespace TriangleTypeAnalyzer.App
{
    public class AnalyzeSidesTest
    {

        [Fact]
        public void ShouldReturnScalene()
        {
            //Arrange
            TriangleTypeAnalyzer _triangleTypeAnalyzer = new TriangleTypeAnalyzer();
            string _expected = "Scalene";
            string _result = "";
            int _sideA = 1;
            int _sideB = 2;
            int _sideC = 3;
        
            //Act
            _result = _triangleTypeAnalyzer.AnalyzeSides(_sideA,_sideB,_sideC);

            //Assert
            Assert.Equal(_expected, _result);
        }

        [Fact]
        public void ShouldReturnIsosceles()
        {
            //Arrange
            TriangleTypeAnalyzer _triangleTypeAnalyzer = new TriangleTypeAnalyzer();
            string _expected = "Isosceles";
            string _result = "";
            int _sideA = 5;
            int _sideB = 5;
            int _sideC = 3;

            //Act
            _result = _triangleTypeAnalyzer.AnalyzeSides(_sideA, _sideB, _sideC);

            //Assert
            Assert.Equal(_expected, _result);
        }
        [Fact]
        public void ShouldReturnEquilateral()
        {
            //Arrange
            TriangleTypeAnalyzer _triangleTypeAnalyzer = new TriangleTypeAnalyzer();
            string _expected = "Equilateral";
            string _result = "";
            int _sideA = 5;
            int _sideB = 5;
            int _sideC = 5;

            //Act
            _result = _triangleTypeAnalyzer.AnalyzeSides(_sideA, _sideB, _sideC);

            //Assert
            Assert.Equal(_expected, _result);
        }

        [Fact]
        public void ShouldReturnErrorWhenOneSideIsZero()
        {
            //Arrange
            TriangleTypeAnalyzer _triangleTypeAnalyzer = new TriangleTypeAnalyzer();
            string _expected = "Error";
            string _result = "";
            int _sideA = 5;
            int _sideB = 5;
            int _sideC = 0;

            //Act
            _result = _triangleTypeAnalyzer.AnalyzeSides(_sideA, _sideB, _sideC);

            //Assert
            Assert.Equal(_expected, _result);
        }

        [Fact]
        public void ShouldReturnErrorWhenOneSideIsNegative()
        {
            //Arrange
            TriangleTypeAnalyzer _triangleTypeAnalyzer = new TriangleTypeAnalyzer();
            string _expected = "Error";
            string _result = "";
            int _sideA = 5;
            int _sideB = 5;
            int _sideC = -1;

            //Act
            _result = _triangleTypeAnalyzer.AnalyzeSides(_sideA, _sideB, _sideC);

            //Assert
            Assert.Equal(_expected, _result);
        }
    }
}
