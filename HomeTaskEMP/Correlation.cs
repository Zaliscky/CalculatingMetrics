using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTaskEMP
{
    class _5lab
    {
        List<double> R(List<double> x, List<double> y)
        {
            // Sort by first
            List<double> first = new List<double>();
            List<double> second = new List<double>();
            // Copying arrays
            for(int i=0;i<x.Count;i++)
            {
                first.Add(x[i]);
                second.Add(y[i]);
            }
            // Sorting 
            for (int i = 0; i < first.Count - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < first.Count - i - 1; j++)
                {
                    if (first[j] > first[j + 1])
                    {
                        double tmp1 = second[j];
                        double tmp = first[j];
                        second[j] = second[j + 1];
                        first[j] = first[j + 1];
                        second[j + 1] = tmp1;
                        first[j + 1] = tmp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            // Creating Rx
            List<double> s = new List<double>();
            for(int i=0;i<second.Count;i++)
            {
                int tmp = 0;
                for(int j = i;j<second.Count;j++)
                {
                    if (second[i] < second[j]) tmp++;
                }
                s.Add(tmp);
            }
            return s;
        }

        double getsumD(List<double> x, List<double> y)
        {
            double sum = 0;
            List<double> Rx = R(x, y);
            List<double> Ry = R(y, x);
            for(int i=0; i<Rx.Count;i++)
            {
                double difference = Math.Pow(Rx[i] - Ry[i], 2);
                sum += difference;
            }
            return sum;
        }
        
        double getCoef(List<double> x, List<double> y)
        {
            double firstpart = getsumD(x, y);
            double secondpart = (double)6 / ((double)30 * (Math.Pow(x.Count, 2) - (double)1));
            return 1 - (firstpart * secondpart);
        }
        double getSignificance(List<double> x, List<double> y)
        {
            double Coef = getCoef(x, y);
            return Coef * Math.Sqrt((double)x.Count - (double)2) / Math.Sqrt(1 - Math.Pow(Coef, 2));
        }

        void BuildRegressionGraphic(List<double> x, List<double> y)
        {
            Regression r = new Regression(x, y, getCoef(x, y), _4lab.StandartDevariation(x), _4lab.StandartDevariation(y));
            Application.Run(r);
        }
        public void UI(List<double> x, List<double> y)
        {
            Console.WriteLine("Coefficient of correlation: " +getCoef(x, y));
            Console.WriteLine("Significance: "+getSignificance(x, y));
            BuildRegressionGraphic(R(x, y),R(y, x));
            Console.ReadKey();
        }
    }
}
