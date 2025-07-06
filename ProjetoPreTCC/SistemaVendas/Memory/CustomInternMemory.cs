using SistemaVendas.Memory.Interface;
using System.ComponentModel;
using System.Linq;

namespace SistemaVendas
{
    public class CustomInternMemory : IMemory
    {
        private BindingList<Sale> sales;

        public CustomInternMemory()
        {
            sales = new BindingList<Sale>()
            {
                new Sale(1, "Teste", 12, 10.0M, "Teste Produto"),
                new Sale(2, "Teste2", 13, 10.0M, "Teste Produto2"),
                new Sale(3, "Teste3", 14, 10.0M, "Teste Produto3"),
                new Sale(4, "Teste4", 15, 10.0M, "Teste Produto4"),
                new Sale(5, "Teste5", 16, 10.0M, "Teste Produto5"),
                new Sale(6, "Teste6", 17, 10.0M, "Teste Produto6")
            };
        }

        public BindingList<Sale> GetSales()
        {
            return sales;
        }

        public Sale Get(long id)
        {
            return sales.FirstOrDefault(x => x.Id == id);
        }

        public bool Delete(long id)
        {
            var sale = Get(id);

            if(sale != null)
            {
                sales.Remove(sale);
                return true;
            }

            return false;
        }
    }
}
