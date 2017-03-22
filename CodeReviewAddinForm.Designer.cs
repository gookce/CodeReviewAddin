using Gtp.Framework.ControlLibrary;

namespace CodeReviewAddin
{
    partial class CodeReviewAddinForm
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
            this.btnSummit = new System.Windows.Forms.Button();
            this.bottumPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bottumPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSummit
            // 
            this.btnSummit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSummit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSummit.Location = new System.Drawing.Point(1119, 16);
            this.btnSummit.Name = "btnSummit";
            this.btnSummit.Size = new System.Drawing.Size(106, 36);
            this.btnSummit.TabIndex = 3;
            this.btnSummit.Text = "Summit";
            this.btnSummit.UseVisualStyleBackColor = true;
            this.btnSummit.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // bottumPanel
            // 
            this.bottumPanel.Controls.Add(this.btnSummit);
            this.bottumPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottumPanel.Location = new System.Drawing.Point(0, 435);
            this.bottumPanel.Name = "bottumPanel";
            this.bottumPanel.Size = new System.Drawing.Size(1237, 64);
            this.bottumPanel.TabIndex = 9;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(1237, 435);
            this.mainPanel.TabIndex = 10;
            // 
            // CodeReviewAddinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1237, 499);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.bottumPanel);
            this.MinimumSize = new System.Drawing.Size(1253, 538);
            this.Name = "CodeReviewAddinForm";
            this.Text = "Code Review Form";
            this.Load += new System.EventHandler(this.CodeReviewAddinForm_Load);
            this.bottumPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSummit;
        private System.Windows.Forms.Panel bottumPanel;
        private System.Windows.Forms.Panel mainPanel;
    }
}