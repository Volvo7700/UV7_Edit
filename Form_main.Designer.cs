
namespace UV7_Edit
{
    partial class Form_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.panel_toolBar = new System.Windows.Forms.Panel();
            this.toolBar_main = new System.Windows.Forms.ToolBar();
            this.tb_newFile = new System.Windows.Forms.ToolBarButton();
            this.tb_openFile = new System.Windows.Forms.ToolBarButton();
            this.tb_saveFile = new System.Windows.Forms.ToolBarButton();
            this.tb_saveAll = new System.Windows.Forms.ToolBarButton();
            this.tb_sep1 = new System.Windows.Forms.ToolBarButton();
            this.tb_newFolder = new System.Windows.Forms.ToolBarButton();
            this.tb_openFolder = new System.Windows.Forms.ToolBarButton();
            this.imageList_toolBar = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mi_file = new System.Windows.Forms.MenuItem();
            this.mi_new = new System.Windows.Forms.MenuItem();
            this.mi_open = new System.Windows.Forms.MenuItem();
            this.mi_save = new System.Windows.Forms.MenuItem();
            this.mi_saveAs = new System.Windows.Forms.MenuItem();
            this.mi_saveAll = new System.Windows.Forms.MenuItem();
            this.mi_sep9 = new System.Windows.Forms.MenuItem();
            this.mi_startScreen = new System.Windows.Forms.MenuItem();
            this.mi_sep1 = new System.Windows.Forms.MenuItem();
            this.mi_pageSetup = new System.Windows.Forms.MenuItem();
            this.mi_print = new System.Windows.Forms.MenuItem();
            this.mi_sep2 = new System.Windows.Forms.MenuItem();
            this.mi_close = new System.Windows.Forms.MenuItem();
            this.mi_exit = new System.Windows.Forms.MenuItem();
            this.mi_folder = new System.Windows.Forms.MenuItem();
            this.fi_newFolder = new System.Windows.Forms.MenuItem();
            this.mi_openFolder = new System.Windows.Forms.MenuItem();
            this.mi_edit = new System.Windows.Forms.MenuItem();
            this.mi_undo = new System.Windows.Forms.MenuItem();
            this.mi_redo = new System.Windows.Forms.MenuItem();
            this.mi_sep3 = new System.Windows.Forms.MenuItem();
            this.mi_cut = new System.Windows.Forms.MenuItem();
            this.mi_copy = new System.Windows.Forms.MenuItem();
            this.mi_paste = new System.Windows.Forms.MenuItem();
            this.mi_sep0 = new System.Windows.Forms.MenuItem();
            this.mi_find = new System.Windows.Forms.MenuItem();
            this.mi_findAgain = new System.Windows.Forms.MenuItem();
            this.mi_replace = new System.Windows.Forms.MenuItem();
            this.mi_sep8 = new System.Windows.Forms.MenuItem();
            this.mi_prefs = new System.Windows.Forms.MenuItem();
            this.mi_format = new System.Windows.Forms.MenuItem();
            this.mi_lineWrap = new System.Windows.Forms.MenuItem();
            this.mi_font = new System.Windows.Forms.MenuItem();
            this.mi_view = new System.Windows.Forms.MenuItem();
            this.mi_showSidebar = new System.Windows.Forms.MenuItem();
            this.mi_showStatusbar = new System.Windows.Forms.MenuItem();
            this.mi_sep6 = new System.Windows.Forms.MenuItem();
            this.mi_zoomIn = new System.Windows.Forms.MenuItem();
            this.mi_zoomOut = new System.Windows.Forms.MenuItem();
            this.mi_resetZoom = new System.Windows.Forms.MenuItem();
            this.mi_editor = new System.Windows.Forms.MenuItem();
            this.mi_viewer = new System.Windows.Forms.MenuItem();
            this.mi_docView = new System.Windows.Forms.MenuItem();
            this.mi_showEditor = new System.Windows.Forms.MenuItem();
            this.mi_showViewer = new System.Windows.Forms.MenuItem();
            this.mi_showBoth = new System.Windows.Forms.MenuItem();
            this.mi_windows = new System.Windows.Forms.MenuItem();
            this.mi_cascade = new System.Windows.Forms.MenuItem();
            this.mi_splitHorz = new System.Windows.Forms.MenuItem();
            this.mi_splitVert = new System.Windows.Forms.MenuItem();
            this.mi_arrangeIcons = new System.Windows.Forms.MenuItem();
            this.mi_help = new System.Windows.Forms.MenuItem();
            this.mi_about = new System.Windows.Forms.MenuItem();
            this.mi_dev = new System.Windows.Forms.MenuItem();
            this.mi_cssStyler = new System.Windows.Forms.MenuItem();
            this.mi_sep5 = new System.Windows.Forms.MenuItem();
            this.mi_something = new System.Windows.Forms.MenuItem();
            this.mi_devChangeLang = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dirPanel = new UV7_Edit.DirPanel();
            this.betterFolderBrowser = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.panel_toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_toolBar
            // 
            this.panel_toolBar.Controls.Add(this.toolBar_main);
            resources.ApplyResources(this.panel_toolBar, "panel_toolBar");
            this.panel_toolBar.Name = "panel_toolBar";
            // 
            // toolBar_main
            // 
            resources.ApplyResources(this.toolBar_main, "toolBar_main");
            this.toolBar_main.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tb_newFile,
            this.tb_openFile,
            this.tb_saveFile,
            this.tb_saveAll,
            this.tb_sep1,
            this.tb_newFolder,
            this.tb_openFolder});
            this.toolBar_main.Divider = false;
            this.toolBar_main.ImageList = this.imageList_toolBar;
            this.toolBar_main.Name = "toolBar_main";
            this.toolBar_main.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_main_ButtonClick);
            // 
            // tb_newFile
            // 
            resources.ApplyResources(this.tb_newFile, "tb_newFile");
            this.tb_newFile.Name = "tb_newFile";
            // 
            // tb_openFile
            // 
            resources.ApplyResources(this.tb_openFile, "tb_openFile");
            this.tb_openFile.Name = "tb_openFile";
            // 
            // tb_saveFile
            // 
            resources.ApplyResources(this.tb_saveFile, "tb_saveFile");
            this.tb_saveFile.Name = "tb_saveFile";
            // 
            // tb_saveAll
            // 
            resources.ApplyResources(this.tb_saveAll, "tb_saveAll");
            this.tb_saveAll.Name = "tb_saveAll";
            // 
            // tb_sep1
            // 
            this.tb_sep1.Name = "tb_sep1";
            this.tb_sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tb_newFolder
            // 
            resources.ApplyResources(this.tb_newFolder, "tb_newFolder");
            this.tb_newFolder.Name = "tb_newFolder";
            // 
            // tb_openFolder
            // 
            resources.ApplyResources(this.tb_openFolder, "tb_openFolder");
            this.tb_openFolder.Name = "tb_openFolder";
            // 
            // imageList_toolBar
            // 
            this.imageList_toolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_toolBar.ImageStream")));
            this.imageList_toolBar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_toolBar.Images.SetKeyName(0, "NewFile");
            this.imageList_toolBar.Images.SetKeyName(1, "OpenFile");
            this.imageList_toolBar.Images.SetKeyName(2, "SaveFile");
            this.imageList_toolBar.Images.SetKeyName(3, "SaveAll");
            this.imageList_toolBar.Images.SetKeyName(4, "NewFolder");
            this.imageList_toolBar.Images.SetKeyName(5, "OpenFolder");
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_file,
            this.mi_folder,
            this.mi_edit,
            this.mi_format,
            this.mi_view,
            this.mi_editor,
            this.mi_viewer,
            this.mi_docView,
            this.mi_windows,
            this.mi_help,
            this.mi_dev});
            // 
            // mi_file
            // 
            this.mi_file.Index = 0;
            this.mi_file.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_new,
            this.mi_open,
            this.mi_save,
            this.mi_saveAs,
            this.mi_saveAll,
            this.mi_sep9,
            this.mi_startScreen,
            this.mi_sep1,
            this.mi_pageSetup,
            this.mi_print,
            this.mi_sep2,
            this.mi_close,
            this.mi_exit});
            resources.ApplyResources(this.mi_file, "mi_file");
            // 
            // mi_new
            // 
            this.mi_new.Index = 0;
            resources.ApplyResources(this.mi_new, "mi_new");
            this.mi_new.Click += new System.EventHandler(this.FileNew);
            // 
            // mi_open
            // 
            this.mi_open.Index = 1;
            resources.ApplyResources(this.mi_open, "mi_open");
            this.mi_open.Click += new System.EventHandler(this.FileOpen);
            // 
            // mi_save
            // 
            resources.ApplyResources(this.mi_save, "mi_save");
            this.mi_save.Index = 2;
            this.mi_save.Click += new System.EventHandler(this.FileSave);
            // 
            // mi_saveAs
            // 
            resources.ApplyResources(this.mi_saveAs, "mi_saveAs");
            this.mi_saveAs.Index = 3;
            this.mi_saveAs.Click += new System.EventHandler(this.FileSaveAs);
            // 
            // mi_saveAll
            // 
            this.mi_saveAll.Index = 4;
            resources.ApplyResources(this.mi_saveAll, "mi_saveAll");
            this.mi_saveAll.Click += new System.EventHandler(this.FileSaveAll);
            // 
            // mi_sep9
            // 
            this.mi_sep9.Index = 5;
            resources.ApplyResources(this.mi_sep9, "mi_sep9");
            // 
            // mi_startScreen
            // 
            this.mi_startScreen.Index = 6;
            resources.ApplyResources(this.mi_startScreen, "mi_startScreen");
            this.mi_startScreen.Click += new System.EventHandler(this.FileStartScreen);
            // 
            // mi_sep1
            // 
            this.mi_sep1.Index = 7;
            resources.ApplyResources(this.mi_sep1, "mi_sep1");
            // 
            // mi_pageSetup
            // 
            resources.ApplyResources(this.mi_pageSetup, "mi_pageSetup");
            this.mi_pageSetup.Index = 8;
            this.mi_pageSetup.Click += new System.EventHandler(this.FilePageSetup);
            // 
            // mi_print
            // 
            resources.ApplyResources(this.mi_print, "mi_print");
            this.mi_print.Index = 9;
            this.mi_print.Click += new System.EventHandler(this.FilePrint);
            // 
            // mi_sep2
            // 
            this.mi_sep2.Index = 10;
            resources.ApplyResources(this.mi_sep2, "mi_sep2");
            // 
            // mi_close
            // 
            resources.ApplyResources(this.mi_close, "mi_close");
            this.mi_close.Index = 11;
            this.mi_close.Click += new System.EventHandler(this.FileClose);
            // 
            // mi_exit
            // 
            this.mi_exit.Index = 12;
            resources.ApplyResources(this.mi_exit, "mi_exit");
            this.mi_exit.Click += new System.EventHandler(this.FileExit);
            // 
            // mi_folder
            // 
            this.mi_folder.Index = 1;
            this.mi_folder.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fi_newFolder,
            this.mi_openFolder});
            resources.ApplyResources(this.mi_folder, "mi_folder");
            // 
            // fi_newFolder
            // 
            this.fi_newFolder.Index = 0;
            resources.ApplyResources(this.fi_newFolder, "fi_newFolder");
            this.fi_newFolder.Click += new System.EventHandler(this.FolderNew);
            // 
            // mi_openFolder
            // 
            this.mi_openFolder.Index = 1;
            resources.ApplyResources(this.mi_openFolder, "mi_openFolder");
            this.mi_openFolder.Click += new System.EventHandler(this.FolderOpen);
            // 
            // mi_edit
            // 
            this.mi_edit.Index = 2;
            this.mi_edit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_undo,
            this.mi_redo,
            this.mi_sep3,
            this.mi_cut,
            this.mi_copy,
            this.mi_paste,
            this.mi_sep0,
            this.mi_find,
            this.mi_findAgain,
            this.mi_replace,
            this.mi_sep8,
            this.mi_prefs});
            resources.ApplyResources(this.mi_edit, "mi_edit");
            // 
            // mi_undo
            // 
            resources.ApplyResources(this.mi_undo, "mi_undo");
            this.mi_undo.Index = 0;
            // 
            // mi_redo
            // 
            resources.ApplyResources(this.mi_redo, "mi_redo");
            this.mi_redo.Index = 1;
            // 
            // mi_sep3
            // 
            this.mi_sep3.Index = 2;
            resources.ApplyResources(this.mi_sep3, "mi_sep3");
            // 
            // mi_cut
            // 
            resources.ApplyResources(this.mi_cut, "mi_cut");
            this.mi_cut.Index = 3;
            // 
            // mi_copy
            // 
            resources.ApplyResources(this.mi_copy, "mi_copy");
            this.mi_copy.Index = 4;
            // 
            // mi_paste
            // 
            resources.ApplyResources(this.mi_paste, "mi_paste");
            this.mi_paste.Index = 5;
            // 
            // mi_sep0
            // 
            this.mi_sep0.Index = 6;
            resources.ApplyResources(this.mi_sep0, "mi_sep0");
            // 
            // mi_find
            // 
            resources.ApplyResources(this.mi_find, "mi_find");
            this.mi_find.Index = 7;
            // 
            // mi_findAgain
            // 
            resources.ApplyResources(this.mi_findAgain, "mi_findAgain");
            this.mi_findAgain.Index = 8;
            // 
            // mi_replace
            // 
            resources.ApplyResources(this.mi_replace, "mi_replace");
            this.mi_replace.Index = 9;
            // 
            // mi_sep8
            // 
            this.mi_sep8.Index = 10;
            resources.ApplyResources(this.mi_sep8, "mi_sep8");
            // 
            // mi_prefs
            // 
            this.mi_prefs.Index = 11;
            resources.ApplyResources(this.mi_prefs, "mi_prefs");
            this.mi_prefs.Click += new System.EventHandler(this.EditPrefs);
            // 
            // mi_format
            // 
            this.mi_format.Index = 3;
            this.mi_format.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_lineWrap,
            this.mi_font});
            resources.ApplyResources(this.mi_format, "mi_format");
            // 
            // mi_lineWrap
            // 
            resources.ApplyResources(this.mi_lineWrap, "mi_lineWrap");
            this.mi_lineWrap.Index = 0;
            // 
            // mi_font
            // 
            resources.ApplyResources(this.mi_font, "mi_font");
            this.mi_font.Index = 1;
            // 
            // mi_view
            // 
            this.mi_view.Index = 4;
            this.mi_view.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_showSidebar,
            this.mi_showStatusbar,
            this.mi_sep6,
            this.mi_zoomIn,
            this.mi_zoomOut,
            this.mi_resetZoom});
            resources.ApplyResources(this.mi_view, "mi_view");
            // 
            // mi_showSidebar
            // 
            this.mi_showSidebar.Checked = true;
            this.mi_showSidebar.Index = 0;
            resources.ApplyResources(this.mi_showSidebar, "mi_showSidebar");
            this.mi_showSidebar.Click += new System.EventHandler(this.ViewShowSidebar);
            // 
            // mi_showStatusbar
            // 
            this.mi_showStatusbar.Checked = true;
            this.mi_showStatusbar.Index = 1;
            resources.ApplyResources(this.mi_showStatusbar, "mi_showStatusbar");
            this.mi_showStatusbar.Click += new System.EventHandler(this.ViewShowStatusbar);
            // 
            // mi_sep6
            // 
            this.mi_sep6.Index = 2;
            resources.ApplyResources(this.mi_sep6, "mi_sep6");
            // 
            // mi_zoomIn
            // 
            resources.ApplyResources(this.mi_zoomIn, "mi_zoomIn");
            this.mi_zoomIn.Index = 3;
            // 
            // mi_zoomOut
            // 
            resources.ApplyResources(this.mi_zoomOut, "mi_zoomOut");
            this.mi_zoomOut.Index = 4;
            // 
            // mi_resetZoom
            // 
            resources.ApplyResources(this.mi_resetZoom, "mi_resetZoom");
            this.mi_resetZoom.Index = 5;
            // 
            // mi_editor
            // 
            this.mi_editor.Index = 5;
            resources.ApplyResources(this.mi_editor, "mi_editor");
            // 
            // mi_viewer
            // 
            this.mi_viewer.Index = 6;
            resources.ApplyResources(this.mi_viewer, "mi_viewer");
            // 
            // mi_docView
            // 
            this.mi_docView.Index = 7;
            this.mi_docView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_showEditor,
            this.mi_showViewer,
            this.mi_showBoth});
            resources.ApplyResources(this.mi_docView, "mi_docView");
            // 
            // mi_showEditor
            // 
            this.mi_showEditor.Index = 0;
            this.mi_showEditor.RadioCheck = true;
            resources.ApplyResources(this.mi_showEditor, "mi_showEditor");
            this.mi_showEditor.Click += new System.EventHandler(this.DocViewShowEditor);
            // 
            // mi_showViewer
            // 
            this.mi_showViewer.Index = 1;
            this.mi_showViewer.RadioCheck = true;
            resources.ApplyResources(this.mi_showViewer, "mi_showViewer");
            this.mi_showViewer.Click += new System.EventHandler(this.DocViewShowViewer);
            // 
            // mi_showBoth
            // 
            this.mi_showBoth.Index = 2;
            this.mi_showBoth.RadioCheck = true;
            resources.ApplyResources(this.mi_showBoth, "mi_showBoth");
            this.mi_showBoth.Click += new System.EventHandler(this.DocViewShowBoth);
            // 
            // mi_windows
            // 
            this.mi_windows.Index = 8;
            this.mi_windows.MdiList = true;
            this.mi_windows.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_cascade,
            this.mi_splitHorz,
            this.mi_splitVert,
            this.mi_arrangeIcons});
            resources.ApplyResources(this.mi_windows, "mi_windows");
            // 
            // mi_cascade
            // 
            this.mi_cascade.Index = 0;
            resources.ApplyResources(this.mi_cascade, "mi_cascade");
            this.mi_cascade.Click += new System.EventHandler(this.WindowCascade);
            // 
            // mi_splitHorz
            // 
            this.mi_splitHorz.Index = 1;
            resources.ApplyResources(this.mi_splitHorz, "mi_splitHorz");
            this.mi_splitHorz.Click += new System.EventHandler(this.WindowSplitHorizontal);
            // 
            // mi_splitVert
            // 
            this.mi_splitVert.Index = 2;
            resources.ApplyResources(this.mi_splitVert, "mi_splitVert");
            this.mi_splitVert.Click += new System.EventHandler(this.WindowSplitVertical);
            // 
            // mi_arrangeIcons
            // 
            this.mi_arrangeIcons.Index = 3;
            resources.ApplyResources(this.mi_arrangeIcons, "mi_arrangeIcons");
            this.mi_arrangeIcons.Click += new System.EventHandler(this.WindowArrangeIcons);
            // 
            // mi_help
            // 
            this.mi_help.Index = 9;
            this.mi_help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_about});
            resources.ApplyResources(this.mi_help, "mi_help");
            // 
            // mi_about
            // 
            this.mi_about.Index = 0;
            resources.ApplyResources(this.mi_about, "mi_about");
            this.mi_about.Click += new System.EventHandler(this.HelpAbout);
            // 
            // mi_dev
            // 
            this.mi_dev.Index = 10;
            this.mi_dev.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_cssStyler,
            this.mi_sep5,
            this.mi_something,
            this.mi_devChangeLang,
            this.menuItem1});
            resources.ApplyResources(this.mi_dev, "mi_dev");
            // 
            // mi_cssStyler
            // 
            this.mi_cssStyler.Index = 0;
            resources.ApplyResources(this.mi_cssStyler, "mi_cssStyler");
            this.mi_cssStyler.Click += new System.EventHandler(this.DevCssStyler);
            // 
            // mi_sep5
            // 
            this.mi_sep5.Index = 1;
            resources.ApplyResources(this.mi_sep5, "mi_sep5");
            // 
            // mi_something
            // 
            this.mi_something.Index = 2;
            resources.ApplyResources(this.mi_something, "mi_something");
            // 
            // mi_devChangeLang
            // 
            this.mi_devChangeLang.Index = 3;
            resources.ApplyResources(this.mi_devChangeLang, "mi_devChangeLang");
            this.mi_devChangeLang.Click += new System.EventHandler(this.DevChangeLang);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            resources.ApplyResources(this.menuItem1, "menuItem1");
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            // 
            // saveFileDialog
            // 
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileOpen_OK);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // dirPanel
            // 
            resources.ApplyResources(this.dirPanel, "dirPanel");
            this.dirPanel.Name = "dirPanel";
            this.dirPanel.Path = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE";
            this.dirPanel.Title = "DirPanel";
            // 
            // betterFolderBrowser
            // 
            this.betterFolderBrowser.Multiselect = false;
            this.betterFolderBrowser.RootFolder = "Application.StartupPath";
            this.betterFolderBrowser.Title = "Open Folder";
            // 
            // Form_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dirPanel);
            this.Controls.Add(this.panel_toolBar);
            this.Controls.Add(this.statusBar);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu;
            this.Name = "Form_main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosed);
            this.MdiChildActivate += new System.EventHandler(this.Form_main_MdiChildActivate);
            this.panel_toolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_toolBar;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem mi_file;
        private System.Windows.Forms.MenuItem mi_new;
        private System.Windows.Forms.MenuItem mi_open;
        private System.Windows.Forms.MenuItem mi_save;
        private System.Windows.Forms.MenuItem mi_saveAs;
        private System.Windows.Forms.MenuItem mi_sep1;
        private System.Windows.Forms.MenuItem mi_pageSetup;
        private System.Windows.Forms.MenuItem mi_print;
        private System.Windows.Forms.MenuItem mi_sep2;
        private System.Windows.Forms.MenuItem mi_close;
        private System.Windows.Forms.MenuItem mi_exit;
        private System.Windows.Forms.MenuItem mi_format;
        private System.Windows.Forms.MenuItem mi_edit;
        private System.Windows.Forms.MenuItem mi_view;
        private System.Windows.Forms.MenuItem mi_help;
        private System.Windows.Forms.MenuItem mi_undo;
        private System.Windows.Forms.MenuItem mi_redo;
        private System.Windows.Forms.MenuItem mi_sep3;
        private System.Windows.Forms.MenuItem mi_cut;
        private System.Windows.Forms.MenuItem mi_copy;
        private System.Windows.Forms.MenuItem mi_paste;
        private System.Windows.Forms.MenuItem mi_sep0;
        private System.Windows.Forms.MenuItem mi_find;
        private System.Windows.Forms.MenuItem mi_findAgain;
        private System.Windows.Forms.MenuItem mi_replace;
        private System.Windows.Forms.MenuItem mi_lineWrap;
        private System.Windows.Forms.MenuItem mi_font;
        private System.Windows.Forms.MenuItem mi_showSidebar;
        private System.Windows.Forms.MenuItem mi_showStatusbar;
        private System.Windows.Forms.MenuItem mi_sep6;
        private System.Windows.Forms.MenuItem mi_zoomIn;
        private System.Windows.Forms.MenuItem mi_zoomOut;
        private System.Windows.Forms.MenuItem mi_resetZoom;
        private System.Windows.Forms.MenuItem mi_about;
        private System.Windows.Forms.MenuItem mi_dev;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.MenuItem mi_cssStyler;
        private System.Windows.Forms.MenuItem mi_sep5;
        private System.Windows.Forms.MenuItem mi_something;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuItem mi_editor;
        private System.Windows.Forms.MenuItem mi_viewer;
        private System.Windows.Forms.MenuItem mi_sep8;
        private System.Windows.Forms.MenuItem mi_prefs;
        private System.Windows.Forms.MenuItem mi_sep9;
        private System.Windows.Forms.MenuItem mi_startScreen;
        private System.Windows.Forms.MenuItem mi_devChangeLang;
        private System.Windows.Forms.MenuItem menuItem1;
        private DirPanel dirPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuItem mi_windows;
        private System.Windows.Forms.MenuItem mi_cascade;
        private System.Windows.Forms.MenuItem mi_splitHorz;
        private System.Windows.Forms.MenuItem mi_splitVert;
        private System.Windows.Forms.MenuItem mi_arrangeIcons;
        private System.Windows.Forms.MenuItem mi_docView;
        private System.Windows.Forms.MenuItem mi_showEditor;
        private System.Windows.Forms.MenuItem mi_showViewer;
        private System.Windows.Forms.MenuItem mi_showBoth;
        private System.Windows.Forms.ToolBar toolBar_main;
        private System.Windows.Forms.ToolBarButton tb_newFile;
        private System.Windows.Forms.ToolBarButton tb_openFile;
        private System.Windows.Forms.ToolBarButton tb_saveFile;
        private System.Windows.Forms.ImageList imageList_toolBar;
        private System.Windows.Forms.ToolBarButton tb_newFolder;
        private System.Windows.Forms.ToolBarButton tb_saveAll;
        private System.Windows.Forms.ToolBarButton tb_sep1;
        private System.Windows.Forms.ToolBarButton tb_openFolder;
        private System.Windows.Forms.MenuItem mi_folder;
        private System.Windows.Forms.MenuItem fi_newFolder;
        private System.Windows.Forms.MenuItem mi_openFolder;
        private System.Windows.Forms.MenuItem mi_saveAll;
        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser betterFolderBrowser;
    }
}

