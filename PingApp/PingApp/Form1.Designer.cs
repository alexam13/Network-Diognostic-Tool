namespace PingApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.status = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.defaultGateway = new System.Windows.Forms.Label();
            this.dgLabel = new System.Windows.Forms.Label();
            this.subnetMask = new System.Windows.Forms.Label();
            this.subnetLabel = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dnsName = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ping";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter IP Address here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unknown";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(455, 399);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dnsName);
            this.tabPage1.Controls.Add(this.status);
            this.tabPage1.Controls.Add(this.statusLabel);
            this.tabPage1.Controls.Add(this.defaultGateway);
            this.tabPage1.Controls.Add(this.dgLabel);
            this.tabPage1.Controls.Add(this.subnetMask);
            this.tabPage1.Controls.Add(this.subnetLabel);
            this.tabPage1.Controls.Add(this.ipAddress);
            this.tabPage1.Controls.Add(this.ipLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(447, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Network Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(6, 139);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(79, 13);
            this.status.TabIndex = 9;
            this.status.Text = "Not Connected";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 126);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status";
            // 
            // defaultGateway
            // 
            this.defaultGateway.AutoSize = true;
            this.defaultGateway.Location = new System.Drawing.Point(6, 96);
            this.defaultGateway.Name = "defaultGateway";
            this.defaultGateway.Size = new System.Drawing.Size(40, 13);
            this.defaultGateway.TabIndex = 7;
            this.defaultGateway.Text = "0.0.0.0";
            // 
            // dgLabel
            // 
            this.dgLabel.AutoSize = true;
            this.dgLabel.Location = new System.Drawing.Point(6, 83);
            this.dgLabel.Name = "dgLabel";
            this.dgLabel.Size = new System.Drawing.Size(86, 13);
            this.dgLabel.TabIndex = 5;
            this.dgLabel.Text = "Default Gateway";
            // 
            // subnetMask
            // 
            this.subnetMask.AutoSize = true;
            this.subnetMask.Location = new System.Drawing.Point(6, 53);
            this.subnetMask.Name = "subnetMask";
            this.subnetMask.Size = new System.Drawing.Size(88, 13);
            this.subnetMask.TabIndex = 6;
            this.subnetMask.Text = "255.255.255.255";
            // 
            // subnetLabel
            // 
            this.subnetLabel.AutoSize = true;
            this.subnetLabel.Location = new System.Drawing.Point(6, 40);
            this.subnetLabel.Name = "subnetLabel";
            this.subnetLabel.Size = new System.Drawing.Size(70, 13);
            this.subnetLabel.TabIndex = 6;
            this.subnetLabel.Text = "Subnet Mask";
            // 
            // ipAddress
            // 
            this.ipAddress.AutoSize = true;
            this.ipAddress.Location = new System.Drawing.Point(6, 16);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(40, 13);
            this.ipAddress.TabIndex = 5;
            this.ipAddress.Text = "0.0.0.0";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(6, 3);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(58, 13);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP Address";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(447, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ping";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dnsName
            // 
            this.dnsName.AutoSize = true;
            this.dnsName.Location = new System.Drawing.Point(6, 176);
            this.dnsName.Name = "dnsName";
            this.dnsName.Size = new System.Drawing.Size(35, 13);
            this.dnsName.TabIndex = 10;
            this.dnsName.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 423);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Network GUI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label defaultGateway;
        private System.Windows.Forms.Label dgLabel;
        private System.Windows.Forms.Label subnetMask;
        private System.Windows.Forms.Label subnetLabel;
        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label dnsName;
    }
}

