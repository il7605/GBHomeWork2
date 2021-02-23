using System;

namespace Lesson_1._3._2
{
    class Program
    {

        public class TestCase
        {
            public int InputN { get; set; }
            public int Expected { get; set; }
        }

        static int Cikle(int number)
        {
            return number;


            int a = 0;
            int b = 1;
            int fib = 0;

            if (number == 1)
            {
                fib = a;
            }
            else if (number == 2)
            {
                fib = b;
            }

            for (int i = 1; i < number; i++)
            {

                fib = a + b;
                a = b;
                b = fib;
                Console.Write(fib);
            }
        }

        static void Main(string[] args)
        {
            var testData = new TestCase[3];
            testData[0] = new TestCase()
            {
                InputN = 5,
                Expected = 1235,
            };
            testData[1] = new TestCase()
            {
                InputN = 6,
                Expected = 12358,
            };
            testData[2] = new TestCase()
            {
                InputN = 8,
                Expected = 123581321,
            };

            foreach (var testCase in testData)
            {
                var result = Cikle(testCase.InputN);
                var correct = result == testCase.Expected;
                Console.WriteLine($"n {testCase.InputN} Actual {result} Expected {testCase.Expected}");
            }




        }
       
    }
}
