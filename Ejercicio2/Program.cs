using System;

class ejercicio2
{
    static void Main()
    {
        int i, impar = 0, par = 0;

        for (i = 1; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0}|", i);
                par++;
            }
        }
        Console.Write("\n\nDel 0 al 100 hay {0} números pares y {1} impares\n\n", par, impar);
    }
}

