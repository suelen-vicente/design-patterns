﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter.ExternalAPIs
{
    public class SecondaryPaymentSystem
    {
        public double totalAmmount { get; set; }
        public string account { get; set; }

        public SecondaryPaymentSystem(double totalAmmount, string account)
        {
            this.totalAmmount = totalAmmount;
            this.account = account;
        }

        public void pay()
        {
            //configure and call external API
        }
    }
}
