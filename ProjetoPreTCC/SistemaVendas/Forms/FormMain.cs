using SistemaVendas.Forms;
using SistemaVendas.Memory.Interface;
using SistemaVendas.Util;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class FormMain : Form
    {
        private readonly IMemory _memory;

        public FormMain()
        {
            InitializeComponent();

            _memory = new CustomInternMemory();

            DgvSales.DataSource = _memory.GetSales();
        }

        private void DgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSales.Columns[e.ColumnIndex].Name == "ColDelete")
            {
                FormHelper.ConfirmationMessageBox("Deseja excluir o registro?", "Confirmação", () =>
                {
                    DgvSales.Rows.RemoveAt(e.RowIndex);
                });
            }
        }

        private void BtnAddSale_Click(object sender, System.EventArgs e)
        {
            new FormEditorFieldsSale(_memory).ShowDialog();
        }
    }
}
