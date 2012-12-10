namespace WindowsFormsApplication1
{
    partial class Search_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.softInfo = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.picboxGeneral = new System.Windows.Forms.PictureBox();
            this.pictureBoxInsert = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelInsert = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.pictureBoxSearch2 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.ComboBox();
            this.labelCID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(996, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // softInfo
            // 
            this.softInfo.AutoSize = true;
            this.softInfo.BackColor = System.Drawing.Color.Transparent;
            this.softInfo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softInfo.ForeColor = System.Drawing.Color.Brown;
            this.softInfo.Location = new System.Drawing.Point(141, 9);
            this.softInfo.Name = "softInfo";
            this.softInfo.Size = new System.Drawing.Size(796, 45);
            this.softInfo.TabIndex = 33;
            this.softInfo.Text = "RV All In One Crime Information Management System";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.BackgroundImage")));
            this.pictureLogo.Location = new System.Drawing.Point(14, 9);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(121, 121);
            this.pictureLogo.TabIndex = 31;
            this.pictureLogo.TabStop = false;
            // 
            // picboxGeneral
            // 
            this.picboxGeneral.Image = ((System.Drawing.Image)(resources.GetObject("picboxGeneral.Image")));
            this.picboxGeneral.Location = new System.Drawing.Point(734, 139);
            this.picboxGeneral.Name = "picboxGeneral";
            this.picboxGeneral.Size = new System.Drawing.Size(75, 75);
            this.picboxGeneral.TabIndex = 30;
            this.picboxGeneral.TabStop = false;
            this.picboxGeneral.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // pictureBoxInsert
            // 
            this.pictureBoxInsert.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInsert.Image")));
            this.pictureBoxInsert.Location = new System.Drawing.Point(356, 139);
            this.pictureBoxInsert.Name = "pictureBoxInsert";
            this.pictureBoxInsert.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxInsert.TabIndex = 36;
            this.pictureBoxInsert.TabStop = false;
            this.pictureBoxInsert.Visible = false;
            this.pictureBoxInsert.Click += new System.EventHandler(this.pictureBoxInsert_Click);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete.Image")));
            this.pictureBoxDelete.Location = new System.Drawing.Point(500, 139);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxDelete.TabIndex = 37;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Visible = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // labelResults
            // 
            this.labelResults.BackColor = System.Drawing.Color.Transparent;
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.ForeColor = System.Drawing.Color.Red;
            this.labelResults.Location = new System.Drawing.Point(66, 235);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(488, 31);
            this.labelResults.TabIndex = 38;
            this.labelResults.Text = "Search Results";
            // 
            // labelSearch
            // 
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(219, 217);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(106, 31);
            this.labelSearch.TabIndex = 39;
            this.labelSearch.Text = "Search";
            this.labelSearch.Visible = false;
            // 
            // labelInsert
            // 
            this.labelInsert.BackColor = System.Drawing.Color.Transparent;
            this.labelInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsert.Location = new System.Drawing.Point(352, 217);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(106, 31);
            this.labelInsert.TabIndex = 40;
            this.labelInsert.Text = "Insert ";
            this.labelInsert.Visible = false;
            // 
            // labelDelete
            // 
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.Location = new System.Drawing.Point(496, 217);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(106, 31);
            this.labelDelete.TabIndex = 41;
            this.labelDelete.Text = "Update";
            this.labelDelete.Visible = false;
            // 
            // pictureBoxSearch2
            // 
            this.pictureBoxSearch2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch2.Image")));
            this.pictureBoxSearch2.Location = new System.Drawing.Point(223, 139);
            this.pictureBoxSearch2.Name = "pictureBoxSearch2";
            this.pictureBoxSearch2.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxSearch2.TabIndex = 42;
            this.pictureBoxSearch2.TabStop = false;
            this.pictureBoxSearch2.Visible = false;
            this.pictureBoxSearch2.Click += new System.EventHandler(this.pictureBoxSearch2_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.FormattingEnabled = true;
            this.textBoxSearch.Location = new System.Drawing.Point(149, 157);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(579, 45);
            this.textBoxSearch.TabIndex = 88;
            this.textBoxSearch.SelectedIndexChanged += new System.EventHandler(this.textBoxSearch_SelectedIndexChanged);
            // 
            // labelCID
            // 
            this.labelCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCID.ForeColor = System.Drawing.Color.Black;
            this.labelCID.Location = new System.Drawing.Point(53, 266);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(378, 31);
            this.labelCID.TabIndex = 89;
            this.labelCID.Text = "ID: ";
            this.labelCID.Visible = false;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(53, 313);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(473, 37);
            this.labelName.TabIndex = 90;
            this.labelName.Text = "Name";
            this.labelName.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(53, 548);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(287, 31);
            this.labelStatus.TabIndex = 91;
            this.labelStatus.Text = "Status";
            this.labelStatus.Visible = false;
            // 
            // labelAge
            // 
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(53, 370);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(147, 31);
            this.labelAge.TabIndex = 92;
            this.labelAge.Text = "Age";
            this.labelAge.Visible = false;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(53, 584);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(482, 105);
            this.labelDescription.TabIndex = 93;
            this.labelDescription.Text = "Description";
            this.labelDescription.Visible = false;
            // 
            // labelHeight
            // 
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(53, 428);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(167, 31);
            this.labelHeight.TabIndex = 94;
            this.labelHeight.Text = "Height";
            this.labelHeight.Visible = false;
            // 
            // labelSex
            // 
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(231, 370);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(109, 31);
            this.labelSex.TabIndex = 95;
            this.labelSex.Text = "Sex";
            this.labelSex.Visible = false;
            // 
            // labelWeight
            // 
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(53, 471);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(193, 31);
            this.labelWeight.TabIndex = 96;
            this.labelWeight.Text = "Weight";
            this.labelWeight.Visible = false;
            // 
            // labelType
            // 
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(53, 517);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(287, 31);
            this.labelType.TabIndex = 97;
            this.labelType.Text = "Type";
            this.labelType.Visible = false;
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.AutoCompleteCustomSource.AddRange(new string[] {
            "Criminal",
            "Victim"});
            this.comboBoxSearchType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSearchType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "Victim",
            "Criminal"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(14, 161);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(123, 39);
            this.comboBoxSearchType.TabIndex = 122;
            this.comboBoxSearchType.Text = "Criminal";
            this.comboBoxSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(353, 689);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 13);
            this.label8.TabIndex = 176;
            this.label8.Text = "© 2012 Satvik Neelakant. All Rights Reserved.";
            this.label8.Visible = false;
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 702);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxSearchType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCID);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBoxSearch2);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelInsert);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.pictureBoxInsert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.softInfo);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.picboxGeneral);
            this.Name = "Search_Form";
            this.Text = "Search the Criminals";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label softInfo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.PictureBox picboxGeneral;
        private System.Windows.Forms.PictureBox pictureBoxInsert;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.PictureBox pictureBoxSearch2;
        private System.Windows.Forms.ComboBox textBoxSearch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.Label label8;

    }
}