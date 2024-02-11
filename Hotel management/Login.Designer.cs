using Microsoft.VisualBasic.ApplicationServices;

namespace Hotel_management
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserID = new Label();
            Password = new Label();
            UserIDTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginBtn = new Button();
            ExitBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // UserID
            // 
            UserID.AutoSize = true;
            UserID.Location = new Point(245, 204);
            UserID.Name = "UserID";
            UserID.Size = new Size(53, 20);
            UserID.TabIndex = 0;
            UserID.Text = "UserID";
            UserID.Click += UserID_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(245, 253);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 1;
            Password.Text = "Password";
            Password.Click += Password_Click;
            // 
            // UserIDTextBox
            // 
            UserIDTextBox.Location = new Point(363, 204);
            UserIDTextBox.Name = "UserIDTextBox";
            UserIDTextBox.Size = new Size(178, 27);
            UserIDTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(363, 250);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(178, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(149, 325);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(149, 73);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(505, 324);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(135, 73);
            ExitBtn.TabIndex = 5;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(200, 61);
            label1.Name = "label1";
            label1.Size = new Size(440, 67);
            label1.TabIndex = 6;
            label1.Text = "Tigress Resort";
            label1.ForeColor = Color.White; // Set font color to white
            label1.BackColor = Color.Transparent; // Remove background color
            label1.Click += label1_Click;


            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ExitBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserIDTextBox);
            Controls.Add(Password);
            Controls.Add(UserID);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserID;
        private Label Password;
        private TextBox UserIDTextBox;
        private TextBox PasswordTextBox;
        private Button LoginBtn;
        private Button ExitBtn;
        private Label label1;
    }
}
