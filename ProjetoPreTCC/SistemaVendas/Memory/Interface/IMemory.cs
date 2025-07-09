using System.ComponentModel;

namespace SistemaVendas.Memory.Interface
{
    public interface IMemory
    {
        BindingList<Sale> GetSales();
        long GetNewId();
        void Add(Sale sale);
    }
}
