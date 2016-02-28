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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlOverview.SuspendLayout();
            this.pnlHyd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(75)))), ((int)(((byte)(147)))));
            this.pnlHeader.Controls.Add(this.btnLogOff);
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.pnlLogo);
            this.pnlHeader.Location = new System.Drawing.Point(2, -1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(774, 64);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(582, 37);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(109, 27);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Something";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(75)))), ((int)(((byte)(147)))));
            this.pnlNavigation.Controls.Add(this.btnReport);
            this.pnlNavigation.Controls.Add(this.bTNsEARCH);
            this.pnlNavigation.Controls.Add(this.btnOverview);
            this.pnlNavigation.Location = new System.Drawing.Point(2, 61);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(197, 376);
            this.pnlNavigation.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(75)))), ((int)(((byte)(147)))));
            this.btnReport.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bTNsEARCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(75)))), ((int)(((byte)(147)))));
            this.bTNsEARCH.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(75)))), ((int)(((byte)(147)))));
            this.btnOverview.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlOverview.Location = new System.Drawing.Point(205, 69);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(559, 356);
            this.pnlOverview.TabIndex = 2;
            // 
            // pnlGur
            // 
            this.pnlGur.Location = new System.Drawing.Point(279, 184);
            this.pnlGur.Name = "pnlGur";
            this.pnlGur.Size = new System.Drawing.Size(261, 151);
            this.pnlGur.TabIndex = 2;
            // 
            // pnlMum
            // 
            this.pnlMum.Location = new System.Drawing.Point(12, 184);
            this.pnlMum.Name = "pnlMum";
            this.pnlMum.Size = new System.Drawing.Size(261, 151);
            this.pnlMum.TabIndex = 1;
            // 
            // pnlBlr
            // 
            this.pnlBlr.Location = new System.Drawing.Point(279, 14);
            this.pnlBlr.Name = "pnlBlr";
            this.pnlBlr.Size = new System.Drawing.Size(261, 151);
            this.pnlBlr.TabIndex = 1;
            // 
            // pnlHyd
            // 
            this.pnlHyd.Controls.Add(this.label1);
            this.pnlHyd.Location = new System.Drawing.Point(12, 14);
            this.pnlHyd.Name = "pnlHyd";
            this.pnlHyd.Size = new System.Drawing.Size(261, 151);
            this.pnlHyd.TabIndex = 0;
            this.pnlHyd.Click += new System.EventHandler(this.pnlHyd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(75)))), ((int)(((byte)(147)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banglore Report";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::OnBoardingDesktopApplication.Properties.Resources.logowhite;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Location = new System.Drawing.Point(0, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(197, 62);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnLogOff
            // 
            this.btnLogOff.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOff.Location = new System.Drawing.Point(638, 4);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(105, 30);
            this.btnLogOff.TabIndex = 2;
            this.btnLogOff.Text = "LogOff";
            this.btnLogOff.UseVisualStyleBackColor = false;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(776, 465);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.Text = "Welcome2Deloitte";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlOverview.ResumeLayout(false);
            this.pnlHyd.ResumeLayout(false);
            this.pnlHyd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLogo;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOff;
    }
}

