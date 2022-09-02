using System;

namespace laboratorio_parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int validador = 0;
            do
            {
                Console.WriteLine("numeros de estudiantesa evaluar");
                int numEstudia = int.Parse(Console.ReadLine());
                int contador = 0;
                ArrayList lista = new ArrayList();
                string nombre;
                Double lab1;
                Double lab2;
                double parc;

                while (contador < numEstudia)
                {
                    Console.WriteLine("ingrese el nombre completo del estudiante ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingrese la nota del labaratorio 1");
                    lab1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la nota del laboratorio 2");
                    lab2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la nota del examen parcial");
                    parc = double.Parse(Console.ReadLine());

                    double notafinal = notafinal(lab1, lab2, parc);
                    string apr = aprob(notafinal);

                    Estudiantes estudiantes = new Estudiantes { nombre = nombre, NotaFinal, apr },
                        lista.Add(estudiantes);
                    contador++;
                }
                foreach(estudiantes st int lista)
                {
                    Console.WriteLine(st.getData());
                }
                Console.WriteLine("");
                Console.WriteLine("si desea ingresar nuevos datos de estudiante, digite cero y de lis y de clic en entrar");
                validador = int.Parse(Console.ReadLine());
                while (validador == 0) ;

            // funciones
         

                    









            }
       
        }



    }
}
