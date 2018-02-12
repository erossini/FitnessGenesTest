using FitnessTest.Interfaces;
using FitnessTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace FitnessTest.Bases
{
    public class OrderFilterBase
    {
        private IOrderWriter _writer;

        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        /// <value>The orders.</value>
        public ObservableCollection<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets the size of the filter.
        /// </summary>
        /// <value>The size of the filter.</value>
        public int FilterSize { get; set; }

        public OrderFilterBase(IOrderWriter orderWriter)
        {
            _writer = orderWriter;

            FilterSize = 0;
            Orders = new ObservableCollection<Order>();
        }

        public void WriteOutFiltrdAndPriceSortedOrders()
        {
            if (Orders.Count > 0 && FilterSize > 0)
                Orders = new ObservableCollection<Order> (FilterOrdersSmallerThan(Orders, FilterSize));

            _writer.WriteOrders(Orders.OrderBy(o => o.Price));
        }

        protected IEnumerable<Order> FilterOrdersSmallerThan(IEnumerable<Order> allOrders, int size)
        {
            if (allOrders != null && size > 0)
                return allOrders.Where(o => o.Size < size).ToList();
            else
                return null;
        }
    }
}