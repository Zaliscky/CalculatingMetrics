using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HomeTaskEMP
{
    class _4lab
    {
        public Dictionary<double, double> histogram(List<double> x)
        {
           Dictionary<double, double> s = new Dictionary<double, double>();
           double h = (x.Max() - x.Min()) / Math.Sqrt(x.Count);
           for(double i=x.Min();i<=x.Max();i+=h)
           {
                int counter = 0;
                double scopemin = i;
                double scopemax = i + h;
                for (int j=0;j<x.Count;j++)
                {
                    if(x[j]<=scopemax && x[j]>scopemin)
                    {
                        counter++;
                    }
                }
                s.Add(i, counter);
           }
            return s;
        }


        public void DrawChart(Dictionary<double,double> x)
        {
            Application.Run(new Form1(x));  
        }
        

        public static double Average(List<double> x)
        {
            double counter = 0;
            for (int i=0;i<x.Count;i++)
            {
                counter += x[i];
            }
            return counter / x.Count;
        }

        public static double Variation(List<double> x)
        {
            return (double)1 / (x.Count - 1);
        }

        public static double Variance(List<double> x)
        {
            double summ = 0;
            double average = Average(x);
            for (int i=0;i<x.Count;i++)
            {
                summ += Math.Pow(average - x[i], 2);
            }
            return (double)summ * Variation(x);
        }

        public static double StandartDevariation(List<double> x)
        {
            return (double)Math.Sqrt(Variance(x));
        }

        public double Skewness(List<double> x)
        {
            double summ = 0;
            double average = Average(x);
            for (int i = 0; i < x.Count; i++)
            {
                summ += Math.Pow(average - x[i], 3);
            }
            return (double)1 / (Math.Pow(StandartDevariation(x), 3) * x.Count) * summ;
        }

        public double Kurtosis(List<double> x)
        {
            double summ = 0;
            double average = Average(x);
            for (int i = 0; i < x.Count; i++)
            {
                summ += Math.Pow(average - x[i], 4);
            }
            return (double)1 / (Math.Pow(StandartDevariation(x), 4) * x.Count) * summ;
        }
      
        public double minAWaitingValues(List<double> x)
        {
            return (double)Average(x) - 1.96 * StandartDevariation(x);
        }

        public double maxBWaitingValues(List<double> x)
        {
            return (double)Average(x) + 1.96 * StandartDevariation(x);
        }

        public double Fx(List<double> x)
        {
            return (double)StandartDevariation(x) / Math.Sqrt(x.Count);
        }

        public double Fs(List<double> x)
        {
            return StandartDevariation(x) / Math.Sqrt(2 * x.Count);
        }

        public double minO(List <double> x)
        {
            return (double)Average(x) - 1.96 * Fx(x);
        }

        public double maxO(List<double> x)
        {
            return (double)Average(x) + 1.96 * (double)Fs(x);
        }

        public double FA(List<double> x)
        {
            return Math.Sqrt((double)6 * ((double)x.Count - (double)2) / ((double)30 + (double)1) * ((double)30 + (double)2));
        }

        public double FE(List<double> x)
        {
            return Math.Sqrt(((double)24 / (double)x.Count) * ((double)1 - ((double)255 / ((double)15 * (double)x.Count + (double)124))));
        }
        
        public void ShowUbnormalValues(List<double> x)
        {
            Console.WriteLine("Ubnormal values:");
            double min = minAWaitingValues(x);
            double max = maxBWaitingValues(x);
            for (int i=0;i<x.Count;i++)
            {
                if (x[i] < min || x[i] > max) Console.WriteLine(i + ":" + x[i]);
            }
        }
        public void UI(List<double> x)
        {
            Console.WriteLine("Average: " + Average(x));
            double Vari = Variation(x);
            Console.WriteLine("Variation: " + Variation(x));
            Console.WriteLine("Variance: " + Variance(x));
            Console.WriteLine("Standart Devariation: " + StandartDevariation(x));
            Console.WriteLine("Skewness: " + Skewness(x));
            Console.WriteLine("Kurtosis: " + Kurtosis(x));
            if (Skewness(x) > (double)1 && Kurtosis(x) > (double)1) Console.WriteLine("Normal distribution law");
            else Console.WriteLine("Ubnormal distribution law");
            Console.WriteLine("minA: " + minAWaitingValues(x));
            Console.WriteLine("maxB: " + maxBWaitingValues(x));
            Console.WriteLine("Fx: " + Fx(x));
            Console.WriteLine("Fs: " + Fs(x));
            Console.WriteLine("min-O: " + minO(x));
            Console.WriteLine("max-O: " + maxO(x));
            Console.WriteLine("F(A): " + FA(x));
            Console.WriteLine("F(E): " + FE(x));
            ShowUbnormalValues(x);
            DrawChart(histogram(x));
            Console.ReadKey();
        }
    }
}
