// See https://aka.ms/new-console-template for more information
using System;
// Hector Flores 1199923
Console.WriteLine("Bienvenido");

int n = 0;
int cont = 0;
int sumatoria = 0;

    for (int i2 = 1; i2 <= 10; i2++)
    {
            Console.WriteLine("Ingrese un numero");
            n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        sumatoria = sumatoria + n;
        cont++;
    }
    else if (n < 0)
    {
        Console.WriteLine("Ingrese un numero mayor que 0");
        i2--;
        cont--;
        sumatoria = sumatoria- n;
    }
        
               
           



            
    }

    Console.WriteLine("el promedio es  " + (sumatoria / cont));


Console.ReadKey();

// ejercicio 2

int contador = 0;



    for ( int i = 2; i < 30; i++)
    {
    for (int h = 1; h <= i; h++)
    {
        if (i % h == 0)
        {
            contador = contador + 1;
        }
    }
            if (contador <= 2)
            {
                Console.WriteLine(i);

            }

        
    contador = 0;
}
    Console.ReadKey();
