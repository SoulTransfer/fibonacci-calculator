using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            calcFibonacci calculator = new calcFibonacci(1, 50);
            calculator.calculateCollection();
            calculator.printCollection();

            Console.ReadLine();
        }

        public class calcFibonacci
        {
            //properties
            private int _initialValue;
            private int[] _fiboCollection;
            private int _iterationCount;
            private int _firstValue;
            //private int _secondValue;

            //constructor
            public calcFibonacci(int initialValue, int iterationCount = 10)
            {
                _initialValue = initialValue;
                _iterationCount = iterationCount;
                _fiboCollection = new int[iterationCount];

            }

            //methods
            public void calculateCollection()
            {
                _firstValue = _initialValue;
                _fiboCollection[0] = _firstValue;
                //_iterationCount++;
                for (int i = 1; i < _iterationCount; i++)
                {
                    _fiboCollection[i] = _firstValue + _fiboCollection[i - 1];
                    _firstValue = _fiboCollection[i - 1];
                }
            }

            public void printCollection()
            {
                try
                {
                    Console.WriteLine(_initialValue);
                    foreach (var printValue in _fiboCollection)
                    {
                        Console.WriteLine(printValue);
                    }
                }
                catch
                {
                    Console.WriteLine("Calculate first!");
                }
            }

        }
    }
}
