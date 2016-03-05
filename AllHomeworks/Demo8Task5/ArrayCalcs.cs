using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task5
{
    class ArrayCalcs
    {
        public const string ArrayIsEmptyMessage = "Array is empty!";

        public static double Sum(double[] array)
        {
            if (array.Length > 0)
            {
                double sum = 0;
                foreach (double d in array)
                {
                    sum += d;
                }
                return sum;
            }
            else
            {
                throw new ArgumentOutOfRangeException(ArrayIsEmptyMessage);
            }
        }

        public static double Average(double[] array)
        {
            if (array.Length > 0) return Sum(array) / array.Length;
            else throw new ArgumentOutOfRangeException(ArrayIsEmptyMessage);
        }

        public static double Min(double[] array)
        {
            if (array.Length == 0) throw new ArgumentOutOfRangeException(ArrayIsEmptyMessage);

            double min = Double.MaxValue;
            foreach (double d in array)
            {
                if (d < min) min = d;
            }
            return min;
        }

        public static double Max(double[] array)
        {
            if (array.Length == 0) throw new ArgumentOutOfRangeException(ArrayIsEmptyMessage);

            double max = Double.MinValue;
            foreach (double d in array)
            {
                if (d > max) max = d;
            }
            return max;
        }

    }
}