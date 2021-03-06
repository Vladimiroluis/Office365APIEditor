﻿namespace Office365APIEditor
{
    partial class AcquireViewerTokenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcquireViewerTokenForm));
            this.textBox_ClientID = new System.Windows.Forms.TextBox();
            this.button_AcquireAccessToken = new System.Windows.Forms.Button();
            this.button1_Cancel = new System.Windows.Forms.Button();
            this.linkLabel_Portal = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_ClientID
            // 
            this.textBox_ClientID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Office365APIEditor.Properties.Settings.Default, "LastMailboxViewerClientID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_ClientID.Location = new System.Drawing.Point(74, 38);
            this.textBox_ClientID.Name = "textBox_ClientID";
            this.textBox_ClientID.Size = new System.Drawing.Size(224, 20);
            this.textBox_ClientID.TabIndex = 1;
            this.textBox_ClientID.Text = global::Office365APIEditor.Properties.Settings.Default.LastMailboxViewerClientID;
            // 
            // button_AcquireAccessToken
            // 
            this.button_AcquireAccessToken.Location = new System.Drawing.Point(435, 66);
            this.button_AcquireAccessToken.Name = "button_AcquireAccessToken";
            this.button_AcquireAccessToken.Size = new System.Drawing.Size(75, 23);
            this.button_AcquireAccessToken.TabIndex = 2;
            this.button_AcquireAccessToken.Text = "OK";
            this.button_AcquireAccessToken.UseVisualStyleBackColor = true;
            this.button_AcquireAccessToken.Click += new System.EventHandler(this.button_AcquireAccessToken_Click);
            // 
            // button1_Cancel
            // 
            this.button1_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1_Cancel.Location = new System.Drawing.Point(516, 66);
            this.button1_Cancel.Name = "button1_Cancel";
            this.button1_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button1_Cancel.TabIndex = 3;
            this.button1_Cancel.Text = "Cancel";
            this.button1_Cancel.UseVisualStyleBackColor = true;
            // 
            // linkLabel_Portal
            // 
            this.linkLabel_Portal.AutoSize = true;
            this.linkLabel_Portal.Location = new System.Drawing.Point(12, 9);
            this.linkLabel_Portal.Name = "linkLabel_Portal";
            this.linkLabel_Portal.Size = new System.Drawing.Size(530, 13);
            this.linkLabel_Portal.TabIndex = 4;
            this.linkLabel_Portal.TabStop = true;
            this.linkLabel_Portal.Text = "Enter the Client ID of your application which registered in Application Registrat" +
    "ion Portal as a mobile application.";
            this.linkLabel_Portal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Portal_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client ID : ";
            // 
            // AcquireViewerTokenForm
            // 
            this.AcceptButton = this.button_AcquireAccessToken;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1_Cancel;
            this.ClientSize = new System.Drawing.Size(603, 101);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_Portal);
            this.Controls.Add(this.button1_Cancel);
            this.Controls.Add(this.button_AcquireAccessToken);
            this.Controls.Add(this.textBox_ClientID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcquireViewerTokenForm";
            this.Text = "Client ID Setting";
            this.Load += new System.EventHandler(this.AcquireViewerTokenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_ClientID;
        private System.Windows.Forms.Button button_AcquireAccessToken;
        private System.Windows.Forms.Button button1_Cancel;
        private System.Windows.Forms.LinkLabel linkLabel_Portal;
        private System.Windows.Forms.Label label1;
    }
}