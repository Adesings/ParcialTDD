using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraSimple
    {
        public int Suma(int a, int b)
        {
            int sumavar = a + b;
            return sumavar;
        }

        public int SumaChar(string a, string b)
        {
            int sumacaracter = Convert.ToInt32(a) + Convert.ToInt32(b);

            return sumacaracter;
        }

        public int SumaChar2(string a, string b)
        {
            int sumacaracter1 = a.Equals(" ") ? 0 : Convert.ToInt32(a);
            int sumacaracter2 = b.Equals(" ") ? 0 : Convert.ToInt32(b);

            return sumacaracter1 + sumacaracter2;
        }

        public int Resta(int c, int d)
        {
            int resta = c - d;
            return resta;
        }

        public int Multiplicacion(int e, int f)
        {
            int multi = e * f;
            return multi;
        }

        public int Multiplicacion2(int e, int f)
        {
            int mult = e * f;
            return mult; 
        }

        public double RaizCuadrada(double g)
        {
            return Math.Sqrt(g);
        }

        public double Potencia(double x, double y)
        {
            double elevar = Math.Pow(x, y);

            return elevar;
        }

        public int Division(int j, int k)
        {
            int dividir = j / k;
            return dividir;
        }

        public double Redondear(double j, double k)
        {
            double redondeo = j / k;
            return Math.Round(redondeo);
        }

        public double Residuo(int j, int k)
        {
            int res = j % k;
            return res;
        }


    }
}
