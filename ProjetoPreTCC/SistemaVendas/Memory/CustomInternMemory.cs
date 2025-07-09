using SistemaVendas.Memory.Interface;
using System.ComponentModel;
using System.Linq;

namespace SistemaVendas
{
    public class CustomInternMemory : IMemory
    {
        private BindingList<Sale> _sales;

        private long _id = 1;

        public CustomInternMemory()
        {
            _sales = new BindingList<Sale>();
        }

        public BindingList<Sale> GetSales()
        {
            return _sales;
        }

        public Sale Get(long id)
        {
            return _sales.FirstOrDefault(x => x.Id == id);
        }

        public bool Delete(long id)
        {
            var sale = Get(id);

            if(sale != null)
            {
                _sales.Remove(sale);
                return true;
            }

            return false;
        }

        public long GetNewId()
        {
            return _id;
        }

        public void Add(Sale sale)
        {
            _sales.Add(sale);
            _id++;
        }
    }
}
