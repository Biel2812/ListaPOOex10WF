using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ10
{
    internal class terreno
    {
        //atributos
        private double bas;
        private double alt;
        private double resultado;




        //metodos 
        public void setVbase(double p)
        {
            bas = p;
        }

        public void setValtura(double p)
        {
            alt = p;
        }


        public double getVbase()
        {
            return bas;
        }

        public double getValtura()
        {
            return alt;
        }

        public double getValores()
        {
            return resultado;
        }


        public void calcularValores()


        {

            resultado = bas * alt;

            if (resultado > 100)
            {
                Console.WriteLine("Terreno grande");
                Console.WriteLine("Com area de: " + resultado);
            }

            else
            {
                Console.WriteLine("Terreno pequeno");
                Console.WriteLine("Com area de: " + resultado);


            }
        }
}
}
