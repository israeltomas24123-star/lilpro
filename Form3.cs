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
    public partial class Form3 : Form
    {
        public int totalf;

        public long totalBytes;

        public long runningBytes;

        private int totaltime;
        public Form3()
        {
            base.FormClosing += this.Form3_FormClosing;
            base.Load += this.Form3_Load;
            this.totalBytes = 1L;
            this.runningBytes = 0L;
            this.totaltime = 0;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double num = checked(totalBytes - runningBytes) * (totaltime / (double)runningBytes);
            this.label4.Text = num.ToString("F") + " Seconds";
            this.totaltime++;

        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.runningBytes = 0L;
            this.totaltime = 0;
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            float num = (float)(runningBytes / (double)totalBytes);
            this.label3.Text = num.ToString("P");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
