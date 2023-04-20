using System;
using System.Globalization;
using TESTES.Entites;

namespace AppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Telefone: ");
            double phone = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Endereço: ");
            string addressName = Console.ReadLine();

            Client client = new Client(name, phone, addressName);

            Console.WriteLine(client);
        }
    }
}