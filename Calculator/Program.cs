using System;

namespace Calculator 
{
    public class Calculat 
    {
        public float Add(float x, float y)
        {
            return x + y;
        }

        public float Sub(float x, float y) 
        {
            return x - y;
        }

        public float Mul(float x, float y) 
        {
            return x * y;
        }

        public float Div(float x, float y) 
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return -1;
            }
        }


        public static void Main()
        { 

        }
    } 
}
