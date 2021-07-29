using System;
using System.Collections.Generic;
using System.Text;

namespace Prj_Contratos_AulaInterface.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
