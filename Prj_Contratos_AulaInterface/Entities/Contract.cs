using System;
using System.Collections.Generic;
using System.Text;

namespace Prj_Contratos_AulaInterface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } 

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>(); 
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

        public string InstallmentsToString()
        {
            string r ="";
            foreach (Installment i in Installments)
            {
                r += i.ToString() + "\n";
            }
            return r;
        }
    }
}
