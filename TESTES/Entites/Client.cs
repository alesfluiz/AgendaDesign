using System;
using System.Net.Sockets;

namespace TESTES.Entites
{
    internal class Client
    {
        public string Name { get; set; }
        public double Phone { get; set; }
        public string Address { get; set; }

        public Client() { 
        }

        public Client(string name, double phone, string address)
        {
            Name = name;
            Phone = phone;
            Address = address;
        }



    }
}
