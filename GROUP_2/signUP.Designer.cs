namespace GROUP_2
{
    partial class signUP
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
            this.userNameBox = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.signUPButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.type = new System.Windows.Forms.Label();
            this.choice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameBox
            // 
            this.userNameBox.AutoSize = true;
            this.userNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameBox.Location = new System.Drawing.Point(202, 88);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(111, 20);
            this.userNameBox.TabIndex = 0;
            this.userNameBox.Text = "Enter email:";
            this.userNameBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(202, 148);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(148, 20);
            this.password.TabIndex = 1;
            this.password.Text = "Enter Password:";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(378, 86);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(147, 22);
            this.userName.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(378, 145);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(147, 22);
            this.passwordBox.TabIndex = 3;
            // 
            // signUPButton
            // 
            this.signUPButton.Location = new System.Drawing.Point(399, 272);
            this.signUPButton.Name = "signUPButton";
            this.signUPButton.Size = new System.Drawing.Size(98, 42);
            this.signUPButton.TabIndex = 4;
            this.signUPButton.Text = "Sign Up";
            this.signUPButton.UseVisualStyleBackColor = true;
            this.signUPButton.Click += new System.EventHandler(this.signUPButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Already have an account?";
            // 
            // loginn
            // 
            this.loginn.Location = new System.Drawing.Point(399, 349);
            this.loginn.Name = "loginn";
            this.loginn.Size = new System.Drawing.Size(98, 42);
            this.loginn.TabIndex = 12;
            this.loginn.Text = "Log In";
            this.loginn.UseVisualStyleBackColor = true;
            this.loginn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GROUP_2.Properties.Resources.ASSALA;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(713, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(202, 198);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(135, 20);
            this.type.TabIndex = 15;
            this.type.Text = "Account Type: ";
            // 
            // choice
            // 
            this.choice.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.choice.FormattingEnabled = true;
            this.choice.Items.AddRange(new object[] {
            "Admin",
            "Passenger",
            "Employee"});
            this.choice.Location = new System.Drawing.Point(378, 194);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(121, 24);
            this.choice.TabIndex = 14;
            this.choice.Text = "Choose";
            // 
            // signUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP_2.Properties.Resources.train_track;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 456);
            this.Controls.Add(this.type);
            this.Controls.Add(this.choice);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.loginn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUPButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userNameBox);
            this.Name = "signUP";
            this.Text = "signUP";
            this.Load += new System.EventHandler(this.signUP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button signUPButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.ComboBox choice;
    }
}