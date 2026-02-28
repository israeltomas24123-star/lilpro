using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Shaiya_Data_file_Tool
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tempPath = Path.GetTempPath();
            if (Directory.Exists(tempPath + "Data"))
            {
                Directory.Delete(tempPath + "Data", true);
            }
            checked
            {
                if (this.checkedListBox1.CheckedItems.Count != 0)
                {
                    IEnumerator enumerator = default(IEnumerator);
                    try
                    {
                        enumerator = this.checkedListBox1.CheckedItems.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
                            int num = Module1.files.Count - 1;
                            for (int i = 0; i <= num; i++)
                            {
                                object obj = Module1.files[i];
                                Module1.SAHfile sAHfile = default(Module1.SAHfile);
                                Module1.SAHfile sAHfile2 = (obj != null) ? ((Module1.SAHfile)obj) : sAHfile;
                                if (Operators.CompareString(sAHfile2.filePath, objectValue.ToString(), false) == 0 & !sAHfile2.dir)
                                {
                                    string text = MyProject.Forms.Form1.extractTempFile(sAHfile2.offset, sAHfile2.len, sAHfile2.fileName, true);
                                    if (Operators.CompareString(text, "", false) != 0)
                                    {
                                        Directory.CreateDirectory(tempPath + sAHfile2.dirPath);
                                        File.Move(text, tempPath + sAHfile2.filePath);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                    DirectoryInfo di = new DirectoryInfo(tempPath + "Data");
                    MyProject.Forms.Form1.makePatch(di);
                    IEnumerator enumerator2 = default(IEnumerator);
                    try
                    {
                        enumerator2 = this.checkedListBox1.CheckedItems.GetEnumerator();
                        while (enumerator2.MoveNext())
                        {
                            object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
                            MyProject.Forms.Form1.importLog.Remove(RuntimeHelpers.GetObjectValue(objectValue2));
                        }
                    }
                    finally
                    {
                        if (enumerator2 is IDisposable)
                        {
                            (enumerator2 as IDisposable).Dispose();
                        }
                    }
                    this.checkedListBox1.Items.Clear();
                    int num2 = MyProject.Forms.Form1.importLog.Count - 1;
                    for (int j = 0; j <= num2; j++)
                    {
                        this.checkedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(MyProject.Forms.Form1.importLog[j]), true);
                    }
                    My.MySettings.Default.importedFiles = null;
                    My.MySettingsProperty.Settings.Save();
                }
            }
        }

        private void checkedListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point p = default(Point);
                p.X = e.X;
                p.Y = e.Y;
                this.checkedListBox1.SelectedIndex = this.checkedListBox1.IndexFromPoint(p);
                if (this.checkedListBox1.SelectedIndex == -1)
                {
                    this.checkedListBox1.Enabled = false;
                }
                else
                {
                    this.checkedListBox1.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to clear the list?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Clear?") == MsgBoxResult.Yes)
            {
                MyProject.Forms.Form1.importLog.Clear();
                My.MySettings.Default.importedFiles = null;
                this.checkedListBox1.Items.Clear();
                My.MySettingsProperty.Settings.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.checkedListBox1.Items.Clear();
            checked
            {
                int num = MyProject.Forms.Form1.importLog.Count - 1;
                for (int i = 0; i <= num; i++)
                {
                    checkedListBox1.Items.Add(RuntimeHelpers.GetObjectValue(MyProject.Forms.Form1.importLog[i]), true);
                }
            }
        }
    }
}
