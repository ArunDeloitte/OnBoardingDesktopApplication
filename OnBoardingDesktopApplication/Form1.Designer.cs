namespace OnBoardingDesktopApplication
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.bTNsEARCH = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.pnlGur = new System.Windows.Forms.Panel();
            this.pnlMum = new System.Windows.Forms.Panel();
            this.pnlBlr = new System.Windows.Forms.Panel();
            this.pnlHyd = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(29)))), ((int)(((byte)(93)))));
            this.pnlHeader.Controls.Add(this.pnlLogo);
            this.pnlHeader.Controls.Add(this.btnLogOff);
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Location = new System.Drawing.Point(2, -1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1272, 78);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(210)))), ((int)(((byte)(1)))));
            this.btnLogOff.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOff.Location = new System.Drawing.Point(1145, 3);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(105, 30);
            this.btnLogOff.TabIndex = 2;
            this.btnLogOff.Text = "LogOff";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(1044, 51);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(109, 27);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Something";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(29)))), ((int)(((byte)(93)))));
            this.pnlNavigation.Controls.Add(this.btnReport);
            this.pnlNavigation.Controls.Add(this.bTNsEARCH);
            this.pnlNavigation.Controls.Add(this.btnOverview);
            this.pnlNavigation.Location = new System.Drawing.Point(2, 74);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(209, 595);
            this.pnlNavigation.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(29)))), ((int)(((byte)(93)))));
            this.btnReport.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(0, 106);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(197, 36);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // bTNsEARCH
            // 
            this.bTNsEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(29)))), ((int)(((byte)(93)))));
            this.bTNsEARCH.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTNsEARCH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bTNsEARCH.Location = new System.Drawing.Point(0, 64);
            this.bTNsEARCH.Name = "bTNsEARCH";
            this.bTNsEARCH.Size = new System.Drawing.Size(197, 36);
            this.bTNsEARCH.TabIndex = 1;
            this.bTNsEARCH.Text = "Search";
            this.bTNsEARCH.UseVisualStyleBackColor = false;
            this.bTNsEARCH.Click += new System.EventHandler(this.bTNsEARCH_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(29)))), ((int)(((byte)(93)))));
            this.btnOverview.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOverview.Location = new System.Drawing.Point(0, 22);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(197, 36);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.pnlGur);
            this.pnlOverview.Controls.Add(this.pnlMum);
            this.pnlOverview.Controls.Add(this.pnlBlr);
            this.pnlOverview.Controls.Add(this.pnlHyd);
            this.pnlOverview.Location = new System.Drawing.Point(217, 83);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(1035, 586);
            this.pnlOverview.TabIndex = 2;
            // 
            // pnlGur
            // 
            this.pnlGur.Location = new System.Drawing.Point(537, 311);
            this.pnlGur.Name = "pnlGur";
            this.pnlGur.Size = new System.Drawing.Size(493, 251);
            this.pnlGur.TabIndex = 2;
            // 
            // pnlMum
            // 
            this.pnlMum.Location = new System.Drawing.Point(12, 311);
            this.pnlMum.Name = "pnlMum";
            this.pnlMum.Size = new System.Drawing.Size(511, 251);
            this.pnlMum.TabIndex = 1;
            // 
            // pnlBlr
            // 
            this.pnlBlr.Location = new System.Drawing.Point(537, 29);
            this.pnlBlr.Name = "pnlBlr";
            this.pnlBlr.Size = new System.Drawing.Size(493, 251);
            this.pnlBlr.TabIndex = 1;
            // 
            // pnlHyd
            // 
            this.pnlHyd.Location = new System.Drawing.Point(12, 29);
            this.pnlHyd.Name = "pnlHyd";
            this.pnlHyd.Size = new System.Drawing.Size(511, 251);
            this.pnlHyd.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::OnBoardingDesktopApplication.Properties.Resources.logowhite;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Location = new System.Drawing.Point(10, 13);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(168, 44);
            this.pnlLogo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.Text = "Welcome2Deloitte";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button bTNsEARCH;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Panel pnlBlr;
        private System.Windows.Forms.Panel pnlHyd;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlGur;
        private System.Windows.Forms.Panel pnlMum;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Panel pnlLogo;
    }
}

