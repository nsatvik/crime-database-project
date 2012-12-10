namespace WindowsFormsApplication1
{
    partial class CrimeStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrimeStats));
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.softInfo = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.pictureBoxPrint = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.labelSearchFilters = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBoxTerminal = new System.Windows.Forms.PictureBox();
            this.pictureBoxRun = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRun)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.Location = new System.Drawing.Point(995, 98);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxHome.TabIndex = 38;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // softInfo
            // 
            this.softInfo.AutoSize = true;
            this.softInfo.BackColor = System.Drawing.Color.Transparent;
            this.softInfo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softInfo.ForeColor = System.Drawing.Color.Brown;
            this.softInfo.Location = new System.Drawing.Point(134, 9);
            this.softInfo.Name = "softInfo";
            this.softInfo.Size = new System.Drawing.Size(796, 45);
            this.softInfo.TabIndex = 37;
            this.softInfo.Text = "RV All In One Crime Information Management System";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.BackgroundImage")));
            this.pictureLogo.Location = new System.Drawing.Point(7, 9);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(121, 121);
            this.pictureLogo.TabIndex = 36;
            this.pictureLogo.TabStop = false;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AllowUserToOrderColumns = true;
            this.dataGridViewResults.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridViewResults.Location = new System.Drawing.Point(312, 244);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(734, 455);
            this.dataGridViewResults.TabIndex = 39;
            this.dataGridViewResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBoxPrint
            // 
            this.pictureBoxPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrint.BackgroundImage")));
            this.pictureBoxPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPrint.Location = new System.Drawing.Point(894, 163);
            this.pictureBoxPrint.Name = "pictureBoxPrint";
            this.pictureBoxPrint.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxPrint.TabIndex = 45;
            this.pictureBoxPrint.TabStop = false;
            this.pictureBoxPrint.Visible = false;
            this.pictureBoxPrint.Click += new System.EventHandler(this.pictureBoxMWL_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(732, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ComboBoxFilter
            // 
            this.ComboBoxFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxFilter.FormattingEnabled = true;
            this.ComboBoxFilter.Items.AddRange(new object[] {
            "List of Criminals",
            "List of Victims",
            "Most Wanted Criminals",
            "List FIRs",
            "List of Police Users",
            "Crimes - By Area",
            "User -> FIR",
            "FIR -> Investigation Officer",
            "List of Cases"});
            this.ComboBoxFilter.Location = new System.Drawing.Point(6, 163);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(300, 45);
            this.ComboBoxFilter.TabIndex = 89;
            this.ComboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.textBoxSearch_SelectedIndexChanged);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxQuery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxQuery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuery.Location = new System.Drawing.Point(328, 163);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuery.Size = new System.Drawing.Size(398, 75);
            this.textBoxQuery.TabIndex = 108;
            this.textBoxQuery.Text = "Enter query";
            this.textBoxQuery.TextChanged += new System.EventHandler(this.textBoxQuery_TextChanged);
            // 
            // labelSearchFilters
            // 
            this.labelSearchFilters.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchFilters.Location = new System.Drawing.Point(12, 244);
            this.labelSearchFilters.Name = "labelSearchFilters";
            this.labelSearchFilters.Size = new System.Drawing.Size(270, 31);
            this.labelSearchFilters.TabIndex = 109;
            this.labelSearchFilters.Text = "Search Filters ";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(7, 457);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(251, 77);
            this.textBoxDescription.TabIndex = 121;
            this.textBoxDescription.Visible = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Terrorist",
            "Naxalite",
            "Underworld Don",
            "Local",
            "Robber",
            "Murderer"});
            this.comboBoxType.Location = new System.Drawing.Point(113, 278);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(135, 32);
            this.comboBoxType.TabIndex = 120;
            this.comboBoxType.Visible = false;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Yavonigottu",
            "Dead",
            "Jailed",
            "Absconded",
            "Missing"});
            this.comboBoxStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Yavonigottu",
            "Dead",
            "Jailed",
            "Absconded",
            "Missing"});
            this.comboBoxStatus.Location = new System.Drawing.Point(137, 324);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(135, 32);
            this.comboBoxStatus.TabIndex = 119;
            this.comboBoxStatus.Visible = false;
            // 
            // labelType
            // 
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(10, 274);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(86, 31);
            this.labelType.TabIndex = 118;
            this.labelType.Text = "Type";
            this.labelType.Visible = false;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(0, 425);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(168, 39);
            this.labelDescription.TabIndex = 117;
            this.labelDescription.Text = "Description";
            this.labelDescription.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(12, 325);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(107, 31);
            this.labelStatus.TabIndex = 116;
            this.labelStatus.Text = "Status";
            this.labelStatus.Visible = false;
            // 
            // pictureBoxTerminal
            // 
            this.pictureBoxTerminal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTerminal.BackgroundImage")));
            this.pictureBoxTerminal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTerminal.Location = new System.Drawing.Point(813, 163);
            this.pictureBoxTerminal.Name = "pictureBoxTerminal";
            this.pictureBoxTerminal.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxTerminal.TabIndex = 126;
            this.pictureBoxTerminal.TabStop = false;
            this.pictureBoxTerminal.Click += new System.EventHandler(this.pictureBoxTerminal_Click);
            // 
            // pictureBoxRun
            // 
            this.pictureBoxRun.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRun.Image")));
            this.pictureBoxRun.Location = new System.Drawing.Point(274, 214);
            this.pictureBoxRun.Name = "pictureBoxRun";
            this.pictureBoxRun.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxRun.TabIndex = 127;
            this.pictureBoxRun.TabStop = false;
            this.pictureBoxRun.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CrimeStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 702);
            this.Controls.Add(this.pictureBoxRun);
            this.Controls.Add(this.pictureBoxTerminal);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelSearchFilters);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.ComboBoxFilter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxPrint);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.pictureBoxHome);
            this.Controls.Add(this.softInfo);
            this.Controls.Add(this.pictureLogo);
            this.Name = "CrimeStats";
            this.Text = "CrimeStats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Label softInfo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.PictureBox pictureBoxPrint;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label labelSearchFilters;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBoxTerminal;
        private System.Windows.Forms.PictureBox pictureBoxRun;
    }
}