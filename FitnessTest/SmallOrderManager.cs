using System;
using System.Collections.Generic;
using System.Text;
using FitnessTest.Interfaces;

namespace FitnessTest
{
    public class SmallOrderManager : OrderManager<SmallFilter>
    {
        public SmallOrderManager(IOrderStore orderStore, IOrderWriter orderWriter) 
            : base(orderStore, orderWriter)
        {
        }
    }
}