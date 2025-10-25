
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
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.mi_sep7 = new System.Windows.Forms.MenuItem();
            this.mi_help = new System.Windows.Forms.MenuItem();
            this.mi_about = new System.Windows.Forms.MenuItem();
            this.mi_dev = new System.Windows.Forms.MenuItem();
            this.mi_cssStyler = new System.Windows.Forms.MenuItem();
            this.mi_sep5 = new System.Windows.Forms.MenuItem();
            this.mi_something = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dirPanel = new UV7_Edit.DirPanel();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 43);
            this.panel3.TabIndex = 2;
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
            this.mi_file.Text = "File";
            // 
            // mi_new
            // 
            this.mi_new.Index = 0;
            this.mi_new.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.mi_new.Text = "New";
            this.mi_new.Click += new System.EventHandler(this.FileNew);
            // 
            // mi_open
            // 
            this.mi_open.Index = 1;
            this.mi_open.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mi_open.Text = "Open...";
            this.mi_open.Click += new System.EventHandler(this.FileOpen);
            // 
            // mi_save
            // 
            this.mi_save.Enabled = false;
            this.mi_save.Index = 2;
            this.mi_save.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mi_save.Text = "Save";
            this.mi_save.Click += new System.EventHandler(this.FileSave);
            // 
            // mi_saveAs
            // 
            this.mi_saveAs.Enabled = false;
            this.mi_saveAs.Index = 3;
            this.mi_saveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.mi_saveAs.Text = "Save as...";
            this.mi_saveAs.Click += new System.EventHandler(this.FileSaveAs);
            // 
            // mi_sep9
            // 
            this.mi_sep9.Index = 4;
            this.mi_sep9.Text = "-";
            // 
            // mi_startScreen
            // 
            this.mi_startScreen.Index = 5;
            this.mi_startScreen.Text = "Start Screen";
            this.mi_startScreen.Click += new System.EventHandler(this.FileStartScreen);
            // 
            // mi_sep1
            // 
            this.mi_sep1.Index = 6;
            this.mi_sep1.Text = "-";
            // 
            // mi_pageSetup
            // 
            this.mi_pageSetup.Enabled = false;
            this.mi_pageSetup.Index = 7;
            this.mi_pageSetup.Text = "Page setup...";
            this.mi_pageSetup.Click += new System.EventHandler(this.FilePageSetup);
            // 
            // mi_print
            // 
            this.mi_print.Enabled = false;
            this.mi_print.Index = 8;
            this.mi_print.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.mi_print.Text = "Print...";
            this.mi_print.Click += new System.EventHandler(this.FilePrint);
            // 
            // mi_sep2
            // 
            this.mi_sep2.Index = 9;
            this.mi_sep2.Text = "-";
            // 
            // mi_close
            // 
            this.mi_close.Enabled = false;
            this.mi_close.Index = 10;
            this.mi_close.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.mi_close.Text = "Close";
            this.mi_close.Click += new System.EventHandler(this.FileClose);
            // 
            // mi_exit
            // 
            this.mi_exit.Index = 11;
            this.mi_exit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mi_exit.Text = "Exit";
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
            this.mi_edit.Text = "Edit";
            // 
            // mi_undo
            // 
            this.mi_undo.Enabled = false;
            this.mi_undo.Index = 0;
            this.mi_undo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.mi_undo.Text = "Undo";
            // 
            // mi_redo
            // 
            this.mi_redo.Enabled = false;
            this.mi_redo.Index = 1;
            this.mi_redo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.mi_redo.Text = "Redo";
            // 
            // mi_sep3
            // 
            this.mi_sep3.Index = 2;
            this.mi_sep3.Text = "-";
            // 
            // mi_cut
            // 
            this.mi_cut.Enabled = false;
            this.mi_cut.Index = 3;
            this.mi_cut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.mi_cut.Text = "Cut";
            // 
            // mi_copy
            // 
            this.mi_copy.Enabled = false;
            this.mi_copy.Index = 4;
            this.mi_copy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.mi_copy.Text = "Copy";
            // 
            // mi_paste
            // 
            this.mi_paste.Enabled = false;
            this.mi_paste.Index = 5;
            this.mi_paste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.mi_paste.Text = "Paste";
            // 
            // mi_sep0
            // 
            this.mi_sep0.Index = 6;
            this.mi_sep0.Text = "-";
            // 
            // mi_find
            // 
            this.mi_find.Enabled = false;
            this.mi_find.Index = 7;
            this.mi_find.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.mi_find.Text = "Find...";
            // 
            // mi_findAgain
            // 
            this.mi_findAgain.Enabled = false;
            this.mi_findAgain.Index = 8;
            this.mi_findAgain.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.mi_findAgain.Text = "Find again";
            // 
            // mi_replace
            // 
            this.mi_replace.Enabled = false;
            this.mi_replace.Index = 9;
            this.mi_replace.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.mi_replace.Text = "Replace...";
            // 
            // mi_sep8
            // 
            this.mi_sep8.Index = 10;
            this.mi_sep8.Text = "-";
            // 
            // mi_prefs
            // 
            this.mi_prefs.Index = 11;
            this.mi_prefs.Text = "Preferences";
            this.mi_prefs.Click += new System.EventHandler(this.EditPrefs);
            // 
            // mi_format
            // 
            this.mi_format.Index = 2;
            this.mi_format.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_lineWrap,
            this.mi_font});
            this.mi_format.Text = "Format";
            // 
            // mi_lineWrap
            // 
            this.mi_lineWrap.Enabled = false;
            this.mi_lineWrap.Index = 0;
            this.mi_lineWrap.Text = "Line Wrap";
            // 
            // mi_font
            // 
            this.mi_font.Enabled = false;
            this.mi_font.Index = 1;
            this.mi_font.Text = "Font...";
            // 
            // mi_editor
            // 
            this.mi_editor.Index = 3;
            this.mi_editor.Text = "Editor";
            this.mi_editor.Visible = false;
            // 
            // mi_viewer
            // 
            this.mi_viewer.Index = 4;
            this.mi_viewer.Text = "Viewer";
            this.mi_viewer.Visible = false;
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
            this.mi_view.Text = "View";
            // 
            // mi_showEditor
            // 
            this.mi_showEditor.Enabled = false;
            this.mi_showEditor.Index = 0;
            this.mi_showEditor.RadioCheck = true;
            this.mi_showEditor.Text = "Show Editor";
            // 
            // mi_showViewer
            // 
            this.mi_showViewer.Enabled = false;
            this.mi_showViewer.Index = 1;
            this.mi_showViewer.RadioCheck = true;
            this.mi_showViewer.Text = "Show Viewer";
            // 
            // mi_showBoth
            // 
            this.mi_showBoth.Checked = true;
            this.mi_showBoth.Enabled = false;
            this.mi_showBoth.Index = 2;
            this.mi_showBoth.RadioCheck = true;
            this.mi_showBoth.Text = "Show Both";
            // 
            // mi_sep4
            // 
            this.mi_sep4.Index = 3;
            this.mi_sep4.Text = "-";
            // 
            // mi_showSidebar
            // 
            this.mi_showSidebar.Checked = true;
            this.mi_showSidebar.Index = 4;
            this.mi_showSidebar.Text = "Show Sidebar";
            this.mi_showSidebar.Click += new System.EventHandler(this.ViewShowSidebar);
            // 
            // mi_showStatusbar
            // 
            this.mi_showStatusbar.Checked = true;
            this.mi_showStatusbar.Index = 5;
            this.mi_showStatusbar.Text = "Show Statusbar";
            this.mi_showStatusbar.Click += new System.EventHandler(this.ViewShowStatusbar);
            // 
            // mi_sep6
            // 
            this.mi_sep6.Index = 6;
            this.mi_sep6.Text = "-";
            // 
            // mi_zoomIn
            // 
            this.mi_zoomIn.Enabled = false;
            this.mi_zoomIn.Index = 7;
            this.mi_zoomIn.Text = "Zoom in";
            // 
            // mi_zoomOut
            // 
            this.mi_zoomOut.Enabled = false;
            this.mi_zoomOut.Index = 8;
            this.mi_zoomOut.Text = "Zoom out";
            // 
            // mi_resetZoom
            // 
            this.mi_resetZoom.Enabled = false;
            this.mi_resetZoom.Index = 9;
            this.mi_resetZoom.Text = "Reset zoom";
            // 
            // mi_windows
            // 
            this.mi_windows.Index = 6;
            this.mi_windows.MdiList = true;
            this.mi_windows.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_cascade,
            this.mi_splitHorz,
            this.mi_splitVert,
            this.mi_arrangeIcons,
            this.mi_sep7});
            this.mi_windows.Text = "Windows";
            // 
            // mi_cascade
            // 
            this.mi_cascade.Index = 0;
            this.mi_cascade.Text = "Cascade";
            // 
            // mi_splitHorz
            // 
            this.mi_splitHorz.Index = 1;
            this.mi_splitHorz.Text = "Split Horizontal";
            // 
            // mi_splitVert
            // 
            this.mi_splitVert.Index = 2;
            this.mi_splitVert.Text = "Split Vertical";
            // 
            // mi_arrangeIcons
            // 
            this.mi_arrangeIcons.Index = 3;
            this.mi_arrangeIcons.Text = "Arrange Icons";
            // 
            // mi_sep7
            // 
            this.mi_sep7.Index = 4;
            this.mi_sep7.MdiList = true;
            this.mi_sep7.Text = "-";
            // 
            // mi_help
            // 
            this.mi_help.Index = 7;
            this.mi_help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_about});
            this.mi_help.Text = "Help";
            // 
            // mi_about
            // 
            this.mi_about.Index = 0;
            this.mi_about.Text = "About";
            this.mi_about.Click += new System.EventHandler(this.HelpAbout);
            // 
            // mi_dev
            // 
            this.mi_dev.Index = 8;
            this.mi_dev.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_cssStyler,
            this.mi_sep5,
            this.mi_something});
            this.mi_dev.Text = "Dev";
            // 
            // mi_cssStyler
            // 
            this.mi_cssStyler.Index = 0;
            this.mi_cssStyler.Text = "CSS Styler";
            this.mi_cssStyler.Click += new System.EventHandler(this.DevCssStyler);
            // 
            // mi_sep5
            // 
            this.mi_sep5.Index = 1;
            this.mi_sep5.Text = "-";
            // 
            // mi_something
            // 
            this.mi_something.Index = 2;
            this.mi_something.Text = "Something";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 351);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(884, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusBar1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Markdown File|*.md|Text File|*.txt|All files|*.*";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Markdown File|*.md|Text File|*.txt|All files|*.*";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileOpen_OK);
            // 
            // dirPanel
            // 
            this.dirPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dirPanel.Location = new System.Drawing.Point(0, 43);
            this.dirPanel.Name = "dirPanel";
            this.dirPanel.Size = new System.Drawing.Size(199, 308);
            this.dirPanel.TabIndex = 0;
            this.dirPanel.Title = "DirPanel";
            this.dirPanel.OpenFileRequest += new System.EventHandler<UV7_Edit.FileInfoEventArgs>(this.Open);
            this.dirPanel.VisibleChanged += new System.EventHandler(this.dirPanel_VisibleChanged);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 373);
            this.Controls.Add(this.dirPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusBar);
            this.IsMdiContainer = true;
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form_main";
            this.Text = "UV7 Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this.Form_main_MdiChildActivate);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.MenuItem mi_sep7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuItem mi_editor;
        private System.Windows.Forms.MenuItem mi_viewer;
        private System.Windows.Forms.MenuItem mi_sep8;
        private System.Windows.Forms.MenuItem mi_prefs;
        private System.Windows.Forms.MenuItem mi_sep9;
        private System.Windows.Forms.MenuItem mi_startScreen;
    }
}

