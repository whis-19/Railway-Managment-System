namespace GROUP_2
{
    partial class manageEmployees
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
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.employeesView = new System.Windows.Forms.DataGridView();
            this.empNameBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.arrivalCity = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.salaryBOX = new System.Windows.Forms.TextBox();
            this.Task = new System.Windows.Forms.Label();
            this.assignTask = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.addressBOX = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.taskbox = new System.Windows.Forms.TextBox();
            this.contactBOX = new System.Windows.Forms.TextBox();
            this.employeeID = new System.Windows.Forms.Label();
            this.empIDbox = new System.Windows.Forms.TextBox();
            this.cnic = new System.Windows.Forms.TextBox();
            this.cnicLABEL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(645, 434);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 34);
            this.delete.TabIndex = 52;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(803, 434);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 34);
            this.update.TabIndex = 51;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(476, 434);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 34);
            this.add.TabIndex = 49;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Search ID";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(555, 122);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 22);
            this.inputBox.TabIndex = 46;
            // 
            // employeesView
            // 
            this.employeesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesView.Location = new System.Drawing.Point(476, 157);
            this.employeesView.Name = "employeesView";
            this.employeesView.RowHeadersWidth = 51;
            this.employeesView.RowTemplate.Height = 24;
            this.employeesView.Size = new System.Drawing.Size(402, 261);
            this.employeesView.TabIndex = 45;
            this.employeesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesView_CellContentClick);
            this.employeesView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employeesView_RowHeaderMouseClick);
            // 
            // empNameBox
            // 
            this.empNameBox.Location = new System.Drawing.Point(162, 235);
            this.empNameBox.Name = "empNameBox";
            this.empNameBox.Size = new System.Drawing.Size(181, 22);
            this.empNameBox.TabIndex = 41;
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(162, 360);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(181, 22);
            this.categoryBox.TabIndex = 40;
            // 
            // arrivalCity
            // 
            this.arrivalCity.AutoSize = true;
            this.arrivalCity.Location = new System.Drawing.Point(42, 360);
            this.arrivalCity.Name = "arrivalCity";
            this.arrivalCity.Size = new System.Drawing.Size(65, 16);
            this.arrivalCity.TabIndex = 37;
            this.arrivalCity.Text = "Category:";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(42, 238);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(112, 16);
            this.employeeName.TabIndex = 35;
            this.employeeName.Text = "Employee Name:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(246, 42);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(342, 41);
            this.title.TabIndex = 34;
            this.title.Text = "Manage Employees";
            // 
            // salaryBOX
            // 
            this.salaryBOX.Location = new System.Drawing.Point(162, 446);
            this.salaryBOX.Name = "salaryBOX";
            this.salaryBOX.Size = new System.Drawing.Size(181, 22);
            this.salaryBOX.TabIndex = 43;
            // 
            // Task
            // 
            this.Task.AutoSize = true;
            this.Task.Location = new System.Drawing.Point(42, 402);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(41, 16);
            this.Task.TabIndex = 38;
            this.Task.Text = "Task:";
            this.Task.Click += new System.EventHandler(this.Task_Click);
            // 
            // assignTask
            // 
            this.assignTask.Location = new System.Drawing.Point(189, 626);
            this.assignTask.Name = "assignTask";
            this.assignTask.Size = new System.Drawing.Size(100, 35);
            this.assignTask.TabIndex = 53;
            this.assignTask.Text = "Assign Task";
            this.assignTask.UseVisualStyleBackColor = true;
            this.assignTask.Click += new System.EventHandler(this.assignTask_Click);
            // 
            // search
            // 
            this.search.BackgroundImage = global::GROUP_2.Properties.Resources.search;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.Location = new System.Drawing.Point(661, 121);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(30, 25);
            this.search.TabIndex = 56;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GROUP_2.Properties.Resources.ASSALA;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(30, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(42, 317);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 16);
            this.password.TabIndex = 57;
            this.password.Text = "Password:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(42, 283);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(44, 16);
            this.email.TabIndex = 58;
            this.email.Text = "Email:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(162, 277);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(181, 22);
            this.emailBox.TabIndex = 59;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(162, 317);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(181, 22);
            this.passwordBox.TabIndex = 60;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(42, 452);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(49, 16);
            this.salary.TabIndex = 61;
            this.salary.Text = "Salary:";
            // 
            // addressBOX
            // 
            this.addressBOX.Location = new System.Drawing.Point(162, 492);
            this.addressBOX.Name = "addressBOX";
            this.addressBOX.Size = new System.Drawing.Size(181, 22);
            this.addressBOX.TabIndex = 62;
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.Location = new System.Drawing.Point(42, 536);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(55, 16);
            this.contact.TabIndex = 64;
            this.contact.Text = "Contact:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(42, 498);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(61, 16);
            this.address.TabIndex = 65;
            this.address.Text = "Address:";
            // 
            // taskbox
            // 
            this.taskbox.Location = new System.Drawing.Point(162, 399);
            this.taskbox.Name = "taskbox";
            this.taskbox.Size = new System.Drawing.Size(181, 22);
            this.taskbox.TabIndex = 66;
            // 
            // contactBOX
            // 
            this.contactBOX.Location = new System.Drawing.Point(162, 536);
            this.contactBOX.Name = "contactBOX";
            this.contactBOX.Size = new System.Drawing.Size(181, 22);
            this.contactBOX.TabIndex = 67;
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.Location = new System.Drawing.Point(42, 196);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(88, 16);
            this.employeeID.TabIndex = 36;
            this.employeeID.Text = "Employee ID:";
            // 
            // empIDbox
            // 
            this.empIDbox.Location = new System.Drawing.Point(162, 193);
            this.empIDbox.Name = "empIDbox";
            this.empIDbox.Size = new System.Drawing.Size(181, 22);
            this.empIDbox.TabIndex = 42;
            // 
            // cnic
            // 
            this.cnic.Location = new System.Drawing.Point(162, 575);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(181, 22);
            this.cnic.TabIndex = 68;
            // 
            // cnicLABEL
            // 
            this.cnicLABEL.AutoSize = true;
            this.cnicLABEL.Location = new System.Drawing.Point(42, 581);
            this.cnicLABEL.Name = "cnicLABEL";
            this.cnicLABEL.Size = new System.Drawing.Size(41, 16);
            this.cnicLABEL.TabIndex = 69;
            this.cnicLABEL.Text = "CNIC:";
            // 
            // manageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP_2.Properties.Resources.train_track;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 712);
            this.Controls.Add(this.cnicLABEL);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.contactBOX);
            this.Controls.Add(this.taskbox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.addressBOX);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.search);
            this.Controls.Add(this.assignTask);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.employeesView);
            this.Controls.Add(this.salaryBOX);
            this.Controls.Add(this.empIDbox);
            this.Controls.Add(this.empNameBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.arrivalCity);
            this.Controls.Add(this.employeeID);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox2);
            this.Name = "manageEmployees";
            this.Text = "manageEmployees";
            this.Load += new System.EventHandler(this.manageEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.DataGridView employeesView;
        private System.Windows.Forms.TextBox empNameBox;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label arrivalCity;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox salaryBOX;
        private System.Windows.Forms.Label Task;
        private System.Windows.Forms.Button assignTask;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.TextBox addressBOX;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox taskbox;
        private System.Windows.Forms.TextBox contactBOX;
        private System.Windows.Forms.Label employeeID;
        private System.Windows.Forms.TextBox empIDbox;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.Label cnicLABEL;
    }
}