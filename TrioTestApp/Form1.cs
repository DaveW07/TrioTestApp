﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrioTestApp
{ 
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trio Connected", "Trio Connection", MessageBoxButtons.OK);
            lblConnected.Text = "Connected";
        }
    }
}
