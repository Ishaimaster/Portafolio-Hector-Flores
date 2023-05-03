using System;

class Program
{
    static void Main() {
        //Héctor Flores Carne 1199923
        int num, sumatoria = 0;
        
        Random r = new Random();
        
        
        
        for(int i = 1; i <= 100; i++){
            
            Console.WriteLine("INGRESE UN NUMERO: ");
            num = r.Next(100);
            
            Console.WriteLine(num);
            sumatoria = sumatoria + num;
            
        }
        
        Console.WriteLine("LA SUMATORIA ES: " + sumatoria);
    }
}