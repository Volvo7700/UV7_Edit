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
    public partial class Form_edit : Form, CancelClosing
    {
        private bool cancelClosing = false;
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

        /// <summary>
        /// Creates a new Form_edit
        /// Requires a Form_main as parent!
        /// </summary>
        /// <param name="file"></param>
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
            if (Doc.File != null)
                this.Text = Doc.File.Name;
            else
                this.Text = "New Document";
            if (!Doc.Saved)
            {
                this.Text += "*";
            }
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

        private void Form_edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelClosing)
            {
                // If closing has to be cancelled, cancel the closing and reset the value
                e.Cancel = true;
                cancelClosing = false;
            }
            else
            {
                if (!Doc.Saved)
                {
                    string fileName = "New Document";
                    if (Doc.FileValid)
                        fileName = Doc.File.Name;
                    DialogResult result = MessageBox.Show($"Do you want to save changes to {fileName}?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ((Form_main)Parent.Parent).Save(this);
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                    else
                    {
                        // If cancel is selected, cancel the closing of this form and all other forms that implement CancelClosing.
                        ClosingCanceller.CancelClosingAll();
                        // Because cancelClosing was also set true for this form, closing has to manually be cancelled and cancelClosing has to manually be reset here.
                        e.Cancel = true;
                        this.cancelClosing = false;
                    }
                }
            }
        }

        public void CancelClosing()
        {
            cancelClosing = true;
        }
    }
}
