namespace CodeReviewAddin
{
    partial class CodeReviewQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbQuestion = new Gtp.Framework.ControlLibrary.GroupBox();
            this.txInfo = new Gtp.Framework.ControlLibrary.TextEdit();
            this.lbInfo = new Gtp.Framework.ControlLibrary.Label();
            this.rbNo = new Gtp.Framework.ControlLibrary.RadioButton();
            this.rbYes = new Gtp.Framework.ControlLibrary.RadioButton();
            this.gbQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txInfo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQuestion
            // 
            this.gbQuestion.AutoSize = true;
            this.gbQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbQuestion.Controls.Add(this.txInfo);
            this.gbQuestion.Controls.Add(this.lbInfo);
            this.gbQuestion.Controls.Add(this.rbNo);
            this.gbQuestion.Controls.Add(this.rbYes);
            this.gbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQuestion.Location = new System.Drawing.Point(0, 0);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(1133, 54);
            this.gbQuestion.TabIndex = 6;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "gbQuestion";
            // 
            // txInfo
            // 
            this.txInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txInfo.Location = new System.Drawing.Point(212, 22);
            this.txInfo.Name = "txInfo";
            this.txInfo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txInfo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.txInfo.Properties.Appearance.Options.UseBackColor = true;
            this.txInfo.Properties.Appearance.Options.UseForeColor = true;
            this.txInfo.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txInfo.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txInfo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txInfo.Size = new System.Drawing.Size(901, 22);
            this.txInfo.TabIndex = 6;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = false;
            this.lbInfo.Location = new System.Drawing.Point(144, 26);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(59, 13);
            this.lbInfo.Style = Gtp.Framework.ControlLibrary.LabelStyle.Default;
            this.lbInfo.TabIndex = 5;
            this.lbInfo.Text = "Açıklama : ";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(78, 24);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(49, 17);
            this.rbNo.TabIndex = 4;
            this.rbNo.Text = "Hayır";
            this.rbNo.UseVisualStyleBackColor = false;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(15, 24);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(47, 17);
            this.rbYes.TabIndex = 3;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Evet";
            this.rbYes.UseVisualStyleBackColor = false;
            // 
            // CodeReviewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbQuestion);
            this.Name = "CodeReviewQuestion";
            this.Size = new System.Drawing.Size(1133, 54);
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txInfo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gtp.Framework.ControlLibrary.GroupBox gbQuestion;
        private Gtp.Framework.ControlLibrary.TextEdit txInfo;
        private Gtp.Framework.ControlLibrary.Label lbInfo;
        private Gtp.Framework.ControlLibrary.RadioButton rbNo;
        private Gtp.Framework.ControlLibrary.RadioButton rbYes;

    }
}
