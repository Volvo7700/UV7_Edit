using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UV7_Edit.Tools
{
    public static class ExplorerFolderHelper
    {


        [ComImport]
        [Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        interface IShellItem
        {
            void BindToHandler();
            void GetParent();
            void GetDisplayName(SIGDN sigdnName, out IntPtr ppszName);
            void GetAttributes();
            void Compare();
        }

        private enum SIGDN : uint
        {
            SIGDN_NORMALDISPLAY = 0,
            SIGDN_FILESYSPATH = 0x80058000
        }

        [Flags]
        enum FileOperationFlags : uint
        {
            FOF_NOCONFIRMMKDIR = 0x00000200
        }

        enum FileAttributes : uint
        {
            Directory = 0x10
        }

        [ComImport]
        [Guid("947AAB5F-0A5C-4C13-B4D6-4EBB2E2E3E3C")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        interface IFileOperation
        {
            void Advise(IntPtr pfops, out uint pdwCookie);
            void Unadvise(uint dwCookie);

            void SetOperationFlags(FileOperationFlags dwOperationFlags);
            void SetProgressMessage([MarshalAs(UnmanagedType.LPWStr)] string pszMessage);
            void SetProgressDialog(IntPtr popd);
            void SetProperties(IntPtr pproparray);
            void SetOwnerWindow(uint hwndOwner);
            void ApplyPropertiesToItem(IShellItem psiItem);
            void ApplyPropertiesToItems(IntPtr punkItems);

            void RenameItem(IShellItem psiItem,
                [MarshalAs(UnmanagedType.LPWStr)] string pszNewName,
                IntPtr pfopsItem);

            void RenameItems(IntPtr pUnkItems,
                [MarshalAs(UnmanagedType.LPWStr)] string pszNewName);

            void MoveItem(IShellItem psiItem, IShellItem psiDestinationFolder,
                [MarshalAs(UnmanagedType.LPWStr)] string pszNewName,
                IntPtr pfopsItem);

            void MoveItems(IntPtr punkItems, IShellItem psiDestinationFolder);

            void CopyItem(IShellItem psiItem, IShellItem psiDestinationFolder,
                [MarshalAs(UnmanagedType.LPWStr)] string pszCopyName,
                IntPtr pfopsItem);

            void CopyItems(IntPtr punkItems, IShellItem psiDestinationFolder);

            void DeleteItem(IShellItem psiItem, IntPtr pfopsItem);
            void DeleteItems(IntPtr punkItems);

            void NewItem(IShellItem psiDestinationFolder,
                FileAttributes dwFileAttributes,
                [MarshalAs(UnmanagedType.LPWStr)] string pszName,
                [MarshalAs(UnmanagedType.LPWStr)] string pszTemplateName,
                out IShellItem ppsiItem);

            void PerformOperations();
            void GetAnyOperationsAborted([MarshalAs(UnmanagedType.Bool)] out bool pfAnyOperationsAborted);
        }

        static readonly Guid CLSID_FileOperation =
            new Guid("3AD05575-8857-4850-9277-11B85BDB8E09");

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern int SHCreateItemFromParsingName(
            string pszPath,
            IntPtr pbc,
            Guid riid,
            out IShellItem ppv);

        public static string CreateExplorerStyleFolder(string parentPath)
        {
            IFileOperation fileOp = (IFileOperation)Activator.CreateInstance(
                Type.GetTypeFromCLSID(CLSID_FileOperation));

            fileOp.SetOperationFlags(FileOperationFlags.FOF_NOCONFIRMMKDIR);

            IShellItem parent;
            SHCreateItemFromParsingName(
                parentPath,
                IntPtr.Zero,
                typeof(IShellItem).GUID,
                out parent);

            IShellItem created;

            fileOp.NewItem(
                parent,
                FileAttributes.Directory,
                null,   // → Shell generiert "Neuer Ordner"
                null,
                out created);

            fileOp.PerformOperations();

            created.GetDisplayName(SIGDN.SIGDN_FILESYSPATH, out IntPtr psz);

            string path = Marshal.PtrToStringUni(psz);
            Marshal.FreeCoTaskMem(psz);

            return path;
        }
    }
}
