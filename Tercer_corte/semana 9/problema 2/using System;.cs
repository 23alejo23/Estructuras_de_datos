using System;



namespace CALCULADORA
{
    class operar
    {
        private int N1 = 0;
        private int N2 = 0;

        public Operar()
        {
            Console.WriteLine("Ingrese el primer valor");
            N1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese el segundo valor");
            N2 = int.Parse(Console.ReadLine()); 
        }

        public void Sumar()
        {
            Console.WriteLine("");
            Console.WriteLine($"La suma de n1 y n2 es: {N1 + N2}");
        }

        public void Restar()
        {
            Console.WriteLine("");
            Console.WriteLine($"La resta de n1 y n2 es: {N1 - N2}");
        }

        public void Multiplicar()
        {
            Console.WriteLine("");
            Console.WriteLine($"La multiplicación de n1 y n2 es: {N1 * N2}");
        }

        public void Dividir()
        {
            Console.WriteLine("");
            Console.WriteLine($"La división de n1 y n2 es: {N1 / N2}");
        }
        
        static void Main(string[] args)
        {
            Operar oo = new Operar();
            oo.Sumar();
            oo.Restar();
            oo.Multiplicar();
            oo.Dividir();
            Console.ReadKey();
        }
    }
}