using FitnessTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTest.Interfaces
{
    // These are stub interfaces that already exist in the system
    // They're out of scope of the code review
    public interface IOrderWriter
    {
        void WriteOrders(IEnumerable<Order> orders);
    }
}
