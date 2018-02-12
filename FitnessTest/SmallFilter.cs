using FitnessTest.Bases;
using FitnessTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTest
{
    public class SmallFilter : OrderFilterBase
    {
        public SmallFilter(IOrderWriter orderWriter) : base(orderWriter)
        {
            FilterSize = 10;
        }
    }
}
