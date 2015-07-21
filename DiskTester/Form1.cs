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
        public Form1()
        {
            InitializeComponent();
            // Temporary solution, change this later.
            // ……反正也能用，怕毛……
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(new ThreadStart(speedTest));
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

        public void speedTest()
        {
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
            label3.Text = @"Running...";
            Stopwatch sw = new Stopwatch();

            /* 1KB */
            sw.Start();
            for (uint i = 0; i <= 1023; i++)
            {
                speedWriteRunner(1024, 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 1MB ÷ time = ?
            label4.Text = Convert.ToString((1024.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();

            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            label21.Text = Convert.ToString((1024.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();


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

            /* 2KB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 1023; i++)
            {
                speedWriteRunner(2048, 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 2048KB ÷ time = ?
            label6.Text = Convert.ToString((2048.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();
            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            label20.Text = Convert.ToString((2048.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();

            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            label20.Text = Convert.ToString((2048.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
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
            label8.Text = Convert.ToString((4096.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();

            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            label19.Text = Convert.ToString((4096.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
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
            label10.Text = Convert.ToString((16384.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();


            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            label18.Text = Convert.ToString((16384.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();
 

            /* 1MB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i <= 1023; i++)
            {
                speedWriteRunner(1048576, 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 1GB ÷ time = ?
            label12.Text = Convert.ToString((1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();

            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            label17.Text = Convert.ToString((1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();


            /* 32MB */
            sw.Reset();
            sw.Start();
            for (uint i = 0; i < 32; i++)
            {
                speedWriteRunner((1048576 * 32), 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 1GB ÷ time = ?
            label14.Text = Convert.ToString((1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();

            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            label16.Text = Convert.ToString((1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds))) + "MB/s";
            System.GC.Collect();

            fileList = Directory.GetFiles(DestDisk, "*.tmp");
            
            foreach (string f in fileList)
            {
                File.Delete(f);
            }

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
                stream.Flush(true);
            }
        }


      /*  public void speedReadRunner(string TargetDisk)
        {
            MemoryStream inMemoryCopy = new MemoryStream();
            string[] fileList = Directory.GetFiles(TargetDisk, "*.tmp");
            int fileCount = fileList.Length;
            Parallel.For(0, fileCount, k =>
            {
                   using (FileStream fs = File.OpenRead(fileList[k]))
                   {
                      fs.CopyTo(inMemoryCopy);
                      fs.Flush();
                      fs.Dispose();
                   }
                
            });
             
        } */

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
            
            System.GC.Collect();
        }
   }



}
