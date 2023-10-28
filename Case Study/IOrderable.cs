﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal interface IOrderable
    {
        void PlaceOrder(Customer customer, Product product, int quantity);
        void ProcessPayment(Customer customer, decimal amount);
        void DeliverProduct(Customer customer, Product product);
    }
}
