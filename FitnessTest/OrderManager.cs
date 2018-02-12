using FitnessTest.Bases;
using FitnessTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTest
{
    public class OrderManager<T> where T : OrderFilterBase
    {
        private readonly IOrderStore _orderStore;
        private readonly IOrderWriter _orderWriter;

        public OrderManager(IOrderStore orderStore, IOrderWriter orderWriter)
        {
            _orderStore = orderStore;
            _orderWriter = orderWriter;
        }

        public void WriteOutOrder()
        {
            var orders = _orderStore.GetOrders();
            _orderWriter.WriteOrders(orders);
        }
    }
}
