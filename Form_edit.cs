using MarkdownDeep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit
{
    public partial class Form_edit : Form
    {
        private Document doc;
        public Document Doc
        {
            get
            {
                return doc;
            }
            set
            {
                doc = value;
            }
        }

        public Form_edit(FileInfo file)
        {
            InitializeComponent();
            Doc = new Document(file);
            Doc.ContentChanged += ContentChanged;
            Doc.SavedChanged += SavedChanged;
        }

        private void ContentChanged(object sender, EventArgs e)
        {
            UpdateEditor();
        }
        private void SavedChanged(object sender, EventArgs e)
        {
            string title = Doc.File.Name;
            if (!Doc.Saved)
            {
                title += "*";
            }
            this.Text = title;
        }

        private void UpdateEditor()
        {
            editor.Text = Doc.Content;
        }

        #region Preview
        private string style = "body { font-family: Verdana } h1 { color:red }";
        private void EditorChanged(object sender, EventArgs e)
        {
            UpdateViewer();
            Doc.Modify(editor.Text);
        }

        private readonly string errorStr = "<head><title>Error</title></head><body><h1>Error</h1><p>The markdown data could not be parsed.<br><br>Detailed Error:<br><code>{0}</code></p></body>";
        private string ConvertMDtoHTML(string mdInput)
        {
            Markdown md = new Markdown();

            try
            {
                return md.Transform(mdInput);
            }
            catch (Exception ex)
            {
                return String.Format(errorStr, ex);
            }
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
        #endregion Preview
    }
}
