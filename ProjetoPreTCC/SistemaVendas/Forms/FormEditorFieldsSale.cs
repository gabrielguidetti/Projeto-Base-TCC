using SistemaVendas.Memory.Interface;
using SistemaVendas.Util;
using System;
using System.Windows.Forms;

namespace SistemaVendas.Forms
{
    public partial class FormEditorFieldsSale : Form
    {
        private readonly IMemory _memory;

        public FormEditorFieldsSale(IMemory memory)
        {
            InitializeComponent();

            _memory = memory;

            TxtBoxId.Text = Convert.ToString(_memory.GetNewId());
        }

        private void BtnConfirmAdd_Click(object sender, EventArgs e)
        {
            var amount = 0M;

            try
            {
                amount = Convert.ToDecimal(TxtBoxAmount.Text);
            }
            catch (Exception ex)
            {
                FormHelper.ErrorMessageBox("Digite um valor numérico no preço (999.99)", "Alerta");
                return;
            }

            var clientName = TxtBoxClientName.Text;
            var clientAge = (int) NumClientAge.Value;
            var id = long.Parse(TxtBoxId.Text);
            var productName = TxtBoxProductName.Text;

            Sale newSale = new Sale(id, clientName, clientAge, amount, productName);

            _memory.Add(newSale);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
