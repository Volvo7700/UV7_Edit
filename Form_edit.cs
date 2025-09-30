using MarkdownDeep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class Form_edit : Form
    {
        private Document Doc { get; set; }
        
        public Form_edit()
        {
            InitializeComponent();
        }

        #region Logic
        private string style = "body { font-family: Verdana } h1 { color:red }";
        private void EditorChanged(object sender, EventArgs e)
        {
            UpdateViewer();
        }

        private string ConvertMDtoHTML(string mdInput)
        {
            Markdown md = new Markdown();

            return md.Transform(mdInput);
        }

        public void ChangeCSS(string css)
        {
            style = css;
            UpdateViewer();
        }

        private void UpdateViewer()
        {
            viewer.DocumentText = $"<html><head><style type=\"text/css\">{style}</style></head><body>{ConvertMDtoHTML(editor.Text)}</body></html>";
        }
        #endregion Logic
    }
}
