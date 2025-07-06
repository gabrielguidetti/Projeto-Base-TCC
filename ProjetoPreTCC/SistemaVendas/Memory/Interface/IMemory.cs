using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Memory.Interface
{
    public interface IMemory
    {
        BindingList<Sale> GetSales();
    }
}
