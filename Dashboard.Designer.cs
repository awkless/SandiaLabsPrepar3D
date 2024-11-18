// Copyright (c) 2010-2022 Lockheed Martin Corporation. All rights reserved.
// Use of this file is bound by the PREPAR3D® SOFTWARE DEVELOPER KIT END USER LICENSE AGREEMENT

using System.Windows.Forms;

namespace Managed_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.toggleButton = new System.Windows.Forms.Button();
            this.collapsiblePanel = new System.Windows.Forms.Panel();
            this.buttonTestReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // buttonTestReport 
            this.buttonTestReport.Location = new System.Drawing.Point(653, 12);
            this.buttonTestReport.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTestReport.Name = "buttonTestReport";
            this.buttonTestReport.Size = new System.Drawing.Size(200, 47);
            this.buttonTestReport.TabIndex = 3;
            this.buttonTestReport.Text = "Generate Test Report";
            this.buttonTestReport.UseVisualStyleBackColor = true;
            this.buttonTestReport.Click += new System.EventHandler(this.buttonTestReport_Click);

            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(13, 12);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(5);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(200, 47);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect to P3D";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(227, 12);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(200, 47);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect from P3D";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(440, 12);
            this.toggleButton.Margin = new System.Windows.Forms.Padding(5);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(200, 47);
            this.toggleButton.TabIndex = 2;
            this.toggleButton.Text = "Hide dashboard";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.TogglePanelsButton_Click);
            // 
            // collapsiblePanel
            // 
            this.collapsiblePanel.Location = new System.Drawing.Point(546, 167);
            this.collapsiblePanel.Margin = new System.Windows.Forms.Padding(4);
            this.collapsiblePanel.Name = "collapsiblePanel";
            this.collapsiblePanel.Size = new System.Drawing.Size(267, 123);
            this.collapsiblePanel.TabIndex = 0;
            this.collapsiblePanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::ManagedDashboard.Properties.Resources.GForceRed;
            this.pictureBox1.Image = global::ManagedDashboard.Properties.Resources.GForceGreen;
            this.pictureBox1.Location = new System.Drawing.Point(854, 670);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LocationChanged += new System.EventHandler(this.pictureBox1_LocationChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 985);
            this.Controls.Add(this.buttonTestReport);
            this.ClientSize = new System.Drawing.Size(1030, 800);
            this.ClientSize = new System.Drawing.Size(1030, 800);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.collapsiblePanel);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Managed Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;

        private System.Windows.Forms.Panel collapsiblePanel;
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.Button buttonTestReport;
        private PictureBox pictureBox1;
    }
}

