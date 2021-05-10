using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureTable.Project
{
    class Orders : TableEntity

    {
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string name { get; set; }
        public string address1 { get; set; }
        public Orders()
        {

        }
        public Orders(int _quantity, string _type, string _orderid)
        {
            PartitionKey = _type;
            RowKey = _orderid;
            Quantity = _quantity;
        }
    }
}
