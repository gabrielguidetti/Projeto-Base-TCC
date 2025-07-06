using System;
using System.Windows.Forms;

namespace SistemaVendas.Forms
{
    public partial class FormEditorFieldsSale : Form
    {
        public FormEditorFieldsSale()
        {
            InitializeComponent();
        }

        private void BtnConfirmAdd_Click(object sender, EventArgs e)
        {
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
