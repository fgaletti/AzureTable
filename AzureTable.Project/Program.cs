using Microsoft.Azure.Cosmos.Table;
using System;

namespace AzureTable.Project
{
   
    class Program
    {
        static string connectionString = "DefaultEndpointsProtocol=https;AccountName=stagingstore204cli;AccountKey=kjYXNyEgv+7Mk54YGV6/JvsCks3uCNSFfiYaYKyyouXP5XVVHPK4VC4ANGFQZ05yDklo0zpy2o4ZIGZspxRRUQ==;EndpointSuffix=core.windows.net";
        static string tableName = "orders";
        static string partitionKey = "cellphones";
        static string key = "04";

        static void Main(string[] args)
        {
            CloudStorageAccount _account = CloudStorageAccount.Parse(connectionString);
            CloudTableClient _tableClient = _account.CreateCloudTableClient();
            CloudTable table = _tableClient.GetTableReference(tableName);
            Orders orders = new Orders()
            {
                RowKey = "12",
                PartitionKey = partitionKey,
                name = "Pet10",
                Quantity = 12,
                UnitPrice = 12
            };

            TableOperation operation = TableOperation.Insert(orders);
            TableResult _result = table.Execute(operation);
            Console.WriteLine("table created");
            Console.ReadKey();
        }
    }
}
