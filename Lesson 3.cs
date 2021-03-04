
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;



namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            
            /* Method                       Mean        Error       StdDev
             * TestPointDistanceDouble      24.41 ns    0.040 ns    0.035 ns
             * TestPointDistance            21.49 ns    0.034 ns    0.029 ns
             * PointDistanceShort           16.02 ns    0.039 ns    0.036 ns
             * TestPointDistanceClass       17.75 ns    0.350 ns    0.310 ns
             */
        }

    }

    public class BechmarkClass
    {
            public class PointClass
            {
            public int X;
            public int Y;
            }

            public struct PointStruct
            {
            public int X;
            public int Y;
            }

            static void pointClass()
            {
                var point = new PointClass() { X = 5, Y = 67 };
                var array = new PointClass[1];
                
            }

            static void pointStruct()
            {
                var pointOne = new PointStruct { X = 3, Y = 5 };
                var pointTwo = new PointStruct { X = 67, Y = 86 };

            }

        
            public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
            {
                double x = pointOne.X - pointTwo.X;
                double y = pointOne.Y - pointTwo.Y;
                return Math.Sqrt((x * x) + (y * y));
            }


            public static float PointDistance(PointStruct pointOne, PointStruct pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return MathF.Sqrt((x * x) + (y * y));
            }

            public static float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return (x * x) + (y * y);
            }

            public static double PointDistanceClass(PointClass pointOne, PointClass pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return Math.Sqrt((x * x) + (y * y));
            }

        [Benchmark]
        public void TestPointDistanceDouble()
        {
            PointStruct pointOne = new PointStruct { X = 3, Y = 5 };
            PointStruct pointTwo = new PointStruct { X = 67, Y = 86 };
            PointDistanceDouble(pointOne, pointTwo);
        }

        [Benchmark]
        public void TestPointDistance()
        {
            PointStruct pointOne = new PointStruct { X = 87, Y = 56 };
            PointStruct pointTwo = new PointStruct { X = 34, Y = 24 };
            PointDistance(pointOne, pointTwo);
        }
        [Benchmark]
        public void PointDistanceShort()
        {
            PointStruct pointOne = new PointStruct { X = 87, Y = 56 };
            PointStruct pointTwo = new PointStruct { X = 34, Y = 24 };
            PointDistanceShort(pointOne, pointTwo);
        }

        [Benchmark]
        public void TestPointDistanceClass()
        {
            PointClass pointOne = new PointClass { X = 87, Y = 56 };
            PointClass pointTwo = new PointClass { X = 34, Y = 24 };
            PointDistanceClass(pointOne, pointTwo);
        }
    }

}






