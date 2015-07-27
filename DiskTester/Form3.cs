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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonStart2_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            comboBoxDest2.Items.Clear();
            foreach (DriveInfo DriveName in allDrives)
            {
                comboBoxDest2.Items.Add(DriveName.Name);
            }
        }

        private void buttonRefresh2_Click(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            comboBoxDest2.Items.Clear();
            foreach (DriveInfo DriveName in allDrives)
            {
                comboBoxDest2.Items.Add(DriveName.Name);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            comboBoxDest2.Items.Clear();
            foreach (DriveInfo DriveName in allDrives)
            {
                comboBoxDest2.Items.Add(DriveName.Name);
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
                stream.Flush();
            }
        }
    }
}
