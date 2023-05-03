using System;

class Pelicula
{

    // Hector Flores Carnet: 1199923 
    string nombre;
    double duracion, calificacion = 0;
    string genero;
    int anio = 0;
    bool Peliepic = true;
    string Director = "";
    bool similar = true;

    public void infoPeli()
    {
        //Método para imprimir información
        Console.WriteLine("Nombre de la película: " + nombre);

        Console.WriteLine("Género de la película: " + genero);

        Console.WriteLine("Año del lanzamiento: " + anio);

        Console.WriteLine("Duración de la película: " + duracion);

    }

    // Método para determinar si la película es épica o no
    public bool esPeliculaEpica()
    {
        if (duracion >= 180)
        {
            Peliepic = true;
        }
        else
        {
            Peliepic = false;
        }
        return Peliepic;
    }

    // Método para determinar la valoración de la película
    public string peliValoracion()
    {
        if (calificacion >= 0 && calificacion <= 2)
        {
            return "Muy mala";
        }
        else if (calificacion > 2 && calificacion <= 5)
        {
            return "Mala";
        }
        else if (calificacion > 5 && calificacion <= 7)
        {
            return "Regular";
        }
        else if (calificacion > 7 && calificacion <= 8)
        {
            return "Buena";
        }
        else if (calificacion > 8 && calificacion <= 10)
        {
            return "Excelente";
        }
        else
        {
            return "Valoración inválida";
        }
    }

    // Método para determinar si dos películas son similares
    public bool esSimilar(Pelicula otraPeli)
    {
        if (duracion == otraPeli.duracion && calificacion == otraPeli.calificacion)
        {
            
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {

        Pelicula miPeli = new Pelicula();

        Console.WriteLine("Ingrese el nombre de la película:");
        miPeli.nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el género de la película (Comedia/Drama/Suspenso/Acción):");
        miPeli.genero = Console.ReadLine();

        Console.WriteLine("Ingrese el año del lanzamiento de la película:");
        miPeli.anio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la duración de la película en minutos:");
        miPeli.duracion = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la calificación de la película (0-10):");
        miPeli.calificacion = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("La información de la película es la siguiente:");
        miPeli.infoPeli();

        Console.WriteLine("¿Es esta película épica? " + miPeli.esPeliculaEpica());


        Console.WriteLine("La valoración de la película es: " + miPeli.peliValoracion());



        Pelicula otraPeli = new Pelicula();
        otraPeli.nombre = "Gandhi";
        otraPeli.Director = "Richard Attenborough";
        otraPeli.genero = "Drama";
        otraPeli.duracion = 191;
        otraPeli.anio = 1982;
        otraPeli.calificacion = 8.1;

        Pelicula otraPeli2 = new Pelicula();
        otraPeli2.nombre = "Thor";
        otraPeli2.Director = "Kenneth Branagh";
        otraPeli2.genero = "Accion";
        otraPeli2.duracion = 115;
        otraPeli2.anio = 2011;
        otraPeli2.calificacion = 7.0;


        Console.WriteLine("¿Esta película es similar a la otra película? " + miPeli.esSimilar(otraPeli));

        

    }
}

