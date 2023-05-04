using System;
using AgendaDesign.Entites;
using AgendaDesign.Services;


namespace AppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Client> clients = new List<Client>();

                Console.WriteLine("INFORMAÇÕES PESSOAIS:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Qual seu e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Telefone: (xx) xxxxx-xxxx: ");
                string telefone = Console.ReadLine();

                Phone test = new Phone(telefone);
                if (test.ValidarTelefone(telefone) == false)
                {
                    Console.Write("Telefone: (xx) xxxxx-xxxx: ");
                    telefone = Console.ReadLine();
                }
                
                Console.Write("Qual o procedimento desejado: ");
                string procedimento = Console.ReadLine();

                clients.Add(new Client(name, telefone, email, new Procedure(DateTime.Now, procedimento, 20.00)));

                foreach (Client client in clients)
                {
                    Console.WriteLine($"Nome: {client.Name}, E-mail: {client.Email}, Telefone: {client.Phone}, Procedimento: " +
                        $"{client.Procedure}");
                }

            }
            catch (ClientException ex)
            {
                Console.WriteLine("Um erro ocorreu!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}