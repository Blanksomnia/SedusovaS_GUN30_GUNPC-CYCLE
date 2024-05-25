using System;
using System.Drawing;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int amount = 0;             
        int[] Arrays = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21};
        int[] Fabonaci = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
        Console.WriteLine("------------ TASK 1 ------------");
        for (int i = Fabonaci.Length - 1; i >= 0; i--)
            Console.WriteLine("({1}): {0}", Fabonaci[i], i + 1);
        Console.WriteLine("------------ TASK 2 ------------");
        for (int index = Arrays.Length - 1; index >= 0; index--)
        {
            int Array = Arrays[index];
            if (Array % 2 != 0 && Array <= 20 || Array == 0)
            {
                continue;
            }
            Console.WriteLine("({1}): {0}",Array, (index + 1) / 2);
        }
        Console.WriteLine("------------ TASK 3 ------------");
        int result = 1;
        do
        {
            for (int index = Arrays.Length - 1; index >= 0; index--)
            {
                int Array = Arrays[index];
                if (Array > 10)
                {
                    continue;
                }
                if (Array == Arrays[10])
                {
                    Console.WriteLine("### multiplication by {0} ###", result);
                }
                Console.WriteLine("{2} * {1} = {0}",(Array) * result, index, result);
                
            }
            result++;
        } while (result <= 5);
        Console.WriteLine("------------ TASK 4 ------------");
        Console.WriteLine("enter the password:  ");
        string password = "qwerty";
        bool unlock = false;
        do
        {
            string right = Console.ReadLine();
            if (right == password)
            {
                unlock = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorrect password!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        } while (unlock == false);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Corrent password!");

    }

}

