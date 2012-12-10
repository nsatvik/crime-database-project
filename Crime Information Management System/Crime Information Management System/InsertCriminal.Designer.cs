namespace WindowsFormsApplication1
{
    partial class InsertCriminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertCriminal));
            this.picHome = new System.Windows.Forms.PictureBox();
            this.welcomeTextBox = new System.Windows.Forms.Label();
            this.softInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCID = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.domainUpDownAge = new System.Windows.Forms.DomainUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.comboBoxInType = new System.Windows.Forms.ComboBox();
            this.labelInsert = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picHome
            // 
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(996, 98);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 32);
            this.picHome.TabIndex = 62;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.AutoSize = true;
            this.welcomeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.welcomeTextBox.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextBox.Location = new System.Drawing.Point(308, 110);
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.Size = new System.Drawing.Size(439, 30);
            this.welcomeTextBox.TabIndex = 61;
            this.welcomeTextBox.Text = "Enter the Details and Insert the Criminal";
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
            this.softInfo.TabIndex = 60;
            this.softInfo.Text = "RV All In One Crime Information Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // labelType
            // 
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(66, 403);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(287, 31);
            this.labelType.TabIndex = 106;
            this.labelType.Text = "Type";
            // 
            // labelWeight
            // 
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(59, 361);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(114, 31);
            this.labelWeight.TabIndex = 105;
            this.labelWeight.Text = "Weight";
            // 
            // labelSex
            // 
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(307, 255);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(63, 31);
            this.labelSex.TabIndex = 104;
            this.labelSex.Text = "Sex";
            // 
            // labelHeight
            // 
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(59, 307);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(114, 31);
            this.labelHeight.TabIndex = 103;
            this.labelHeight.Text = "Height";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(59, 526);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(168, 39);
            this.labelDescription.TabIndex = 102;
            this.labelDescription.Text = "Description";
            // 
            // labelAge
            // 
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(59, 255);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(80, 31);
            this.labelAge.TabIndex = 101;
            this.labelAge.Text = "Age";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(66, 473);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(107, 31);
            this.labelStatus.TabIndex = 100;
            this.labelStatus.Text = "Status";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(59, 198);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 37);
            this.labelName.TabIndex = 99;
            this.labelName.Text = "Name";
            // 
            // labelCID
            // 
            this.labelCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCID.ForeColor = System.Drawing.Color.Black;
            this.labelCID.Location = new System.Drawing.Point(59, 151);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(53, 31);
            this.labelCID.TabIndex = 98;
            this.labelCID.Text = "ID: ";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(162, 311);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(142, 29);
            this.textBoxHeight.TabIndex = 113;
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
            this.comboBoxType.Location = new System.Drawing.Point(169, 407);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(135, 32);
            this.comboBoxType.TabIndex = 112;
            this.comboBoxType.Text = "Terrorist";
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
            this.comboBoxStatus.Location = new System.Drawing.Point(191, 472);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(135, 32);
            this.comboBoxStatus.TabIndex = 111;
            this.comboBoxStatus.Text = "Missing";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(430, 265);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 110;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(376, 265);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 109;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // domainUpDownAge
            // 
            this.domainUpDownAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDownAge.Items.Add("18");
            this.domainUpDownAge.Items.Add("19");
            this.domainUpDownAge.Items.Add("20");
            this.domainUpDownAge.Items.Add("21");
            this.domainUpDownAge.Items.Add("22");
            this.domainUpDownAge.Items.Add("23");
            this.domainUpDownAge.Items.Add("24");
            this.domainUpDownAge.Items.Add("25");
            this.domainUpDownAge.Items.Add("26");
            this.domainUpDownAge.Items.Add("27");
            this.domainUpDownAge.Items.Add("28");
            this.domainUpDownAge.Items.Add("29");
            this.domainUpDownAge.Items.Add("30");
            this.domainUpDownAge.Items.Add("31");
            this.domainUpDownAge.Items.Add("32");
            this.domainUpDownAge.Items.Add("33");
            this.domainUpDownAge.Items.Add("34");
            this.domainUpDownAge.Items.Add("35");
            this.domainUpDownAge.Items.Add("36");
            this.domainUpDownAge.Items.Add("37");
            this.domainUpDownAge.Items.Add("38");
            this.domainUpDownAge.Items.Add("39");
            this.domainUpDownAge.Items.Add("40");
            this.domainUpDownAge.Items.Add("41");
            this.domainUpDownAge.Items.Add("42");
            this.domainUpDownAge.Items.Add("43");
            this.domainUpDownAge.Items.Add("44");
            this.domainUpDownAge.Items.Add("45");
            this.domainUpDownAge.Items.Add("46");
            this.domainUpDownAge.Items.Add("47");
            this.domainUpDownAge.Items.Add("48");
            this.domainUpDownAge.Items.Add("49");
            this.domainUpDownAge.Items.Add("50");
            this.domainUpDownAge.Items.Add("51");
            this.domainUpDownAge.Items.Add("52");
            this.domainUpDownAge.Items.Add("53");
            this.domainUpDownAge.Items.Add("54");
            this.domainUpDownAge.Items.Add("55");
            this.domainUpDownAge.Items.Add("56");
            this.domainUpDownAge.Items.Add("57");
            this.domainUpDownAge.Items.Add("58");
            this.domainUpDownAge.Items.Add("59");
            this.domainUpDownAge.Items.Add("60");
            this.domainUpDownAge.Items.Add("61");
            this.domainUpDownAge.Items.Add("62");
            this.domainUpDownAge.Items.Add("63");
            this.domainUpDownAge.Items.Add("64");
            this.domainUpDownAge.Items.Add("65");
            this.domainUpDownAge.Items.Add("66");
            this.domainUpDownAge.Items.Add("67");
            this.domainUpDownAge.Items.Add("68");
            this.domainUpDownAge.Items.Add("69");
            this.domainUpDownAge.Items.Add("70");
            this.domainUpDownAge.Items.Add("71");
            this.domainUpDownAge.Items.Add("72");
            this.domainUpDownAge.Items.Add("73");
            this.domainUpDownAge.Items.Add("74");
            this.domainUpDownAge.Items.Add("75");
            this.domainUpDownAge.Items.Add("76");
            this.domainUpDownAge.Items.Add("77");
            this.domainUpDownAge.Items.Add("78");
            this.domainUpDownAge.Items.Add("79");
            this.domainUpDownAge.Items.Add("80");
            this.domainUpDownAge.Items.Add("81");
            this.domainUpDownAge.Items.Add("82");
            this.domainUpDownAge.Items.Add("83");
            this.domainUpDownAge.Items.Add("84");
            this.domainUpDownAge.Items.Add("85");
            this.domainUpDownAge.Items.Add("86");
            this.domainUpDownAge.Items.Add("87");
            this.domainUpDownAge.Items.Add("88");
            this.domainUpDownAge.Items.Add("89");
            this.domainUpDownAge.Items.Add("90");
            this.domainUpDownAge.Items.Add("91");
            this.domainUpDownAge.Items.Add("92");
            this.domainUpDownAge.Items.Add("93");
            this.domainUpDownAge.Items.Add("94");
            this.domainUpDownAge.Items.Add("95");
            this.domainUpDownAge.Items.Add("96");
            this.domainUpDownAge.Items.Add("97");
            this.domainUpDownAge.Items.Add("98");
            this.domainUpDownAge.Items.Add("99");
            this.domainUpDownAge.Items.Add("100");
            this.domainUpDownAge.Location = new System.Drawing.Point(145, 257);
            this.domainUpDownAge.Name = "domainUpDownAge";
            this.domainUpDownAge.Size = new System.Drawing.Size(120, 29);
            this.domainUpDownAge.TabIndex = 108;
            this.domainUpDownAge.Text = "18";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(159, 202);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(251, 29);
            this.textBoxName.TabIndex = 107;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.Location = new System.Drawing.Point(162, 365);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(142, 29);
            this.textBoxWeight.TabIndex = 114;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(227, 530);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(251, 29);
            this.textBoxDescription.TabIndex = 115;
            // 
            // textBoxID
            // 
            this.textBoxID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(162, 155);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(251, 29);
            this.textBoxID.TabIndex = 116;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 613);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 44);
            this.buttonCancel.TabIndex = 118;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(72, 613);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(112, 44);
            this.buttonInsert.TabIndex = 117;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // comboBoxInType
            // 
            this.comboBoxInType.AutoCompleteCustomSource.AddRange(new string[] {
            "Criminal",
            "Victim"});
            this.comboBoxInType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxInType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxInType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInType.FormattingEnabled = true;
            this.comboBoxInType.Items.AddRange(new object[] {
            "Victim",
            "Criminal"});
            this.comboBoxInType.Location = new System.Drawing.Point(894, 154);
            this.comboBoxInType.Name = "comboBoxInType";
            this.comboBoxInType.Size = new System.Drawing.Size(135, 32);
            this.comboBoxInType.TabIndex = 120;
            this.comboBoxInType.Text = "Criminal";
            this.comboBoxInType.SelectedIndexChanged += new System.EventHandler(this.comboBoxInType_SelectedIndexChanged);
            // 
            // labelInsert
            // 
            this.labelInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsert.Location = new System.Drawing.Point(769, 155);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(107, 31);
            this.labelInsert.TabIndex = 119;
            this.labelInsert.Text = "Insert";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(356, 689);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 13);
            this.label8.TabIndex = 176;
            this.label8.Text = "© 2012 Satvik Neelakant. All Rights Reserved.";
            this.label8.Visible = false;
            // 
            // InsertCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 702);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxInType);
            this.Controls.Add(this.labelInsert);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.domainUpDownAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCID);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.welcomeTextBox);
            this.Controls.Add(this.softInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InsertCriminal";
            this.Text = "Insert A Criminal";
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label welcomeTextBox;
        private System.Windows.Forms.Label softInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DomainUpDown domainUpDownAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxInType;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.Label label8;
    }
}