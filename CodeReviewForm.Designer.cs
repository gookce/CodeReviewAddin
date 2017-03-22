namespace CodeReviewAddin
{
    partial class CodeReviewForm
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
            this.grQuestions = new Gtp.Framework.ControlLibrary.GridControlGTP();
            this.bottumPanel = new System.Windows.Forms.Panel();
            this.btnSummit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grQuestions)).BeginInit();
            this.bottumPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grQuestions
            // 
            this.grQuestions.BestFitColumns = true;
            this.grQuestions.ColumnAutoWidth = true;
            this.grQuestions.CustomFooterAreaText = null;
            this.grQuestions.CustomHeaderAreaText = null;
            this.grQuestions.CustomHeaderFooter = false;
            this.grQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grQuestions.Location = new System.Drawing.Point(0, 0);
            this.grQuestions.Name = "grQuestions";
            this.grQuestions.ShowDeleteMenuItem = false;
            this.grQuestions.Size = new System.Drawing.Size(1243, 425);
            this.grQuestions.TabIndex = 0;
            // 
            // bottumPanel
            // 
            this.bottumPanel.Controls.Add(this.btnSummit);
            this.bottumPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottumPanel.Location = new System.Drawing.Point(0, 425);
            this.bottumPanel.Name = "bottumPanel";
            this.bottumPanel.Size = new System.Drawing.Size(1243, 64);
            this.bottumPanel.TabIndex = 10;
            // 
            // btnSummit
            // 
            this.btnSummit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSummit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSummit.Location = new System.Drawing.Point(1125, 16);
            this.btnSummit.Name = "btnSummit";
            this.btnSummit.Size = new System.Drawing.Size(106, 36);
            this.btnSummit.TabIndex = 3;
            this.btnSummit.Text = "Summit";
            this.btnSummit.UseVisualStyleBackColor = true;
            // 
            // CodeReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 489);
            this.Controls.Add(this.grQuestions);
            this.Controls.Add(this.bottumPanel);
            this.Name = "CodeReviewForm";
            this.Text = "CodeReviewForm";
            this.Load += new System.EventHandler(this.CodeReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grQuestions)).EndInit();
            this.bottumPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gtp.Framework.ControlLibrary.GridControlGTP grQuestions;
        private System.Windows.Forms.Panel bottumPanel;
        private System.Windows.Forms.Button btnSummit;
    }
}