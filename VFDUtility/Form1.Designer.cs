namespace VFDUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trkBrightness = new System.Windows.Forms.TrackBar();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.btnTglConnection = new System.Windows.Forms.Button();
            this.btnSelfTestDisplay = new System.Windows.Forms.Button();
            this.btnClearDisplay = new System.Windows.Forms.Button();
            this.txtLine2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAnnuciatorContainer = new System.Windows.Forms.Panel();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(267, 131);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 43);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trkBrightness);
            this.groupBox1.Controls.Add(this.cmbPorts);
            this.groupBox1.Controls.Add(this.btnTglConnection);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Brightness:";
            // 
            // trkBrightness
            // 
            this.trkBrightness.Location = new System.Drawing.Point(78, 56);
            this.trkBrightness.Maximum = 4;
            this.trkBrightness.Minimum = 1;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Size = new System.Drawing.Size(104, 45);
            this.trkBrightness.TabIndex = 4;
            this.trkBrightness.Value = 4;
            this.trkBrightness.Scroll += new System.EventHandler(this.trkBrightness_Scroll);
            // 
            // cmbPorts
            // 
            this.cmbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(16, 28);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(68, 21);
            this.cmbPorts.TabIndex = 3;
            // 
            // btnTglConnection
            // 
            this.btnTglConnection.Location = new System.Drawing.Point(90, 27);
            this.btnTglConnection.Name = "btnTglConnection";
            this.btnTglConnection.Size = new System.Drawing.Size(84, 23);
            this.btnTglConnection.TabIndex = 2;
            this.btnTglConnection.Text = "Connect";
            this.btnTglConnection.UseVisualStyleBackColor = true;
            this.btnTglConnection.Click += new System.EventHandler(this.btnTglConnection_Click);
            // 
            // btnSelfTestDisplay
            // 
            this.btnSelfTestDisplay.Location = new System.Drawing.Point(267, 180);
            this.btnSelfTestDisplay.Name = "btnSelfTestDisplay";
            this.btnSelfTestDisplay.Size = new System.Drawing.Size(99, 23);
            this.btnSelfTestDisplay.TabIndex = 4;
            this.btnSelfTestDisplay.Text = "Run SelfTest";
            this.btnSelfTestDisplay.UseVisualStyleBackColor = true;
            this.btnSelfTestDisplay.Click += new System.EventHandler(this.btnSelfTest_Click);
            // 
            // btnClearDisplay
            // 
            this.btnClearDisplay.Location = new System.Drawing.Point(267, 209);
            this.btnClearDisplay.Name = "btnClearDisplay";
            this.btnClearDisplay.Size = new System.Drawing.Size(99, 23);
            this.btnClearDisplay.TabIndex = 5;
            this.btnClearDisplay.Text = "Clear Display";
            this.btnClearDisplay.UseVisualStyleBackColor = true;
            this.btnClearDisplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // txtLine2
            // 
            this.txtLine2.BackColor = System.Drawing.Color.Black;
            this.txtLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLine2.ForeColor = System.Drawing.Color.Lime;
            this.txtLine2.Location = new System.Drawing.Point(25, 56);
            this.txtLine2.MaxLength = 20;
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.Size = new System.Drawing.Size(330, 20);
            this.txtLine2.TabIndex = 7;
            this.txtLine2.Text = "Line 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 104);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pnlAnnuciatorContainer
            // 
            this.pnlAnnuciatorContainer.BackColor = System.Drawing.Color.Black;
            this.pnlAnnuciatorContainer.Location = new System.Drawing.Point(30, 93);
            this.pnlAnnuciatorContainer.Name = "pnlAnnuciatorContainer";
            this.pnlAnnuciatorContainer.Size = new System.Drawing.Size(325, 15);
            this.pnlAnnuciatorContainer.TabIndex = 9;
            // 
            // txtLine1
            // 
            this.txtLine1.BackColor = System.Drawing.Color.Black;
            this.txtLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLine1.ForeColor = System.Drawing.Color.Lime;
            this.txtLine1.Location = new System.Drawing.Point(25, 25);
            this.txtLine1.MaxLength = 20;
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.Size = new System.Drawing.Size(330, 20);
            this.txtLine1.TabIndex = 6;
            this.txtLine1.Text = "This is a test yolo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 246);
            this.Controls.Add(this.pnlAnnuciatorContainer);
            this.Controls.Add(this.txtLine2);
            this.Controls.Add(this.txtLine1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClearDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelfTestDisplay);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VFD Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelfTestDisplay;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnTglConnection;
        private System.Windows.Forms.Button btnClearDisplay;
        private System.Windows.Forms.TextBox txtLine2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trkBrightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAnnuciatorContainer;
        private System.Windows.Forms.TextBox txtLine1;
    }
}

