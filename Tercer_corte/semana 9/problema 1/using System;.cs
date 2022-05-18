using System;

namespace prb_1
{
    
   
    class Empleado
    {   
        int sueldo;
        string nombre;
        public Empleado()
        {
            Console.WriteLine(" nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Sueldo: ");
            sueldo = int.Parse(Console.ReadLine());

        }

        public void Imprimir()
        {
            Console.WriteLine(nombre);
            Console.WriteLine(sueldo);
        }
        public void Impuesto()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Saldo superior a 3000 debe pagar impuesto");
            }
        }

        static void Main(string[] args)
        {
            Empleado oo = new Empleado();
            oo.Imprimir();
            oo.Impuesto();
        }
    }
}