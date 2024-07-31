using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TrioTestApp
{ 
    public partial class Form1 : Form
    {
        bool _TrioConnected = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //# MessageBox.Show("Trio Connected", "Trio Connection", MessageBoxButtons.OK)
            lblConnected.Text = "Connected";
            _TrioConnected = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblConnected.Text = "Not Connected";
            cboPrograms.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_TrioConnected && !progTimer.Enabled)
            {
                lblprogName.Text = "Running: " + cboPrograms.SelectedItem.ToString();
                progTimer.Enabled = true;
            }
        }

        private void progTimer_Tick(object sender, EventArgs e)
        {
            lblprogName.Text = "Running: Idle";
            progTimer.Enabled = false;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (_TrioConnected && !progTimer.Enabled)
            {
                lblConnected.Text = "Not Connected";
                _TrioConnected = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _TrioConnected = false;
            Application.Exit();
        }
    }
}
