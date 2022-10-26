using System;

class ejercicio
{
    static void Main()
    {
        int i;

        //Mostrar los multiplos de 3 y de 2 entre el 0 y 100
        for(i = 0; i < 100; i++)
        {  
            if(i % 3 == 0 || i % 2 == 0)
            {
                Console.Write("{0}|",i);
            }    
        }      


        Console.Write("\n\n");

    }
}   
