using FitnessTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTest.Interfaces
{
    public interface IOrderStore
    {
        List<Order> GetOrders();
    }
}