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

            /* 1KB */
            sw.Start();
            for (uint i = 0; i <= 1024; i++)
            {
                const int blockSize = 1024;
                byte[] data = new byte[blockSize];
                using (FileStream stream = File.OpenWrite(DestDisk + "HUDT" + i.ToString() + ".tmp"))
                {
                    // Generate 1024*1KB files, 10MB in total.
                    for (int k = 0; k < 1; k++)
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }
                    
                }

            }
            sw.Stop();
            // 1024KB ÷ time = ?
            label4.Text = Convert.ToString((1024.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();


            /* 2KB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 1024; i++)
            {
                const int blockSize = 2048;
                byte[] data = new byte[blockSize];
                using (FileStream stream = File.OpenWrite(DestDisk + "HUDT" + i.ToString() + ".tmp"))
                {
                    // Generate 1024*2KB files, 2MB in total.
                    for (int k = 0; k < 1; k++)
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }

                }

            }
            sw.Stop();
            // 2048KB ÷ time = ?
            label6.Text = Convert.ToString((2048.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();


            /* 4KB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 1024; i++)
            {
                const int blockSize = 4096;
                byte[] data = new byte[blockSize];
                using (FileStream stream = File.OpenWrite(DestDisk + "HUDT" + i.ToString() + ".tmp"))
                {
                    // Generate 1024*4KB files, 4MB in total.
                    for (int k = 0; k < 1; k++)
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }

                }

            }
            sw.Stop();
            // 4096KB ÷ time = ?
            label8.Text = Convert.ToString((4096.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();

            /* 16KB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 1024; i++)
            {
                const int blockSize = 16384;
                byte[] data = new byte[blockSize];
                using (FileStream stream = File.OpenWrite(DestDisk + "HUDT" + i.ToString() + ".tmp"))
                {
                    // Generate 1024*16KB files, 16MB in total.
                    for (int k = 0; k < 1; k++)
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }

                }

            }
            sw.Stop();
            // 4096KB ÷ time = ?
            label10.Text = Convert.ToString((16384.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();


            /* 1MB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 1024; i++)
            {
                const ulong blockSize = 1048576;
                byte[] data = new byte[blockSize];
                using (FileStream stream = File.OpenWrite(DestDisk + "HUDT" + i.ToString() + ".tmp"))
                {
                    // Generate 1024*1MB files, 1GB in total.
                    for (int k = 0; k < 1; k++)
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }

                }

            }
            sw.Stop();
            // 1GB ÷ time = ?
            label12.Text = Convert.ToString((1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();

            /* 32MB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 32; i++)
            {
                const ulong blockSize = 1048576 * 32;
                byte[] data = new byte[blockSize];
                using (FileStream stream = File.OpenWrite(DestDisk + "HUDT" + i.ToString() + ".tmp"))
                {
                    // Generate 32*32MB files, 1GB in total.
                    for (int k = 0; k < 1; k++)
                    {
                        stream.Write(data, 0, data.Length);
                        stream.Flush();
                    }

                }

            }
            sw.Stop();
            // 1GB ÷ time = ?
            label14.Text = Convert.ToString((1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();

            sw.Reset();
            sw.Start();
            File.Delete(DestDisk);
            sw.Stop();
            label25.Text = Convert.ToString(sw.ElapsedMilliseconds) + "ms";




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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



     
    }
}
