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
    }
}
