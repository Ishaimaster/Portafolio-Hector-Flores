
class Libro
{
    //Constructor
   
    int codigo = 0;
     int pag = 0;
    string nombre;
    double porcentaje = 0;
    string estado;
    int pagleidas = 0;

   

    public void leerLibro()
    {
        pagleidas++;
        
        if (pagleidas == pag) 
        {
            estado = "";
                
        }else if (pagleidas > pag) {

            Console.WriteLine("Error, se alcanzo el limite de paginas del libro");
        
        }

    }

    public double obtenerPorcentaje()
    {
        porcentaje = ((double)pagleidas/ pag) * 100;

        porcentaje = (int)porcentaje;

        return porcentaje;

    }

    public int pagActual()
    {
        if(pagleidas < pag)
        {
            pagleidas = pagleidas;

        }else if (pagleidas > pag)
        {
            pagleidas--;
         
        }
        return pagleidas;

    }

    public void mostrarLibro()
    {
        Console.WriteLine("El codigo del libro es: " + codigo);

        Console.WriteLine("El nombre del libro es: " + nombre);

        Console.WriteLine("La cantidad de paginas del libro es: " + pag);

        Console.WriteLine("El porcentaje de lectura: " + obtenerPorcentaje()+"%");

        if (pagleidas < pag)
        {
            Console.WriteLine("Cantidad de paginas leidas es :" + pagleidas);
        }else if (pagleidas > pag)
        {
            pagleidas--;
            Console.WriteLine("Cantidad de paginas leidas es: " + pagleidas);
        }
    }


    public string estadoLibro()
    {
        if (pagleidas == pag)
        {
            estado = "Leido";

        }

        if (pagleidas < pag && pagleidas > 0)
        {


            estado = "En proceso";


        }
        else if (pagleidas == 0)
        {

            estado = "No leido";
        }

        return estado;

    }

    static void Main()
    {

        Libro libro = new Libro();

        Console.WriteLine("Ingrese el nombre del libro:");
        libro.nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el codigo");
        libro.codigo = Convert.ToInt32(Console.ReadLine());

        libro.pag = 300;

        libro.pagleidas = 200;

        libro.mostrarLibro();

        Console.WriteLine("El estado del libro es : " +libro.estadoLibro());

        Console.WriteLine("Al leer una pag del libro");
        
         libro.leerLibro();


        Console.WriteLine("La pagina actual es : " + libro.pagActual());






    }

        




















































}