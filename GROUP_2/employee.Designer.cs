namespace GROUP_2
{
    partial class employee
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkProfile = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.Button();
            this.todo = new System.Windows.Forms.Button();
            this.custSupport = new System.Windows.Forms.Button();
            this.ticketSelling = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GROUP_2.Properties.Resources.employee;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(430, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 463);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GROUP_2.Properties.Resources.ASSALA;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(155, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // checkProfile
            // 
            this.checkProfile.Location = new System.Drawing.Point(172, 94);
            this.checkProfile.Name = "checkProfile";
            this.checkProfile.Size = new System.Drawing.Size(110, 60);
            this.checkProfile.TabIndex = 11;
            this.checkProfile.Text = "Check Profile";
            this.checkProfile.UseVisualStyleBackColor = true;
            this.checkProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(306, 279);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(110, 60);
            this.salary.TabIndex = 12;
            this.salary.Text = "Salary";
            this.salary.UseVisualStyleBackColor = true;
            // 
            // todo
            // 
            this.todo.Location = new System.Drawing.Point(29, 175);
            this.todo.Name = "todo";
            this.todo.Size = new System.Drawing.Size(110, 60);
            this.todo.TabIndex = 13;
            this.todo.Text = "To-Do";
            this.todo.UseVisualStyleBackColor = true;
            // 
            // custSupport
            // 
            this.custSupport.Location = new System.Drawing.Point(29, 279);
            this.custSupport.Name = "custSupport";
            this.custSupport.Size = new System.Drawing.Size(110, 60);
            this.custSupport.TabIndex = 14;
            this.custSupport.Text = "Customer Support";
            this.custSupport.UseVisualStyleBackColor = true;
            // 
            // ticketSelling
            // 
            this.ticketSelling.Location = new System.Drawing.Point(306, 175);
            this.ticketSelling.Name = "ticketSelling";
            this.ticketSelling.Size = new System.Drawing.Size(110, 60);
            this.ticketSelling.TabIndex = 15;
            this.ticketSelling.Text = "Selling Of Ticket";
            this.ticketSelling.UseVisualStyleBackColor = true;
            this.ticketSelling.Click += new System.EventHandler(this.ticketSelling_Click);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 456);
            this.Controls.Add(this.ticketSelling);
            this.Controls.Add(this.custSupport);
            this.Controls.Add(this.todo);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.checkProfile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "employee";
            this.Text = "employee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button checkProfile;
        private System.Windows.Forms.Button salary;
        private System.Windows.Forms.Button todo;
        private System.Windows.Forms.Button custSupport;
        private System.Windows.Forms.Button ticketSelling;
    }
}