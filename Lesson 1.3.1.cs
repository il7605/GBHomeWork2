using System;

namespace Lesson_1._3._1
{
    class Program
    {

        public class TestCase
        {
            public int InputN { get; set; }
            public int Expected { get; set; }
        }
        static int Recurs (int number)
        {
            return number;
            int Fib = GetFib(number);

        
        }
    static int GetFib(int number)
    {
        if (number == 0 || number == 1)
        {
            return number;
        }
        else
        {
            return GetFib(number - 1) + GetFib(number - 2);
        }
    }
        
        static void Main(string[] args)
        {
            var testData = new TestCase[3];
            testData[0] = new TestCase()
            {
                InputN = 5,
                Expected = 5,
            };
            testData[1] = new TestCase()
            {
                InputN = 6,
                Expected = 8,
            };
            testData[2] = new TestCase()
            {
                InputN = 8,
                Expected = 21,
            };

            foreach (var testCase in testData)
            {
                var result = Recurs(testCase.InputN);
                var correct = result == testCase.Expected;
                Console.WriteLine($"n {testCase.InputN} Actual {result} Expected {testCase.Expected}");
            }
        }
    }
}
