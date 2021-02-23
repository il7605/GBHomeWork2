using System;
using System.Collections.Generic;
using System.Linq;


namespace Lesson_1._1
{
    class Program
    {
        public class TestCase
        {
            public int InputN { get; set; }
            public string Expected { get; set; }
        }
        static int AlgTest (int n)
        {

            return n;

            int d = 0;
            int i = 2;


            while (i < n)
            {

                if (n % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }

            }

            if (d == 0)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }
        }
        static void Main(string[] args)
        {
            var testData = new TestCase[3];
            testData[0] = new TestCase()
            {
                InputN = 1,
                Expected = "Простое",
            };
            testData[1] = new TestCase()
            {
                InputN = 2,
                Expected = "Не простое",
            };
            testData[2] = new TestCase()
            {
                InputN = 3,
                Expected = "Простое",
            };

            foreach (var testCase in testData)
            {
                string result = Convert.ToString(AlgTest(testCase.InputN));
                
                Console.WriteLine($"n {testCase.InputN} Actual {result} Expected {testCase.Expected}");
            }
        }
    }
}
