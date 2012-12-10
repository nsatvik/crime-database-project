namespace WindowsFormsApplication1
{
    partial class SafetyTips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafetyTips));
            this.welcomeTextBox = new System.Windows.Forms.Label();
            this.softInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.AutoSize = true;
            this.welcomeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.welcomeTextBox.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextBox.Location = new System.Drawing.Point(308, 110);
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.Size = new System.Drawing.Size(210, 30);
            this.welcomeTextBox.TabIndex = 57;
            this.welcomeTextBox.Text = "General Safety Tips";
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
            this.softInfo.TabIndex = 56;
            this.softInfo.Text = "RV All In One Crime Information Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 121);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(996, 98);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 32);
            this.picHome.TabIndex = 58;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(12, 157);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(593, 320);
            this.labelQuestion.TabIndex = 84;
            this.labelQuestion.Text = resources.GetString("labelQuestion.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 216);
            this.label1.TabIndex = 85;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // labelUpdate
            // 
            this.labelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdate.Location = new System.Drawing.Point(906, 250);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(106, 31);
            this.labelUpdate.TabIndex = 87;
            this.labelUpdate.Text = "Update ";
            this.labelUpdate.Visible = false;
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpdate.Image")));
            this.pictureBoxUpdate.Location = new System.Drawing.Point(910, 172);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 86;
            this.pictureBoxUpdate.TabStop = false;
            this.pictureBoxUpdate.Visible = false;
            // 
            // SafetyTips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 702);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.pictureBoxUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.welcomeTextBox);
            this.Controls.Add(this.softInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SafetyTips";
            this.Text = "Safety Tips";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeTextBox;
        private System.Windows.Forms.Label softInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
    }
}