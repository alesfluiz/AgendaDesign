using System;
using AgendaDesign.Entites;

namespace AgendaDesign.Services
{
    internal class Procedure
    {
        public DateTime Date { get; set; }
        public string NameProcedure { get; set; }
        public double Value { get; set; }

        public List<Client> Clients { get; set; }

        public Procedure()
        {
        }
        public Procedure(DateTime date, string nameProcedure, double value)
        {
            Date = date;
            NameProcedure = nameProcedure;
            Value = value;
        }


    }
}
