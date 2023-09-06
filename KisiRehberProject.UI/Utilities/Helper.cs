using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiRehberProject.UI.Utilities
{
    public class Helper
    {
        public static void ClearControls(Control.ControlCollection control)
        {
            foreach (Control c in control)
            {
                if(c is TextBox)
                {
                    TextBox textBox = (TextBox)c;
                    textBox.Clear();
                }
                else if(c is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox= (MaskedTextBox)c;
                    maskedTextBox.Clear();

                }
                else if (c is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)c;
                    ClearControls(groupBox.Controls);
                }
            }

        }
    }
}
