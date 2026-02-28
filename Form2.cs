using Microsoft.VisualBasic.CompilerServices;
using Shaiya_Data_file_Tool.My;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Shaiya_Data_file_Tool.My
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label3.Text = MyProject.Application.Info.Version.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
