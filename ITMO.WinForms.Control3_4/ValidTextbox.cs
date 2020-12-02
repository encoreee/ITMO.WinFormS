using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForms.Control3_4
{
    public class ValidTextbox : System.Windows.Forms.TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле PIN не может содержать буквы");
            }
        }

    }
}

