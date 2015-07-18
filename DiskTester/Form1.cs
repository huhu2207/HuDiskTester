using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;

namespace DiskTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Environment.CurrentDirectory+@"\temp"))
            {
                //If directory exists, then do nothing.
            }
            else
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\temp");
            } 

            String DestDisk = comboBox1.Text + @"HuDiskTesterTemp\";
            if (Directory.Exists(DestDisk))
            {
                //If directory exists, then do nothing.
            }
            else
            {
                Directory.CreateDirectory(DestDisk);
            }
            label3.Text = @"Running...";
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (uint i = 0; i <= 1024; i++)
            {
                const int blockSize = 1024;
                byte[] data = new byte[blockSize];
                using (FileStream stream = File.OpenWrite(DestDisk + "HU1KB" + i.ToString() + ".tmp"))
                {
                    // Generate 1024 1KB files, 10MB in total.
                    for (int k = 0; k < 1; k++)
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }
                    
                }

            }
            sw.Stop();
            // 1024KB ÷ 1000ms = ?
            label4.Text = Convert.ToString((1024.0d / Convert.ToDouble(sw.ElapsedMilliseconds)));


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach(DriveInfo DriveName in allDrives) {
                comboBox1.Items.Add(DriveName.Name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo DriveName in allDrives)
            {
                comboBox1.Items.Add(DriveName.Name);
            }
        }
    }
}
