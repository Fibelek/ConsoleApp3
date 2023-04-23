using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = { 1.2, 1.6, 2.1, 2.6 };
            double[] y = { 0.1823, 0.4700, 0.7419, 1.6864 };
            Console.Write("Введите сколько значений X вы хотите найти: ");
            int n = int.Parse(Console.ReadLine());
            double[] X = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите Х: ");
                X[i] = double.Parse(Console.ReadLine());
            }
            double[] Y = PR(x, y, X);
            for (int i = 0; i < X.Length; i++)
            {
                Console.WriteLine("f({0}) = {1}", X[i], Y[i]);
            }
        }
        public static double[] PR(double[] x, double[] y, double[] X)
        {
            double[] Y = new double[X.Length];

            for (int i = 0; i < X.Length; i++)
            {
                double L = 0;

                for (int j = 0; j < x.Length; j++)
                {
                    double B= 1;

                    for (int k = 0; k < x.Length; k++)
                    {
                        if (j != k)
                        {
                            B*= (X[i] - x[k]) / (x[j] - x[k]);
                        }
                    }
                    L += y[j] * B;
                }
                Y[i] = L;
            }
            return Y;
        }
    }
}