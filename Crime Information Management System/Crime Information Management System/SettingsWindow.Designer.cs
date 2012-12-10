namespace WindowsFormsApplication1
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.softInfo = new System.Windows.Forms.Label();
            this.welcomeTextBox = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureChPasswd = new System.Windows.Forms.PictureBox();
            this.pictureDelAcc = new System.Windows.Forms.PictureBox();
            this.labelPasswd = new System.Windows.Forms.Label();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.labelUname = new System.Windows.Forms.Label();
            this.textBoxUName = new System.Windows.Forms.TextBox();
            this.labelPassNew = new System.Windows.Forms.Label();
            this.textBoxPassNew = new System.Windows.Forms.TextBox();
            this.butConfirm = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.buttonCanDel = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelPassDel = new System.Windows.Forms.Label();
            this.textBoxPassDel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChPasswd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.softInfo.TabIndex = 19;
            this.softInfo.Text = "RV All In One Crime Information Management System";
            // 
            // welcomeTextBox
            // 
            this.welcomeTextBox.AutoSize = true;
            this.welcomeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.welcomeTextBox.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeTextBox.Location = new System.Drawing.Point(263, 131);
            this.welcomeTextBox.Name = "welcomeTextBox";
            this.welcomeTextBox.Size = new System.Drawing.Size(217, 30);
            this.welcomeTextBox.TabIndex = 18;
            this.welcomeTextBox.Text = "Change Settings for ";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.BackgroundImage")));
            this.pictureLogo.Location = new System.Drawing.Point(7, 9);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(121, 121);
            this.pictureLogo.TabIndex = 17;
            this.pictureLogo.TabStop = false;
            // 
            // pictureChPasswd
            // 
            this.pictureChPasswd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureChPasswd.BackgroundImage")));
            this.pictureChPasswd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureChPasswd.Location = new System.Drawing.Point(333, 238);
            this.pictureChPasswd.Name = "pictureChPasswd";
            this.pictureChPasswd.Size = new System.Drawing.Size(75, 75);
            this.pictureChPasswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureChPasswd.TabIndex = 20;
            this.pictureChPasswd.TabStop = false;
            this.pictureChPasswd.Click += new System.EventHandler(this.pictureChPasswd_Click);
            // 
            // pictureDelAcc
            // 
            this.pictureDelAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureDelAcc.BackgroundImage")));
            this.pictureDelAcc.Location = new System.Drawing.Point(333, 461);
            this.pictureDelAcc.Name = "pictureDelAcc";
            this.pictureDelAcc.Size = new System.Drawing.Size(75, 75);
            this.pictureDelAcc.TabIndex = 21;
            this.pictureDelAcc.TabStop = false;
            this.pictureDelAcc.Click += new System.EventHandler(this.pictureDelAcc_Click);
            // 
            // labelPasswd
            // 
            this.labelPasswd.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswd.Location = new System.Drawing.Point(547, 238);
            this.labelPasswd.Name = "labelPasswd";
            this.labelPasswd.Size = new System.Drawing.Size(106, 31);
            this.labelPasswd.TabIndex = 25;
            this.labelPasswd.Text = "Password";
            this.labelPasswd.Visible = false;
            this.labelPasswd.Click += new System.EventHandler(this.labelPasswd_Click);
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.BackColor = System.Drawing.Color.FloralWhite;
            this.textBoxPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswd.Location = new System.Drawing.Point(659, 238);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.PasswordChar = '*';
            this.textBoxPasswd.Size = new System.Drawing.Size(251, 29);
            this.textBoxPasswd.TabIndex = 24;
            this.textBoxPasswd.Visible = false;
            this.textBoxPasswd.TextChanged += new System.EventHandler(this.textBoxPasswd_TextChanged);
            // 
            // labelUname
            // 
            this.labelUname.BackColor = System.Drawing.Color.Transparent;
            this.labelUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUname.Location = new System.Drawing.Point(547, 196);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(106, 31);
            this.labelUname.TabIndex = 23;
            this.labelUname.Text = "Username";
            this.labelUname.Visible = false;
            this.labelUname.Click += new System.EventHandler(this.labelUname_Click);
            // 
            // textBoxUName
            // 
            this.textBoxUName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUName.Location = new System.Drawing.Point(659, 196);
            this.textBoxUName.Name = "textBoxUName";
            this.textBoxUName.Size = new System.Drawing.Size(251, 29);
            this.textBoxUName.TabIndex = 22;
            this.textBoxUName.Visible = false;
            this.textBoxUName.TextChanged += new System.EventHandler(this.textBoxUName_TextChanged);
            // 
            // labelPassNew
            // 
            this.labelPassNew.BackColor = System.Drawing.Color.Transparent;
            this.labelPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassNew.Location = new System.Drawing.Point(509, 287);
            this.labelPassNew.Name = "labelPassNew";
            this.labelPassNew.Size = new System.Drawing.Size(144, 31);
            this.labelPassNew.TabIndex = 27;
            this.labelPassNew.Text = "New Password";
            this.labelPassNew.Visible = false;
            this.labelPassNew.Click += new System.EventHandler(this.labelPassNew_Click);
            // 
            // textBoxPassNew
            // 
            this.textBoxPassNew.BackColor = System.Drawing.Color.Ivory;
            this.textBoxPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassNew.Location = new System.Drawing.Point(663, 287);
            this.textBoxPassNew.Name = "textBoxPassNew";
            this.textBoxPassNew.PasswordChar = '*';
            this.textBoxPassNew.Size = new System.Drawing.Size(247, 29);
            this.textBoxPassNew.TabIndex = 26;
            this.textBoxPassNew.Visible = false;
            this.textBoxPassNew.TextChanged += new System.EventHandler(this.textBoxPassNew_TextChanged);
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(659, 343);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(79, 37);
            this.butConfirm.TabIndex = 28;
            this.butConfirm.Text = "Confirm";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Visible = false;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(756, 343);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(79, 37);
            this.butCancel.TabIndex = 29;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Visible = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // buttonCanDel
            // 
            this.buttonCanDel.Location = new System.Drawing.Point(760, 529);
            this.buttonCanDel.Name = "buttonCanDel";
            this.buttonCanDel.Size = new System.Drawing.Size(79, 37);
            this.buttonCanDel.TabIndex = 33;
            this.buttonCanDel.Text = "Cancel";
            this.buttonCanDel.UseVisualStyleBackColor = true;
            this.buttonCanDel.Visible = false;
            this.buttonCanDel.Click += new System.EventHandler(this.buttonCanDel_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(663, 529);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(79, 37);
            this.buttonDel.TabIndex = 32;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Visible = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelPassDel
            // 
            this.labelPassDel.BackColor = System.Drawing.Color.Transparent;
            this.labelPassDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassDel.Location = new System.Drawing.Point(547, 474);
            this.labelPassDel.Name = "labelPassDel";
            this.labelPassDel.Size = new System.Drawing.Size(106, 31);
            this.labelPassDel.TabIndex = 31;
            this.labelPassDel.Text = "Password";
            this.labelPassDel.Visible = false;
            // 
            // textBoxPassDel
            // 
            this.textBoxPassDel.BackColor = System.Drawing.Color.Honeydew;
            this.textBoxPassDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassDel.Location = new System.Drawing.Point(659, 474);
            this.textBoxPassDel.Name = "textBoxPassDel";
            this.textBoxPassDel.PasswordChar = '*';
            this.textBoxPassDel.Size = new System.Drawing.Size(251, 29);
            this.textBoxPassDel.TabIndex = 30;
            this.textBoxPassDel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(996, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Delete Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Change Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(288, 680);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "© 2012 Satvik Neelakant. All Rights Reserved.";
            this.label8.Visible = false;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 702);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCanDel);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.labelPassDel);
            this.Controls.Add(this.textBoxPassDel);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.labelPassNew);
            this.Controls.Add(this.textBoxPassNew);
            this.Controls.Add(this.labelPasswd);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.labelUname);
            this.Controls.Add(this.textBoxUName);
            this.Controls.Add(this.pictureDelAcc);
            this.Controls.Add(this.pictureChPasswd);
            this.Controls.Add(this.softInfo);
            this.Controls.Add(this.welcomeTextBox);
            this.Controls.Add(this.pictureLogo);
            this.Name = "SettingsWindow";
            this.Text = "User Settings Window";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChPasswd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label softInfo;
        private System.Windows.Forms.Label welcomeTextBox;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.PictureBox pictureChPasswd;
        private System.Windows.Forms.PictureBox pictureDelAcc;
        private System.Windows.Forms.Label labelPasswd;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Label labelUname;
        private System.Windows.Forms.TextBox textBoxUName;
        private System.Windows.Forms.Label labelPassNew;
        private System.Windows.Forms.TextBox textBoxPassNew;
        private System.Windows.Forms.Button butConfirm;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button buttonCanDel;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelPassDel;
        private System.Windows.Forms.TextBox textBoxPassDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}