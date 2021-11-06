using System;

public class Program
{
    public static void Main()
    {
        int a = 0, b = 1;

        for (int i = 0; i < 51; i++)
        {
            int temp = a;
            a = b;
            b = a + temp;

            Console.Write(a + " ");


            if ((EsPar(a)) == true)
            {
                Console.Write("Es par" + ", ");
            }
            else
            {
                Console.Write("Es impar" + ", ");
            }

            if ((EsPrimo(a)) == true)
            {
                Console.Write("Es primo" + ", ");
            }
            else
            {
                Console.Write("No es primo" + ", ");
            }

            int c = a;

            while (c != 0)
            {

                int temp2 = c % 10;
                Console.Write(" '" + Convert.ToInt32(temp2) + "' ");
                c = c - temp2;
                c = c / 10;
            }

            Console.WriteLine();

        }
    }


    static bool EsPrimo(int a)
    {
        for (int i = 2; i < a; i++)
        {

            if ((a % i) == 0)
            {
                return false;
            }
        }
        return true;

    }

    static bool EsPar(int a)
    {
        if ((a % 2) == 0)
        {
            return true;
        }

        return false;
    }

}
