using Reservahotel.Classes;
using System;

internal class Program
{
   public static void Main(string[] args)
    {
        List<Reservas> lista = new List<Reservas>(); 

        Console.WriteLine("Numero da sala ");
        int numquarto = int.Parse(Console.ReadLine());

        Console.WriteLine("Data entrada");
        DateTime dataentrada = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Data saida");
        DateTime datasaida = DateTime.Parse(Console.ReadLine());

        if (datasaida > dataentrada)
        {

            lista.Add(new Reservas(numquarto, dataentrada, datasaida));
        }
        else
        {
            Console.WriteLine("data invalida");

        }
        Console.WriteLine(.ToString(numquarto));
    }
}