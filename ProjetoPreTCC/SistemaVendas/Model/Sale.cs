using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas
{
    public class Sale
    {
        public long Id { get; set; }
        public string ClientName { get; set; }
        public int ClientAge { get; set; }
        public decimal Amount { get; set; }
        public string ProductName { get; set; }

        public Sale(long id, string clientName, int clietAge, decimal amout, string productName)
        {
            this.Id = id;
            this.ClientName = clientName;
            this.ClientAge = clietAge;
            this.Amount = amout;
            this.ProductName = productName;
        }
    }
}
