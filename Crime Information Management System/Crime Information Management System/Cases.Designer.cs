namespace WindowsFormsApplication1
{
    partial class Cases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cases));
            this.labelFileFIR = new System.Windows.Forms.Label();
            this.pictureBoxFIR = new System.Windows.Forms.PictureBox();
            this.labelByMe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarEfficiency = new System.Windows.Forms.ProgressBar();
            this.pictureBoxSearch2 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearchBy = new System.Windows.Forms.Label();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.welcomeTextBox = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.softInfo = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.ComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.labelCaseID = new System.Windows.Forms.Label();
            this.textBoxCaseID = new System.Windows.Forms.TextBox();
            this.comboBoxFIRStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBoxRun = new System.Windows.Forms.PictureBox();
            this.buttonTakeUp = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFileFIR
            // 
            this.labelFileFIR.AutoSize = true;
            this.labelFileFIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileFIR.Location = new System.Drawing.Point(3, 306);
            this.labelFileFIR.Name = "labelFileFIR";
            this.labelFileFIR.Size = new System.Drawing.Size(80, 16);
            this.labelFileFIR.TabIndex = 155;
            this.labelFileFIR.Text = "My Cases ";
            // 
            // pictureBoxFIR
            // 
            this.pictureBoxFIR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFIR.BackgroundImage")));
            this.pictureBoxFIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFIR.Location = new System.Drawing.Point(6, 234);
            this.pictureBoxFIR.Name = "pictureBoxFIR";
            this.pictureBoxFIR.Size = new System.Drawing.Size(75, 69);
            this.pictureBoxFIR.TabIndex = 154;
            this.pictureBoxFIR.TabStop = false;
            this.pictureBoxFIR.Click += new System.EventHandler(this.pictureBoxFIR_Click);
            // 
            // labelByMe
            // 
            this.labelByMe.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelByMe.Location = new System.Drawing.Point(334, 201);
            this.labelByMe.Name = "labelByMe";
            this.labelByMe.Size = new System.Drawing.Size(276, 30);
            this.labelByMe.TabIndex = 153;
            this.labelByMe.Text = "Cases handled by me";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 151;
            this.label2.Text = "Efficiency";
            // 
            // progressBarEfficiency
            // 
            this.progressBarEfficiency.Location = new System.Drawing.Point(73, 647);
            this.progressBarEfficiency.Name = "progressBarEfficiency";
            this.progressBarEfficiency.Size = new System.Drawing.Size(100, 23);
            this.progressBarEfficiency.TabIndex = 150;
            // 
            // pictureBoxSearch2
            // 
            this.pictureBoxSearch2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch2.Image")));
            this.pictureBoxSearch2.Location = new System.Drawing.Point(715, 198);
            this.pictureBoxSearch2.Name = "pictureBoxSearch2";
            this.pictureBoxSearch2.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxSearch2.TabIndex = 146;
            this.pictureBoxSearch2.TabStop = false;
            this.pictureBoxSearch2.Visible = false;
            this.pictureBoxSearch2.Click += new System.EventHandler(this.pictureBoxSearch2_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(443, 198);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(251, 29);
            this.textBoxSearch.TabIndex = 145;
            this.textBoxSearch.Visible = false;
            // 
            // labelSearchBy
            // 
            this.labelSearchBy.AutoSize = true;
            this.labelSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchBy.Location = new System.Drawing.Point(188, 203);
            this.labelSearchBy.Name = "labelSearchBy";
            this.labelSearchBy.Size = new System.Drawing.Size(96, 24);
            this.labelSearchBy.TabIndex = 144;
            this.labelSearchBy.Text = "Search By";
            this.labelSearchBy.Visible = false;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(6, 366);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxSearch.TabIndex = 134;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(2, 444);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(106, 51);
            this.labelSearch.TabIndex = 133;
            this.labelSearch.Text = "Search Cases";
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.AutoSize = true;
            this.welcomeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.welcomeTextBox.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextBox.Location = new System.Drawing.Point(308, 110);
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.Size = new System.Drawing.Size(266, 30);
            this.welcomeTextBox.TabIndex = 132;
            this.welcomeTextBox.Text = "Information About Cases";
            // 
            // picHome
            // 
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(961, 98);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 32);
            this.picHome.TabIndex = 131;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // softInfo
            // 
            this.softInfo.AutoSize = true;
            this.softInfo.BackColor = System.Drawing.Color.Transparent;
            this.softInfo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softInfo.ForeColor = System.Drawing.Color.Brown;
            this.softInfo.Location = new System.Drawing.Point(130, 9);
            this.softInfo.Name = "softInfo";
            this.softInfo.Size = new System.Drawing.Size(796, 45);
            this.softInfo.TabIndex = 130;
            this.softInfo.Text = "RV All In One Crime Information Management System";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.BackgroundImage")));
            this.pictureLogo.Location = new System.Drawing.Point(3, 9);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(121, 121);
            this.pictureLogo.TabIndex = 129;
            this.pictureLogo.TabStop = false;
            // 
            // ComboBoxFilter
            // 
            this.ComboBoxFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxFilter.FormattingEnabled = true;
            this.ComboBoxFilter.Items.AddRange(new object[] {
            "Type",
            "CaseID"});
            this.ComboBoxFilter.Location = new System.Drawing.Point(290, 187);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(147, 45);
            this.ComboBoxFilter.TabIndex = 166;
            this.ComboBoxFilter.Visible = false;
            // 
            // labelCaseID
            // 
            this.labelCaseID.AutoSize = true;
            this.labelCaseID.BackColor = System.Drawing.Color.Transparent;
            this.labelCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaseID.Location = new System.Drawing.Point(753, 307);
            this.labelCaseID.Name = "labelCaseID";
            this.labelCaseID.Size = new System.Drawing.Size(75, 24);
            this.labelCaseID.TabIndex = 167;
            this.labelCaseID.Text = "Case ID";
            // 
            // textBoxCaseID
            // 
            this.textBoxCaseID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCaseID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCaseID.BackColor = System.Drawing.Color.White;
            this.textBoxCaseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaseID.Location = new System.Drawing.Point(834, 302);
            this.textBoxCaseID.Name = "textBoxCaseID";
            this.textBoxCaseID.Size = new System.Drawing.Size(168, 29);
            this.textBoxCaseID.TabIndex = 168;
            this.textBoxCaseID.TextChanged += new System.EventHandler(this.textBoxFIRID_TextChanged);
            // 
            // comboBoxFIRStatus
            // 
            this.comboBoxFIRStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFIRStatus.FormattingEnabled = true;
            this.comboBoxFIRStatus.Items.AddRange(new object[] {
            "Pending",
            "Stopped",
            "Withdrawn",
            "Solved"});
            this.comboBoxFIRStatus.Location = new System.Drawing.Point(834, 337);
            this.comboBoxFIRStatus.Name = "comboBoxFIRStatus";
            this.comboBoxFIRStatus.Size = new System.Drawing.Size(168, 32);
            this.comboBoxFIRStatus.TabIndex = 170;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(753, 337);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(84, 31);
            this.labelStatus.TabIndex = 169;
            this.labelStatus.Text = "Status";
            // 
            // pictureBoxRun
            // 
            this.pictureBoxRun.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRun.Image")));
            this.pictureBoxRun.Location = new System.Drawing.Point(1008, 299);
            this.pictureBoxRun.Name = "pictureBoxRun";
            this.pictureBoxRun.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxRun.TabIndex = 171;
            this.pictureBoxRun.TabStop = false;
            this.pictureBoxRun.Click += new System.EventHandler(this.pictureBoxRun_Click);
            // 
            // buttonTakeUp
            // 
            this.buttonTakeUp.Location = new System.Drawing.Point(834, 411);
            this.buttonTakeUp.Name = "buttonTakeUp";
            this.buttonTakeUp.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeUp.TabIndex = 172;
            this.buttonTakeUp.Text = "Take Up";
            this.buttonTakeUp.UseVisualStyleBackColor = true;
            this.buttonTakeUp.Click += new System.EventHandler(this.buttonTakeUp_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(927, 411);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 173;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridResults
            // 
            this.dataGridResults.AllowUserToAddRows = false;
            this.dataGridResults.AllowUserToDeleteRows = false;
            this.dataGridResults.AllowUserToOrderColumns = true;
            this.dataGridResults.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridResults.Location = new System.Drawing.Point(192, 238);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.Size = new System.Drawing.Size(555, 422);
            this.dataGridResults.TabIndex = 174;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(358, 680);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 13);
            this.label8.TabIndex = 175;
            this.label8.Text = "© 2012 Satvik Neelakant. All Rights Reserved.";
            this.label8.Visible = false;
            // 
            // Cases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 702);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonTakeUp);
            this.Controls.Add(this.pictureBoxRun);
            this.Controls.Add(this.comboBoxFIRStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxCaseID);
            this.Controls.Add(this.labelCaseID);
            this.Controls.Add(this.ComboBoxFilter);
            this.Controls.Add(this.labelFileFIR);
            this.Controls.Add(this.pictureBoxFIR);
            this.Controls.Add(this.labelByMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarEfficiency);
            this.Controls.Add(this.pictureBoxSearch2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearchBy);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.welcomeTextBox);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.softInfo);
            this.Controls.Add(this.pictureLogo);
            this.Name = "Cases";
            this.Text = "Cases - Seach, Edit.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileFIR;
        private System.Windows.Forms.PictureBox pictureBoxFIR;
        private System.Windows.Forms.Label labelByMe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarEfficiency;
        private System.Windows.Forms.PictureBox pictureBoxSearch2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label welcomeTextBox;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label softInfo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
        private System.Windows.Forms.Label labelCaseID;
        private System.Windows.Forms.TextBox textBoxCaseID;
        private System.Windows.Forms.ComboBox comboBoxFIRStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBoxRun;
        private System.Windows.Forms.Button buttonTakeUp;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.Label label8;
    }
}