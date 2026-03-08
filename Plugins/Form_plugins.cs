using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using UV7_Edit_FileTypePlugin;

namespace UV7_Edit.Plugins
{
    public partial class Form_plugins : Form
    {
        public Form_plugins()
        {
            InitializeComponent();
            fastObjectListView1.SetObjects(FileTypes.LoadedAssemblies);
        }

        private void fastObjectListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateCurrentInfo();
        }

        private void UpdateCurrentInfo()
        {
            if (fastObjectListView1.SelectedObject is Assembly asm)
            {
                label_title.Text = AssemblyTools.getTitle(asm);
                label_desc.Text = AssemblyTools.getDescription(asm);
                Version ver = AssemblyTools.getVersion(asm);
                label_version.Text = $"{ver.Major}.{ver.Minor}.{ver.Build}.{ver.Revision}";
                label_company.Text = AssemblyTools.getCompany(asm);

                string fileTypes = "";
                IFileTypeSupport[] fileTypeSupports = PluginTools.GetFileTypeSupports(asm);
                foreach (IFileTypeSupport fileType in fileTypeSupports)
                {
                    fileTypes += fileType.FileFormat + Environment.NewLine;
                    
                    foreach (string extension in fileType.FileExtensions)
                    {
                        fileTypes += extension + " ";
                    }

                    fileTypes += Environment.NewLine + Environment.NewLine;
                }
                label_fileTypes.Text = fileTypes;
            }
            else
            {
                label_title.Text = "";
                label_desc.Text = "";
                label_version.Text = "";
                label_company.Text = "";
            }
        }
    }
}
