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

        public static void ErrorMessageBox(string text, string title)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
