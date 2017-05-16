namespace BasicPCClean
{
    partial class frmMain
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
            this.btnRemoveTemp = new System.Windows.Forms.Button();
            this.btnResetIE = new System.Windows.Forms.Button();
            this.btnResetCCChrome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveTemp
            // 
            this.btnRemoveTemp.Location = new System.Drawing.Point(13, 13);
            this.btnRemoveTemp.Name = "btnRemoveTemp";
            this.btnRemoveTemp.Size = new System.Drawing.Size(259, 88);
            this.btnRemoveTemp.TabIndex = 0;
            this.btnRemoveTemp.Text = "Remove Temporary Files";
            this.btnRemoveTemp.UseVisualStyleBackColor = true;
            this.btnRemoveTemp.Click += new System.EventHandler(this.btnRemoveTemp_Click);
            // 
            // btnResetIE
            // 
            this.btnResetIE.Location = new System.Drawing.Point(13, 107);
            this.btnResetIE.Name = "btnResetIE";
            this.btnResetIE.Size = new System.Drawing.Size(259, 88);
            this.btnResetIE.TabIndex = 1;
            this.btnResetIE.Text = "Reset Internet Explorer";
            this.btnResetIE.UseVisualStyleBackColor = true;
            this.btnResetIE.Click += new System.EventHandler(this.btnResetIE_Click);
            // 
            // btnResetCCChrome
            // 
            this.btnResetCCChrome.Location = new System.Drawing.Point(13, 201);
            this.btnResetCCChrome.Name = "btnResetCCChrome";
            this.btnResetCCChrome.Size = new System.Drawing.Size(259, 88);
            this.btnResetCCChrome.TabIndex = 2;
            this.btnResetCCChrome.Text = "Reset Cache and Cookies in Chrome";
            this.btnResetCCChrome.UseVisualStyleBackColor = true;
            this.btnResetCCChrome.Click += new System.EventHandler(this.btnResetCCChrome_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 303);
            this.Controls.Add(this.btnResetCCChrome);
            this.Controls.Add(this.btnResetIE);
            this.Controls.Add(this.btnRemoveTemp);
            this.MaximumSize = new System.Drawing.Size(300, 342);
            this.MinimumSize = new System.Drawing.Size(300, 342);
            this.Name = "frmMain";
            this.Text = "Basic PC Clean";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveTemp;
        private System.Windows.Forms.Button btnResetIE;
        private System.Windows.Forms.Button btnResetCCChrome;
    }
}

