﻿using guiNetScanner.scanners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiNetScanner
{
    public partial class Form2 : Form
    {
        string ip;
        public Form2()
        {
            InitializeComponent();
        }

        private void set(string ip, RichTextBox label)
        {
            string info = getInfo.stdInfo(ip);
            label.Invoke(new MethodInvoker(delegate { label.Text = info; }));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Loading IP info for (" + ip + ")... This might take a second.";
            Thread setThread = new Thread(delegate () { set(ip, richTextBox1); });
            setThread.Start();
        }

        public void setIp(string infos)
        {
            ip = infos;
        }

        private void f2Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
