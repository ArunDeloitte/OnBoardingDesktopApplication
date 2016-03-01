namespace OnBoardingDesktopApplication
{
    partial class AdminReport
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.welcome2DeloitteDataSet = new OnBoardingDesktopApplication.Welcome2DeloitteDataSet();
            this.reportsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportsViewTableAdapter = new OnBoardingDesktopApplication.Welcome2DeloitteDataSetTableAdapters.ReportsViewTableAdapter();
            this.onBoardingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onBoardingTableAdapter = new OnBoardingDesktopApplication.Welcome2DeloitteDataSetTableAdapters.OnBoardingTableAdapter();
            this.dgvAdminReport = new System.Windows.Forms.DataGridView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.onBoardingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.candidateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequenceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateMiddleInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateHomePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateMobilePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiringLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentativeStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiringLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofHireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSResponsibilityCenterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationalUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSJobCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSPersonnelAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w2DStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w2DStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w2DDayNonDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gHRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laptopStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w2DDay1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.w2DDay2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome2DeloitteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onBoardingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onBoardingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(29)))), ((int)(((byte)(93)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Controls.Add(this.pnlLogo);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1271, 75);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(1119, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 22);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(1040, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(109, 27);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Something";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::OnBoardingDesktopApplication.Properties.Resources.logowhite;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(198, 65);
            this.pnlLogo.TabIndex = 0;
            // 
            // welcome2DeloitteDataSet
            // 
            this.welcome2DeloitteDataSet.DataSetName = "Welcome2DeloitteDataSet";
            this.welcome2DeloitteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportsViewBindingSource
            // 
            this.reportsViewBindingSource.DataMember = "ReportsView";
            this.reportsViewBindingSource.DataSource = this.welcome2DeloitteDataSet;
            // 
            // reportsViewTableAdapter
            // 
            this.reportsViewTableAdapter.ClearBeforeFill = true;
            // 
            // onBoardingBindingSource
            // 
            this.onBoardingBindingSource.DataMember = "OnBoarding";
            this.onBoardingBindingSource.DataSource = this.welcome2DeloitteDataSet;
            // 
            // onBoardingTableAdapter
            // 
            this.onBoardingTableAdapter.ClearBeforeFill = true;
            // 
            // dgvAdminReport
            // 
            this.dgvAdminReport.AutoGenerateColumns = false;
            this.dgvAdminReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAdminReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidateIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.sequenceNumberDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.candidateNameDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.entityDataGridViewTextBoxColumn,
            this.functionDataGridViewTextBoxColumn,
            this.prefixDataGridViewTextBoxColumn,
            this.candidateFirstNameDataGridViewTextBoxColumn,
            this.candidateMiddleInitialDataGridViewTextBoxColumn,
            this.candidateLastNameDataGridViewTextBoxColumn,
            this.candidateHomePhoneDataGridViewTextBoxColumn,
            this.candidateMobilePhoneDataGridViewTextBoxColumn,
            this.candidateEmailDataGridViewTextBoxColumn,
            this.hiringLocationDataGridViewTextBoxColumn,
            this.tentativeStartDateDataGridViewTextBoxColumn,
            this.hiringLevelDataGridViewTextBoxColumn,
            this.typeofHireDataGridViewTextBoxColumn,
            this.uSResponsibilityCenterDataGridViewTextBoxColumn,
            this.organizationalUnitDataGridViewTextBoxColumn,
            this.uSJobCodeDataGridViewTextBoxColumn,
            this.uSPersonnelAreaDataGridViewTextBoxColumn,
            this.w2DStatusDataGridViewTextBoxColumn,
            this.w2DStartDateDataGridViewTextBoxColumn,
            this.w2DDayNonDayDataGridViewTextBoxColumn,
            this.gHRDataGridViewTextBoxColumn,
            this.joiningStatusDataGridViewTextBoxColumn,
            this.laptopStatusDataGridViewTextBoxColumn,
            this.w2DDay1DataGridViewTextBoxColumn,
            this.w2DDay2DataGridViewTextBoxColumn});
            this.dgvAdminReport.DataSource = this.onBoardingBindingSource1;
            this.dgvAdminReport.Location = new System.Drawing.Point(12, 81);
            this.dgvAdminReport.Name = "dgvAdminReport";
            this.dgvAdminReport.Size = new System.Drawing.Size(1247, 505);
            this.dgvAdminReport.TabIndex = 2;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(29)))), ((int)(((byte)(93)))));
            this.btnDownload.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDownload.Location = new System.Drawing.Point(554, 615);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(171, 54);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "DOWNLOAD";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // onBoardingBindingSource1
            // 
            this.onBoardingBindingSource1.DataMember = "OnBoarding";
            this.onBoardingBindingSource1.DataSource = this.welcome2DeloitteDataSet;
            // 
            // candidateIDDataGridViewTextBoxColumn
            // 
            this.candidateIDDataGridViewTextBoxColumn.DataPropertyName = "Candidate_ID";
            this.candidateIDDataGridViewTextBoxColumn.HeaderText = "Candidate_ID";
            this.candidateIDDataGridViewTextBoxColumn.Name = "candidateIDDataGridViewTextBoxColumn";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // sequenceNumberDataGridViewTextBoxColumn
            // 
            this.sequenceNumberDataGridViewTextBoxColumn.DataPropertyName = "Sequence_Number";
            this.sequenceNumberDataGridViewTextBoxColumn.HeaderText = "Sequence_Number";
            this.sequenceNumberDataGridViewTextBoxColumn.Name = "sequenceNumberDataGridViewTextBoxColumn";
            // 
            // emailIDDataGridViewTextBoxColumn
            // 
            this.emailIDDataGridViewTextBoxColumn.DataPropertyName = "EmailID";
            this.emailIDDataGridViewTextBoxColumn.HeaderText = "EmailID";
            this.emailIDDataGridViewTextBoxColumn.Name = "emailIDDataGridViewTextBoxColumn";
            // 
            // candidateNameDataGridViewTextBoxColumn
            // 
            this.candidateNameDataGridViewTextBoxColumn.DataPropertyName = "CandidateName";
            this.candidateNameDataGridViewTextBoxColumn.HeaderText = "CandidateName";
            this.candidateNameDataGridViewTextBoxColumn.Name = "candidateNameDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // entityDataGridViewTextBoxColumn
            // 
            this.entityDataGridViewTextBoxColumn.DataPropertyName = "Entity";
            this.entityDataGridViewTextBoxColumn.HeaderText = "Entity";
            this.entityDataGridViewTextBoxColumn.Name = "entityDataGridViewTextBoxColumn";
            // 
            // functionDataGridViewTextBoxColumn
            // 
            this.functionDataGridViewTextBoxColumn.DataPropertyName = "Function";
            this.functionDataGridViewTextBoxColumn.HeaderText = "Function";
            this.functionDataGridViewTextBoxColumn.Name = "functionDataGridViewTextBoxColumn";
            // 
            // prefixDataGridViewTextBoxColumn
            // 
            this.prefixDataGridViewTextBoxColumn.DataPropertyName = "Prefix";
            this.prefixDataGridViewTextBoxColumn.HeaderText = "Prefix";
            this.prefixDataGridViewTextBoxColumn.Name = "prefixDataGridViewTextBoxColumn";
            // 
            // candidateFirstNameDataGridViewTextBoxColumn
            // 
            this.candidateFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CandidateFirstName";
            this.candidateFirstNameDataGridViewTextBoxColumn.HeaderText = "CandidateFirstName";
            this.candidateFirstNameDataGridViewTextBoxColumn.Name = "candidateFirstNameDataGridViewTextBoxColumn";
            // 
            // candidateMiddleInitialDataGridViewTextBoxColumn
            // 
            this.candidateMiddleInitialDataGridViewTextBoxColumn.DataPropertyName = "CandidateMiddleInitial";
            this.candidateMiddleInitialDataGridViewTextBoxColumn.HeaderText = "CandidateMiddleInitial";
            this.candidateMiddleInitialDataGridViewTextBoxColumn.Name = "candidateMiddleInitialDataGridViewTextBoxColumn";
            // 
            // candidateLastNameDataGridViewTextBoxColumn
            // 
            this.candidateLastNameDataGridViewTextBoxColumn.DataPropertyName = "CandidateLastName";
            this.candidateLastNameDataGridViewTextBoxColumn.HeaderText = "CandidateLastName";
            this.candidateLastNameDataGridViewTextBoxColumn.Name = "candidateLastNameDataGridViewTextBoxColumn";
            // 
            // candidateHomePhoneDataGridViewTextBoxColumn
            // 
            this.candidateHomePhoneDataGridViewTextBoxColumn.DataPropertyName = "CandidateHomePhone";
            this.candidateHomePhoneDataGridViewTextBoxColumn.HeaderText = "CandidateHomePhone";
            this.candidateHomePhoneDataGridViewTextBoxColumn.Name = "candidateHomePhoneDataGridViewTextBoxColumn";
            // 
            // candidateMobilePhoneDataGridViewTextBoxColumn
            // 
            this.candidateMobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "CandidateMobilePhone";
            this.candidateMobilePhoneDataGridViewTextBoxColumn.HeaderText = "CandidateMobilePhone";
            this.candidateMobilePhoneDataGridViewTextBoxColumn.Name = "candidateMobilePhoneDataGridViewTextBoxColumn";
            // 
            // candidateEmailDataGridViewTextBoxColumn
            // 
            this.candidateEmailDataGridViewTextBoxColumn.DataPropertyName = "CandidateEmail";
            this.candidateEmailDataGridViewTextBoxColumn.HeaderText = "CandidateEmail";
            this.candidateEmailDataGridViewTextBoxColumn.Name = "candidateEmailDataGridViewTextBoxColumn";
            // 
            // hiringLocationDataGridViewTextBoxColumn
            // 
            this.hiringLocationDataGridViewTextBoxColumn.DataPropertyName = "Hiring_Location";
            this.hiringLocationDataGridViewTextBoxColumn.HeaderText = "Hiring_Location";
            this.hiringLocationDataGridViewTextBoxColumn.Name = "hiringLocationDataGridViewTextBoxColumn";
            // 
            // tentativeStartDateDataGridViewTextBoxColumn
            // 
            this.tentativeStartDateDataGridViewTextBoxColumn.DataPropertyName = "Tentative_StartDate";
            this.tentativeStartDateDataGridViewTextBoxColumn.HeaderText = "Tentative_StartDate";
            this.tentativeStartDateDataGridViewTextBoxColumn.Name = "tentativeStartDateDataGridViewTextBoxColumn";
            // 
            // hiringLevelDataGridViewTextBoxColumn
            // 
            this.hiringLevelDataGridViewTextBoxColumn.DataPropertyName = "Hiring_Level";
            this.hiringLevelDataGridViewTextBoxColumn.HeaderText = "Hiring_Level";
            this.hiringLevelDataGridViewTextBoxColumn.Name = "hiringLevelDataGridViewTextBoxColumn";
            // 
            // typeofHireDataGridViewTextBoxColumn
            // 
            this.typeofHireDataGridViewTextBoxColumn.DataPropertyName = "TypeofHire";
            this.typeofHireDataGridViewTextBoxColumn.HeaderText = "TypeofHire";
            this.typeofHireDataGridViewTextBoxColumn.Name = "typeofHireDataGridViewTextBoxColumn";
            // 
            // uSResponsibilityCenterDataGridViewTextBoxColumn
            // 
            this.uSResponsibilityCenterDataGridViewTextBoxColumn.DataPropertyName = "US_ResponsibilityCenter";
            this.uSResponsibilityCenterDataGridViewTextBoxColumn.HeaderText = "US_ResponsibilityCenter";
            this.uSResponsibilityCenterDataGridViewTextBoxColumn.Name = "uSResponsibilityCenterDataGridViewTextBoxColumn";
            // 
            // organizationalUnitDataGridViewTextBoxColumn
            // 
            this.organizationalUnitDataGridViewTextBoxColumn.DataPropertyName = "OrganizationalUnit";
            this.organizationalUnitDataGridViewTextBoxColumn.HeaderText = "OrganizationalUnit";
            this.organizationalUnitDataGridViewTextBoxColumn.Name = "organizationalUnitDataGridViewTextBoxColumn";
            // 
            // uSJobCodeDataGridViewTextBoxColumn
            // 
            this.uSJobCodeDataGridViewTextBoxColumn.DataPropertyName = "US_JobCode";
            this.uSJobCodeDataGridViewTextBoxColumn.HeaderText = "US_JobCode";
            this.uSJobCodeDataGridViewTextBoxColumn.Name = "uSJobCodeDataGridViewTextBoxColumn";
            // 
            // uSPersonnelAreaDataGridViewTextBoxColumn
            // 
            this.uSPersonnelAreaDataGridViewTextBoxColumn.DataPropertyName = "US_PersonnelArea";
            this.uSPersonnelAreaDataGridViewTextBoxColumn.HeaderText = "US_PersonnelArea";
            this.uSPersonnelAreaDataGridViewTextBoxColumn.Name = "uSPersonnelAreaDataGridViewTextBoxColumn";
            // 
            // w2DStatusDataGridViewTextBoxColumn
            // 
            this.w2DStatusDataGridViewTextBoxColumn.DataPropertyName = "W2D_Status";
            this.w2DStatusDataGridViewTextBoxColumn.HeaderText = "W2D_Status";
            this.w2DStatusDataGridViewTextBoxColumn.Name = "w2DStatusDataGridViewTextBoxColumn";
            // 
            // w2DStartDateDataGridViewTextBoxColumn
            // 
            this.w2DStartDateDataGridViewTextBoxColumn.DataPropertyName = "W2D_StartDate";
            this.w2DStartDateDataGridViewTextBoxColumn.HeaderText = "W2D_StartDate";
            this.w2DStartDateDataGridViewTextBoxColumn.Name = "w2DStartDateDataGridViewTextBoxColumn";
            // 
            // w2DDayNonDayDataGridViewTextBoxColumn
            // 
            this.w2DDayNonDayDataGridViewTextBoxColumn.DataPropertyName = "W2D_Day_NonDay";
            this.w2DDayNonDayDataGridViewTextBoxColumn.HeaderText = "W2D_Day_NonDay";
            this.w2DDayNonDayDataGridViewTextBoxColumn.Name = "w2DDayNonDayDataGridViewTextBoxColumn";
            // 
            // gHRDataGridViewTextBoxColumn
            // 
            this.gHRDataGridViewTextBoxColumn.DataPropertyName = "GHR";
            this.gHRDataGridViewTextBoxColumn.HeaderText = "GHR";
            this.gHRDataGridViewTextBoxColumn.Name = "gHRDataGridViewTextBoxColumn";
            // 
            // joiningStatusDataGridViewTextBoxColumn
            // 
            this.joiningStatusDataGridViewTextBoxColumn.DataPropertyName = "Joining_Status";
            this.joiningStatusDataGridViewTextBoxColumn.HeaderText = "Joining_Status";
            this.joiningStatusDataGridViewTextBoxColumn.Name = "joiningStatusDataGridViewTextBoxColumn";
            // 
            // laptopStatusDataGridViewTextBoxColumn
            // 
            this.laptopStatusDataGridViewTextBoxColumn.DataPropertyName = "Laptop_Status";
            this.laptopStatusDataGridViewTextBoxColumn.HeaderText = "Laptop_Status";
            this.laptopStatusDataGridViewTextBoxColumn.Name = "laptopStatusDataGridViewTextBoxColumn";
            // 
            // w2DDay1DataGridViewTextBoxColumn
            // 
            this.w2DDay1DataGridViewTextBoxColumn.DataPropertyName = "W2D_Day1";
            this.w2DDay1DataGridViewTextBoxColumn.HeaderText = "W2D_Day1";
            this.w2DDay1DataGridViewTextBoxColumn.Name = "w2DDay1DataGridViewTextBoxColumn";
            // 
            // w2DDay2DataGridViewTextBoxColumn
            // 
            this.w2DDay2DataGridViewTextBoxColumn.DataPropertyName = "W2D_Day2";
            this.w2DDay2DataGridViewTextBoxColumn.HeaderText = "W2D_Day2";
            this.w2DDay2DataGridViewTextBoxColumn.Name = "w2DDay2DataGridViewTextBoxColumn";
            // 
            // AdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.dgvAdminReport);
            this.Controls.Add(this.pnlHeader);
            this.Name = "AdminReport";
            this.Text = "AdminReport";
            this.Load += new System.EventHandler(this.AdminReport_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome2DeloitteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onBoardingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onBoardingBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private Welcome2DeloitteDataSet welcome2DeloitteDataSet;
        private System.Windows.Forms.BindingSource reportsViewBindingSource;
        private Welcome2DeloitteDataSetTableAdapters.ReportsViewTableAdapter reportsViewTableAdapter;
        private System.Windows.Forms.BindingSource onBoardingBindingSource;
        private Welcome2DeloitteDataSetTableAdapters.OnBoardingTableAdapter onBoardingTableAdapter;
        private System.Windows.Forms.DataGridView dgvAdminReport;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequenceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateMiddleInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateHomePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateMobilePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiringLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentativeStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiringLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofHireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSResponsibilityCenterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationalUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSJobCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSPersonnelAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn w2DStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn w2DStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn w2DDayNonDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gHRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laptopStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn w2DDay1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn w2DDay2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource onBoardingBindingSource1;
    }
}