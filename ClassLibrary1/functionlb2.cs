using System;


namespace ClassLibrary1
{
    public class functionlb2
    {
        public static double function(double x)
        {
            if (x <= 0)
            {
                return (mathfunctions.Pow(mathfunctions.Pow(mathfunctions.Cos(x), 3) + mathfunctions.cotan(x), 2) - mathfunctions.Csc(x)) - mathfunctions.Cos(x);
            }

            else
            {
                return (mathfunctions.Pow(mathfunctions.Log(x, 10) / mathfunctions.Log(x, 5), 3) + mathfunctions.Log(x, 2) + mathfunctions.Log(x, 5)) - 
                    (mathfunctions.Pow(mathfunctions.Ln(x), 3) / mathfunctions.Log(x, 3)) - (mathfunctions.Log(x, 2) + mathfunctions.Log(x, 5));
            }
        }

        public static double functionSys(double x)
        {
            if (x <= 0)
            {
                return (Math.Pow(Math.Pow(Math.Cos(x), 3) + 1.0 / Math.Tan(x), 2) - 1.0 / Math.Sin(x)) - Math.Cos(x);
            }

            else
            {
                return (Math.Pow(Math.Log(x, 10) / Math.Log(x, 5), 3) + Math.Log(x, 2) + Math.Log(x, 5)) -
                    (Math.Pow(Math.Log(x), 3) / Math.Log(x, 3)) - (Math.Log(x, 2) + Math.Log(x, 5));
            }
        }


    }
}
