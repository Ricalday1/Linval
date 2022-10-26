using System;

class ejercicio1
{
    static void Main()
    {
        int i, impar = 0, par = 0;
        
        //Mostrar los nùmeros impares entre el 0 y el 100
        for (i = 0; i < 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write("{0}|", i);
                impar++;
            }
        }
        Console.Write("\n\n");
    }    
}

        
