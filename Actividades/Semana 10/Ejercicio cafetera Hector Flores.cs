using System;

class Cafetera
{
    //atributos de la clase
    int codigo = 0;
    int capacidad = 0;
    bool lleno = true;
    int disponibles = 0;

    public void hacerCafe()
    {
        lleno = true;
        disponibles = capacidad;
      
        
    }
    public void servirTaza(int cantidad)
    {
    
         
        if (disponibles >= cantidad)
        {
            disponibles = disponibles - cantidad;
        }
        else
        {
            Console.WriteLine("Error, tazas no disponibles");
        }
        

    }

   public double obtenerPorcentaje()
    {

        double porcentaje = ((double)disponibles / capacidad) * 100;

        return porcentaje;

    }

    public void mostrarEstado()
    {
        string texto = codigo + " capacidad: "+ capacidad+" tazas servidas: "+(capacidad - disponibles)+
        " porcentaje: " + obtenerPorcentaje() + "%";
        
        Console.WriteLine(texto);

    }
    
    //constructor
    public Cafetera (int elCodigo, int laCapacidad){
        codigo = elCodigo;
        capacidad = laCapacidad;
        lleno = false;
        disponibles = 0;
    }
    static void Main()
    {
        Console.WriteLine("Ingrese capacidad de cafetera");
        int cap =Convert.ToInt32(Console.ReadLine());
        string opcion = "";
        
        Cafetera c = new Cafetera(1, cap);//objeto c tipo Cafetera
        
        c.hacerCafe();
        do{
            Console.WriteLine("Cuantas tazas quiere servir?");
            int tz = Convert.ToInt32(Console.ReadLine());
            c.servirTaza(tz);
            c.mostrarEstado();
            
            Console.WriteLine("Desea ingresar mas tazas?  s/n");
             opcion = Console.ReadLine();
            
        }while(opcion == "s");
        
    }



}