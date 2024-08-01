
namespace TrioTestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnected = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboPrograms = new System.Windows.Forms.ComboBox();
            this.lblprogName = new System.Windows.Forms.Label();
            this.progTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConnect.Location = new System.Drawing.Point(28, 15);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(156, 49);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.BackColor = System.Drawing.Color.Transparent;
            this.lblConnected.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected.ForeColor = System.Drawing.Color.Red;
            this.lblConnected.Location = new System.Drawing.Point(231, 32);
            this.lblConnected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(117, 19);
            this.lblConnected.TabIndex = 1;
            this.lblConnected.Text = "Not Connected";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(33, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run Program";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboPrograms
            // 
            this.cboPrograms.FormattingEnabled = true;
            this.cboPrograms.Items.AddRange(new object[] {
            "Home",
            "Shake",
            "Fire"});
            this.cboPrograms.Location = new System.Drawing.Point(225, 140);
            this.cboPrograms.Margin = new System.Windows.Forms.Padding(4);
            this.cboPrograms.Name = "cboPrograms";
            this.cboPrograms.Size = new System.Drawing.Size(139, 24);
            this.cboPrograms.TabIndex = 3;
            // 
            // lblprogName
            // 
            this.lblprogName.AutoSize = true;
            this.lblprogName.Location = new System.Drawing.Point(433, 150);
            this.lblprogName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprogName.Name = "lblprogName";
            this.lblprogName.Size = new System.Drawing.Size(91, 17);
            this.lblprogName.TabIndex = 4;
            this.lblprogName.Text = "Running: Idle";
            // 
            // progTimer
            // 
            this.progTimer.Interval = 3000;
            this.progTimer.Tick += new System.EventHandler(this.progTimer_Tick);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDisconnect.Location = new System.Drawing.Point(33, 204);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(150, 42);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(436, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 277);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblprogName);
            this.Controls.Add(this.cboPrograms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.btnConnect);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Trio Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboPrograms;
        private System.Windows.Forms.Label lblprogName;
        private System.Windows.Forms.Timer progTimer;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnExit;
    }
}

