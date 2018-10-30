using System;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 365; i++)
            {
                Random rnd = new Random();
                double x = rnd.Next(1,1000000);
                double sqrtNumber = Math.Sqrt(x);
                if (sqrtNumber > 1 && sqrtNumber < 300)
                {
                    double y = sqrtNumber * 5.1;
                    double h = Math.Round(y, 4);
                }
                else if (sqrtNumber > 301 && sqrtNumber < 600)
                {

                    double z = sqrtNumber * 10.098;
                    double t = Math.Round(z, 4);
                }
                else if (sqrtNumber > 601 && sqrtNumber < 999)
                {
                    double u = sqrtNumber * 100.00001;
                    double j = Math.Round(u,4);
                }

            }

        }
    }
}
