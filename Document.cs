using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UV7_Edit
{
    public class Document
    {
        public FileInfo File { get; set; }
        private string content;
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                OnContentChanged();
            }
        }
        public bool Modified { get; private set; }
        public bool Saved => !Modified && FileValid;

        public Document(FileInfo file)
        {
            File = file;
            Content = String.Empty;
            Modified = false;

            OnSavedChanged();
        }

        public void Modify(string newContent)
        {
            if (newContent != Content)
            {
                content = newContent;
                if (!Modified)
                {
                    Modified = true;
                    OnSavedChanged();
                }
            }
        }

        public void Save(string path)
        {
            if (path != null)
            {
                File = new FileInfo(path);
                Modified = false;
                OnSavedChanged();
            }
        }

        public bool FileValid
        {
            get
            {
                if (File != null)
                {
                    return File.Exists;
                }
                return false;
            }
        }

        public event EventHandler ContentChanged;
        private void OnContentChanged()
        {
            if (ContentChanged != null)
                ContentChanged.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler SavedChanged;
        private void OnSavedChanged()
        {
            if (SavedChanged != null)
            {
                SavedChanged.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
