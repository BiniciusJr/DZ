using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Vranjes
{
    internal class ZAD2
    {
        public class Average
        {
            public List<double> averages(List<double[]> arrays)
            {
                List<double> averages = new List<double>();
                foreach (double[] array in arrays)
                {
                    double sum = suma(array);
                    double average = sum / array.Length;
                    averages.Add(average);
                }
                return averages;
            }
            public double suma(double[] array)
            {
                double sum = 0;
                foreach (double value in array)
                {
                    sum += value;
                }
                return sum;
            }
        }
    }
}
