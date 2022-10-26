using System;

class ejercicio
{
    static void Main()
    {
        int i;

        //Mostrar los multiplos de 3 del 0 al 100
        for(i = 0; i < 100; i++)
        {  
            if(i % 3 == 0)
            {
                Console.Write("{0}|",i);
            }    
        }      


        Console.Write("\n\n");

    }
}    
