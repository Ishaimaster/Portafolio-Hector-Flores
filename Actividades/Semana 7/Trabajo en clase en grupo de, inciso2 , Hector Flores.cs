using System;

class Program
{
    static void Main() {
        // Hector Flores Carne 1199923
        //VARIABLES
        double estatura, promedio;
        int cont = 0;
        double suma = 0;
        char r;
        
        //CICLO
        do{
          
          Console.WriteLine("INGRESE ESTATURA: ");
          estatura = Convert.ToDouble(Console.ReadLine());
          
          suma = suma + estatura;
          cont++;
          
          Console.WriteLine("¿DESEA CONTINUAR? s = si / n = no");
          r = Convert.ToChar(Console.ReadLine());
            
            
            
            
        }while( r == 's');
        
        promedio = suma/cont;
        
        Console.WriteLine("EL PROMEDIO DE ESTATURA ES: " + promedio + " metros");
        
    }
}