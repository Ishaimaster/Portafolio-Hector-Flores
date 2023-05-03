using System;

class Program
{
    static void Main()
    {
        //Filas = estudiantes Columnas = Asignaturas
        double[,] notas = new double[5, 6];
        string[] nombres = new string[5]; //Nombres de estudiantes

        //Llenarlos
        for (int f = 0; f < 5; f++)
        {
            Console.WriteLine("Ingrese nombre");
            nombres[f] = Console.ReadLine();


            for (int c = 0; c < 6; c++)
            {
                Random r = new Random();

                notas[f, c] = r.Next(1, 100);
            }

        }

        //promedio por estudiante
        double[] promedioest = new double[5];
        for (int f = 0; f < 5; f++)
        {
            double promedio = 0; //Reinicio de la variable

            for (int c = 0; c < 6; c++)
            {
                promedio = promedio + notas[f, c];
            }
            promedio = promedio / 6;
            promedioest[f] = promedio;

        }


        //promedio por asignatura
        double[] promedioasig = new double[6];
        for (int c = 0; c < 6; c++)
        {
            double promedioc = 0; //Reinicio de la variable

            for (int f = 0; f < 5; f++)
            {
                promedioc = promedioc + notas[f, c];
            }
            promedioc = promedioc / 5;
            promedioasig[c] = promedioc;

        }

        // mostrar datos
        for (int f = 0; f < 5; f++)
        {
            Console.Write(nombres[f]);

            for (int c = 0; c < 6; c++)
            {
                Console.Write(" " + notas[f, c] + " - ");

            }

            Console.Write("Promedio " + promedioest[f].ToString("0.00"));
            Console.WriteLine();

            Console.Write("Promedio por asignatura " + promedioasig[f].ToString("0.00"));
            Console.WriteLine();
        }


    }
}