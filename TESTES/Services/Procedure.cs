using System;

namespace TESTES.Services
{
    internal class Procedure
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }

        public Procedure()
        {
        }
        public Procedure(DateTime date, string name, double value)
        {
            Date = date;
            Name = name;
            Value = value;
        }


    }
}
