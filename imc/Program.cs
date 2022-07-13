using System;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com peso");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com altura");
            float altura = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Peso da pessoa:   " + peso);
            Console.WriteLine("Altura da pessoa:    " + altura);

            float imc = (peso /(altura * altura));

            if (imc < 18)
            {
                Console.WriteLine("Magro");


            }
            else if (imc > 18)
            {
                Console.WriteLine("Normal");

            }
            else if (ReferenceEquals(imc, 2))
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc = )



        }
    }
}
