using System.Globalization;

namespace AgendaDesign.Entites
{
    internal class Invoice
    {
        public double Payment { get; set; }

        public Invoice(double payment)
        {
            Payment = payment;
        }

        public double TotalPayment(double valouPerProcedure)
        {
            Payment += valouPerProcedure;
            return Payment;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
