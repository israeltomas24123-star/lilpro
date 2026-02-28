// Decompiled with JetBrains decompiler
// Type: Shaiya_Data_file_Tool.settingForm
// Assembly: Shaiya Data file Tool, Version=1.0.15.0, Culture=neutral, PublicKeyToken=null
// MVID: 9D261911-2ADE-4A78-BB6E-CFFE6F2DCD89
// Assembly location: C:\Users\Totoshka\Desktop\Shaiya Data File Tool\Shaiya Data file Tool.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Shaiya_Data_file_Tool.My;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Shaiya_Data_file_Tool
{
  [DesignerGenerated]
  public class settingForm : Form
  {
    private IContainer components;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("TextBox1")]
    private TextBox _TextBox1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("TextBox2")]
    private TextBox _TextBox2;
    [AccessedThroughProperty("Button2")]
    private Button _Button2;
    [AccessedThroughProperty("Button3")]
    private Button _Button3;
    [AccessedThroughProperty("Button4")]
    private Button _Button4;
    [AccessedThroughProperty("OpenFileDialog1")]
    private OpenFileDialog _OpenFileDialog1;
    [AccessedThroughProperty("Button5")]
    private Button _Button5;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("TextBox3")]
    private TextBox _TextBox3;
    [AccessedThroughProperty("CheckBox1")]
    private CheckBox _CheckBox1;

    [DebuggerNonUserCode]
    public settingForm()
    {
      this.Load += new EventHandler(this.settingForm_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (settingForm));
      this.Button1 = new Button();
      this.TextBox1 = new TextBox();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.TextBox2 = new TextBox();
      this.Button4 = new Button();
      this.OpenFileDialog1 = new OpenFileDialog();
      this.Button3 = new Button();
      this.Button2 = new Button();
      this.Button5 = new Button();
      this.Label3 = new Label();
      this.TextBox3 = new TextBox();
      this.CheckBox1 = new CheckBox();
      this.SuspendLayout();
      this.Button1.DialogResult = DialogResult.Cancel;
      Button button1_1 = this.Button1;
      Point point1 = new Point(287, 149);
      Point point2 = point1;
      button1_1.Location = point2;
      this.Button1.Name = "Button1";
      Button button1_2 = this.Button1;
      Size size1 = new Size(75, 23);
      Size size2 = size1;
      button1_2.Size = size2;
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Cancel";
      this.Button1.UseVisualStyleBackColor = true;
      TextBox textBox1_1 = this.TextBox1;
      point1 = new Point(15, 25);
      Point point3 = point1;
      textBox1_1.Location = point3;
      this.TextBox1.Name = "TextBox1";
      TextBox textBox1_2 = this.TextBox1;
      size1 = new Size(297, 20);
      Size size3 = size1;
      textBox1_2.Size = size3;
      this.TextBox1.TabIndex = 1;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(12, 9);
      Point point4 = point1;
      label1_1.Location = point4;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(102, 13);
      Size size4 = size1;
      label1_2.Size = size4;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "External Text Editor:";
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(12, 53);
      Point point5 = point1;
      label2_1.Location = point5;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(100, 13);
      Size size5 = size1;
      label2_2.Size = size5;
      this.Label2.TabIndex = 4;
      this.Label2.Text = "External Hex Editor:";
      TextBox textBox2_1 = this.TextBox2;
      point1 = new Point(15, 69);
      Point point6 = point1;
      textBox2_1.Location = point6;
      this.TextBox2.Name = "TextBox2";
      TextBox textBox2_2 = this.TextBox2;
      size1 = new Size(297, 20);
      Size size6 = size1;
      textBox2_2.Size = size6;
      this.TextBox2.TabIndex = 3;
      Button button4_1 = this.Button4;
      point1 = new Point(188, 149);
      Point point7 = point1;
      button4_1.Location = point7;
      this.Button4.Name = "Button4";
      Button button4_2 = this.Button4;
      size1 = new Size(93, 23);
      Size size7 = size1;
      button4_2.Size = size7;
      this.Button4.TabIndex = 7;
      this.Button4.Text = "Save and Close";
      this.Button4.UseVisualStyleBackColor = true;
      this.OpenFileDialog1.Filter = "*.Exe | *.exe";
      this.OpenFileDialog1.RestoreDirectory = true;
      this.Button3.Image = (Image) Shaiya_Data_file_Tool.My.Resources.Resources.icon_folder_open;
      Button button3_1 = this.Button3;
      point1 = new Point(319, 69);
      Point point8 = point1;
      button3_1.Location = point8;
      this.Button3.Name = "Button3";
      Button button3_2 = this.Button3;
      size1 = new Size(42, 20);
      Size size8 = size1;
      button3_2.Size = size8;
      this.Button3.TabIndex = 6;
      this.Button3.UseVisualStyleBackColor = true;
      this.Button2.Image = (Image) Shaiya_Data_file_Tool.My.Resources.Resources.icon_folder_open;
      Button button2_1 = this.Button2;
      point1 = new Point(319, 25);
      Point point9 = point1;
      button2_1.Location = point9;
      this.Button2.Name = "Button2";
      Button button2_2 = this.Button2;
      size1 = new Size(42, 20);
      Size size9 = size1;
      button2_2.Size = size9;
      this.Button2.TabIndex = 5;
      this.Button2.UseVisualStyleBackColor = true;
      this.Button5.Image = (Image) Shaiya_Data_file_Tool.My.Resources.Resources.icon_folder_open;
      Button button5_1 = this.Button5;
      point1 = new Point(319, 113);
      Point point10 = point1;
      button5_1.Location = point10;
      this.Button5.Name = "Button5";
      Button button5_2 = this.Button5;
      size1 = new Size(42, 20);
      Size size10 = size1;
      button5_2.Size = size10;
      this.Button5.TabIndex = 10;
      this.Button5.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(12, 97);
      Point point11 = point1;
      label3_1.Location = point11;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(109, 13);
      Size size11 = size1;
      label3_2.Size = size11;
      this.Label3.TabIndex = 9;
      this.Label3.Text = "External Photo Editor:";
      TextBox textBox3_1 = this.TextBox3;
      point1 = new Point(15, 113);
      Point point12 = point1;
      textBox3_1.Location = point12;
      this.TextBox3.Name = "TextBox3";
      TextBox textBox3_2 = this.TextBox3;
      size1 = new Size(297, 20);
      Size size12 = size1;
      textBox3_2.Size = size12;
      this.TextBox3.TabIndex = 8;
      this.CheckBox1.AutoSize = true;
      CheckBox checkBox1_1 = this.CheckBox1;
      point1 = new Point(15, 153);
      Point point13 = point1;
      checkBox1_1.Location = point13;
      this.CheckBox1.Name = "CheckBox1";
      CheckBox checkBox1_2 = this.CheckBox1;
      size1 = new Size(141, 17);
      Size size13 = size1;
      checkBox1_2.Size = size13;
      this.CheckBox1.TabIndex = 11;
      this.CheckBox1.Text = "Associate SAH file types";
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.AcceptButton = (IButtonControl) this.Button4;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Button1;
      size1 = new Size(374, 180);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.CheckBox1);
      this.Controls.Add((Control) this.Button5);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.TextBox3);
      this.Controls.Add((Control) this.Button4);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.TextBox2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.TextBox1);
      this.Controls.Add((Control) this.Button1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (settingForm);
      this.Text = "Setting";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button Button1
    {
      [DebuggerNonUserCode] get
      {
        return this._Button1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual TextBox TextBox1
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox1 = value;
      }
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get
      {
        return this._Label1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get
      {
        return this._Label2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label2 = value;
      }
    }

    internal virtual TextBox TextBox2
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox2 = value;
      }
    }

    internal virtual Button Button2
    {
      [DebuggerNonUserCode] get
      {
        return this._Button2;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._Button2 != null)
          this._Button2.Click -= eventHandler;
        this._Button2 = value;
        if (this._Button2 == null)
          return;
        this._Button2.Click += eventHandler;
      }
    }

    internal virtual Button Button3
    {
      [DebuggerNonUserCode] get
      {
        return this._Button3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        if (this._Button3 != null)
          this._Button3.Click -= eventHandler;
        this._Button3 = value;
        if (this._Button3 == null)
          return;
        this._Button3.Click += eventHandler;
      }
    }

    internal virtual Button Button4
    {
      [DebuggerNonUserCode] get
      {
        return this._Button4;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button4_Click);
        if (this._Button4 != null)
          this._Button4.Click -= eventHandler;
        this._Button4 = value;
        if (this._Button4 == null)
          return;
        this._Button4.Click += eventHandler;
      }
    }

    internal virtual OpenFileDialog OpenFileDialog1
    {
      [DebuggerNonUserCode] get
      {
        return this._OpenFileDialog1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._OpenFileDialog1 = value;
      }
    }

    internal virtual Button Button5
    {
      [DebuggerNonUserCode] get
      {
        return this._Button5;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button5_Click);
        if (this._Button5 != null)
          this._Button5.Click -= eventHandler;
        this._Button5 = value;
        if (this._Button5 == null)
          return;
        this._Button5.Click += eventHandler;
      }
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get
      {
        return this._Label3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual TextBox TextBox3
    {
      [DebuggerNonUserCode] get
      {
        return this._TextBox3;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._TextBox3 = value;
      }
    }

    internal virtual CheckBox CheckBox1
    {
      [DebuggerNonUserCode] get
      {
        return this._CheckBox1;
      }
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._CheckBox1 = value;
      }
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (this.OpenFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.TextBox1.Text = this.OpenFileDialog1.FileName;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      if (this.OpenFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.TextBox2.Text = this.OpenFileDialog1.FileName;
    }

    private void Button4_Click(object sender, EventArgs e)
    {
      MySettingsProperty.Settings.txtEditor = this.TextBox1.Text;
      MySettingsProperty.Settings.hexEditor = this.TextBox2.Text;
      MySettingsProperty.Settings.photoEditor = this.TextBox3.Text;
      MySettingsProperty.Settings.Save();
      try
      {
        if (this.CheckBox1.Checked)
        {
          MyProject.Computer.Registry.ClassesRoot.CreateSubKey(".sah").SetValue("", (object) "sah", RegistryValueKind.String);
          MyProject.Computer.Registry.ClassesRoot.CreateSubKey(".sah\\shell\\open\\command").SetValue("", (object) (Application.ExecutablePath + " \"%l\" "), RegistryValueKind.String);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Error while saving file Type. All other info was saved though.", MsgBoxStyle.OkOnly, (object) null);
        ProjectData.ClearProjectError();
      }
      this.Close();
    }

    private void settingForm_Load(object sender, EventArgs e)
    {
      this.TextBox1.Text = MySettingsProperty.Settings.txtEditor;
      this.TextBox2.Text = MySettingsProperty.Settings.hexEditor;
      this.TextBox3.Text = MySettingsProperty.Settings.photoEditor;
      if (!((IEnumerable<string>) MyProject.Computer.Registry.ClassesRoot.GetSubKeyNames()).Contains<string>(".sah"))
        return;
      this.CheckBox1.Checked = true;
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      if (this.OpenFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.TextBox3.Text = this.OpenFileDialog1.FileName;
    }
  }
}
