namespace WindowsFormsApplication1
{
    partial class FIR_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIR_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.softInfo = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.welcomeTextBox = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancelFIR = new System.Windows.Forms.Button();
            this.labelFIRID = new System.Windows.Forms.Label();
            this.labelFileFIR = new System.Windows.Forms.Label();
            this.labelViewFIR = new System.Windows.Forms.Label();
            this.pictureBoxFIR = new System.Windows.Forms.PictureBox();
            this.pictureBoxViewFIR = new System.Windows.Forms.PictureBox();
            this.labelFIRbyYou = new System.Windows.Forms.Label();
            this.textBoxFIRID = new System.Windows.Forms.TextBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridFIRs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewFIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFIRs)).BeginInit();
            this.SuspendLayout();
            // 
            // picHome
            // 
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(964, 98);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 32);
            this.picHome.TabIndex = 39;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // softInfo
            // 
            this.softInfo.AutoSize = true;
            this.softInfo.BackColor = System.Drawing.Color.Transparent;
            this.softInfo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.softInfo.ForeColor = System.Drawing.Color.Brown;
            this.softInfo.Location = new System.Drawing.Point(133, 9);
            this.softInfo.Name = "softInfo";
            this.softInfo.Size = new System.Drawing.Size(796, 45);
            this.softInfo.TabIndex = 37;
            this.softInfo.Text = "RV All In One Crime Information Management System";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.BackgroundImage")));
            this.pictureLogo.Location = new System.Drawing.Point(6, 9);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(121, 121);
            this.pictureLogo.TabIndex = 36;
            this.pictureLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 41;
            this.label1.Visible = false;
            // 
            // labelSubject
            // 
            this.labelSubject.BackColor = System.Drawing.Color.Transparent;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(247, 227);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(106, 31);
            this.labelSubject.TabIndex = 43;
            this.labelSubject.Text = "Subject";
            this.labelSubject.Visible = false;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BackColor = System.Drawing.Color.White;
            this.textBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubject.Location = new System.Drawing.Point(359, 227);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(251, 29);
            this.textBoxSubject.TabIndex = 42;
            this.textBoxSubject.Visible = false;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(247, 281);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(106, 31);
            this.labelDescription.TabIndex = 45;
            this.labelDescription.Text = "Description";
            this.labelDescription.Visible = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(359, 281);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(292, 172);
            this.textBoxDescription.TabIndex = 44;
            this.textBoxDescription.Visible = false;
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.AutoSize = true;
            this.welcomeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.welcomeTextBox.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextBox.Location = new System.Drawing.Point(311, 110);
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.Size = new System.Drawing.Size(248, 30);
            this.welcomeTextBox.TabIndex = 50;
            this.welcomeTextBox.Text = " Fill in the FIR Details";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(251, 524);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(146, 45);
            this.buttonSubmit.TabIndex = 51;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancelFIR
            // 
            this.buttonCancelFIR.Location = new System.Drawing.Point(424, 524);
            this.buttonCancelFIR.Name = "buttonCancelFIR";
            this.buttonCancelFIR.Size = new System.Drawing.Size(146, 45);
            this.buttonCancelFIR.TabIndex = 52;
            this.buttonCancelFIR.Text = "Cancel";
            this.buttonCancelFIR.UseVisualStyleBackColor = true;
            this.buttonCancelFIR.Visible = false;
            this.buttonCancelFIR.Click += new System.EventHandler(this.buttonCancelFIR_Click);
            // 
            // labelFIRID
            // 
            this.labelFIRID.AutoSize = true;
            this.labelFIRID.BackColor = System.Drawing.Color.Transparent;
            this.labelFIRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFIRID.Location = new System.Drawing.Point(247, 177);
            this.labelFIRID.Name = "labelFIRID";
            this.labelFIRID.Size = new System.Drawing.Size(61, 24);
            this.labelFIRID.TabIndex = 53;
            this.labelFIRID.Text = "FIR ID";
            this.labelFIRID.Visible = false;
            // 
            // labelFileFIR
            // 
            this.labelFileFIR.AutoSize = true;
            this.labelFileFIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileFIR.Location = new System.Drawing.Point(27, 305);
            this.labelFileFIR.Name = "labelFileFIR";
            this.labelFileFIR.Size = new System.Drawing.Size(62, 16);
            this.labelFileFIR.TabIndex = 57;
            this.labelFileFIR.Text = "File FIR";
            // 
            // labelViewFIR
            // 
            this.labelViewFIR.AutoSize = true;
            this.labelViewFIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewFIR.Location = new System.Drawing.Point(28, 418);
            this.labelViewFIR.Name = "labelViewFIR";
            this.labelViewFIR.Size = new System.Drawing.Size(77, 16);
            this.labelViewFIR.TabIndex = 56;
            this.labelViewFIR.Text = "View FIRs";
            // 
            // pictureBoxFIR
            // 
            this.pictureBoxFIR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFIR.BackgroundImage")));
            this.pictureBoxFIR.Location = new System.Drawing.Point(30, 216);
            this.pictureBoxFIR.Name = "pictureBoxFIR";
            this.pictureBoxFIR.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxFIR.TabIndex = 55;
            this.pictureBoxFIR.TabStop = false;
            this.pictureBoxFIR.Click += new System.EventHandler(this.pictureBoxFIR_Click);
            // 
            // pictureBoxViewFIR
            // 
            this.pictureBoxViewFIR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxViewFIR.BackgroundImage")));
            this.pictureBoxViewFIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxViewFIR.Location = new System.Drawing.Point(30, 340);
            this.pictureBoxViewFIR.Name = "pictureBoxViewFIR";
            this.pictureBoxViewFIR.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxViewFIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxViewFIR.TabIndex = 54;
            this.pictureBoxViewFIR.TabStop = false;
            this.pictureBoxViewFIR.Click += new System.EventHandler(this.pictureBoxViewFIR_Click);
            // 
            // labelFIRbyYou
            // 
            this.labelFIRbyYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFIRbyYou.Location = new System.Drawing.Point(895, 179);
            this.labelFIRbyYou.Name = "labelFIRbyYou";
            this.labelFIRbyYou.Size = new System.Drawing.Size(149, 19);
            this.labelFIRbyYou.TabIndex = 86;
            this.labelFIRbyYou.Text = "FIRs Submitted By You";
            // 
            // textBoxFIRID
            // 
            this.textBoxFIRID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxFIRID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFIRID.BackColor = System.Drawing.Color.White;
            this.textBoxFIRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFIRID.Location = new System.Drawing.Point(359, 179);
            this.textBoxFIRID.Name = "textBoxFIRID";
            this.textBoxFIRID.Size = new System.Drawing.Size(251, 29);
            this.textBoxFIRID.TabIndex = 87;
            this.textBoxFIRID.Visible = false;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(631, 179);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxSearch.TabIndex = 88;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Visible = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(247, 456);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(363, 31);
            this.labelStatus.TabIndex = 89;
            this.labelStatus.Text = "Status";
            this.labelStatus.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(356, 689);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "© 2012 Satvik Neelakant. All Rights Reserved.";
            this.label8.Visible = false;
            // 
            // dataGridFIRs
            // 
            this.dataGridFIRs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridFIRs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridFIRs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFIRs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFIRs.Location = new System.Drawing.Point(916, 201);
            this.dataGridFIRs.Name = "dataGridFIRs";
            this.dataGridFIRs.ReadOnly = true;
            this.dataGridFIRs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridFIRs.Size = new System.Drawing.Size(128, 445);
            this.dataGridFIRs.TabIndex = 92;
            // 
            // FIR_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 702);
            this.Controls.Add(this.dataGridFIRs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.textBoxFIRID);
            this.Controls.Add(this.labelFIRbyYou);
            this.Controls.Add(this.labelFileFIR);
            this.Controls.Add(this.labelViewFIR);
            this.Controls.Add(this.pictureBoxFIR);
            this.Controls.Add(this.pictureBoxViewFIR);
            this.Controls.Add(this.labelFIRID);
            this.Controls.Add(this.buttonCancelFIR);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.welcomeTextBox);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.softInfo);
            this.Controls.Add(this.pictureLogo);
            this.Name = "FIR_Form";
            this.Text = "First Information Report Form";
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewFIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFIRs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label softInfo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label welcomeTextBox;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancelFIR;
        private System.Windows.Forms.Label labelFIRID;
        private System.Windows.Forms.Label labelFileFIR;
        private System.Windows.Forms.Label labelViewFIR;
        private System.Windows.Forms.PictureBox pictureBoxFIR;
        private System.Windows.Forms.PictureBox pictureBoxViewFIR;
        private System.Windows.Forms.Label labelFIRbyYou;
        private System.Windows.Forms.TextBox textBoxFIRID;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridFIRs;
    }
}