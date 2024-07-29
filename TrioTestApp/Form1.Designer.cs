
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
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConnect.Location = new System.Drawing.Point(21, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 40);
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
            this.lblConnected.Location = new System.Drawing.Point(173, 26);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(102, 16);
            this.lblConnected.TabIndex = 1;
            this.lblConnected.Text = "Not Connected";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(25, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
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
            this.cboPrograms.Location = new System.Drawing.Point(169, 114);
            this.cboPrograms.Name = "cboPrograms";
            this.cboPrograms.Size = new System.Drawing.Size(105, 21);
            this.cboPrograms.TabIndex = 3;
            // 
            // lblprogName
            // 
            this.lblprogName.AutoSize = true;
            this.lblprogName.Location = new System.Drawing.Point(325, 122);
            this.lblprogName.Name = "lblprogName";
            this.lblprogName.Size = new System.Drawing.Size(70, 13);
            this.lblprogName.TabIndex = 4;
            this.lblprogName.Text = "Running: Idle";
            // 
            // progTimer
            // 
            this.progTimer.Interval = 3000;
            this.progTimer.Tick += new System.EventHandler(this.progTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 217);
            this.Controls.Add(this.lblprogName);
            this.Controls.Add(this.cboPrograms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.btnConnect);
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
    }
}

