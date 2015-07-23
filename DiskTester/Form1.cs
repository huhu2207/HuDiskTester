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
            groupBox11.Enabled = false;
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
            groupBox11.Enabled = false;
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
            label3.Text = @"正在跑分……";
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
            for (uint i = 0; i <= 1023; i++)
            {
                speedWriteRunner(1048576, 1, DestDisk, i.ToString());
            }
            sw.Stop();
            // 1GB ÷ time = ?
            gmb1w = (1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds));
            label12.Text = Convert.ToString(gmb1w) + "MB/s";
            System.GC.Collect();

            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            gmb1r = (1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds));
            label17.Text = Convert.ToString(gmb1r) + "MB/s";
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
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
            gmb16w = (1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds));
            label14.Text = Convert.ToString(gmb16w) + "MB/s";
            

            sw.Reset();
            sw.Start();
            speedReadRunner(DestDisk);
            sw.Stop();
            gmb16r = (1048576.0f / Convert.ToSingle(sw.ElapsedMilliseconds));
            label16.Text = Convert.ToString(gmb16r) + "MB/s";
            

            fileList = Directory.GetFiles(DestDisk, "*.tmp");
            
            foreach (string f in fileList)
            {
                File.Delete(f);
            }
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();

            // Output the chart
            ChartMaker();

            groupBox11.Enabled = true;
            groupBox1.Enabled = true;
            button1.Enabled = true;
            label3.Text = @"跑分完成！";
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

        
        public void ChartMaker()
        {
            float step = 73;
            float[] speedTotal = new float[] {gkb1r,gkb1w,gkb2r,gkb2w,gkb4r,gkb4w,gkb16r,gkb16w,gmb1r,gmb1w,gmb16r,gmb16w};
            long maxSpeed = Convert.ToInt64(speedTotal.Max());
           

            if (maxSpeed >= 0 && maxSpeed <= 10)
            {
                label5.Text = "1";
                label7.Text = "2";
                label9.Text = "3";
                label11.Text = "4";
                label13.Text = "5";
                label15.Text = "6";
                label30.Text = "7";
                label37.Text = "8";
                label38.Text = "9";
                step = 86f;
            }
            else
            {
                if (maxSpeed > 10 && maxSpeed < 20)
                {
                    label5.Text = "2";
                    label7.Text = "4";
                    label9.Text = "6";
                    label11.Text = "8";
                    label13.Text = "10";
                    label15.Text = "12";
                    label30.Text = "14";
                    label37.Text = "16";
                    label38.Text = "18";
                    step = (86f / 2f);
                }
                else if (maxSpeed > 20 && maxSpeed <= 40)
                {
                        label5.Text = "4";
                        label7.Text = "8";
                        label9.Text = "12";
                        label11.Text = "16";
                        label13.Text = "20";
                        label15.Text = "24";
                        label30.Text = "28";
                        label37.Text = "32";
                        label38.Text = "36";
                    step = (86f / 4f);
                }
                 else  if (maxSpeed > 40 && maxSpeed <= 80)
                 {
                            label5.Text = "8";
                            label7.Text = "16";
                            label9.Text = "24";
                            label11.Text = "32";
                            label13.Text = "40";
                            label15.Text = "48";
                            label30.Text = "56";
                            label37.Text = "64";
                            label38.Text = "72";
                    step = (86 / 8f);
                }
                else if (maxSpeed > 80 && maxSpeed <= 160)
                {
                           label5.Text = "16";
                           label7.Text = "32";
                           label9.Text = "48";
                           label11.Text = "64";
                           label13.Text = "80";
                           label15.Text = "96";
                           label30.Text = "112";
                           label37.Text = "128";
                           label38.Text = "134";
                    step = (86f / 16f);
                }
                else if (maxSpeed > 160 && maxSpeed <= 320)
                {
                    label5.Text = "32";
                    label7.Text = "64";
                    label9.Text = "96";
                    label11.Text = "128";
                    label13.Text = "160";
                    label15.Text = "192";
                    label30.Text = "224";
                    label37.Text = "256";
                    label38.Text = "288";
                    step = (86 / 32f);
                }
                else if (maxSpeed > 320)
                {
                    label5.Text = "64";
                    label7.Text = "128";
                    label9.Text = "192";
                    label11.Text = "256";
                    label13.Text = "320";
                    label15.Text = "384";
                    label30.Text = "448";
                    label37.Text = "512";
                    label38.Text = "576";
                    step = (86f / 64f);
                }
                    
                
            }
            pictureBox2.Height = Convert.ToInt32(gkb1w * step);
            pictureBox3.Height = Convert.ToInt32(gkb1r * step);
            pictureBox7.Height = Convert.ToInt32(gkb2w * step);
            pictureBox6.Height = Convert.ToInt32(gkb2r * step);
            pictureBox5.Height = Convert.ToInt32(gkb4w * step);
            pictureBox4.Height = Convert.ToInt32(gkb4r * step);
            pictureBox9.Height = Convert.ToInt32(gkb16w * step);
            pictureBox8.Height = Convert.ToInt32(gkb16r * step);
            pictureBox11.Height = Convert.ToInt32(gmb1w * step);
            pictureBox10.Height = Convert.ToInt32(gmb1r * step);
            pictureBox13.Height = Convert.ToInt32(gmb16w * step);
            pictureBox12.Height = Convert.ToInt32(gmb16r * step);
            System.GC.Collect();
        }
        
        
   }

    

}
