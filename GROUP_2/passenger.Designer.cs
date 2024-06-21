namespace GROUP_2
{
    partial class passenger
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
            this.bookReservation = new System.Windows.Forms.Button();
            this.prevReservation = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Button();
            this.trackTrain = new System.Windows.Forms.Button();
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
            this.checkProfile.TabIndex = 10;
            this.checkProfile.Text = "Check Profile";
            this.checkProfile.UseVisualStyleBackColor = true;
            this.checkProfile.Click += new System.EventHandler(this.checkProfile_Click);
            // 
            // bookReservation
            // 
            this.bookReservation.Location = new System.Drawing.Point(29, 175);
            this.bookReservation.Name = "bookReservation";
            this.bookReservation.Size = new System.Drawing.Size(110, 60);
            this.bookReservation.TabIndex = 11;
            this.bookReservation.Text = "Book Seat";
            this.bookReservation.UseVisualStyleBackColor = true;
            this.bookReservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // prevReservation
            // 
            this.prevReservation.Location = new System.Drawing.Point(306, 279);
            this.prevReservation.Name = "prevReservation";
            this.prevReservation.Size = new System.Drawing.Size(110, 60);
            this.prevReservation.TabIndex = 12;
            this.prevReservation.Text = "Previous Reservation";
            this.prevReservation.UseVisualStyleBackColor = true;
            // 
            // feedback
            // 
            this.feedback.Location = new System.Drawing.Point(29, 279);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(110, 60);
            this.feedback.TabIndex = 13;
            this.feedback.Text = "Feedback";
            this.feedback.UseVisualStyleBackColor = true;
            this.feedback.Click += new System.EventHandler(this.button3_Click);
            // 
            // trackTrain
            // 
            this.trackTrain.Location = new System.Drawing.Point(306, 175);
            this.trackTrain.Name = "trackTrain";
            this.trackTrain.Size = new System.Drawing.Size(110, 60);
            this.trackTrain.TabIndex = 14;
            this.trackTrain.Text = "Track Train";
            this.trackTrain.UseVisualStyleBackColor = true;
            this.trackTrain.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GROUP_2.Properties.Resources.ASSALA;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(155, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GROUP_2.Properties.Resources.passenger;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(430, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 463);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 456);
            this.Controls.Add(this.trackTrain);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.prevReservation);
            this.Controls.Add(this.bookReservation);
            this.Controls.Add(this.checkProfile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "passenger";
            this.Text = "passenger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button checkProfile;
        private System.Windows.Forms.Button bookReservation;
        private System.Windows.Forms.Button prevReservation;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button trackTrain;
    }
}