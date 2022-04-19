﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
    public interface PaymentAdapter
    {
        void callsExternalPaymentSystem(Payment paymentModel);
    }
}
