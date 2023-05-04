using AgendaDesign.Entites;
using System.Text.RegularExpressions;

namespace AgendaDesign.Services
{
    internal class Phone
    {
        public string TelPhone { get; set; }

        public Phone(string phone)
        {
            TelPhone = phone;
        }


        public bool ValidarTelefone(string telphone)
        {
            return Regex.IsMatch(TelPhone, @"\d{10}$");
        }


    }
}
