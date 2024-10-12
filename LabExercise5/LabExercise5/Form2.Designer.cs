namespace LabExercise5
{
    partial class Form2
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
            lblStudentID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            textFirstName = new TextBox();
            textLastName = new TextBox();
            textAddress = new TextBox();
            textPhone = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(55, 70);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(65, 15);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "Student ID:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(55, 110);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(56, 153);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(61, 240);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(56, 197);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(146, 107);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(100, 23);
            textFirstName.TabIndex = 6;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(146, 150);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(100, 23);
            textLastName.TabIndex = 7;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(146, 194);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(100, 23);
            textAddress.TabIndex = 8;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(146, 237);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(100, 23);
            textPhone.TabIndex = 9;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(47, 299);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(181, 299);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 356);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textPhone);
            Controls.Add(textAddress);
            Controls.Add(textLastName);
            Controls.Add(textFirstName);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblStudentID);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Label lblAddress;
        private TextBox textFirstName;
        private TextBox textLastName;
        private TextBox textAddress;
        private TextBox textPhone;
        private Button buttonSave;
        private Button buttonCancel;
    }
}