
using AgendaDesign.Entites;
using AgendaDesign.Services;
using System;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace AgendaDesign.Entites
{
    internal class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Procedure Procedure { get; set; }

        public Client(string name, string phone, string email, Procedure procedure)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Procedure = procedure;
        }

        public void AddProcedure(Procedure procedure)
        {
            Procedure = procedure;
        }
       

    }
}
