using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaCorporation
{
    internal class Support
    {
        public static void MSE(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MSI(string text)
        {
            MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MSW(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
