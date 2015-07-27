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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo DriveName in allDrives)
            {
                comboBoxDest.Items.Add(DriveName.Name);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            comboBoxDest.Items.Clear();
            foreach (DriveInfo DriveName in allDrives)
            {
                comboBoxDest.Items.Add(DriveName.Name);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

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
    }
}
