using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Você Pode Doar Sangue---\n");

            Console.Write("Indique sua idade: ");
            double idade = Convert.ToDouble(Console.ReadLine());

            if (idade < 18 || idade > 67)
            {
                Console.Write($"\nVocê não pode doar sangue com {idade} anos \n");
            }
            else
            {
               Console.Write($"\nVocê pode doar sangue com {idade} anos\n");
            }
        }
    }
}
