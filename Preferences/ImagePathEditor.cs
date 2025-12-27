using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UV7_Edit.Preferences
{
    public partial class ImagePathEditor : UserControl
    {
        public ImagePathEditor(string imagePath)
        {
            InitializeComponent();
            try
            {
                ImageFileInfo = new FileInfo(imagePath);
            }
            catch
            {
                ImageFileInfo = null;
            }
        }

        private FileInfo imageFileInfo;
        public FileInfo ImageFileInfo
        {
            get => imageFileInfo;
            set
            {
                imageFileInfo = value;
                label_imageFileName.Text = value?.Name ?? String.Empty;
            }
        }

        public ImagePath ImagePath
        {
            get
            {
                string path = ImageFileInfo?.FullName ?? string.Empty;
                return new ImagePath(path);
            }
        }

        private void SelectImage(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    ImageFileInfo = new FileInfo(openFileDialog.FileName);
                }
                catch
                {

                }
                OnValueChanged();
            }
        }

        private void OnValueChanged()
        {
            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        public event EventHandler ValueChanged;
    }
}
