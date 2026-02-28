using Ionic.Zip;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Shaiya_Data_file_Tool.My;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Shaiya_Data_file_Tool
{
    [DesignerGenerated]
    public class Form1 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("StatusStrip1")]
        private StatusStrip _StatusStrip1;
        [AccessedThroughProperty("TLabel1")]
        private ToolStripStatusLabel _TLabel1;
        [AccessedThroughProperty("OFD")]
        private OpenFileDialog _OFD;
        [AccessedThroughProperty("SaveFileDialog1")]
        private SaveFileDialog _SaveFileDialog1;
        [AccessedThroughProperty("TreeView1")]
        private TreeView _TreeView1;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("FileToolStripMenuItem")]
        private ToolStripMenuItem _FileToolStripMenuItem;
        [AccessedThroughProperty("OpenToolStripMenuItem")]
        private ToolStripMenuItem _OpenToolStripMenuItem;
        [AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator _ToolStripSeparator1;
        [AccessedThroughProperty("ExitToolStripMenuItem")]
        private ToolStripMenuItem _ExitToolStripMenuItem;
        [AccessedThroughProperty("ContextMenuStrip1")]
        private ContextMenuStrip _ContextMenuStrip1;
        [AccessedThroughProperty("ExtractToolStripMenuItem")]
        private ToolStripMenuItem _ExtractToolStripMenuItem;
        [AccessedThroughProperty("ImportToolStripMenuItem")]
        private ToolStripMenuItem _ImportToolStripMenuItem;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("AboutToolStripMenuItem")]
        private ToolStripMenuItem _AboutToolStripMenuItem;
        [AccessedThroughProperty("tsPb")]
        private ToolStripProgressBar _tsPb;
        [AccessedThroughProperty("ExtractAllToolStripMenuItem")]
        private ToolStripMenuItem _ExtractAllToolStripMenuItem;
        [AccessedThroughProperty("ViewFileToolStripMenuItem")]
        private ToolStripMenuItem _ViewFileToolStripMenuItem;
        [AccessedThroughProperty("txtViewer")]
        private TextBox _txtViewer;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;
        [AccessedThroughProperty("BuildDataFileFromFolderToolStripMenuItem")]
        private ToolStripMenuItem _BuildDataFileFromFolderToolStripMenuItem;
        [AccessedThroughProperty("CreatePatchToolStripMenuItem")]
        private ToolStripMenuItem _CreatePatchToolStripMenuItem;
        [AccessedThroughProperty("RebuildDataFileTS")]
        private ToolStripMenuItem _RebuildDataFileTS;
        [AccessedThroughProperty("btnCloseView")]
        private Button _btnCloseView;
        [AccessedThroughProperty("OpenPatchFolderToolStripMenuItem")]
        private ToolStripMenuItem _OpenPatchFolderToolStripMenuItem;
        [AccessedThroughProperty("ToolStripSeparator2")]
        private ToolStripSeparator _ToolStripSeparator2;
        [AccessedThroughProperty("EncryptFileToolStripMenuItem")]
        private ToolStripMenuItem _EncryptFileToolStripMenuItem;
        [AccessedThroughProperty("DecryptFileToolStripMenuItem")]
        private ToolStripMenuItem _DecryptFileToolStripMenuItem;
        [AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator _ToolStripSeparator3;
        [AccessedThroughProperty("FolderBrowserDialog1")]
        private FolderBrowserDialog _FolderBrowserDialog1;
        [AccessedThroughProperty("CheckBox2")]
        private CheckBox _CheckBox2;
        [AccessedThroughProperty("RenameToolStripMenuItem")]
        private ToolStripMenuItem _RenameToolStripMenuItem;
        [AccessedThroughProperty("DeleteToolStripMenuItem")]
        private ToolStripMenuItem _DeleteToolStripMenuItem;
        [AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator _ToolStripSeparator4;
        [AccessedThroughProperty("SettingsToolStripMenuItem")]
        private ToolStripMenuItem _SettingsToolStripMenuItem;
        [AccessedThroughProperty("EditToolStripMenuItem")]
        private ToolStripMenuItem _EditToolStripMenuItem;
        [AccessedThroughProperty("InTextEditorToolStripMenuItem")]
        private ToolStripMenuItem _InTextEditorToolStripMenuItem;
        [AccessedThroughProperty("InHexEditorToolStripMenuItem")]
        private ToolStripMenuItem _InHexEditorToolStripMenuItem;
        [AccessedThroughProperty("EditToolStripMenuItem1")]
        private ToolStripMenuItem _EditToolStripMenuItem1;
        [AccessedThroughProperty("InTextEditorToolStripMenuItem1")]
        private ToolStripMenuItem _InTextEditorToolStripMenuItem1;
        [AccessedThroughProperty("InHexEditorToolStripMenuItem1")]
        private ToolStripMenuItem _InHexEditorToolStripMenuItem1;
        [AccessedThroughProperty("InPhotoEditorToolStripMenuItem")]
        private ToolStripMenuItem _InPhotoEditorToolStripMenuItem;
        [AccessedThroughProperty("ToolStripSeparator5")]
        private ToolStripSeparator _ToolStripSeparator5;
        [AccessedThroughProperty("FromFolderToolStripMenuItem")]
        private ToolStripMenuItem _FromFolderToolStripMenuItem;
        [AccessedThroughProperty("ImportLogToolStripMenuItem")]
        private ToolStripMenuItem _ImportLogToolStripMenuItem;
        [AccessedThroughProperty("CreateFolderToolStripMenuItem")]
        private ToolStripMenuItem _CreateFolderToolStripMenuItem;
        [AccessedThroughProperty("ImageList1")]
        private ImageList _ImageList1;
        [AccessedThroughProperty("DeleteFolderToolStripMenuItem")]
        private ToolStripMenuItem _DeleteFolderToolStripMenuItem;
        [AccessedThroughProperty("OpenFileDialog2")]
        private OpenFileDialog _OpenFileDialog2;
        [AccessedThroughProperty("AddToPatchListToolStripMenuItem")]
        private ToolStripMenuItem _AddToPatchListToolStripMenuItem;
        [AccessedThroughProperty("ToolStripSeparator6")]
        private ToolStripSeparator _ToolStripSeparator6;
        public ArrayList importLog;
        private string selectedNodePath;
        public string extractPath;
        private Module1.SAHfile selNodefile;
        private int totalFiles;
        public bool canButton;
        private FileStream SahFS;
        private FileStream SafFS;

        public Form1()
        {
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new EventHandler(this.Form1_Load);
            this.importLog = new ArrayList();
            this.totalFiles = 0;
            this.canButton = false;
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (!disposing || this.components == null)
                    return;
                this.components.Dispose();
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = (IContainer)new System.ComponentModel.Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            this.StatusStrip1 = new StatusStrip();
            this.tsPb = new ToolStripProgressBar();
            this.TLabel1 = new ToolStripStatusLabel();
            this.OFD = new OpenFileDialog();
            this.SaveFileDialog1 = new SaveFileDialog();
            this.TreeView1 = new TreeView();
            this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
            this.ExtractToolStripMenuItem = new ToolStripMenuItem();
            this.ImportToolStripMenuItem = new ToolStripMenuItem();
            this.CreateFolderToolStripMenuItem = new ToolStripMenuItem();
            this.DeleteFolderToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ViewFileToolStripMenuItem = new ToolStripMenuItem();
            this.EditToolStripMenuItem1 = new ToolStripMenuItem();
            this.InTextEditorToolStripMenuItem1 = new ToolStripMenuItem();
            this.InHexEditorToolStripMenuItem1 = new ToolStripMenuItem();
            this.InPhotoEditorToolStripMenuItem = new ToolStripMenuItem();
            this.RenameToolStripMenuItem = new ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.RebuildDataFileTS = new ToolStripMenuItem();
            this.ImageList1 = new ImageList(this.components);
            this.MenuStrip1 = new MenuStrip();
            this.FileToolStripMenuItem = new ToolStripMenuItem();
            this.OpenToolStripMenuItem = new ToolStripMenuItem();
            this.ExtractAllToolStripMenuItem = new ToolStripMenuItem();
            this.BuildDataFileFromFolderToolStripMenuItem = new ToolStripMenuItem();
            this.CreatePatchToolStripMenuItem = new ToolStripMenuItem();
            this.FromFolderToolStripMenuItem = new ToolStripMenuItem();
            this.ImportLogToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.EncryptFileToolStripMenuItem = new ToolStripMenuItem();
            this.DecryptFileToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.OpenPatchFolderToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ExitToolStripMenuItem = new ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new ToolStripMenuItem();
            this.AboutToolStripMenuItem = new ToolStripMenuItem();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.txtViewer = new TextBox();
            this.Label3 = new Label();
            this.CheckBox1 = new CheckBox();
            this.btnCloseView = new Button();
            this.FolderBrowserDialog1 = new FolderBrowserDialog();
            this.CheckBox2 = new CheckBox();
            this.EditToolStripMenuItem = new ToolStripMenuItem();
            this.InTextEditorToolStripMenuItem = new ToolStripMenuItem();
            this.InHexEditorToolStripMenuItem = new ToolStripMenuItem();
            this.OpenFileDialog2 = new OpenFileDialog();
            this.AddToPatchListToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.StatusStrip1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.StatusStrip1.Items.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.tsPb,
        (ToolStripItem) this.TLabel1
            });
            StatusStrip statusStrip1_1 = this.StatusStrip1;
            Point point1 = new Point(0, 451);
            Point point2 = point1;
            statusStrip1_1.Location = point2;
            this.StatusStrip1.Name = "StatusStrip1";
            StatusStrip statusStrip1_2 = this.StatusStrip1;
            Size size1 = new Size(359, 22);
            Size size2 = size1;
            statusStrip1_2.Size = size2;
            this.StatusStrip1.SizingGrip = false;
            this.StatusStrip1.TabIndex = 8;
            this.StatusStrip1.Text = "StatusStrip1";
            this.tsPb.Name = "tsPb";
            ToolStripProgressBar tsPb = this.tsPb;
            size1 = new Size(100, 16);
            Size size3 = size1;
            tsPb.Size = size3;
            this.tsPb.Step = 1;
            this.tsPb.Style = ProgressBarStyle.Continuous;
            this.tsPb.Visible = false;
            this.TLabel1.Name = "TLabel1";
            ToolStripStatusLabel tlabel1 = this.TLabel1;
            size1 = new Size(39, 17);
            Size size4 = size1;
            tlabel1.Size = size4;
            this.TLabel1.Text = "Ready";
            this.OFD.FileName = "Data.sah";
            this.OFD.Filter = "Data.sah file|*.sah";
            this.OFD.RestoreDirectory = true;
            this.OFD.Title = "Open";
            this.SaveFileDialog1.Title = "Save";
            this.TreeView1.AllowDrop = true;
            this.TreeView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.TreeView1.ImageIndex = 1;
            this.TreeView1.ImageList = this.ImageList1;
            TreeView treeView1_1 = this.TreeView1;
            point1 = new Point(4, 31);
            Point point3 = point1;
            treeView1_1.Location = point3;
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.SelectedImageIndex = 0;
            TreeView treeView1_2 = this.TreeView1;
            size1 = new Size(349, 399);
            Size size5 = size1;
            treeView1_2.Size = size5;
            this.TreeView1.TabIndex = 9;
            this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[13]
            {
        (ToolStripItem) this.ExtractToolStripMenuItem,
        (ToolStripItem) this.ImportToolStripMenuItem,
        (ToolStripItem) this.CreateFolderToolStripMenuItem,
        (ToolStripItem) this.DeleteFolderToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator5,
        (ToolStripItem) this.ViewFileToolStripMenuItem,
        (ToolStripItem) this.EditToolStripMenuItem1,
        (ToolStripItem) this.RenameToolStripMenuItem,
        (ToolStripItem) this.DeleteToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator4,
        (ToolStripItem) this.AddToPatchListToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator6,
        (ToolStripItem) this.RebuildDataFileTS
            });
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip contextMenuStrip1 = this.ContextMenuStrip1;
            size1 = new Size(165, 242);
            Size size6 = size1;
            contextMenuStrip1.Size = size6;
            this.ExtractToolStripMenuItem.Name = "ExtractToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.ExtractToolStripMenuItem;
            size1 = new Size(160, 22);
            Size size7 = size1;
            toolStripMenuItem1.Size = size7;
            this.ExtractToolStripMenuItem.Text = "Extract";
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.ImportToolStripMenuItem;
            size1 = new Size(160, 22);
            Size size8 = size1;
            toolStripMenuItem2.Size = size8;
            this.ImportToolStripMenuItem.Text = "Import";
            this.CreateFolderToolStripMenuItem.Name = "CreateFolderToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.CreateFolderToolStripMenuItem;
            size1 = new Size(160, 22);
            Size size9 = size1;
            toolStripMenuItem3.Size = size9;
            this.CreateFolderToolStripMenuItem.Text = "Create Folder";
            this.DeleteFolderToolStripMenuItem.Name = "DeleteFolderToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem4 = this.DeleteFolderToolStripMenuItem;
            size1 = new Size(160, 22);
            Size size10 = size1;
            toolStripMenuItem4.Size = size10;
            this.DeleteFolderToolStripMenuItem.Text = "Delete Folder";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            ToolStripSeparator toolStripSeparator5 = this.ToolStripSeparator5;
            size1 = new Size(157, 6);
            Size size11 = size1;
            toolStripSeparator5.Size = size11;
            this.ViewFileToolStripMenuItem.Enabled = false;
            this.ViewFileToolStripMenuItem.Name = "ViewFileToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem5 = this.ViewFileToolStripMenuItem;
            size1 = new Size(160, 22);
            Size size12 = size1;
            toolStripMenuItem5.Size = size12;
            this.ViewFileToolStripMenuItem.Text = "View File";
            this.EditToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.InTextEditorToolStripMenuItem1,
        (ToolStripItem) this.InHexEditorToolStripMenuItem1,
        (ToolStripItem) this.InPhotoEditorToolStripMenuItem
            });
            this.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_1 = this.EditToolStripMenuItem1;
            size1 = new Size(160, 22);
            Size size13 = size1;
            toolStripMenuItem1_1.Size = size13;
            this.EditToolStripMenuItem1.Text = "Edit";
            this.InTextEditorToolStripMenuItem1.Name = "InTextEditorToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_2 = this.InTextEditorToolStripMenuItem1;
            size1 = new Size(153, 22);
            Size size14 = size1;
            toolStripMenuItem1_2.Size = size14;
            this.InTextEditorToolStripMenuItem1.Text = "In Text Editor";
            this.InHexEditorToolStripMenuItem1.Name = "InHexEditorToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_3 = this.InHexEditorToolStripMenuItem1;
            size1 = new Size(153, 22);
            Size size15 = size1;
            toolStripMenuItem1_3.Size = size15;
            this.InHexEditorToolStripMenuItem1.Text = "In Hex Editor";
            this.InPhotoEditorToolStripMenuItem.Name = "InPhotoEditorToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem6 = this.InPhotoEditorToolStripMenuItem;
            size1 = new Size(153, 22);
            Size size16 = size1;
            toolStripMenuItem6.Size = size16;
            this.InPhotoEditorToolStripMenuItem.Text = "In Photo Editor";
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem7 = this.RenameToolStripMenuItem;
            size1 = new Size(160, 22);
            Size size17 = size1;
            toolStripMenuItem7.Size = size17;
            this.RenameToolStripMenuItem.Text = "Rename";
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem8 = this.DeleteToolStripMenuItem;
            size1 = new Size(160, 22);
            Size size18 = size1;
            toolStripMenuItem8.Size = size18;
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            ToolStripSeparator toolStripSeparator4 = this.ToolStripSeparator4;
            size1 = new Size(157, 6);
            Size size19 = size1;
            toolStripSeparator4.Size = size19;
            this.RebuildDataFileTS.Name = "RebuildDataFileTS";
            ToolStripMenuItem rebuildDataFileTs = this.RebuildDataFileTS;
            size1 = new Size(160, 22);
            Size size20 = size1;
            rebuildDataFileTs.Size = size20;
            this.RebuildDataFileTS.Text = "Rebuild Data file";
            this.RebuildDataFileTS.Visible = false;
            this.ImageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
            this.ImageList1.TransparentColor = Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Folder.ico");
            this.ImageList1.Images.SetKeyName(1, "document-icon.png");
            this.ImageList1.Images.SetKeyName(2, "image-vertical-icon.png");
            this.MenuStrip1.Items.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.FileToolStripMenuItem,
        (ToolStripItem) this.SettingsToolStripMenuItem,
        (ToolStripItem) this.AboutToolStripMenuItem
            });
            MenuStrip menuStrip1_1 = this.MenuStrip1;
            point1 = new Point(0, 0);
            Point point4 = point1;
            menuStrip1_1.Location = point4;
            this.MenuStrip1.Name = "MenuStrip1";
            MenuStrip menuStrip1_2 = this.MenuStrip1;
            size1 = new Size(359, 24);
            Size size21 = size1;
            menuStrip1_2.Size = size21;
            this.MenuStrip1.TabIndex = 11;
            this.MenuStrip1.Text = "MenuStrip1";
            this.FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[11]
            {
        (ToolStripItem) this.OpenToolStripMenuItem,
        (ToolStripItem) this.ExtractAllToolStripMenuItem,
        (ToolStripItem) this.BuildDataFileFromFolderToolStripMenuItem,
        (ToolStripItem) this.CreatePatchToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator3,
        (ToolStripItem) this.EncryptFileToolStripMenuItem,
        (ToolStripItem) this.DecryptFileToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator1,
        (ToolStripItem) this.OpenPatchFolderToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator2,
        (ToolStripItem) this.ExitToolStripMenuItem
            });
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem9 = this.FileToolStripMenuItem;
            size1 = new Size(37, 20);
            Size size22 = size1;
            toolStripMenuItem9.Size = size22;
            this.FileToolStripMenuItem.Text = "File";
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem10 = this.OpenToolStripMenuItem;
            size1 = new Size(212, 22);
            Size size23 = size1;
            toolStripMenuItem10.Size = size23;
            this.OpenToolStripMenuItem.Text = "Open";
            this.ExtractAllToolStripMenuItem.Enabled = false;
            this.ExtractAllToolStripMenuItem.Name = "ExtractAllToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem11 = this.ExtractAllToolStripMenuItem;
            size1 = new Size(212, 22);
            Size size24 = size1;
            toolStripMenuItem11.Size = size24;
            this.ExtractAllToolStripMenuItem.Text = "Extract All";
            this.BuildDataFileFromFolderToolStripMenuItem.Name = "BuildDataFileFromFolderToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem12 = this.BuildDataFileFromFolderToolStripMenuItem;
            size1 = new Size(212, 22);
            Size size25 = size1;
            toolStripMenuItem12.Size = size25;
            this.BuildDataFileFromFolderToolStripMenuItem.Text = "Build Data file from Folder";
            this.CreatePatchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.FromFolderToolStripMenuItem,
        (ToolStripItem) this.ImportLogToolStripMenuItem
            });
            this.CreatePatchToolStripMenuItem.Name = "CreatePatchToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem13 = this.CreatePatchToolStripMenuItem;
            size1 = new Size(212, 22);
            Size size26 = size1;
            toolStripMenuItem13.Size = size26;
            this.CreatePatchToolStripMenuItem.Text = "Create Patch";
            this.FromFolderToolStripMenuItem.Name = "FromFolderToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem14 = this.FromFolderToolStripMenuItem;
            size1 = new Size(152, 22);
            Size size27 = size1;
            toolStripMenuItem14.Size = size27;
            this.FromFolderToolStripMenuItem.Text = "From Folder";
            this.ImportLogToolStripMenuItem.Name = "ImportLogToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem15 = this.ImportLogToolStripMenuItem;
            size1 = new Size(195, 22);
            Size size28 = size1;
            toolStripMenuItem15.Size = size28;
            this.ImportLogToolStripMenuItem.Text = "Import Log / Patch List";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator3;
            size1 = new Size(209, 6);
            Size size29 = size1;
            toolStripSeparator3.Size = size29;
            this.EncryptFileToolStripMenuItem.Name = "EncryptFileToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem16 = this.EncryptFileToolStripMenuItem;
            size1 = new Size(212, 22);
            Size size30 = size1;
            toolStripMenuItem16.Size = size30;
            this.EncryptFileToolStripMenuItem.Text = "Encrypt File";
            this.DecryptFileToolStripMenuItem.Name = "DecryptFileToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem17 = this.DecryptFileToolStripMenuItem;
            size1 = new Size(212, 22);
            Size size31 = size1;
            toolStripMenuItem17.Size = size31;
            this.DecryptFileToolStripMenuItem.Text = "Decrypt File";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator toolStripSeparator1 = this.ToolStripSeparator1;
            size1 = new Size(209, 6);
            Size size32 = size1;
            toolStripSeparator1.Size = size32;
            this.OpenPatchFolderToolStripMenuItem.Name = "OpenPatchFolderToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem18 = this.OpenPatchFolderToolStripMenuItem;
            size1 = new Size(212, 22);
            Size size33 = size1;
            toolStripMenuItem18.Size = size33;
            this.OpenPatchFolderToolStripMenuItem.Text = "Open Patch Folder";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator toolStripSeparator2 = this.ToolStripSeparator2;
            size1 = new Size(209, 6);
            Size size34 = size1;
            toolStripSeparator2.Size = size34;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem19 = this.ExitToolStripMenuItem;
            size1 = new Size(212, 22);
            Size size35 = size1;
            toolStripMenuItem19.Size = size35;
            this.ExitToolStripMenuItem.Text = "Exit";
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem20 = this.SettingsToolStripMenuItem;
            size1 = new Size(61, 20);
            Size size36 = size1;
            toolStripMenuItem20.Size = size36;
            this.SettingsToolStripMenuItem.Text = "Settings";
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem21 = this.AboutToolStripMenuItem;
            size1 = new Size(52, 20);
            Size size37 = size1;
            toolStripMenuItem21.Size = size37;
            this.AboutToolStripMenuItem.Text = "About";
            this.Label1.AutoSize = true;
            Label label1_1 = this.Label1;
            point1 = new Point(1, 433);
            Point point5 = point1;
            label1_1.Location = point5;
            this.Label1.Name = "Label1";
            Label label1_2 = this.Label1;
            size1 = new Size(58, 13);
            Size size38 = size1;
            label1_2.Size = size38;
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Offset: 0x0";
            this.Label2.AutoSize = true;
            Label label2_1 = this.Label2;
            point1 = new Point(182, 433);
            Point point6 = point1;
            label2_1.Location = point6;
            this.Label2.Name = "Label2";
            Label label2_2 = this.Label2;
            size1 = new Size(63, 13);
            Size size39 = size1;
            label2_2.Size = size39;
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Length: 0x0";
            this.txtViewer.Font = new Font("Courier New", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            TextBox txtViewer1 = this.txtViewer;
            point1 = new Point(359, 52);
            Point point7 = point1;
            txtViewer1.Location = point7;
            this.txtViewer.Multiline = true;
            this.txtViewer.Name = "txtViewer";
            this.txtViewer.ScrollBars = ScrollBars.Both;
            TextBox txtViewer2 = this.txtViewer;
            size1 = new Size(593, 378);
            Size size40 = size1;
            txtViewer2.Size = size40;
            this.txtViewer.TabIndex = 14;
            this.txtViewer.WordWrap = false;
            this.Label3.AutoSize = true;
            Label label3_1 = this.Label3;
            point1 = new Point(359, 33);
            Point point8 = point1;
            label3_1.Location = point8;
            this.Label3.Name = "Label3";
            Label label3_2 = this.Label3;
            size1 = new Size(47, 13);
            Size size41 = size1;
            label3_2.Size = size41;
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Viewing:";
            this.CheckBox1.AutoSize = true;
            CheckBox checkBox1_1 = this.CheckBox1;
            point1 = new Point(874, 433);
            Point point9 = point1;
            checkBox1_1.Location = point9;
            this.CheckBox1.Name = "CheckBox1";
            CheckBox checkBox1_2 = this.CheckBox1;
            size1 = new Size(78, 17);
            Size size42 = size1;
            checkBox1_2.Size = size42;
            this.CheckBox1.TabIndex = 16;
            this.CheckBox1.Text = "WordWrap";
            this.CheckBox1.UseVisualStyleBackColor = true;
            Button btnCloseView1 = this.btnCloseView;
            point1 = new Point(932, 27);
            Point point10 = point1;
            btnCloseView1.Location = point10;
            this.btnCloseView.Name = "btnCloseView";
            Button btnCloseView2 = this.btnCloseView;
            size1 = new Size(20, 19);
            Size size43 = size1;
            btnCloseView2.Size = size43;
            this.btnCloseView.TabIndex = 17;
            this.btnCloseView.Text = "X";
            this.btnCloseView.UseVisualStyleBackColor = true;
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Checked = true;
            this.CheckBox2.CheckState = CheckState.Checked;
            CheckBox checkBox2_1 = this.CheckBox2;
            point1 = new Point(362, 433);
            Point point11 = point1;
            checkBox2_1.Location = point11;
            this.CheckBox2.Name = "CheckBox2";
            CheckBox checkBox2_2 = this.CheckBox2;
            size1 = new Size(82, 17);
            Size size44 = size1;
            checkBox2_2.Size = size44;
            this.CheckBox2.TabIndex = 18;
            this.CheckBox2.Text = "View in Hex";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem22 = this.EditToolStripMenuItem;
            size1 = new Size(32, 19);
            Size size45 = size1;
            toolStripMenuItem22.Size = size45;
            this.InTextEditorToolStripMenuItem.Name = "InTextEditorToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem23 = this.InTextEditorToolStripMenuItem;
            size1 = new Size(32, 19);
            Size size46 = size1;
            toolStripMenuItem23.Size = size46;
            this.InHexEditorToolStripMenuItem.Name = "InHexEditorToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem24 = this.InHexEditorToolStripMenuItem;
            size1 = new Size(32, 19);
            Size size47 = size1;
            toolStripMenuItem24.Size = size47;
            this.OpenFileDialog2.FileName = "Data.sah";
            this.OpenFileDialog2.Filter = "Data.sah file|*.sah";
            this.OpenFileDialog2.RestoreDirectory = true;
            this.OpenFileDialog2.Title = "Open";
            this.AddToPatchListToolStripMenuItem.Name = "AddToPatchListToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem25 = this.AddToPatchListToolStripMenuItem;
            size1 = new Size(164, 22);
            Size size48 = size1;
            toolStripMenuItem25.Size = size48;
            this.AddToPatchListToolStripMenuItem.Text = "Add to Patch List";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            ToolStripSeparator toolStripSeparator6 = this.ToolStripSeparator6;
            size1 = new Size(161, 6);
            Size size49 = size1;
            toolStripSeparator6.Size = size49;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(359, 473);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.CheckBox2);
            this.Controls.Add((Control)this.txtViewer);
            this.Controls.Add((Control)this.btnCloseView);
            this.Controls.Add((Control)this.CheckBox1);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.TreeView1);
            this.Controls.Add((Control)this.StatusStrip1);
            this.Controls.Add((Control)this.MenuStrip1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = nameof(Form1);
            this.Text = "Shaiya Data File Tool By Totoshka";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual StatusStrip StatusStrip1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._StatusStrip1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._StatusStrip1 = value;
            }
        }

        internal virtual ToolStripStatusLabel TLabel1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TLabel1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TLabel1 = value;
            }
        }

        internal virtual OpenFileDialog OFD
        {
            [DebuggerNonUserCode]
            get
            {
                return this._OFD;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._OFD = value;
            }
        }

        internal virtual SaveFileDialog SaveFileDialog1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._SaveFileDialog1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._SaveFileDialog1 = value;
            }
        }

        internal virtual TreeView TreeView1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._TreeView1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                TreeViewEventHandler viewEventHandler = new TreeViewEventHandler(this.TreeView1_AfterSelect);
                MouseEventHandler mouseEventHandler = new MouseEventHandler(this.TreeView1_MouseDown);
                DragEventHandler dragEventHandler1 = new DragEventHandler(this.TreeView1_DragEnter);
                DragEventHandler dragEventHandler2 = new DragEventHandler(this.TreeView1_DragDrop);
                if (this._TreeView1 != null)
                {
                    this._TreeView1.AfterSelect -= viewEventHandler;
                    this._TreeView1.MouseDown -= mouseEventHandler;
                    this._TreeView1.DragEnter -= dragEventHandler1;
                    this._TreeView1.DragDrop -= dragEventHandler2;
                }
                this._TreeView1 = value;
                if (this._TreeView1 == null)
                    return;
                this._TreeView1.AfterSelect += viewEventHandler;
                this._TreeView1.MouseDown += mouseEventHandler;
                this._TreeView1.DragEnter += dragEventHandler1;
                this._TreeView1.DragDrop += dragEventHandler2;
            }
        }

        internal virtual MenuStrip MenuStrip1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._MenuStrip1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._MenuStrip1 = value;
            }
        }

        internal virtual ToolStripMenuItem FileToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._FileToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._FileToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem OpenToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._OpenToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpenToolStripMenuItem_Click);
                if (this._OpenToolStripMenuItem != null)
                    this._OpenToolStripMenuItem.Click -= eventHandler;
                this._OpenToolStripMenuItem = value;
                if (this._OpenToolStripMenuItem == null)
                    return;
                this._OpenToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolStripSeparator1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator1 = value;
            }
        }

        internal virtual ToolStripMenuItem ExitToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ExitToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ExitToolStripMenuItem_Click);
                if (this._ExitToolStripMenuItem != null)
                    this._ExitToolStripMenuItem.Click -= eventHandler;
                this._ExitToolStripMenuItem = value;
                if (this._ExitToolStripMenuItem == null)
                    return;
                this._ExitToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ContextMenuStrip ContextMenuStrip1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ContextMenuStrip1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ContextMenuStrip1 = value;
            }
        }

        internal virtual ToolStripMenuItem ExtractToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ExtractToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ExtractToolStripMenuItem_Click);
                if (this._ExtractToolStripMenuItem != null)
                    this._ExtractToolStripMenuItem.Click -= eventHandler;
                this._ExtractToolStripMenuItem = value;
                if (this._ExtractToolStripMenuItem == null)
                    return;
                this._ExtractToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem ImportToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ImportToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ImportToolStripMenuItem_Click);
                if (this._ImportToolStripMenuItem != null)
                    this._ImportToolStripMenuItem.Click -= eventHandler;
                this._ImportToolStripMenuItem = value;
                if (this._ImportToolStripMenuItem == null)
                    return;
                this._ImportToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label1 = value;
            }
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label2 = value;
            }
        }

        internal virtual ToolStripMenuItem AboutToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._AboutToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.AboutToolStripMenuItem_Click);
                if (this._AboutToolStripMenuItem != null)
                    this._AboutToolStripMenuItem.Click -= eventHandler;
                this._AboutToolStripMenuItem = value;
                if (this._AboutToolStripMenuItem == null)
                    return;
                this._AboutToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripProgressBar tsPb
        {
            [DebuggerNonUserCode]
            get
            {
                return this._tsPb;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tsPb = value;
            }
        }

        internal virtual ToolStripMenuItem ExtractAllToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ExtractAllToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ExtractAllToolStripMenuItem_Click);
                if (this._ExtractAllToolStripMenuItem != null)
                    this._ExtractAllToolStripMenuItem.Click -= eventHandler;
                this._ExtractAllToolStripMenuItem = value;
                if (this._ExtractAllToolStripMenuItem == null)
                    return;
                this._ExtractAllToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem ViewFileToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ViewFileToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ViewFileToolStripMenuItem_Click);
                if (this._ViewFileToolStripMenuItem != null)
                    this._ViewFileToolStripMenuItem.Click -= eventHandler;
                this._ViewFileToolStripMenuItem = value;
                if (this._ViewFileToolStripMenuItem == null)
                    return;
                this._ViewFileToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual TextBox txtViewer
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtViewer;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtViewer = value;
            }
        }

        internal virtual Label Label3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label3 = value;
            }
        }

        internal virtual CheckBox CheckBox1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
                if (this._CheckBox1 != null)
                    this._CheckBox1.CheckedChanged -= eventHandler;
                this._CheckBox1 = value;
                if (this._CheckBox1 == null)
                    return;
                this._CheckBox1.CheckedChanged += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem BuildDataFileFromFolderToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._BuildDataFileFromFolderToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.BuildDataFileFromFolderToolStripMenuItem_Click);
                if (this._BuildDataFileFromFolderToolStripMenuItem != null)
                    this._BuildDataFileFromFolderToolStripMenuItem.Click -= eventHandler;
                this._BuildDataFileFromFolderToolStripMenuItem = value;
                if (this._BuildDataFileFromFolderToolStripMenuItem == null)
                    return;
                this._BuildDataFileFromFolderToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem CreatePatchToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CreatePatchToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CreatePatchToolStripMenuItem_Click);
                if (this._CreatePatchToolStripMenuItem != null)
                    this._CreatePatchToolStripMenuItem.Click -= eventHandler;
                this._CreatePatchToolStripMenuItem = value;
                if (this._CreatePatchToolStripMenuItem == null)
                    return;
                this._CreatePatchToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem RebuildDataFileTS
        {
            [DebuggerNonUserCode]
            get
            {
                return this._RebuildDataFileTS;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.RebuildDataFileTS_Click);
                if (this._RebuildDataFileTS != null)
                    this._RebuildDataFileTS.Click -= eventHandler;
                this._RebuildDataFileTS = value;
                if (this._RebuildDataFileTS == null)
                    return;
                this._RebuildDataFileTS.Click += eventHandler;
            }
        }

        internal virtual Button btnCloseView
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnCloseView;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = (EventHandler)((a0, a1) => this.btnCloseView_Click());
                if (this._btnCloseView != null)
                    this._btnCloseView.Click -= eventHandler;
                this._btnCloseView = value;
                if (this._btnCloseView == null)
                    return;
                this._btnCloseView.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem OpenPatchFolderToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._OpenPatchFolderToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpenPatchFolderToolStripMenuItem_Click);
                if (this._OpenPatchFolderToolStripMenuItem != null)
                    this._OpenPatchFolderToolStripMenuItem.Click -= eventHandler;
                this._OpenPatchFolderToolStripMenuItem = value;
                if (this._OpenPatchFolderToolStripMenuItem == null)
                    return;
                this._OpenPatchFolderToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolStripSeparator2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator2 = value;
            }
        }

        internal virtual ToolStripMenuItem EncryptFileToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._EncryptFileToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.EncryptFileToolStripMenuItem_Click);
                if (this._EncryptFileToolStripMenuItem != null)
                    this._EncryptFileToolStripMenuItem.Click -= eventHandler;
                this._EncryptFileToolStripMenuItem = value;
                if (this._EncryptFileToolStripMenuItem == null)
                    return;
                this._EncryptFileToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem DecryptFileToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DecryptFileToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DecryptFileToolStripMenuItem_Click);
                if (this._DecryptFileToolStripMenuItem != null)
                    this._DecryptFileToolStripMenuItem.Click -= eventHandler;
                this._DecryptFileToolStripMenuItem = value;
                if (this._DecryptFileToolStripMenuItem == null)
                    return;
                this._DecryptFileToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolStripSeparator3;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator3 = value;
            }
        }

        internal virtual FolderBrowserDialog FolderBrowserDialog1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._FolderBrowserDialog1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._FolderBrowserDialog1 = value;
            }
        }

        internal virtual CheckBox CheckBox2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CheckBox2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CheckBox2_CheckedChanged);
                if (this._CheckBox2 != null)
                    this._CheckBox2.CheckedChanged -= eventHandler;
                this._CheckBox2 = value;
                if (this._CheckBox2 == null)
                    return;
                this._CheckBox2.CheckedChanged += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem RenameToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._RenameToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.RenameToolStripMenuItem_Click);
                if (this._RenameToolStripMenuItem != null)
                    this._RenameToolStripMenuItem.Click -= eventHandler;
                this._RenameToolStripMenuItem = value;
                if (this._RenameToolStripMenuItem == null)
                    return;
                this._RenameToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem DeleteToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DeleteToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem_Click);
                if (this._DeleteToolStripMenuItem != null)
                    this._DeleteToolStripMenuItem.Click -= eventHandler;
                this._DeleteToolStripMenuItem = value;
                if (this._DeleteToolStripMenuItem == null)
                    return;
                this._DeleteToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolStripSeparator4;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator4 = value;
            }
        }

        internal virtual ToolStripMenuItem SettingsToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._SettingsToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SettingsToolStripMenuItem_Click);
                if (this._SettingsToolStripMenuItem != null)
                    this._SettingsToolStripMenuItem.Click -= eventHandler;
                this._SettingsToolStripMenuItem = value;
                if (this._SettingsToolStripMenuItem == null)
                    return;
                this._SettingsToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem EditToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._EditToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._EditToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem InTextEditorToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._InTextEditorToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._InTextEditorToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem InHexEditorToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._InHexEditorToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._InHexEditorToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem EditToolStripMenuItem1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._EditToolStripMenuItem1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._EditToolStripMenuItem1 = value;
            }
        }

        internal virtual ToolStripMenuItem InTextEditorToolStripMenuItem1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._InTextEditorToolStripMenuItem1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.InTextEditorToolStripMenuItem1_Click);
                if (this._InTextEditorToolStripMenuItem1 != null)
                    this._InTextEditorToolStripMenuItem1.Click -= eventHandler;
                this._InTextEditorToolStripMenuItem1 = value;
                if (this._InTextEditorToolStripMenuItem1 == null)
                    return;
                this._InTextEditorToolStripMenuItem1.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem InHexEditorToolStripMenuItem1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._InHexEditorToolStripMenuItem1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.InHexEditorToolStripMenuItem1_Click);
                if (this._InHexEditorToolStripMenuItem1 != null)
                    this._InHexEditorToolStripMenuItem1.Click -= eventHandler;
                this._InHexEditorToolStripMenuItem1 = value;
                if (this._InHexEditorToolStripMenuItem1 == null)
                    return;
                this._InHexEditorToolStripMenuItem1.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem InPhotoEditorToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._InPhotoEditorToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.InPhotoEditorToolStripMenuItem_Click);
                if (this._InPhotoEditorToolStripMenuItem != null)
                    this._InPhotoEditorToolStripMenuItem.Click -= eventHandler;
                this._InPhotoEditorToolStripMenuItem = value;
                if (this._InPhotoEditorToolStripMenuItem == null)
                    return;
                this._InPhotoEditorToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolStripSeparator5;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator5 = value;
            }
        }

        internal virtual ToolStripMenuItem FromFolderToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._FromFolderToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.FromFolderToolStripMenuItem_Click);
                if (this._FromFolderToolStripMenuItem != null)
                    this._FromFolderToolStripMenuItem.Click -= eventHandler;
                this._FromFolderToolStripMenuItem = value;
                if (this._FromFolderToolStripMenuItem == null)
                    return;
                this._FromFolderToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem ImportLogToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ImportLogToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ImportLogToolStripMenuItem_Click);
                if (this._ImportLogToolStripMenuItem != null)
                    this._ImportLogToolStripMenuItem.Click -= eventHandler;
                this._ImportLogToolStripMenuItem = value;
                if (this._ImportLogToolStripMenuItem == null)
                    return;
                this._ImportLogToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem CreateFolderToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._CreateFolderToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CreateFolderToolStripMenuItem_Click);
                if (this._CreateFolderToolStripMenuItem != null)
                    this._CreateFolderToolStripMenuItem.Click -= eventHandler;
                this._CreateFolderToolStripMenuItem = value;
                if (this._CreateFolderToolStripMenuItem == null)
                    return;
                this._CreateFolderToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ImageList ImageList1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ImageList1;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ImageList1 = value;
            }
        }

        internal virtual ToolStripMenuItem DeleteFolderToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._DeleteFolderToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DeleteFolderToolStripMenuItem_Click);
                if (this._DeleteFolderToolStripMenuItem != null)
                    this._DeleteFolderToolStripMenuItem.Click -= eventHandler;
                this._DeleteFolderToolStripMenuItem = value;
                if (this._DeleteFolderToolStripMenuItem == null)
                    return;
                this._DeleteFolderToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual OpenFileDialog OpenFileDialog2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._OpenFileDialog2;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._OpenFileDialog2 = value;
            }
        }

        internal virtual ToolStripMenuItem AddToPatchListToolStripMenuItem
        {
            [DebuggerNonUserCode]
            get
            {
                return this._AddToPatchListToolStripMenuItem;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.AddToPatchListToolStripMenuItem_Click);
                if (this._AddToPatchListToolStripMenuItem != null)
                    this._AddToPatchListToolStripMenuItem.Click -= eventHandler;
                this._AddToPatchListToolStripMenuItem = value;
                if (this._AddToPatchListToolStripMenuItem == null)
                    return;
                this._AddToPatchListToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._ToolStripSeparator6;
            }
            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ToolStripSeparator6 = value;
            }
        }

        private string savefile(ref byte[] byteA, string filename, bool auto = false, string fPath = "")
        {
            string path;
            if (!auto)
            {
                this.SaveFileDialog1.Filter = "all files|*.*";
                this.SaveFileDialog1.FileName = filename;
                if (this.SaveFileDialog1.ShowDialog() != DialogResult.OK)
                    return "";
                path = this.SaveFileDialog1.FileName;
            }
            else
            {
                if (Operators.CompareString(this.extractPath, "", false) == 0)
                    this.extractPath = Application.StartupPath;
                path = this.extractPath + "\\" + filename;
            }
            if (Operators.CompareString(fPath, "", false) != 0)
                path = fPath;
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryWriter binaryWriter = new BinaryWriter((Stream)fileStream);
            int num1 = 0;
            int num2 = checked(byteA.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                binaryWriter.Write(byteA[index]);
                checked { ++index; }
            }
            fileStream.Close();
            binaryWriter.Close();
            this.TLabel1.Text = "Extracted and Saved file: " + filename;
            return path;
        }

        private string prsFilename(string filename)
        {
            string str;
            try
            {
                return filename.Remove(0, checked(filename.LastIndexOf("\\") + 1));
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                str = "";
                ProjectData.ClearProjectError();
            }
            return str;
        }

        private ulong writeFile(ref byte[] aByte, ulong address, long length)
        {
            string path = Module1.sahPath.Replace("sah", "saf");
            FileStream fileStream = default(FileStream);
            ulong num1;
            try
            {
                fileStream = new FileStream(path, FileMode.Open);
                if (Decimal.Compare(new Decimal(address), Decimal.Zero) == 0)
                    address = checked((ulong)fileStream.Length);
                fileStream.Seek(checked((long)address), SeekOrigin.Begin);
                fileStream.Write(aByte, 0, checked((int)length));
                fileStream.Close();
                num1 = address;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num2 = (int)Interaction.MsgBox((object)("Error writing to Data.Saf, Please make sure it is not already open.\r\n" + ex.Message), MsgBoxStyle.Exclamation, (object)"Error 2");
                num1 = 0UL;
                ProjectData.ClearProjectError();
            }
            finally
            {
                fileStream.Close();
            }
            return num1;
        }

        private void write(ref byte[] varToWriteTo, int StartAddress, string dataToWrite)
        {
            byte[] bytes = this.getBytes(dataToWrite);
            int num1 = 0;
            int num2 = checked(bytes.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                if ((int)bytes[index] != 0)
                    varToWriteTo[checked(StartAddress + index)] = bytes[index];
                checked { ++index; }
            }
        }

        private long findstring(ref byte[] a, byte[] sigBytes, int start = 0)
        {
            int num1 = start;
            int num2 = checked(a.Length - 1);
            int index1 = num1;
            while (index1 <= num2)
            {
                if ((int)a[index1] == (int)sigBytes[0])
                {
                    int num3 = 1;
                    int num4 = checked(sigBytes.Length - 1);
                    int index2 = num3;
                    while (index2 <= num4)
                    {
                        if (!((int)a[checked(index1 + index2)] != (int)sigBytes[index2] & (int)sigBytes[index2] != 0))
                            checked { ++index2; }
                        else
                            goto label_7;
                    }
                    return (long)index1;
                }
            label_7:
                checked { ++index1; }
            }
            return -1;
        }

        private byte[] getBytes(string sig)
        {
            byte[] numArray = new byte[checked((int)Math.Round(unchecked((double)sig.Length / 2.0 - 1.0)) + 1)];
            int index = 0;
            int num1 = 0;
            int num2 = checked(sig.Length - 1);
            int startIndex = num1;
            while (startIndex <= num2)
            {
                numArray[index] = Operators.CompareString(sig.Substring(startIndex, 2), "**", false) != 0 ? Conversions.ToByte("&H" + sig.Substring(startIndex, 2)) : (byte)0;
                checked { ++index; }
                checked { startIndex += 2; }
            }
            return numArray;
        }

        private ulong readAddress(long address, ref byte[] aByte)
        {
            string str = "";
            int num = 0;
            do
            {
                str = this.Hex2((object)aByte[checked((int)(address + (long)num))]) + str;
                checked { ++num; }
            }
            while (num <= 7);
            return Conversions.ToULong("&H" + str);
        }

        private uint readLength(long address, ref byte[] aByte)
        {
            string str = "";
            int num = 0;
            do
            {
                str = this.Hex2((object)aByte[checked((int)(address + (long)num))]) + str;
                checked { ++num; }
            }
            while (num <= 3);
            return checked((uint)Conversions.ToULong("&H" + str));
        }

        private string Hex2(object value)
        {
            return Conversion.Hex(RuntimeHelpers.GetObjectValue(value)).ToString().PadLeft(2, '0');
        }

        private bool extractFile(ulong address, long length, string filename, bool auto = false, string fPath = "")
        {
            byte[] byteA = new byte[checked((int)(length - 1L) + 1)];
            FileStream fileStream = default(FileStream);
            bool flag;
            try
            {
                fileStream = new FileStream(Module1.safPath, FileMode.Open);
                fileStream.Seek(checked((long)address), SeekOrigin.Begin);
                fileStream.Read(byteA, 0, checked((int)length));
                if (Microsoft.VisualBasic.Strings.LCase(filename).EndsWith(".sdata"))
                {
                    BinaryReader binaryReader = new BinaryReader((Stream)fileStream);
                    binaryReader.BaseStream.Seek(checked((long)address), SeekOrigin.Begin);
                    string Left = new string(binaryReader.ReadChars(40));
                    binaryReader.Close();
                    if (Operators.CompareString(Left, "0001CBCEBC5B2784D3FC9A2A9DB84D1C3FEB6E99", false) == 0 && Interaction.MsgBox((object)("This file: " + filename + " is encrypted. Would you like to save it as decrypted or leave encrypted? Click yes to decrypt it Or no to save it as is."), MsgBoxStyle.YesNo | MsgBoxStyle.Information, (object)"Decrypt?") == MsgBoxResult.Yes)
                    {
                        switch (Module1.decrypt(byteA, checked((uint)byteA.Length)))
                        {
                            case 0:
                                int num1 = (int)Interaction.MsgBox((object)"Error decrypting file. Might not be aligned correctly.", MsgBoxStyle.Exclamation, (object)"Error");
                                break;
                            case 1:
                                int num2 = (int)Interaction.MsgBox((object)"Error decrypting file. Incorrect Header info.", MsgBoxStyle.Exclamation, (object)"Error");
                                break;
                            case 2:
                                int num3 = (int)Interaction.MsgBox((object)"Error decrypting file. CRC mismatch.", MsgBoxStyle.Exclamation, (object)"Error");
                                break;
                        }
                    }
                }
                fileStream.Close();
                flag = Operators.CompareString(this.savefile(ref byteA, filename, auto, fPath), "", false) != 0;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)("Error reading Data.Saf, Please make sure it is not already open.\r\n" + ex.Message), MsgBoxStyle.Exclamation, (object)"Error 3");
                flag = false;
                ProjectData.ClearProjectError();
            }
            finally
            {
                fileStream.Close();
            }
            return flag;
        }

        public string extractTempFile(ulong address, long length, string filename, bool auto = false)
        {
            byte[] numArray = new byte[checked((int)(length - 1L) + 1)];
            FileStream fileStream1 = default(FileStream);
            string str;
            try
            {
                fileStream1 = new FileStream(Module1.safPath, FileMode.Open);
                fileStream1.Seek(checked((long)address), SeekOrigin.Begin);
                fileStream1.Read(numArray, 0, checked((int)length));
                if (Microsoft.VisualBasic.Strings.LCase(filename).EndsWith(".sdata"))
                {
                    BinaryReader binaryReader = new BinaryReader((Stream)fileStream1);
                    binaryReader.BaseStream.Seek(checked((long)address), SeekOrigin.Begin);
                    string Left = new string(binaryReader.ReadChars(40));
                    binaryReader.Close();
                    if (Operators.CompareString(Left, "0001CBCEBC5B2784D3FC9A2A9DB84D1C3FEB6E99", false) == 0 & !auto && Interaction.MsgBox((object)("This file: " + filename + "  is encrypted. Would you like to view it decrypted or leave encrypted? Click yes to decrypt it Or no to view it as is."), MsgBoxStyle.YesNo | MsgBoxStyle.Information, (object)"Decrypt?") == MsgBoxResult.Yes)
                    {
                        switch (Module1.decrypt(numArray, checked((uint)numArray.Length)))
                        {
                            case 0:
                                int num1 = (int)Interaction.MsgBox((object)"Error decrypting file. Might not be aligned correctly.", MsgBoxStyle.Exclamation, (object)"Error");
                                break;
                            case 1:
                                int num2 = (int)Interaction.MsgBox((object)"Error decrypting file. Incorrect Header info.", MsgBoxStyle.Exclamation, (object)"Error");
                                break;
                            case 2:
                                int num3 = (int)Interaction.MsgBox((object)"Error decrypting file. CRC mismatch.", MsgBoxStyle.Exclamation, (object)"Error");
                                break;
                        }
                    }
                }
                FileStream fileStream2 = new FileStream(Path.GetTempPath() + filename, FileMode.OpenOrCreate);
                BinaryWriter binaryWriter = new BinaryWriter((Stream)fileStream2);
                int num4 = 0;
                int num5 = checked(numArray.Length - 1);
                int index = num4;
                while (index <= num5)
                {
                    binaryWriter.Write(numArray[index]);
                    checked { ++index; }
                }
                fileStream2.Close();
                binaryWriter.Close();
                str = Path.GetTempPath() + filename;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)("Error reading Data.Saf, Please make sure it is not already open.\r\n" + ex.Message), MsgBoxStyle.Exclamation, (object)"Error 3");
                str = "";
                ProjectData.ClearProjectError();
            }
            finally
            {
                fileStream1.Close();
            }
            return str;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.importLog.Count > 0)
            {
                MySettingsProperty.Settings.importedFiles = this.importLog;
                MySettingsProperty.Settings.Save();
                if (Interaction.MsgBox((object)"There are items in the import log, would you like to create a patch of the changes?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Make Patch?") == MsgBoxResult.Yes)
                {
                    int num = (int)MyProject.Forms.Form6.ShowDialog();
                }
            }
            Module1.sahPath = "";
            this.importLog.Clear();
            this.open();
        }

        private void open()
        {
            this.btnCloseView_Click();
            if (Operators.CompareString(Module1.sahPath, "", false) == 0)
            {
                this.OpenFileDialog2.Filter = "Data.sah file|*.sah";
                if (File.Exists(MySettingsProperty.Settings.lastSahOpen))
                    this.OpenFileDialog2.FileName = MySettingsProperty.Settings.lastSahOpen;
                if (this.OpenFileDialog2.ShowDialog() != DialogResult.OK)
                    return;
                Module1.sahPath = this.OpenFileDialog2.FileName;
            }
            Module1.safPath = Module1.sahPath.Replace("sah", "saf");
            if (!File.Exists(Module1.sahPath))
                return;
            Module1.files.Clear();
            if (this.TreeView1.SelectedNode != null && Operators.CompareString(this.TreeView1.SelectedNode.FullPath, "Data", false) != 0)
                this.selectedNodePath = this.TreeView1.SelectedNode.FullPath.Substring(0, this.TreeView1.SelectedNode.FullPath.LastIndexOf("\\"));
            this.TreeView1.Nodes.Clear();
            TreeNode node = this.TreeView1.Nodes.Add("Data", "Data", 0, 0);
            this.Cursor = Cursors.WaitCursor;
            Module1.readSah(Module1.sahPath, ref node);
            if (this.selectedNodePath != null)
                this.expandNode(this.TreeView1.Nodes, this.selectedNodePath);
            this.Cursor = Cursors.Default;
            this.ExtractAllToolStripMenuItem.Enabled = true;
            if (Operators.CompareString(Module1.sahPath, MySettingsProperty.Settings.lastSahOpen, false) == 0)
            {
                this.importLog = MySettingsProperty.Settings.importedFiles;
                if (this.importLog == null)
                    this.importLog = new ArrayList();
            }
            MySettingsProperty.Settings.lastSahOpen = Module1.sahPath;
            MySettingsProperty.Settings.Save();
            this.Text = "Shaiya Data File Tool By Totoshka - " + Module1.sahPath;
        }

        private void expandNode(TreeNodeCollection nodes, string sPath)
        {
            try
            {
                foreach (TreeNode node in nodes)
                {
                    if (Operators.CompareString(node.FullPath, sPath, false) == 0)
                    {
                        node.Expand();
                        node.EnsureVisible();
                        this.TreeView1.SelectedNode = node;
                    }
                    if (node.GetNodeCount(true) > 0)
                        this.expandNode(node.Nodes, sPath);
                }
            }
            finally
            {
                IEnumerator enumerator = default(IEnumerator);
                if (enumerator is IDisposable)
                    (enumerator as IDisposable).Dispose();
            }
        }

        private void TreeView1_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void TreeView1_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void TreeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            this.TreeView1.SelectedNode = this.TreeView1.GetNodeAt(e.X, e.Y);
            if (this.TreeView1.SelectedNode != null)
            {
                this.ContextMenuStrip1.Enabled = true;
                if (this.TreeView1.SelectedNode.FullPath.Contains("."))
                {
                    this.ViewFileToolStripMenuItem.Visible = true;
                    this.ViewFileToolStripMenuItem.Enabled = true;
                    this.RenameToolStripMenuItem.Visible = true;
                    this.DeleteToolStripMenuItem.Visible = true;
                    this.EditToolStripMenuItem1.Visible = true;
                    this.CreateFolderToolStripMenuItem.Visible = false;
                    this.DeleteFolderToolStripMenuItem.Visible = false;
                    this.ImportToolStripMenuItem.Text = "Import";
                    this.ToolStripSeparator5.Visible = true;
                    this.AddToPatchListToolStripMenuItem.Visible = true;
                    this.ToolStripSeparator4.Visible = true;
                }
                else
                {
                    this.ViewFileToolStripMenuItem.Visible = false;
                    this.ViewFileToolStripMenuItem.Enabled = false;
                    this.RenameToolStripMenuItem.Visible = false;
                    this.DeleteToolStripMenuItem.Visible = false;
                    this.EditToolStripMenuItem1.Visible = false;
                    this.CreateFolderToolStripMenuItem.Visible = true;
                    this.DeleteFolderToolStripMenuItem.Visible = true;
                    this.ImportToolStripMenuItem.Text = "Import New File";
                    this.ToolStripSeparator5.Visible = false;
                    this.AddToPatchListToolStripMenuItem.Visible = false;
                    this.ToolStripSeparator4.Visible = false;
                }
                if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, "Data", false) == 0)
                {
                    this.RebuildDataFileTS.Visible = true;
                    this.ToolStripSeparator6.Visible = true;
                }
                else
                {
                    this.RebuildDataFileTS.Visible = false;
                    this.ToolStripSeparator6.Visible = false;
                }
            }
            else
                this.ContextMenuStrip1.Enabled = false;
        }

        private void ExtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, "Data", false) == 0)
            {
                if (Interaction.MsgBox((object)"Are you sure you want to Extract the whole Data file?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Extract all?") != MsgBoxResult.Yes)
                    return;
                this.Cursor = Cursors.WaitCursor;
                if (this.FolderBrowserDialog1.ShowDialog() != DialogResult.OK)
                {
                    this.tsPb.Visible = false;
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    this.extractPath = this.FolderBrowserDialog1.SelectedPath;
                    this.extractAll();
                    this.tsPb.Visible = false;
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                int num1 = 0;
                int num2 = checked(Module1.files.Count - 1);
                int index = num1;
                while (index <= num2)
                {
                    object file = Module1.files[index];
                    Module1.SAHfile saHfile1 = default(Module1.SAHfile);
                    Module1.SAHfile saHfile2 = file != null ? (Module1.SAHfile)file : saHfile1;
                    if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, saHfile2.filePath, false) == 0)
                    {
                        if (saHfile2.dir)
                        {
                            if (this.FolderBrowserDialog1.ShowDialog() != DialogResult.OK)
                            {
                                this.tsPb.Visible = false;
                                this.Cursor = Cursors.Default;
                                break;
                            }
                            this.extractPath = this.FolderBrowserDialog1.SelectedPath;
                            this.extractPart(saHfile2.filePath);
                            int num3 = (int)Interaction.MsgBox((object)"Extraction Success!", MsgBoxStyle.Information, (object)"Success!");
                            this.tsPb.Visible = false;
                            this.Cursor = Cursors.Default;
                            break;
                        }
                        if (this.extractFile(saHfile2.offset, (long)saHfile2.len, saHfile2.fileName, false, ""))
                        {
                            int num3 = (int)Interaction.MsgBox((object)"Extraction Success!", MsgBoxStyle.Information, (object)"Success!");
                            this.tsPb.Visible = false;
                            this.Cursor = Cursors.Default;
                            break;
                        }
                        int num4 = (int)Interaction.MsgBox((object)"An Error Occured during Extraction.", MsgBoxStyle.Exclamation, (object)"Error");
                        break;
                    }
                    checked { ++index; }
                }
            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.import(new Module1.SAHfile(), "");
        }

        private void import(Module1.SAHfile iSah, string fPath)
        {
            Module1.SAHfile saHfile1 = new Module1.SAHfile();
            bool flag1 = false;
            string Left1 = this.TreeView1.SelectedNode.FullPath;
            if (Operators.CompareString(iSah.filePath, "", false) != 0)
                Left1 = iSah.filePath;
            bool flag2 = default(bool);
            if (Operators.CompareString(Left1, "Data", false) == 0)
            {
                saHfile1.dir = true;
                saHfile1.filePath = "Data";
                flag2 = true;
            }
            else
            {
                int num1 = 0;
                int num2 = checked(Module1.files.Count - 1);
                int index = num1;
                while (index <= num2)
                {
                    object file = Module1.files[index];
                    Module1.SAHfile saHfile2 = default(Module1.SAHfile);
                    saHfile1 = file != null ? (Module1.SAHfile)file : saHfile2;
                    if (Operators.CompareString(Left1, saHfile1.filePath, false) == 0)
                    {
                        flag2 = true;
                        break;
                    }
                    checked { ++index; }
                }
            }
            if (saHfile1.dir)
            {
                if (Interaction.MsgBox((object)"Do you want to import a new file into this folder?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"import new?") != MsgBoxResult.Yes)
                    return;
                saHfile1 = new Module1.SAHfile()
                {
                    dir = false,
                    dirPath = saHfile1.filePath + "\\"
                };
                flag1 = true;
            }
            if (!flag2)
            {
                int num3 = (int)Interaction.MsgBox((object)"Error in importing file.", MsgBoxStyle.Exclamation, (object)"Error");
            }
            else
            {
                string str;
                if (Operators.CompareString(fPath, "", false) == 0 | !File.Exists(fPath))
                {
                    this.OFD.Filter = "all files|*.*";
                    this.OFD.FileName = saHfile1.fileName;
                    if (this.OFD.ShowDialog() == DialogResult.OK)
                    {
                        str = this.prsFilename(this.OFD.FileName);
                        fPath = this.OFD.FileName;
                    }
                    else
                        goto label_45;
                }
                else
                    str = this.prsFilename(fPath);
                if (flag1)
                {
                    saHfile1.fileName = str;
                    saHfile1.filePath = saHfile1.dirPath + str;
                    saHfile1.len = 0;
                    saHfile1.offset = 0UL;
                    Module1.files.Add((object)saHfile1);
                }
                if (Operators.CompareString(Microsoft.VisualBasic.Strings.LCase(str), Microsoft.VisualBasic.Strings.LCase(saHfile1.fileName), false) != 0)
                {
                    int num1 = (int)Interaction.MsgBox((object)"Selected file doesn't match filenames.", MsgBoxStyle.Exclamation, (object)"Error");
                    return;
                }
                FileStream fileStream;
                try
                {
                    fileStream = new FileStream(fPath, FileMode.Open);
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    int num1 = (int)Interaction.MsgBox((object)"Error reading file, Please make sure it is not already open.", MsgBoxStyle.Exclamation, (object)"Error 5");
                    ProjectData.ClearProjectError();
                    goto label_45;
                }
                BinaryReader binaryReader = new BinaryReader((Stream)fileStream);
                this.Cursor = Cursors.WaitCursor;
                byte[] fdata = new byte[checked((int)(fileStream.Length - 1L) + 1)];
                int num2 = 0;
                int num4 = checked(fdata.Length - 1);
                int index1 = num2;
                while (index1 <= num4)
                {
                    fdata[index1] = binaryReader.ReadByte();
                    checked { ++index1; }
                }
                binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
                string Left2 = new string(binaryReader.ReadChars(40));
                fileStream.Close();
                binaryReader.Close();
                if (Operators.CompareString(Left2, "0001CBCEBC5B2784D3FC9A2A9DB84D1C3FEB6E99", false) == 0 & Microsoft.VisualBasic.Strings.UCase(fPath).EndsWith("SDATA") && Interaction.MsgBox((object)"This file is decrypted. Would you like to import it as decrypted or encrypt it? Click yes to import as is Or no to encrypt it and import.", MsgBoxStyle.YesNo | MsgBoxStyle.Information, (object)"Decrypted?") == MsgBoxResult.No)
                {
                    Array.Resize<byte>(ref fdata, checked(fdata.Length + 64 + 16));
                    uint num1 = Module1.encrypt(fdata, checked((uint)(fdata.Length - 64 - 16)));
                    Array.Resize<byte>(ref fdata, checked((int)((long)num1 + 64L)));
                    if ((long)num1 < 5L)
                    {
                        int num5 = (int)Interaction.MsgBox((object)"Error Encrypting file. Import aborted.", MsgBoxStyle.Exclamation, (object)"Error");
                        return;
                    }
                }
                ulong Number;
                if (fdata.Length > saHfile1.len)
                {
                    if (Interaction.MsgBox((object)"The file you are attemping to import is larger than the file that already exhists or is a new file. Do you want to append it to the bottom of the data.saf file?", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo, (object)"Append?") != MsgBoxResult.Yes)
                    {
                        int num1 = (int)Interaction.MsgBox((object)"Operation aborted.", MsgBoxStyle.Exclamation, (object)"Aborted");
                        goto label_45;
                    }
                    else
                        Number = this.writeFile(ref fdata, 0UL, (long)fdata.Length);
                }
                else
                    Number = this.writeFile(ref fdata, saHfile1.offset, (long)fdata.Length);
                bool flag3 = false;
                if (Decimal.Compare(new Decimal(Number), Decimal.Zero) == 0)
                {
                    int num6 = (int)Interaction.MsgBox((object)"Error writing file. Operation aborted!", MsgBoxStyle.Exclamation, (object)"Aborted");
                }
                else
                {
                    saHfile1.offset = Number;
                    saHfile1.len = fdata.Length;
                    int num1 = 0;
                    int num5 = checked(Module1.files.Count - 1);
                    int index2 = num1;
                    while (index2 <= num5)
                    {
                        object file = Module1.files[index2];
                        Module1.SAHfile saHfile2 = default(Module1.SAHfile);
                        if (Operators.CompareString((file != null ? (Module1.SAHfile)file : saHfile2).filePath, saHfile1.filePath, false) == 0)
                        {
                            Module1.files[index2] = (object)saHfile1;
                            break;
                        }
                        checked { ++index2; }
                    }
                    if (this.importLog.IndexOf((object)saHfile1.filePath) == -1)
                        this.importLog.Add((object)saHfile1.filePath);
                    this.MakeSahFromFiles();
                    int num7 = (int)Interaction.MsgBox((object)"File Imported successfully!", MsgBoxStyle.Information, (object)"Success!");
                    this.TLabel1.Text = "Wrote file: " + str + " to 0x" + Conversion.Hex(Number);
                    flag3 = true;
                }
            label_45:
                this.Cursor = Cursors.Default;
                this.open();
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index = num1;
            while (index <= num2)
            {
                object file = Module1.files[index];
                Module1.SAHfile saHfile1 = default(Module1.SAHfile);
                Module1.SAHfile saHfile2 = file != null ? (Module1.SAHfile)file : saHfile1;
                if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, saHfile2.filePath, false) == 0)
                {
                    this.Label1.Text = "Offset: 0x" + Conversion.Hex(saHfile2.offset);
                    this.Label2.Text = "Length: 0x0" + Conversion.Hex(saHfile2.len);
                    break;
                }
                checked { ++index; }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = (int)MyProject.Forms.Form2.ShowDialog();
        }

        public bool extractAll()
        {
            bool flag;
            try
            {
                if (Operators.CompareString(this.extractPath, "", false) == 0)
                    this.extractPath = Application.StartupPath;
                this.tsPb.Visible = true;
                this.deleteData();
                int count = Module1.files.Count;
                long num1 = 0;
                int num2 = 0;
                int num3 = checked(Module1.files.Count - 1);
                int index1 = num2;
                Module1.SAHfile saHfile1 = default(Module1.SAHfile);
                while (index1 <= num3)
                {
                    object file = Module1.files[index1];
                    Module1.SAHfile saHfile2 = file != null ? (Module1.SAHfile)file : saHfile1;
                    if (!saHfile2.dir)
                        checked { num1 += (long)saHfile2.len; }
                    checked { ++index1; }
                }
                MyProject.Forms.Form3.totalf = count;
                MyProject.Forms.Form3.totalBytes = num1;
                MyProject.Forms.Form3.label2.Text = "0/" + MyProject.Forms.Form3.totalf.ToString();
                MyProject.Forms.Form3.Show();
                this.tsPb.Maximum = checked(Module1.files.Count - 1);
                int num4 = 0;
                int num5 = checked(Module1.files.Count - 1);
                int index2 = num4;
                while (index2 <= num5)
                {
                    MyProject.Forms.Form3.label2.Text = index2.ToString() + "/" + MyProject.Forms.Form3.totalf.ToString();
                    if (!MyProject.Forms.Form3.Visible)
                    {
                        this.tsPb.Visible = false;
                        this.TLabel1.Text = "User Canceled Extraction.";
                        this.extractPath = "";
                        flag = false;
                        goto label_20;
                    }
                    else
                    {
                        object file = Module1.files[index2];
                        Module1.SAHfile saHfile2 = file != null ? (Module1.SAHfile)file : saHfile1;
                        if (saHfile2.dir)
                        {
                            Directory.CreateDirectory(this.extractPath + "\\" + saHfile2.filePath);
                        }
                        else
                        {
                            if (!Directory.Exists(this.extractPath + "\\" + saHfile2.filePath.Substring(0, checked(saHfile2.filePath.LastIndexOf("\\") + 1))))
                                Directory.CreateDirectory(this.extractPath + "\\" + saHfile2.filePath.Substring(0, checked(saHfile2.filePath.LastIndexOf("\\") + 1)));
                            if (!this.extractFile(saHfile2.offset, (long)saHfile2.len, saHfile2.filePath, true, ""))
                                throw new Exception("Error Extracting files.");
                        }
                        this.tsPb.Value = index2;
                        checked { MyProject.Forms.Form3.runningBytes += (long)saHfile2.len; }
                        Application.DoEvents();
                        checked { ++index2; }
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)("Error Extracting all files and folders.\r\n" + ex.Message), MsgBoxStyle.Critical, (object)"Error 6");
                this.tsPb.Visible = false;
                this.TLabel1.Text = "Error Extracting";
                MyProject.Forms.Form3.Hide();
                this.extractPath = "";
                flag = false;
                ProjectData.ClearProjectError();
                goto label_20;
            }
            MyProject.Forms.Form3.Hide();
            this.TLabel1.Text = "Extraction Success!";
            this.extractPath = "";
            return true;
        label_20:
            return flag;
        }

        private void deleteData()
        {
            if (!Directory.Exists(this.extractPath + "\\Data") || Interaction.MsgBox((object)"There are files in the Data folder. Would you like to delete them first?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Delete?") != MsgBoxResult.Yes)
                return;
            Directory.Delete(Application.StartupPath + "\\Data", true);
        }

        public bool extractPart(string dir)
        {
            bool flag;
            try
            {
                if (Operators.CompareString(this.extractPath, "", false) == 0)
                    this.extractPath = Application.StartupPath;
                this.tsPb.Visible = true;
                this.deleteData();
                ArrayList arrayList = new ArrayList();
                int num1 = 0;
                long num2 = 0;
                int num3 = 0;
                int num4 = checked(Module1.files.Count - 1);
                int index1 = num3;
                Module1.SAHfile saHfile1 = default(Module1.SAHfile);
                while (index1 <= num4)
                {
                    object file = Module1.files[index1];
                    Module1.SAHfile saHfile2 = file != null ? (Module1.SAHfile)file : saHfile1;
                    if (saHfile2.dirPath.StartsWith(dir))
                    {
                        arrayList.Add((object)saHfile2);
                        checked { num2 += (long)saHfile2.len; }
                        checked { ++num1; }
                    }
                    checked { ++index1; }
                }
                MyProject.Forms.Form3.totalf = arrayList.Count;
                MyProject.Forms.Form3.totalBytes = num2;
                MyProject.Forms.Form3.label2.Text = "0/" + MyProject.Forms.Form3.totalf.ToString();
                MyProject.Forms.Form3.Show();
                this.tsPb.Maximum = checked(arrayList.Count - 1);
                int num5 = 0;
                int num6 = checked(arrayList.Count - 1);
                int index2 = num5;
                while (index2 <= num6)
                {
                    MyProject.Forms.Form3.label2.Text = index2.ToString() + "/" + Conversions.ToString(checked(arrayList.Count - 1));
                    if (!MyProject.Forms.Form3.Visible)
                    {
                        this.tsPb.Visible = false;
                        this.TLabel1.Text = "User Canceled Extraction.";
                        this.extractPath = "";
                        flag = false;
                        goto label_20;
                    }
                    else
                    {
                        object obj = arrayList[index2];
                        Module1.SAHfile saHfile2 = obj != null ? (Module1.SAHfile)obj : saHfile1;
                        if (saHfile2.dir)
                        {
                            Directory.CreateDirectory(this.extractPath + "\\" + saHfile2.filePath);
                        }
                        else
                        {
                            if (!Directory.Exists(this.extractPath + "\\" + saHfile2.filePath.Substring(0, checked(saHfile2.filePath.LastIndexOf("\\") + 1))))
                                Directory.CreateDirectory(this.extractPath + "\\" + saHfile2.filePath.Substring(0, checked(saHfile2.filePath.LastIndexOf("\\") + 1)));
                            if (!this.extractFile(saHfile2.offset, (long)saHfile2.len, saHfile2.filePath, true, ""))
                                throw new Exception("Error Extracting files.");
                        }
                        checked { MyProject.Forms.Form3.runningBytes += (long)saHfile2.len; }
                        this.tsPb.Value = index2;
                        Application.DoEvents();
                        checked { ++index2; }
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)("Error Extracting all files and folders.\r\n" + ex.Message), MsgBoxStyle.Critical, (object)"Error 6");
                this.TLabel1.Text = "Error Extracting...";
                this.tsPb.Visible = false;
                MyProject.Forms.Form3.Hide();
                this.extractPath = "";
                flag = false;
                ProjectData.ClearProjectError();
                goto label_20;
            }
            MyProject.Forms.Form3.Hide();
            this.TLabel1.Text = "Extraction Success!";
            this.extractPath = "";
            return true;
        label_20:
            return flag;
        }

        private void ExtractAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (this.FolderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                this.tsPb.Visible = false;
                this.Cursor = Cursors.Default;
            }
            else
            {
                this.extractPath = this.FolderBrowserDialog1.SelectedPath;
                this.extractAll();
                this.tsPb.Visible = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void ViewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index = num1;
            while (index <= num2)
            {
                Module1.SAHfile fSah = Module1.files[index] != null ? (Module1.SAHfile)Module1.files[index] : default(Module1.SAHfile);
                if (Operators.CompareString(TreeView1.SelectedNode.FullPath, fSah.filePath, false) == 0)
                {
                    selNodefile = fSah;
                    if (Strings.LCase(fSah.fileName).EndsWith(".dds") | Strings.LCase(fSah.fileName).EndsWith(".tga") | Strings.LCase(fSah.fileName).EndsWith(".jpg") | Strings.LCase(fSah.fileName).EndsWith(".bmp"))
                        viewImage(fSah);
                    else
                        ViewFile(fSah);
                }
                checked { ++index; }
            }
        }

        private void viewImage(Module1.SAHfile fSah)
        {
            try
            {
                string tempFile = extractTempFile(fSah.offset, fSah.len, fSah.fileName, false);
                if (Operators.CompareString(tempFile, "", false) == 0)
                    return;
                Bitmap bitmap = DevIL.DevIL.LoadBitmap(tempFile);
                //Image bitmap = Image.FromFile(tempFile);
                MyProject.Forms.Form5.pictureBox1.Image = bitmap;
                MyProject.Forms.Form5.pictureBox1.Width = bitmap.Width;
                MyProject.Forms.Form5.pictureBox1.Height = bitmap.Height;
                MyProject.Forms.Form5.Width = checked(bitmap.Width + 6);
                MyProject.Forms.Form5.Height = checked(bitmap.Height + 24);
                MyProject.Forms.Form5.Show();
                File.Delete(tempFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }

        private void ViewFile(Module1.SAHfile fSah)
        {
            byte[] numArray = new byte[checked(fSah.len - 1 + 1)];
            FileStream fileStream = default(FileStream);
            try
            {
                fileStream = new FileStream(Module1.safPath, FileMode.Open);
                fileStream.Seek(checked((long)fSah.offset), SeekOrigin.Begin);
                fileStream.Read(numArray, 0, fSah.len);
                if (Microsoft.VisualBasic.Strings.LCase(fSah.fileName).EndsWith(".sdata"))
                {
                    BinaryReader binaryReader = new BinaryReader((Stream)fileStream);
                    binaryReader.BaseStream.Seek(checked((long)fSah.offset), SeekOrigin.Begin);
                    string Left = new string(binaryReader.ReadChars(40));
                    binaryReader.Close();
                    if (Operators.CompareString(Left, "0001CBCEBC5B2784D3FC9A2A9DB84D1C3FEB6E99", false) == 0 && Interaction.MsgBox((object)("This file: " + fSah.fileName + "  is encrypted. Would you like to view it decrypted or leave encrypted? Click yes to decrypt it Or no to view it as is."), MsgBoxStyle.YesNo | MsgBoxStyle.Information, (object)"Decrypt?") == MsgBoxResult.Yes)
                    {
                        switch (Module1.decrypt(numArray, checked((uint)numArray.Length)))
                        {
                            case 0:
                                int num1 = (int)Interaction.MsgBox((object)"Error decrypting file. Might not be aligned correctly.", MsgBoxStyle.Exclamation, (object)"Error");
                                break;
                            case 1:
                                int num2 = (int)Interaction.MsgBox((object)"Error decrypting file. Incorrect Header info.", MsgBoxStyle.Exclamation, (object)"Error");
                                break;
                            case 2:
                                int num3 = (int)Interaction.MsgBox((object)"Error decrypting file. CRC mismatch.", MsgBoxStyle.Exclamation, (object)"Error");
                                break;
                        }
                    }
                }
                if (this.CheckBox2.Checked)
                {
                    string str1 = "";
                    int num1 = 0;
                    StringBuilder stringBuilder = new StringBuilder();
                    int num2;
                    do
                    {
                        num2 = checked(num1 + 9);
                        int num3 = num1;
                        int num4 = num2;
                        int index = num3;
                        while (index <= num4)
                        {
                            if (index > Information.UBound((Array)numArray, 1))
                            {
                                stringBuilder.Append("    ");
                                str1 += "  ";
                            }
                            else
                            {
                                string str2 = Microsoft.VisualBasic.Strings.UCase(Convert.ToString(numArray[index], 16));
                                stringBuilder.Append(str2.PadLeft(2, '0') + "  ");
                                str1 = (int)numArray[index] >= 32 ? str1 + Conversions.ToString(Microsoft.VisualBasic.Strings.Chr((int)numArray[index])) + " " : str1 + ". ";
                            }
                            checked { ++index; }
                        }
                        stringBuilder.Append("    |    " + str1 + "\r\n");
                        str1 = "";
                        checked { num1 += 10; }
                    }
                    while (num2 < Information.UBound((Array)numArray, 1));
                    this.txtViewer.Font = new Font("Courier New", 10f, FontStyle.Bold);
                    this.txtViewer.Text = stringBuilder.ToString();
                }
                else
                {
                    char[] chArray = new char[checked(numArray.Length - 1 + 1)];
                    int num1 = 0;
                    int num2 = checked(numArray.Length - 1);
                    int index = num1;
                    while (index <= num2)
                    {
                        chArray[index] = Microsoft.VisualBasic.Strings.ChrW((int)numArray[index]);
                        if ((int)chArray[index] == 0)
                            chArray[index] = '.';
                        checked { ++index; }
                    }
                    string str = new string(chArray);
                    this.txtViewer.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular);
                    this.txtViewer.Text = str;
                }
                this.Label3.Text = "Viewing: " + fSah.fileName;
                this.Size = new Size(965, this.Height);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)("Error reading Data.Saf, Please make sure it is not already open.\r\n" + ex.Message), MsgBoxStyle.Exclamation, (object)"Error 3");
                ProjectData.ClearProjectError();
            }
            finally
            {
                fileStream.Close();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtViewer.WordWrap = this.CheckBox1.Checked;
        }

        private void InnerDir(DirectoryInfo di)
        {
            int num1 = 0;
            int num2 = 0;
            FileInfo[] files1 = di.GetFiles();
            int index1 = 0;
            while (index1 < files1.Length)
            {
                FileInfo fileInfo = files1[index1];
                if ((fileInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden & (fileInfo.Attributes & FileAttributes.System) != FileAttributes.System)
                    checked { ++num1; }
                checked { ++index1; }
            }
            this.SahFS.Write(BitConverter.GetBytes(num1), 0, 4);
            FileInfo[] files2 = di.GetFiles();
            int index2 = 0;
            while (index2 < files2.Length)
            {
                FileInfo fileInfo = files2[index2];
                if ((fileInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden & (fileInfo.Attributes & FileAttributes.System) != FileAttributes.System)
                {
                    this.SahFS.Write(BitConverter.GetBytes(checked(fileInfo.Name.Length + 1)), 0, 4);
                    this.SahFS.Write(Encoding.ASCII.GetBytes(fileInfo.Name), 0, fileInfo.Name.Length);
                    this.SahFS.WriteByte((byte)0);
                    this.SahFS.Write(BitConverter.GetBytes(checked((ulong)this.SafFS.Position)), 0, 8);
                    this.SahFS.Write(BitConverter.GetBytes(checked((int)fileInfo.Length)), 0, 4);
                    this.SahFS.Write(new byte[4]
                    {
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0
                    }, 0, 4);
                    checked { ++this.totalFiles; }
                    MyProject.Forms.Form4.label2.Text = this.totalFiles.ToString() + "/" + MyProject.Forms.Form4.totalf.ToString();
                    this.writeSAF(fileInfo.FullName);
                    Application.DoEvents();
                }
                checked { ++index2; }
            }
            if (this.canButton)
                return;
            DirectoryInfo[] directories1 = di.GetDirectories();
            int index3 = 0;
            while (index3 < directories1.Length)
            {
                DirectoryInfo directoryInfo = directories1[index3];
                if ((directoryInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden & (directoryInfo.Attributes & FileAttributes.System) != FileAttributes.System)
                    checked { ++num2; }
                checked { ++index3; }
            }
            this.SahFS.Write(BitConverter.GetBytes(num2), 0, 4);
            DirectoryInfo[] directories2 = di.GetDirectories();
            int index4 = 0;
            while (index4 < directories2.Length)
            {
                DirectoryInfo di1 = directories2[index4];
                if ((di1.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden & (di1.Attributes & FileAttributes.System) != FileAttributes.System)
                {
                    this.SahFS.Write(BitConverter.GetBytes(checked(di1.Name.Length + 1)), 0, 4);
                    this.SahFS.Write(Encoding.ASCII.GetBytes(di1.Name), 0, di1.Name.Length);
                    this.SahFS.WriteByte((byte)0);
                    this.InnerDir(di1);
                }
                checked { ++index4; }
            }
            if (this.canButton)
                ;
        }

        private void InnerDir2(string di)
        {
            ArrayList arrayList = new ArrayList();
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index1 = num1;
            Module1.SAHfile saHfile1 = default(Module1.SAHfile);
            while (index1 <= num2)
            {
                object file = Module1.files[index1];
                Module1.SAHfile saHfile2 = file != null ? (Module1.SAHfile)file : saHfile1;
                if (Operators.CompareString(saHfile2.dirPath, di, false) == 0)
                    arrayList.Add((object)saHfile2);
                checked { ++index1; }
            }
            int num3 = 0;
            int num4 = 0;
            int num5 = checked(arrayList.Count - 1);
            int index2 = num4;
            while (index2 <= num5)
            {
                object obj = arrayList[index2];
                if (!(obj != null ? (Module1.SAHfile)obj : saHfile1).dir)
                    checked { ++num3; }
                checked { ++index2; }
            }
            this.SahFS.Write(BitConverter.GetBytes(num3), 0, 4);
            int num6 = 0;
            int num7 = checked(arrayList.Count - 1);
            int index3 = num6;
            while (index3 <= num7)
            {
                object obj = arrayList[index3];
                Module1.SAHfile saHfile2 = obj != null ? (Module1.SAHfile)obj : saHfile1;
                if (!saHfile2.dir)
                {
                    this.SahFS.Write(BitConverter.GetBytes(checked(saHfile2.fileName.Length + 1)), 0, 4);
                    this.SahFS.Write(Encoding.ASCII.GetBytes(saHfile2.fileName), 0, saHfile2.fileName.Length);
                    this.SahFS.WriteByte((byte)0);
                    this.SahFS.Write(BitConverter.GetBytes(saHfile2.offset), 0, 8);
                    this.SahFS.Write(BitConverter.GetBytes(saHfile2.len), 0, 4);
                    this.SahFS.Write(new byte[4]
                    {
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0
                    }, 0, 4);
                    checked { ++this.totalFiles; }
                }
                checked { ++index3; }
            }
            int num8 = 0;
            int num9 = 0;
            int num10 = checked(arrayList.Count - 1);
            int index4 = num9;
            while (index4 <= num10)
            {
                object obj = arrayList[index4];
                if ((obj != null ? (Module1.SAHfile)obj : saHfile1).dir)
                    checked { ++num8; }
                checked { ++index4; }
            }
            this.SahFS.Write(BitConverter.GetBytes(num8), 0, 4);
            int num11 = 0;
            int num12 = checked(arrayList.Count - 1);
            int index5 = num11;
            while (index5 <= num12)
            {
                object obj = arrayList[index5];
                Module1.SAHfile saHfile2 = obj != null ? (Module1.SAHfile)obj : saHfile1;
                if (saHfile2.dir)
                {
                    this.SahFS.Write(BitConverter.GetBytes(checked(saHfile2.fileName.Length + 1)), 0, 4);
                    this.SahFS.Write(Encoding.ASCII.GetBytes(saHfile2.fileName), 0, saHfile2.fileName.Length);
                    this.SahFS.WriteByte((byte)0);
                    this.InnerDir2(saHfile2.filePath + "\\");
                }
                checked { ++index5; }
            }
        }

        private void InnerDir3(string di)
        {
            if (this.canButton)
                return;
            ArrayList arrayList = new ArrayList();
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index1 = num1;
            Module1.SAHfile saHfile1 = default(Module1.SAHfile);
            while (index1 <= num2)
            {
                object file = Module1.files[index1];
                Module1.SAHfile saHfile2 = file != null ? (Module1.SAHfile)file : saHfile1;
                if (Operators.CompareString(saHfile2.dirPath, di, false) == 0)
                    arrayList.Add((object)saHfile2);
                checked { ++index1; }
            }
            int num3 = 0;
            int num4 = 0;
            int num5 = checked(arrayList.Count - 1);
            int index2 = num4;
            while (index2 <= num5)
            {
                object obj = arrayList[index2];
                if (!(obj != null ? (Module1.SAHfile)obj : saHfile1).dir)
                    checked { ++num3; }
                checked { ++index2; }
            }
            this.SahFS.Write(BitConverter.GetBytes(num3), 0, 4);
            int num6 = 0;
            int num7 = checked(arrayList.Count - 1);
            int index3 = num6;
            while (index3 <= num7)
            {
                object obj = arrayList[index3];
                Module1.SAHfile saHfile2 = obj != null ? (Module1.SAHfile)obj : saHfile1;
                if (!saHfile2.dir)
                {
                    this.SahFS.Write(BitConverter.GetBytes(checked(saHfile2.fileName.Length + 1)), 0, 4);
                    this.SahFS.Write(Encoding.ASCII.GetBytes(saHfile2.fileName), 0, saHfile2.fileName.Length);
                    this.SahFS.WriteByte((byte)0);
                    this.SahFS.Write(BitConverter.GetBytes(checked((ulong)this.SafFS.Position)), 0, 8);
                    this.SahFS.Write(BitConverter.GetBytes(saHfile2.len), 0, 4);
                    this.SahFS.Write(new byte[4]
                    {
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0
                    }, 0, 4);
                    checked { ++this.totalFiles; }
                    MyProject.Forms.Form4.label2.Text = this.totalFiles.ToString() + "/" + MyProject.Forms.Form4.totalf.ToString();
                    FileStream fileStream = new FileStream(Module1.safPath, FileMode.Open);
                    fileStream.Seek(checked((long)saHfile2.offset), SeekOrigin.Begin);
                    byte[] array = new byte[checked(saHfile2.len - 1 + 1)];
                    fileStream.Read(array, 0, saHfile2.len);
                    this.SafFS.Write(array, 0, saHfile2.len);
                    fileStream.Close();
                    checked { MyProject.Forms.Form4.runningBytes += (long)saHfile2.len; }
                    Application.DoEvents();
                    if (this.canButton)
                        return;
                }
                checked { ++index3; }
            }
            int num8 = 0;
            int num9 = 0;
            int num10 = checked(arrayList.Count - 1);
            int index4 = num9;
            while (index4 <= num10)
            {
                object obj = arrayList[index4];
                if ((obj != null ? (Module1.SAHfile)obj : saHfile1).dir)
                    checked { ++num8; }
                checked { ++index4; }
            }
            this.SahFS.Write(BitConverter.GetBytes(num8), 0, 4);
            if (this.canButton)
                return;
            int num11 = 0;
            int num12 = checked(arrayList.Count - 1);
            int index5 = num11;
            while (index5 <= num12)
            {
                object obj = arrayList[index5];
                Module1.SAHfile saHfile2 = obj != null ? (Module1.SAHfile)obj : saHfile1;
                if (saHfile2.dir)
                {
                    this.SahFS.Write(BitConverter.GetBytes(checked(saHfile2.fileName.Length + 1)), 0, 4);
                    this.SahFS.Write(Encoding.ASCII.GetBytes(saHfile2.fileName), 0, saHfile2.fileName.Length);
                    this.SahFS.WriteByte((byte)0);
                    this.InnerDir3(saHfile2.filePath + "\\");
                    if (this.canButton)
                        break;
                }
                checked { ++index5; }
            }
        }

        private void MakeSah(DirectoryInfo dataDI)
        {
            try
            {
                this.canButton = false;
                string path = Application.StartupPath + "\\Output\\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                FileInfo[] files = dataDI.GetFiles("*", SearchOption.AllDirectories);
                long num1 = 0;
                int num2 = 0;
                int num3 = 0;
                int num4 = checked(((IEnumerable<FileInfo>)files).Count<FileInfo>() - 1);
                int index = num3;
                while (index <= num4)
                {
                    if ((files[index].Attributes & FileAttributes.Hidden) != FileAttributes.Hidden & (files[index].Attributes & FileAttributes.System) != FileAttributes.System)
                    {
                        checked { num1 += files[index].Length; }
                        checked { ++num2; }
                    }
                    checked { ++index; }
                }
                MyProject.Forms.Form4.totalf = num2;
                MyProject.Forms.Form4.totalBytes = num1;
                MyProject.Forms.Form4.label2.Text = "0/" + MyProject.Forms.Form4.totalf.ToString();
                MyProject.Forms.Form4.Show();
                this.SahFS = new FileStream(path + "data.sah", FileMode.Create);
                this.SafFS = new FileStream(path + "data.saf", FileMode.Create);
                byte[] array1 = new byte[56]
                {
          (byte) 83,
          (byte) 65,
          (byte) 72,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 183,
          (byte) 79,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 1,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0
                };
                byte[] array2 = new byte[12]
                {
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0
                };
                this.SahFS.Write(array1, 0, array1.Length);
                this.totalFiles = 0;
                this.InnerDir(dataDI);
                this.SahFS.Write(array2, 0, 8);
                this.SahFS.Seek(7L, SeekOrigin.Begin);
                this.SahFS.Write(BitConverter.GetBytes(this.totalFiles), 0, 4);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)("There was an Error.\r\n\r\n" + ex.Message), MsgBoxStyle.Critical, (object)"Error");
                ProjectData.ClearProjectError();
            }
            finally
            {
                this.SahFS.Close();
                this.SafFS.Close();
                MyProject.Forms.Form4.Hide();
            }
        }

        private void rebuildData()
        {
            try
            {
                this.canButton = false;
                int num1 = 0;
                long num2 = 0;
                int num3 = 0;
                int num4 = checked(Module1.files.Count - 1);
                int index = num3;
                while (index <= num4)
                {
                    object file = Module1.files[index];
                    Module1.SAHfile saHfile1 = default(Module1.SAHfile);
                    Module1.SAHfile saHfile2 = file != null ? (Module1.SAHfile)file : saHfile1;
                    if (!saHfile2.dir)
                    {
                        checked { ++num1; }
                        checked { num2 += (long)saHfile2.len; }
                    }
                    checked { ++index; }
                }
                MyProject.Forms.Form4.totalf = num1;
                MyProject.Forms.Form4.totalBytes = num2;
                MyProject.Forms.Form4.label2.Text = "0/" + MyProject.Forms.Form4.totalf.ToString();
                MyProject.Forms.Form4.Show();
                string path = Module1.sahPath.Replace(".sah", "_new.sah");
                this.SahFS = new FileStream(path, FileMode.Create);
                this.SafFS = new FileStream(path.Replace(".sah", ".saf"), FileMode.Create);
                byte[] array1 = new byte[56]
                {
          (byte) 83,
          (byte) 65,
          (byte) 72,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 183,
          (byte) 79,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 1,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0
                };
                byte[] array2 = new byte[12]
                {
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0
                };
                this.SahFS.Write(array1, 0, array1.Length);
                this.totalFiles = 0;
                this.InnerDir3("Data\\");
                this.SahFS.Write(array2, 0, 8);
                this.SahFS.Seek(7L, SeekOrigin.Begin);
                this.SahFS.Write(BitConverter.GetBytes(this.totalFiles), 0, 4);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)("There was an Error.\r\n\r\n" + ex.Message), MsgBoxStyle.Critical, (object)"Error");
                ProjectData.ClearProjectError();
            }
            finally
            {
                this.SahFS.Close();
                this.SafFS.Close();
                MyProject.Forms.Form4.Hide();
            }
        }

        private void MakeSahFromFiles()
        {
            try
            {
                this.SahFS = new FileStream(Module1.sahPath, FileMode.Create);
                byte[] array1 = new byte[56]
                {
          (byte) 83,
          (byte) 65,
          (byte) 72,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 183,
          (byte) 79,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 1,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0
                };
                byte[] array2 = new byte[12]
                {
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0
                };
                this.SahFS.Write(array1, 0, array1.Length);
                this.totalFiles = 0;
                this.InnerDir2("Data\\");
                this.SahFS.Write(array2, 0, 8);
                this.SahFS.Seek(7L, SeekOrigin.Begin);
                this.SahFS.Write(BitConverter.GetBytes(this.totalFiles), 0, 4);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)("There was an Error.\r\n\r\n" + ex.Message), MsgBoxStyle.Critical, (object)"Error");
                ProjectData.ClearProjectError();
            }
            finally
            {
                this.SahFS.Close();
            }
        }

        private void writeSAF(string filetowrite)
        {
            FileStream fileStream = new FileStream(filetowrite, FileMode.Open);
            byte[] array = new byte[checked((int)(fileStream.Length - 1L) + 1)];
            fileStream.Read(array, 0, checked((int)fileStream.Length));
            this.SafFS.Write(array, 0, checked((int)fileStream.Length));
            fileStream.Close();
        }

        private void BuildDataFileFromFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            FolderBrowserDialog folderBrowserDialog2 = folderBrowserDialog1;
            folderBrowserDialog2.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog2.SelectedPath = Application.StartupPath + "\\Data\\";
            folderBrowserDialog2.Description = "Select the Data Folder";
            if (folderBrowserDialog2.ShowDialog() != DialogResult.OK)
                return;
            if (!Microsoft.VisualBasic.Strings.LCase(folderBrowserDialog1.SelectedPath).EndsWith("data") && Interaction.MsgBox((object)"You have select a folder that isn't Name Data. Are you sure you want to combine?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Continue?") != MsgBoxResult.Yes || Interaction.MsgBox((object)"Any data in the \"Output\" Folder will be deleted. Continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Information, (object)"Continue?") != MsgBoxResult.Yes)
                return;
            Directory.Delete(Application.StartupPath + "\\Output\\", true);
            Directory.CreateDirectory(Application.StartupPath + "\\Output\\");
            this.MakeSah(new DirectoryInfo(folderBrowserDialog1.SelectedPath));
        }

        private void CreatePatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void RebuildDataFileTS_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox((object)"Are you sure you want to rebuild the Data file?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Rebuild?") != MsgBoxResult.Yes)
                return;
            this.Cursor = Cursors.WaitCursor;
            this.rebuildData();
            this.Cursor = Cursors.Default;
            if (this.canButton)
            {
                if (File.Exists(Module1.sahPath.Replace(".sah", "_new.sah")))
                    File.Delete(Module1.sahPath.Replace(".sah", "_new.sah"));
                if (!File.Exists(Module1.sahPath.Replace(".sah", "_new.saf")))
                    return;
                File.Delete(Module1.sahPath.Replace(".sah", "_new.saf"));
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                if (File.Exists(Module1.sahPath))
                    File.Delete(Module1.sahPath);
                if (File.Exists(Module1.sahPath.Replace(".sah", ".saf")))
                    File.Delete(Module1.sahPath.Replace(".sah", ".saf"));
                File.Move(Module1.sahPath.Replace(".sah", "_new.sah"), Module1.sahPath);
                File.Move(Module1.sahPath.Replace(".sah", "_new.saf"), Module1.sahPath.Replace(".sah", ".saf"));
                this.open();
                this.Cursor = Cursors.Default;
                int num = (int)Interaction.MsgBox((object)"Done.", MsgBoxStyle.OkOnly, (object)null);
            }
        }

        private void btnCloseView_Click()
        {
            this.Size = new Size(365, this.Height);
        }

        private void OpenPatchFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Application.StartupPath + "\\Patch\\");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySettingsProperty.Settings.importedFiles = this.importLog;
            MySettingsProperty.Settings.Save();
            if (this.importLog.Count <= 0 || Interaction.MsgBox((object)"There are items in the import log, would you like to create a patch of the changes?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Make Patch?") != MsgBoxResult.Yes)
                return;
            e.Cancel = true;
            int num = (int)MyProject.Forms.Form6.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\Patch\\"))
                Directory.CreateDirectory(Application.StartupPath + "\\Patch\\");
            if (!Directory.Exists(Application.StartupPath + "\\Data\\"))
                Directory.CreateDirectory(Application.StartupPath + "\\Data\\");
            if (!Directory.Exists(Application.StartupPath + "\\Output\\"))
                Directory.CreateDirectory(Application.StartupPath + "\\Output\\");
            try
            {
                string commandLineArg = MyProject.Application.CommandLineArgs[0];
                if (Operators.CompareString(commandLineArg, "", false) == 0 || !File.Exists(commandLineArg))
                    return;
                Module1.sahPath = commandLineArg;
                this.open();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }

        private void EncryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.Sdata) |*.Sdata|(*.*) |*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK || !Module1.encryptFile(openFileDialog.FileName))
                return;
            int num = (int)Interaction.MsgBox((object)"File encrypted successfully!", MsgBoxStyle.Information, (object)"Done.");
        }

        private void DecryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.Sdata) |*.Sdata|(*.*) |*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK || !Module1.decryptFile(openFileDialog.FileName))
                return;
            int num = (int)Interaction.MsgBox((object)"File decrypted successfully!", MsgBoxStyle.Information, (object)"Done.");
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckBox1.Enabled = !this.CheckBox2.Checked;
            if (Operators.CompareString(this.selNodefile.filePath, "", false) == 0)
                return;
            this.ViewFile(this.selNodefile);
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module1.SAHfile saHfile1 = new Module1.SAHfile();
            Module1.SAHfile saHfile2 = new Module1.SAHfile();
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index1 = num1;
            Module1.SAHfile saHfile3 = default(Module1.SAHfile);
            bool flag = default(bool);
            while (index1 <= num2)
            {
                object file = Module1.files[index1];
                saHfile1 = file != null ? (Module1.SAHfile)file : saHfile3;
                if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, saHfile1.filePath, false) == 0)
                {
                    flag = true;
                    saHfile2 = saHfile1;
                    break;
                }
                checked { ++index1; }
            }
            string Left = Interaction.InputBox("Enter New name.", "New Name.", saHfile1.fileName, -1, -1);
            if (!(Operators.CompareString(Left, "", false) != 0 & Operators.CompareString(Left, saHfile1.fileName, false) != 0 & flag))
                return;
            saHfile1.fileName = Left;
            saHfile1.filePath = saHfile1.dirPath + Left;
            int num3 = 0;
            int num4 = checked(Module1.files.Count - 1);
            int index2 = num3;
            while (index2 <= num4)
            {
                object file = Module1.files[index2];
                if (Operators.CompareString((file != null ? (Module1.SAHfile)file : saHfile3).filePath, saHfile2.filePath, false) == 0)
                {
                    Module1.files[index2] = (object)saHfile1;
                    break;
                }
                checked { ++index2; }
            }
            this.MakeSahFromFiles();
            int num5 = (int)Interaction.MsgBox((object)"File renamed successfully!", MsgBoxStyle.Information, (object)"Success!");
            this.TLabel1.Text = "renamed file: " + saHfile2.fileName + " to: " + Left;
            this.open();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module1.SAHfile saHfile1 = new Module1.SAHfile();
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index = num1;
            bool flag = default(bool);
            while (index <= num2)
            {
                object file = Module1.files[index];
                Module1.SAHfile saHfile2 = default(Module1.SAHfile);
                saHfile1 = file != null ? (Module1.SAHfile)file : saHfile2;
                if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, saHfile1.filePath, false) == 0)
                {
                    flag = true;
                    break;
                }
                checked { ++index; }
            }
            if (!(Interaction.MsgBox((object)("Are you sure you want to delete: " + saHfile1.fileName + "?"), MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Delete") == MsgBoxResult.Yes & flag))
                return;
            Module1.files.Remove((object)saHfile1);
            this.importLog.Remove((object)saHfile1.filePath);
            this.MakeSahFromFiles();
            int num3 = (int)Interaction.MsgBox((object)"File Deleted successfully!", MsgBoxStyle.Information, (object)"Success!");
            this.TLabel1.Text = "deleted file: " + saHfile1.fileName;
            this.open();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = (int)MyProject.Forms.settingForm.ShowDialog();
        }

        private void InTextEditorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.editExt(MySettingsProperty.Settings.txtEditor);
        }

        private void editExt(string extPath)
        {
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index = num1;
            while (index <= num2)
            {
                object file = Module1.files[index];
                Module1.SAHfile saHfile2 = default(Module1.SAHfile);
                Module1.SAHfile iSah = file != null ? (Module1.SAHfile)file : saHfile2;
                if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, iSah.filePath, false) == 0)
                {
                    string tempFile = this.extractTempFile(iSah.offset, (long)iSah.len, iSah.fileName, false);
                    if (Operators.CompareString(tempFile, "", false) != 0)
                    {
                        if (!File.Exists(tempFile))
                            break;
                        DateTime lastWriteTime = File.GetLastWriteTime(tempFile);
                        if (File.Exists(extPath))
                        {
                            Process process = new Process();
                            process.StartInfo.FileName = extPath;
                            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                            process.StartInfo.Arguments = tempFile;
                            process.Start();
                            this.TLabel1.Text = "Waiting on External Editor to close.";
                            while (!process.HasExited)
                                Thread.Sleep(500);
                            if (DateTime.Compare(File.GetLastWriteTime(tempFile), lastWriteTime) > 0 && Interaction.MsgBox((object)"File has changed, would you like to import it back?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Saved?") == MsgBoxResult.Yes)
                                this.import(iSah, tempFile);
                        }
                        File.Delete(tempFile);
                        this.TLabel1.Text = "Done editing file.";
                        break;
                    }
                    int num3 = (int)Interaction.MsgBox((object)"An Error Occured during Extraction.", MsgBoxStyle.Exclamation, (object)"Error");
                    break;
                }
                checked { ++index; }
            }
        }

        private void InHexEditorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.editExt(MySettingsProperty.Settings.hexEditor);
        }

        private void InPhotoEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editExt(MySettingsProperty.Settings.photoEditor);
        }

        private void ImportLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = (int)MyProject.Forms.Form6.ShowDialog();
        }

        private void FromFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            FolderBrowserDialog folderBrowserDialog2 = folderBrowserDialog1;
            folderBrowserDialog2.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog2.SelectedPath = Application.StartupPath + "\\Data\\";
            folderBrowserDialog2.Description = "Select the Data Folder";
            if (folderBrowserDialog2.ShowDialog() != DialogResult.OK)
                return;
            if (!Microsoft.VisualBasic.Strings.LCase(folderBrowserDialog1.SelectedPath).EndsWith("data") && Interaction.MsgBox((object)"You have select a folder that isn't Name Data. Are you sure you want to combine?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Continue?") != MsgBoxResult.Yes)
                return;
            this.makePatch(new DirectoryInfo(folderBrowserDialog1.SelectedPath));
        }

        public void makePatch(DirectoryInfo di)
        {
            if (Interaction.MsgBox((object)"Any data in the \"Output\" Folder will be deleted. Continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Information, (object)"Continue?") != MsgBoxResult.Yes)
                return;
            Directory.Delete(Application.StartupPath + "\\Output\\", true);
            Directory.CreateDirectory(Application.StartupPath + "\\Output\\");
            int num1 = 1;
            while (File.Exists(Application.StartupPath + "\\Patch\\ps" + num1.ToString().PadLeft(4, '0') + ".patch"))
            {
                checked { ++num1; }
                if (num1 > 1000)
                    break;
            }
            string Left;
            while (true)
            {
                Left = Interaction.InputBox("Please Enter the patch number you want to create.", "Patch Numer", num1.ToString(), -1, -1);
                if (Operators.CompareString(Left, "", false) != 0 && Versioned.IsNumeric((object)Left))
                {
                    if (File.Exists(Application.StartupPath + "\\Patch\\ps" + Left.PadLeft(4, '0') + ".patch"))
                    {
                        int num2 = (int)Interaction.MsgBox((object)"Patch Number already exists. Please either Delete the file or Pick a new number.", MsgBoxStyle.Exclamation, (object)"");
                    }
                    else
                        goto label_9;
                }
                else
                    break;
            }
            return;
        label_9:
            this.MakeSah(di);
            MyProject.Computer.FileSystem.RenameFile(Application.StartupPath + "\\Output\\data.sah", "update.sah");
            MyProject.Computer.FileSystem.RenameFile(Application.StartupPath + "\\Output\\data.saf", "update.saf");
            using (ZipFile zipFile = new ZipFile())
            {
                zipFile.AddFile(Application.StartupPath + "\\Output\\update.sah", "");
                zipFile.AddFile(Application.StartupPath + "\\Output\\update.saf", "");
                zipFile.Save(Application.StartupPath + "\\Patch\\ps" + Left.PadLeft(4, '0') + ".patch");
            }
            File.Delete(Application.StartupPath + "\\Output\\update.sah");
            File.Delete(Application.StartupPath + "\\Output\\update.saf");
            int num3 = (int)Interaction.MsgBox((object)"Done.", MsgBoxStyle.OkOnly, (object)null);
        }

        private void CreateFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module1.SAHfile saHfile1 = new Module1.SAHfile();
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index = num1;
            bool flag = default(bool);
            while (index <= num2)
            {
                object file = Module1.files[index];
                Module1.SAHfile saHfile2 = default(Module1.SAHfile);
                saHfile1 = file != null ? (Module1.SAHfile)file : saHfile2;
                if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, saHfile1.filePath, false) == 0)
                {
                    flag = true;
                    break;
                }
                checked { ++index; }
            }
            string Left = Regex.Replace(Interaction.InputBox("Enter folder name.", "Folder Name.", saHfile1.fileName, -1, -1), "[^a-zA-Z0-9]", "");
            if (!(Operators.CompareString(Left, "", false) != 0 & flag))
                return;
            Module1.SAHfile saHfile3 = new Module1.SAHfile();
            saHfile3.dir = true;
            saHfile3.filePath = saHfile1.filePath + "\\" + Left;
            saHfile3.dirPath = saHfile1.filePath + "\\";
            saHfile3.fileName = Left;
            saHfile3.offset = 0UL;
            saHfile3.len = 0;
            Module1.files.Add((object)saHfile3);
            this.MakeSahFromFiles();
            int num3 = (int)Interaction.MsgBox((object)"Folder Created successfully!", MsgBoxStyle.Information, (object)"Success!");
            this.TLabel1.Text = "Folder Created: " + saHfile3.filePath;
            this.open();
        }

        private void DeleteFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module1.SAHfile saHfile1 = new Module1.SAHfile();
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index = num1;
            bool flag = default(bool);
            while (index <= num2)
            {
                object file = Module1.files[index];
                Module1.SAHfile saHfile2 = default(Module1.SAHfile);
                saHfile1 = file != null ? (Module1.SAHfile)file : saHfile2;
                if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, saHfile1.filePath, false) == 0)
                {
                    flag = true;
                    break;
                }
                checked { ++index; }
            }
            if (!(Interaction.MsgBox((object)"Are you sure you want to delete this folder? All subfolders and files will ALSO be DELETED!", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object)"Delete?") == MsgBoxResult.Yes & flag))
                return;
            Module1.files.Remove((object)saHfile1);
            try
            {
                foreach (object obj in this.importLog)
                {
                    string str = Conversions.ToString(obj);
                    if (str.StartsWith(saHfile1.filePath))
                        this.importLog.Remove((object)str);
                }
            }
            finally
            {
                IEnumerator enumerator = default(IEnumerator);
                if (enumerator is IDisposable)
                    (enumerator as IDisposable).Dispose();
            }
            this.MakeSahFromFiles();
            int num3 = (int)Interaction.MsgBox((object)"File Deleted successfully!", MsgBoxStyle.Information, (object)"Success!");
            this.TLabel1.Text = "deleted file: " + saHfile1.fileName;
            this.open();
        }

        private void AddToPatchListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = checked(Module1.files.Count - 1);
            int index = num1;
            while (index <= num2)
            {
                object file = Module1.files[index];
                Module1.SAHfile saHfile1 = default(Module1.SAHfile);
                Module1.SAHfile saHfile2 = file != null ? (Module1.SAHfile)file : saHfile1;
                if (Operators.CompareString(this.TreeView1.SelectedNode.FullPath, saHfile2.filePath, false) == 0 && !saHfile2.dir)
                {
                    if (this.importLog.IndexOf((object)saHfile2.filePath) != -1)
                        break;
                    this.importLog.Add((object)saHfile2.filePath);
                    break;
                }
                checked { ++index; }
            }
        }
    }
}
