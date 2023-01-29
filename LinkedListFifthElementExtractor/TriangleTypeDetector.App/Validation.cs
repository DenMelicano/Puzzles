using System;

namespace TriangleTypeAnalyzer.App
{
    public class Validation
    {
        TriangleTypeAnalyzer _triangleTypeAnalyzer = new TriangleTypeAnalyzer();

        public bool InputValidation(string data1, string data2, string data3)
        {
            int _sideA = -1;
            int _sideB = -1;
            int _sideC = -1;

           // Checking if the data input is an integer or not
           if(int.TryParse(data1, out _sideA) && int.TryParse(data2, out _sideB) 
                && int.TryParse(data3, out _sideC))
            {
                if ( _sideA <= 0 || _sideB <= 0 || _sideC <= 0 )
                {
                    Console.WriteLine("\nError");
                    return false;
                }
                else
                {
                    _triangleTypeAnalyzer.AnalyzeSides(_sideA, _sideB, _sideC); 
                    return true;
                }                   
            }
            else
            {
                Console.WriteLine("\nError");
                return false;
            }
        }
    }
}
