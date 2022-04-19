using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using design_patterns.Adapter.ExternalAPIs;

namespace design_patterns.Adapter
{
    public class SecondaryPaymentSystemAdapter : IPaymentAdapter
    {
        public void callsExternalPaymentSystem(Payment paymentModel)
        {
            var secondaryPayment = new SecondaryPaymentSystem(paymentModel.ammount, paymentModel.depositAccount) ;
            secondaryPayment.pay();
        }
    }
}
