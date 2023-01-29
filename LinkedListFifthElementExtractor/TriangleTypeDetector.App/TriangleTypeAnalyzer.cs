namespace TriangleTypeAnalyzer.App
{
    public class TriangleTypeAnalyzer
    {      
        public string AnalyzeSides(int sideA,int sideB, int sideC)
        {
            string _result = null;

            if (sideA != sideB && sideB != sideC && sideA != sideC) // no equal sides "Scalene"
            {
                _result = "Scalene";
                DisplayResult(_result);
                return _result;
            }
            else if (sideA == sideB && sideB == sideC) // all sides are equal "Equilateral"
            {
                _result = "Equilateral";
                DisplayResult(_result);
                return _result;
            }
            else // 2 sides are equal "Isosceles"
            {
                _result = "Isosceles";
                DisplayResult(_result);
                return _result;
            }
  
        }

        private void DisplayResult(string data)
        {
            Console.WriteLine("\n" + data);
        }
    }
}
