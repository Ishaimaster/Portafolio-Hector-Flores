// See https://aka.ms/new-console-template for more information

public class Equipo
{
    

  //Hector FLores 1199923
  //Joaquin Choc 1280423

    static void Main()
    {
        //Solicita los equipos
        Console.WriteLine("Bienvenido al Campeonato de Futbol");
        Console.WriteLine("Cuantos equipos de futbol jugaron?");
        int equip = Convert.ToInt32(Console.ReadLine());

        string[] names = new string[equip];

        //Pide el nombre de los equipos
        for(int i = 0; i < equip ; i++)
        {
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del equipo");
                names[i] = Console.ReadLine();
                try
                {


                    if (names[i] != names[i - 1])
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Error");
                    }
                }
                catch
                {
                    break;
                }
            }
        }

        //Imprime el formato de la tabla
        string[] desc = { " " + "Partidos jugados", "Partidos ganados", "Partidos empatados", "Partidos Perdidos", "Goles a favor", "Goles en contra" };
    
        Random r = new Random();
        
        //Coloca el Random
        int[,] datos = new int[equip,6];
        
        for(int i = 0; i < equip; i++)
        {
            for(int j = 0; j < 6 ; j++)
            {
                datos[i, j] = r.Next(1, 15);
            }

        }

        //Imprime la matriz
        for(int i = 0; i < 6; i++)
        {
            Console.Write(desc[i]+ "\t");
        }
        Console.WriteLine();


        for (int i = 0; i < equip; i++)

        {

            Console.Write(names[i]+ " ");

            for (int j = 0; j < 6; j++)
            {

                Console.Write("");
                Console.Write(datos[i, j] + "\t" + "\t"); 
            }
            Console.WriteLine();
        }
        //////////////////////////////////////////////////////////////
        ///

        //Condiciones Mayor GOles a favor
        Console.WriteLine();

        double maximo = datos[0,0];

        for(int i = 0 ; i < equip ; i++)
        {
            if(maximo < datos[i, 4])
            {
                maximo = datos[i, 4];
                Console.WriteLine(" el equipo con mas goles a favor es " + names[i]);
            }    
            
        }

       
        // Menos goles en contra
        double minimo = datos[0, 0];

        for (int i = 0; i < equip; i++)
        {
            if (minimo > datos[i, 5])
            {
                minimo = datos[i, 5];

                Console.WriteLine(" el equipo con menos goles en contra es " + names[i]);
            }

        }


        Console.WriteLine() ;
        //Promedio de partidos jugados
        double suma = 0;
        double promedio = 0;

        for (int i = 0; i < equip; i++)
        {

            suma = datos[equip, 0] + suma;
        }

        promedio = suma / equip;

        Console.WriteLine(" EL promedio de partidos jugados es: " + promedio);

        //suma total de goles a favor
        double suma1 = 0;

        for (int i = 0; i < equip; i++)
        {

            suma1 = datos[equip, 4] + suma1;
        }

        Console.WriteLine("La suma total de goles a favor es: " + suma1);

        //Suma total de goles en contra
        double suma2 = 0;

        for (int i = 0; i < equip; i++)
        {

            suma2 = datos[equip, 5] + suma2;
        }

        Console.WriteLine("La suma total de goles en contra es: " + suma2);

        // Equipo con mas partidos empatados
        double maximo1 = datos[0, 0];

        for (int i = 0; i < equip; i++)
        {
            if (maximo < datos[i, 2])
            {
                maximo = datos[i, 2];
                Console.WriteLine(" el equipo con mas partidos empatados es " + names[i]);
            }

        }


        


    }





























































}