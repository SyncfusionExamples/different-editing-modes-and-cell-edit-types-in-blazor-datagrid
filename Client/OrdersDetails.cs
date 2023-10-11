using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DifferentEditingSample
{
    public class OrdersDetails
    { 
        public int? OrderID { get; set; }

        public string CustomerID { get; set; }

        public DateTime? OrderDate { get; set; }

        public double? Freight { get; set; }

        public string ShipCountry { get; set; }

        public static List<OrdersDetails> GetOrdersDetails()
        {
            List<OrdersDetails> OrderData = new List<OrdersDetails>();
            {
                OrderData.Add(new OrdersDetails() { OrderID = 10248, CustomerID = "VINET", Freight = 32.38, ShipCountry = "Sweden", OrderDate = new DateTime(2019, 11, 15) });
                OrderData.Add(new OrdersDetails() { OrderID = 10249, CustomerID = "TOMSP", Freight = 11.61, ShipCountry = "Canada", OrderDate = new DateTime(2020, 06, 1) });
                OrderData.Add(new OrdersDetails() { OrderID = 10250, CustomerID = "HANAR", Freight = 65.83, ShipCountry = "Mexico", OrderDate = new DateTime(2019, 12, 15) });
                OrderData.Add(new OrdersDetails() { OrderID = 10251, CustomerID = "VICTE", Freight = 41.34, ShipCountry = "Austria", OrderDate = new DateTime(2020, 05, 15) });
                OrderData.Add(new OrdersDetails() { OrderID = 10252, CustomerID = "SUPRD", Freight = 51.3, ShipCountry = "UK", OrderDate = new DateTime(2020, 06, 10) });
                OrderData.Add(new OrdersDetails() { OrderID = 10253, CustomerID = "HANAR", Freight = 58.17, ShipCountry = "France", OrderDate = new DateTime(2020, 06, 2) });
                OrderData.Add(new OrdersDetails() { OrderID = 10254, CustomerID = "CHOPS", Freight = 22.98, ShipCountry = "Germany", OrderDate = new DateTime(2020, 07, 20) });
                OrderData.Add(new OrdersDetails() { OrderID = 10255, CustomerID = "RICSU", Freight = 148.33, ShipCountry = "Brazil", OrderDate = new DateTime(2020, 08, 22) });
                OrderData.Add(new OrdersDetails() { OrderID = 10256, CustomerID = "WELLI", Freight = 13.97, ShipCountry = "Denmark", OrderDate = new DateTime(2020, 02, 5) });
                OrderData.Add(new OrdersDetails() { OrderID = 10257, CustomerID = "HILAA", Freight = 81.91, ShipCountry = "Switzerland", OrderDate = new DateTime(2020, 05, 22) });
            };
            return OrderData;
        }
    }
}
