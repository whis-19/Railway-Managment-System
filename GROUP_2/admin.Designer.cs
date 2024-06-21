namespace GROUP_2
{
    partial class admin
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
            this.checkProfile = new System.Windows.Forms.Button();
            this.mngEmployees = new System.Windows.Forms.Button();
            this.revenue = new System.Windows.Forms.Button();
            this.viewTrains = new System.Windows.Forms.Button();
            this.trainSchedule = new System.Windows.Forms.Button();
            this.viewFeedback = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkProfile
            // 
            this.checkProfile.Location = new System.Drawing.Point(172, 94);
            this.checkProfile.Name = "checkProfile";
            this.checkProfile.Size = new System.Drawing.Size(110, 60);
            this.checkProfile.TabIndex = 0;
            this.checkProfile.Text = "Check Profile";
            this.checkProfile.UseVisualStyleBackColor = true;
            this.checkProfile.Click += new System.EventHandler(this.checkProfile_Click);
            // 
            // mngEmployees
            // 
            this.mngEmployees.Location = new System.Drawing.Point(30, 162);
            this.mngEmployees.Name = "mngEmployees";
            this.mngEmployees.Size = new System.Drawing.Size(110, 60);
            this.mngEmployees.TabIndex = 1;
            this.mngEmployees.Text = "Manage Employees";
            this.mngEmployees.UseVisualStyleBackColor = true;
            this.mngEmployees.Click += new System.EventHandler(this.mngEmployees_Click);
            // 
            // revenue
            // 
            this.revenue.Location = new System.Drawing.Point(310, 252);
            this.revenue.Name = "revenue";
            this.revenue.Size = new System.Drawing.Size(110, 60);
            this.revenue.TabIndex = 3;
            this.revenue.Text = "Generate Revenue";
            this.revenue.UseVisualStyleBackColor = true;
            this.revenue.Click += new System.EventHandler(this.button4_Click);
            // 
            // viewTrains
            // 
            this.viewTrains.Location = new System.Drawing.Point(172, 342);
            this.viewTrains.Name = "viewTrains";
            this.viewTrains.Size = new System.Drawing.Size(110, 60);
            this.viewTrains.TabIndex = 4;
            this.viewTrains.Text = "View Trains";
            this.viewTrains.UseVisualStyleBackColor = true;
            this.viewTrains.Click += new System.EventHandler(this.viewTrains_Click);
            // 
            // trainSchedule
            // 
            this.trainSchedule.Location = new System.Drawing.Point(30, 252);
            this.trainSchedule.Name = "trainSchedule";
            this.trainSchedule.Size = new System.Drawing.Size(110, 60);
            this.trainSchedule.TabIndex = 5;
            this.trainSchedule.Text = "Manage Train Schedule";
            this.trainSchedule.UseVisualStyleBackColor = true;
            this.trainSchedule.Click += new System.EventHandler(this.button6_Click);
            // 
            // viewFeedback
            // 
            this.viewFeedback.Location = new System.Drawing.Point(310, 162);
            this.viewFeedback.Name = "viewFeedback";
            this.viewFeedback.Size = new System.Drawing.Size(110, 60);
            this.viewFeedback.TabIndex = 7;
            this.viewFeedback.Text = "View Feedback";
            this.viewFeedback.UseVisualStyleBackColor = true;
            this.viewFeedback.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GROUP_2.Properties.Resources.ASSALA;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(155, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GROUP_2.Properties.Resources.adminBG;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(430, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 463);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(909, 456);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.viewFeedback);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trainSchedule);
            this.Controls.Add(this.viewTrains);
            this.Controls.Add(this.revenue);
            this.Controls.Add(this.mngEmployees);
            this.Controls.Add(this.checkProfile);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkProfile;
        private System.Windows.Forms.Button mngEmployees;
        private System.Windows.Forms.Button revenue;
        private System.Windows.Forms.Button viewTrains;
        private System.Windows.Forms.Button trainSchedule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewFeedback;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}