using System;
using System.Collections.Generic;
using System.Text;
using Prj_Contratos_AulaInterface.Entities;

namespace Prj_Contratos_AulaInterface.Services
{
    class ContractService
    { 
        private IOnlinePaymentService _paymentService;

        public ContractService(IOnlinePaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract Contract, int months)
        {
            double baseAmount = Contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                //adds the interest
                double amount = _paymentService.Interest(baseAmount, i);
                //adds the payment fee
                amount = _paymentService.PaymentFee(amount);

                Installment inst = new Installment(Contract.Date.AddMonths(i), amount);
                Contract.AddInstallment(inst);
            }
        }
    }
}
