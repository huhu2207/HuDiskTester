using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;

namespace DiskTester
{
    public partial class Form1 : Form
    {
        public float gkb1r, gkb1w, gkb2r, gkb2w, gkb4r, gkb4w, gkb16r, gkb16w, gmb1r, gmb1w, gmb16r, gmb16w;

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            // Temporary solution, change this later.
            // ……反正也能用，怕毛……
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(new ThreadStart(speedTestMain));
            thread1.Start();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo DriveName in allDrives)
            {
                comboBox1.Items.Add(DriveName.Name);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            comboBox1.Items.Clear();
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

        public void speedTestMain()
        {
            button1.Enabled = false;
            groupBox1.Enabled = false;
            
            if (Directory.Exists(Environment.CurrentDirectory + @"\temp"))
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
            label3.Text = @"正在跑分!";
            Stopwatch sw = new Stopwatch();

            /* 1KB */
            sw.Start();
            for (uint i = 0; i <= 1023; i++)
            {
                speedWriteRunner(1024, 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 1MB ÷ time = ?
            gkb1w = 1024.0f / Convert.ToSingle(sw.ElapsedMilliseconds);
            label4.Text = Convert.ToString(gkb1w) + "MB/s";



            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            gkb1r = (1024.0f / Convert.ToSingle(sw.ElapsedMilliseconds));
            label21.Text = Convert.ToString(gkb1r) + "MB/s";



            sw.Reset();
            string[] fileList = Directory.GetFiles(DestDisk, "*.tmp");
            sw.Start();
            foreach (string f in fileList)
            {
                File.Delete(f);
            }
            sw.Stop();
            label25.Text = Convert.ToString(Convert.ToSingle(sw.ElapsedMilliseconds) / 1024.0f) + "ms";
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();

            /* 2KB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 1023; i++)
            {
                speedWriteRunner(2048, 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 2048KB ÷ time = ?
            gkb2w = 2048.0f / Convert.ToSingle(sw.ElapsedMilliseconds);
            label6.Text = Convert.ToString(gkb2w) + "MB/s";

            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            gkb2r = 2048.0f / Convert.ToSingle(sw.ElapsedMilliseconds);
            label20.Text = Convert.ToString(gkb2r) + "MB/s";
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();


            /* 4KB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 1023; i++)
            {
                speedWriteRunner(4096, 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 4096KB ÷ time = ?
            gkb4w = 4096.0f / Convert.ToSingle(sw.ElapsedMilliseconds);
            label8.Text = Convert.ToString(gkb4w) + "MB/s";


            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            gkb4r = 4096.0f / Convert.ToSingle(sw.ElapsedMilliseconds);
            label19.Text = Convert.ToString(gkb4r) + "MB/s";
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();


            /* 16KB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 1023; i++)
            {
                speedWriteRunner(16384, 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 16MB ÷ time = ?
            gkb16w = 16384.0f / Convert.ToSingle(sw.ElapsedMilliseconds);
            label10.Text = Convert.ToString(gkb16w) + "MB/s";



            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            gkb16r = 16384.0f / Convert.ToSingle(sw.ElapsedMilliseconds);
            label18.Text = Convert.ToString(gkb16r) + "MB/s";
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();


            /* 1MB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 127; i++)
            {
                speedWriteRunner(1048576, 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 128 * 1MB ÷ time = ?
            gmb1w = (131072.0f / Convert.ToSingle(sw.ElapsedMilliseconds));
            label12.Text = Convert.ToString(gmb1w) + "MB/s";
            System.GC.Collect();

            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            gmb1r = (131072.0f / Convert.ToSingle(sw.ElapsedMilliseconds));
            label17.Text = Convert.ToString(gmb1r) + "MB/s";
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();


            /* 32MB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i < 3; i++)
            {
                speedWriteRunner((1048576 * 32), 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 32MB * 3 ÷ time = ?
            gmb16w = (98300.0f / Convert.ToSingle(sw.ElapsedMilliseconds));
            label14.Text = Convert.ToString(gmb16w) + "MB/s";


            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            gmb16r = (98300.0f / Convert.ToSingle(sw.ElapsedMilliseconds));
            label16.Text = Convert.ToString(gmb16r) + "MB/s";


            fileList = Directory.GetFiles(DestDisk, "*.tmp");

            foreach (string f in fileList)
            {
                File.Delete(f);
            }
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();


            groupBox1.Enabled = true;
            button1.Enabled = true;
            label3.Text = @"跑分完成!";
        }

        public void speedWriteRunner(ulong blockSize, long blockCount, string TargetDisk, string FileName)
        {
            using (FileStream stream = File.OpenWrite(TargetDisk + "HUDT" + FileName + ".tmp"))
            {
                byte[] data = new byte[blockSize];
                Parallel.For(0, blockCount, k =>
                {
                    stream.Write(data, 0, data.Length);
                }
                );
                stream.Flush();
            }
        }


        public void speedReadRunner(string TargetDisk)
        {
            string[] fileList = Directory.GetFiles(TargetDisk, @"*.tmp");
            Parallel.For(0, fileList.Length, k =>
            {
                using (FileStream fs = File.Open(fileList[k], FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                    }
                }

            });

            // Get rid of unnecessary memory uses.
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();
        }


        

    }



}