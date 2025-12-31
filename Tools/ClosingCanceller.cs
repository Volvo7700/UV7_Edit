using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit.Tools
{
    public static class ClosingCanceller
    {
        public static void CancelClosingAll()
        {
            foreach (CancelClosing f in Application.OpenForms.OfType<CancelClosing>())
            {
                f.CancelClosing();
            }
        }

        public static void ClearAll()
        {
            foreach (CancelClosing f in Application.OpenForms.OfType<CancelClosing>())
            {
                f.ClearCancelClosing();
            }
        }
    }
}
