using System;
using System.Globalization;
using Prj_Contratos_AulaInterface.Entities;
using Prj_Contratos_AulaInterface.Services;

namespace Prj_Contratos_AulaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reads information
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value($): ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine());

            //Creates the contract
            Contract contract = new Contract(number, date, value);

            //Creates the contract and payment service
            ContractService cs = new ContractService(new PaypalPaymentService());

            //Process Contract
            cs.ProcessContract(contract, installmentsNumber);

            //Print installments
            Console.WriteLine("INSTALLMENTS: ");
            Console.WriteLine(contract.InstallmentsToString()); 
        }
    }
}
