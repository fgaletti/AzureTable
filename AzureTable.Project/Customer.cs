using System;
using System.Collections.Generic;
using System.Text;

namespace AzureTable.Project
{
    public  class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }

    }
}
