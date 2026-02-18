using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UV7_Edit.Preferences;

namespace UV7_Edit.Tools
{
    public static class FileSystemHelper
    {
        [DllImport("Shell32.dll", CharSet = CharSet.Auto)]
        private static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO pExecInfo);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        private const int SW_SHOW = 5;
        private const uint SEE_MASK_INVOKEIDLIST = 12;
        
        //private string basePath;
        //public string BasePath
        //{
        //    get => basePath;
        //    set
        //    {
        //        basePath = value;
        //        Initialize();
        //    }
        //}

        //DirectoryInfo dirInfo;

        //public FileHelper(string basePath)
        //{
        //    if (basePath != null)
        //    {
        //        BasePath = basePath;
        //    }
        //}

        //private void Initialize()
        //{
        //    dirInfo = new DirectoryInfo(basePath);
        //}

        //public bool CreateFile(string fileName)
        //{
        //    try
        //    {
        //        File.Create(Path.Combine(basePath, fileName));
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public bool RenameFile(string oldFileName, string newFileName)
        //{
        //    try
        //    {
        //        File.Move(Path.Combine(basePath, oldFileName), Path.Combine(basePath, newFileName));
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        private static void ShowErrorMsgBox(Exception ex)
        {
            MessageBox.Show(ex.ToString() + Environment.NewLine + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void OpenFolder(DirectoryInfo dirInfo)
        {
            try
            {
                Process.Start(dirInfo.FullName);
            }
            catch (Exception ex)
            {
                ShowErrorMsgBox(ex);
            }
        }

        public static void DeleteDirectory(DirectoryInfo dirInfo, bool shift)
        {
            UIOption ui = UIOption.OnlyErrorDialogs;
            UICancelOption uic = UICancelOption.DoNothing;
            RecycleOption re = RecycleOption.SendToRecycleBin;

            bool perma = !Pref.Prefs.NavigationTree.UseRecycleBin;

            // Delete directory permanently if...
            // Default is permadel and shift is not pressed
            // Default is recycle  and shift is     pressed
            // Else, use the recycling bin
            bool delete = shift ^ perma;

            if (delete)
            {
                re = RecycleOption.DeletePermanently;
                if (Pref.Prefs.NavigationTree.ShowDeleteConfirmation)
                {
                    ui = UIOption.AllDialogs;
                }
            }
            else
            {
                if (Pref.Prefs.NavigationTree.ShowRecycleConfirmation)
                {
                    ui = UIOption.AllDialogs;
                }
            }
            try
            {
                FileSystem.DeleteDirectory(dirInfo.FullName, ui, re, uic);
            }
            catch (Exception ex)
            {
                ShowErrorMsgBox(ex);
            }
        }

        public static void DeleteFile(FileInfo fileInfo, bool shift)
        {
            UIOption ui = UIOption.OnlyErrorDialogs;
            UICancelOption uic = UICancelOption.DoNothing;
            RecycleOption re = RecycleOption.SendToRecycleBin;

            bool perma = !Pref.Prefs.NavigationTree.UseRecycleBin;
            
            // Delete file permanently if...
            // Default is permadel and shift is not pressed
            // Default is recycle  and shift is     pressed
            // Else, use the recycling bin
            bool delete = shift ^ perma;

            if (delete)
            {
                re = RecycleOption.DeletePermanently;
                if (Pref.Prefs.NavigationTree.ShowDeleteConfirmation)
                {
                    ui = UIOption.AllDialogs;
                }
            }
            else
            {
                if (Pref.Prefs.NavigationTree.ShowRecycleConfirmation)
                {
                    ui = UIOption.AllDialogs;
                }
            }
            try
            {
                FileSystem.DeleteFile(fileInfo.FullName, ui, re, uic);
            }
            catch (Exception ex)
            {
                ShowErrorMsgBox(ex);
            }
        }

        public static void PropertiesDirectory(DirectoryInfo dirInfo)
        {
            //ProcessStartInfo psi = new ProcessStartInfo(dirInfo.FullName);
            //psi.Verb = "properties";
            //psi.UseShellExecute = true;
            //Process.Start(psi);
            try
            {
                SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
                info.cbSize = Marshal.SizeOf(info);
                info.lpVerb = "properties";
                info.lpFile = dirInfo.FullName;
                info.nShow = SW_SHOW;
                info.fMask = SEE_MASK_INVOKEIDLIST;

                ShellExecuteEx(ref info);
            }
            catch (Exception ex)
            {
                ShowErrorMsgBox(ex);
            }
        }
        public static void PropertiesFile(FileInfo fileInfo)
        {
            try
            {
                SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
                info.cbSize = Marshal.SizeOf(info);
                info.lpVerb = "properties";
                info.lpFile = fileInfo.FullName;
                info.nShow = SW_SHOW;
                info.fMask = SEE_MASK_INVOKEIDLIST;

                ShellExecuteEx(ref info);
            }
            catch (Exception ex)
            {
                ShowErrorMsgBox(ex);
            }
        }

        public static void RenameDirectory(DirectoryInfo dirInfo, string newName)
        {
            try
            {
                FileSystem.RenameDirectory(dirInfo.FullName, newName);
            }
            catch (Exception ex)
            {
                ShowErrorMsgBox(ex);
            }
        }

        public static void RenameFile(FileInfo fileInfo, string newName)
        {
            try
            {
                FileSystem.RenameFile(fileInfo.FullName, newName);
            }
            catch (Exception ex)
            {
                ShowErrorMsgBox(ex);
            }
        }
    }
}
