using System;
using System.Windows.Forms;

namespace SistemaVendas.Util
{
    public static class FormHelper
    {
        public static void ConfirmationMessageBox(string text, string title, Action function)
        {
            if (MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                function();
        }
    }
}
