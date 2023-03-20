using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservahotel.Classes
{
    internal class Reservas
    {
        public int Numquarto { get; set; }

        public DateTime Dataentrada { get; set; }

        public DateTime Datasaida { get; set; }

        public Reservas()
        {

        }
        public Reservas(int numquarto, DateTime dataentrada, DateTime datasaida)
        {
            Numquarto = numquarto;
            Dataentrada = dataentrada;
            Datasaida = datasaida;
        }

        public int Duracao()
        {
            TimeSpan duracao = Datasaida.Subtract(Dataentrada);

            return (int)duracao.TotalDays;
        }

        public void Atualizardata(DateTime dataentrada, DateTime datasaida )
        {
            Dataentrada = dataentrada;
            Datasaida = datasaida;


        }

        public override string ToString()
        {
            return " Numquarto:"
                + Numquarto
                 + " dataentrada:"
                  + Dataentrada.ToString("dd/MM/yyyy ")
                   + " datasaida:"
                    + Datasaida.ToString("dd/MM/yyyy ")
                     + Duracao()
                      + " noites";

        }


    }
}
