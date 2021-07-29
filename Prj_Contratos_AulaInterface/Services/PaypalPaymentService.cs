using System;
using System.Collections.Generic;
using System.Text;

namespace Prj_Contratos_AulaInterface.Services
{
    class PaypalPaymentService : IOnlinePaymentService
    {
        private double _monthInterest = 0.01;
        private double _paymentFee = 0.02;

        public double PaymentFee(double amount)
        {
            return amount += amount * _paymentFee;
        }

        public double Interest(double amount, int month)
        {
            return amount + (amount * _monthInterest * month);
        }
    }
}
