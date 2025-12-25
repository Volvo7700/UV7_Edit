
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
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mi_file = new System.Windows.Forms.MenuItem();
            this.mi_new = new System.Windows.Forms.MenuItem();
            this.mi_open = new System.Windows.Forms.MenuItem();
            this.mi_save = new System.Windows.Forms.MenuItem();
            this.mi_saveAs = new System.Windows.Forms.MenuItem();
            this.mi_sep9 = new System.Windows.Forms.MenuItem();
            this.mi_startScreen = new System.Windows.Forms.MenuItem();
            this.mi_sep1 = new System.Windows.Forms.MenuItem();
            this.mi_pageSetup = new System.Windows.Forms.MenuItem();
            this.mi_print = new System.Windows.Forms.MenuItem();
            this.mi_sep2 = new System.Windows.Forms.MenuItem();
            this.mi_close = new System.Windows.Forms.MenuItem();
            this.mi_exit = new System.Windows.Forms.MenuItem();
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
            this.mi_editor = new System.Windows.Forms.MenuItem();
            this.mi_viewer = new System.Windows.Forms.MenuItem();
            this.mi_view = new System.Windows.Forms.MenuItem();
            this.mi_showEditor = new System.Windows.Forms.MenuItem();
            this.mi_showViewer = new System.Windows.Forms.MenuItem();
            this.mi_showBoth = new System.Windows.Forms.MenuItem();
            this.mi_sep4 = new System.Windows.Forms.MenuItem();
            this.mi_showSidebar = new System.Windows.Forms.MenuItem();
            this.mi_showStatusbar = new System.Windows.Forms.MenuItem();
            this.mi_sep6 = new System.Windows.Forms.MenuItem();
            this.mi_zoomIn = new System.Windows.Forms.MenuItem();
            this.mi_zoomOut = new System.Windows.Forms.MenuItem();
            this.mi_resetZoom = new System.Windows.Forms.MenuItem();
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
            this.dirPanel = new UV7_Edit.DirPanel();
            this.SuspendLayout();
            // 
            // panel_toolBar
            // 
            resources.ApplyResources(this.panel_toolBar, "panel_toolBar");
            this.panel_toolBar.Name = "panel_toolBar";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_file,
            this.mi_edit,
            this.mi_format,
            this.mi_editor,
            this.mi_viewer,
            this.mi_view,
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
            // mi_sep9
            // 
            this.mi_sep9.Index = 4;
            resources.ApplyResources(this.mi_sep9, "mi_sep9");
            // 
            // mi_startScreen
            // 
            this.mi_startScreen.Index = 5;
            resources.ApplyResources(this.mi_startScreen, "mi_startScreen");
            this.mi_startScreen.Click += new System.EventHandler(this.FileStartScreen);
            // 
            // mi_sep1
            // 
            this.mi_sep1.Index = 6;
            resources.ApplyResources(this.mi_sep1, "mi_sep1");
            // 
            // mi_pageSetup
            // 
            resources.ApplyResources(this.mi_pageSetup, "mi_pageSetup");
            this.mi_pageSetup.Index = 7;
            this.mi_pageSetup.Click += new System.EventHandler(this.FilePageSetup);
            // 
            // mi_print
            // 
            resources.ApplyResources(this.mi_print, "mi_print");
            this.mi_print.Index = 8;
            this.mi_print.Click += new System.EventHandler(this.FilePrint);
            // 
            // mi_sep2
            // 
            this.mi_sep2.Index = 9;
            resources.ApplyResources(this.mi_sep2, "mi_sep2");
            // 
            // mi_close
            // 
            resources.ApplyResources(this.mi_close, "mi_close");
            this.mi_close.Index = 10;
            this.mi_close.Click += new System.EventHandler(this.FileClose);
            // 
            // mi_exit
            // 
            this.mi_exit.Index = 11;
            resources.ApplyResources(this.mi_exit, "mi_exit");
            this.mi_exit.Click += new System.EventHandler(this.FileExit);
            // 
            // mi_edit
            // 
            this.mi_edit.Index = 1;
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
            this.mi_format.Index = 2;
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
            // mi_editor
            // 
            this.mi_editor.Index = 3;
            resources.ApplyResources(this.mi_editor, "mi_editor");
            // 
            // mi_viewer
            // 
            this.mi_viewer.Index = 4;
            resources.ApplyResources(this.mi_viewer, "mi_viewer");
            // 
            // mi_view
            // 
            this.mi_view.Index = 5;
            this.mi_view.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_showEditor,
            this.mi_showViewer,
            this.mi_showBoth,
            this.mi_sep4,
            this.mi_showSidebar,
            this.mi_showStatusbar,
            this.mi_sep6,
            this.mi_zoomIn,
            this.mi_zoomOut,
            this.mi_resetZoom});
            resources.ApplyResources(this.mi_view, "mi_view");
            // 
            // mi_showEditor
            // 
            resources.ApplyResources(this.mi_showEditor, "mi_showEditor");
            this.mi_showEditor.Index = 0;
            this.mi_showEditor.RadioCheck = true;
            // 
            // mi_showViewer
            // 
            resources.ApplyResources(this.mi_showViewer, "mi_showViewer");
            this.mi_showViewer.Index = 1;
            this.mi_showViewer.RadioCheck = true;
            // 
            // mi_showBoth
            // 
            this.mi_showBoth.Checked = true;
            resources.ApplyResources(this.mi_showBoth, "mi_showBoth");
            this.mi_showBoth.Index = 2;
            this.mi_showBoth.RadioCheck = true;
            // 
            // mi_sep4
            // 
            this.mi_sep4.Index = 3;
            resources.ApplyResources(this.mi_sep4, "mi_sep4");
            // 
            // mi_showSidebar
            // 
            this.mi_showSidebar.Checked = true;
            this.mi_showSidebar.Index = 4;
            resources.ApplyResources(this.mi_showSidebar, "mi_showSidebar");
            this.mi_showSidebar.Click += new System.EventHandler(this.ViewShowSidebar);
            // 
            // mi_showStatusbar
            // 
            this.mi_showStatusbar.Checked = true;
            this.mi_showStatusbar.Index = 5;
            resources.ApplyResources(this.mi_showStatusbar, "mi_showStatusbar");
            this.mi_showStatusbar.Click += new System.EventHandler(this.ViewShowStatusbar);
            // 
            // mi_sep6
            // 
            this.mi_sep6.Index = 6;
            resources.ApplyResources(this.mi_sep6, "mi_sep6");
            // 
            // mi_zoomIn
            // 
            resources.ApplyResources(this.mi_zoomIn, "mi_zoomIn");
            this.mi_zoomIn.Index = 7;
            // 
            // mi_zoomOut
            // 
            resources.ApplyResources(this.mi_zoomOut, "mi_zoomOut");
            this.mi_zoomOut.Index = 8;
            // 
            // mi_resetZoom
            // 
            resources.ApplyResources(this.mi_resetZoom, "mi_resetZoom");
            this.mi_resetZoom.Index = 9;
            // 
            // mi_windows
            // 
            this.mi_windows.Index = 6;
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
            // 
            // mi_splitHorz
            // 
            this.mi_splitHorz.Index = 1;
            resources.ApplyResources(this.mi_splitHorz, "mi_splitHorz");
            // 
            // mi_splitVert
            // 
            this.mi_splitVert.Index = 2;
            resources.ApplyResources(this.mi_splitVert, "mi_splitVert");
            // 
            // mi_arrangeIcons
            // 
            this.mi_arrangeIcons.Index = 3;
            resources.ApplyResources(this.mi_arrangeIcons, "mi_arrangeIcons");
            // 
            // mi_help
            // 
            this.mi_help.Index = 7;
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
            this.mi_dev.Index = 8;
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
            // dirPanel
            // 
            resources.ApplyResources(this.dirPanel, "dirPanel");
            this.dirPanel.Name = "dirPanel";
            this.dirPanel.Path = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE";
            this.dirPanel.Title = "DirPanel";
            this.dirPanel.OpenFileRequest += new System.EventHandler<UV7_Edit.FileInfoEventArgs>(this.Open);
            this.dirPanel.VisibleChanged += new System.EventHandler(this.dirPanel_VisibleChanged);
            // 
            // Form_main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dirPanel);
            this.Controls.Add(this.panel_toolBar);
            this.Controls.Add(this.statusBar);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu;
            this.Name = "Form_main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosed);
            this.MdiChildActivate += new System.EventHandler(this.Form_main_MdiChildActivate);
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
        private DirPanel dirPanel;
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
        private System.Windows.Forms.MenuItem mi_showEditor;
        private System.Windows.Forms.MenuItem mi_showViewer;
        private System.Windows.Forms.MenuItem mi_lineWrap;
        private System.Windows.Forms.MenuItem mi_font;
        private System.Windows.Forms.MenuItem mi_showBoth;
        private System.Windows.Forms.MenuItem mi_sep4;
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
        private System.Windows.Forms.MenuItem mi_windows;
        private System.Windows.Forms.MenuItem mi_cascade;
        private System.Windows.Forms.MenuItem mi_splitHorz;
        private System.Windows.Forms.MenuItem mi_splitVert;
        private System.Windows.Forms.MenuItem mi_arrangeIcons;
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
    }
}

