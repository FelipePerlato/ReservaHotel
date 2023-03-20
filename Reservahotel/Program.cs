using Reservahotel.Classes;

using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Reservas r1 = new Reservas();

        Console.WriteLine("Numero da sala ");
        int numquarto = int.Parse(Console.ReadLine());

        Console.WriteLine("Data entrada");
        DateTime dataentrada = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Data saida");
        DateTime datasaida = DateTime.Parse(Console.ReadLine());

        if (datasaida > dataentrada)
        {
          r1 = new Reservas(numquarto, dataentrada, datasaida);

            Console.WriteLine("Reservas: " + r1);

        }
        else
        {
            Console.WriteLine("data invalida");

        }

        Console.WriteLine("Entre com os dados para atualizar a reserva");
        Console.WriteLine("Data entrada");
        dataentrada = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Data saida");
        datasaida = DateTime.Parse(Console.ReadLine());

         

        r1.Atualizardata(dataentrada,datasaida);


        Console.WriteLine("Reservas: " + r1);
    }
}