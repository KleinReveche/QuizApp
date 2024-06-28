using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Forms
{
    partial class EntryForm
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
            panelLeft = new Panel();
            ActionBar2 = new Panel();
            pictureBox1 = new PictureBox();
            panelRegister = new Panel();
            boxRegisterLastName = new ReaLTaiizor.Controls.HopeTextBox();
            lblLastName = new Label();
            boxRegisterFirstName = new ReaLTaiizor.Controls.HopeTextBox();
            btnRegister = new ReaLTaiizor.Controls.ForeverButton();
            lblFirstName = new Label();
            lblSwitchToLogin = new Label();
            lblRegister = new Label();
            boxEmail = new ReaLTaiizor.Controls.HopeTextBox();
            lblUsername = new Label();
            boxRepeatPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblPassword = new Label();
            boxRegisterPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblRepeatPassword = new Label();
            boxRegisterUsername = new ReaLTaiizor.Controls.HopeTextBox();
            lblEmail = new Label();
            panelLogin = new Panel();
            lblSwitchToRegister = new Label();
            btnLogin = new ReaLTaiizor.Controls.ForeverButton();
            boxLoginPassword = new ReaLTaiizor.Controls.HopeTextBox();
            boxLoginUsername = new ReaLTaiizor.Controls.HopeTextBox();
            lblLoginPassword = new Label();
            lblLoginUsername = new Label();
            lblLogin = new Label();
            lblClose = new Label();
            ActionBar = new Panel();
            panelRight = new Panel();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRegister.SuspendLayout();
            panelLogin.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(152, 26, 37);
            panelLeft.Controls.Add(ActionBar2);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(4, 3, 4, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(346, 627);
            panelLeft.TabIndex = 0;
            // 
            // ActionBar2
            // 
            ActionBar2.Location = new Point(0, 3);
            ActionBar2.Name = "ActionBar2";
            ActionBar2.Size = new Size(346, 39);
            ActionBar2.TabIndex = 2;
            ActionBar2.MouseDown += ActionBar_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Resources.trace_logo;
            pictureBox1.Image = Resources.trace_logo;
            pictureBox1.InitialImage = Resources.trace_logo;
            pictureBox1.Location = new Point(63, 210);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(boxRegisterLastName);
            panelRegister.Controls.Add(lblLastName);
            panelRegister.Controls.Add(boxRegisterFirstName);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(lblFirstName);
            panelRegister.Controls.Add(lblSwitchToLogin);
            panelRegister.Controls.Add(lblRegister);
            panelRegister.Controls.Add(boxEmail);
            panelRegister.Controls.Add(lblUsername);
            panelRegister.Controls.Add(boxRepeatPassword);
            panelRegister.Controls.Add(lblPassword);
            panelRegister.Controls.Add(boxRegisterPassword);
            panelRegister.Controls.Add(lblRepeatPassword);
            panelRegister.Controls.Add(boxRegisterUsername);
            panelRegister.Controls.Add(lblEmail);
            panelRegister.Location = new Point(1, 44);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(427, 559);
            panelRegister.TabIndex = 8;
            panelRegister.Visible = false;
            // 
            // boxRegisterLastName
            // 
            boxRegisterLastName.BackColor = Color.FromArgb(29, 16, 15);
            boxRegisterLastName.BaseColor = Color.FromArgb(29, 16, 15);
            boxRegisterLastName.BorderColorA = Color.FromArgb(64, 158, 255);
            boxRegisterLastName.BorderColorB = Color.FromArgb(246, 221, 218);
            boxRegisterLastName.Font = new Font("Segoe UI", 12F);
            boxRegisterLastName.ForeColor = Color.FromArgb(255, 249, 249);
            boxRegisterLastName.Hint = "";
            boxRegisterLastName.Location = new Point(219, 96);
            boxRegisterLastName.MaxLength = 32767;
            boxRegisterLastName.Multiline = false;
            boxRegisterLastName.Name = "boxRegisterLastName";
            boxRegisterLastName.PasswordChar = '\0';
            boxRegisterLastName.ScrollBars = ScrollBars.None;
            boxRegisterLastName.SelectedText = "";
            boxRegisterLastName.SelectionLength = 0;
            boxRegisterLastName.SelectionStart = 0;
            boxRegisterLastName.Size = new Size(184, 38);
            boxRegisterLastName.TabIndex = 14;
            boxRegisterLastName.TabStop = false;
            boxRegisterLastName.UseSystemPasswordChar = false;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.FromArgb(255, 249, 249);
            lblLastName.Location = new Point(212, 71);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(97, 21);
            lblLastName.TabIndex = 13;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.TopCenter;
            // 
            // boxRegisterFirstName
            // 
            boxRegisterFirstName.BackColor = Color.FromArgb(29, 16, 15);
            boxRegisterFirstName.BaseColor = Color.FromArgb(29, 16, 15);
            boxRegisterFirstName.BorderColorA = Color.FromArgb(64, 158, 255);
            boxRegisterFirstName.BorderColorB = Color.FromArgb(246, 221, 218);
            boxRegisterFirstName.Font = new Font("Segoe UI", 12F);
            boxRegisterFirstName.ForeColor = Color.FromArgb(255, 249, 249);
            boxRegisterFirstName.Hint = "";
            boxRegisterFirstName.Location = new Point(30, 96);
            boxRegisterFirstName.MaxLength = 32767;
            boxRegisterFirstName.Multiline = false;
            boxRegisterFirstName.Name = "boxRegisterFirstName";
            boxRegisterFirstName.PasswordChar = '\0';
            boxRegisterFirstName.ScrollBars = ScrollBars.None;
            boxRegisterFirstName.SelectedText = "";
            boxRegisterFirstName.SelectionLength = 0;
            boxRegisterFirstName.SelectionStart = 0;
            boxRegisterFirstName.Size = new Size(183, 38);
            boxRegisterFirstName.TabIndex = 12;
            boxRegisterFirstName.TabStop = false;
            boxRegisterFirstName.UseSystemPasswordChar = false;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BaseColor = Color.FromArgb(229, 196, 146);
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.Location = new Point(43, 467);
            btnRegister.Name = "btnRegister";
            btnRegister.Rounded = true;
            btnRegister.Size = new Size(351, 45);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.TextColor = Color.FromArgb(65, 45, 5);
            btnRegister.Click += btnAction_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.FromArgb(255, 249, 249);
            lblFirstName.Location = new Point(23, 71);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(95, 21);
            lblFirstName.TabIndex = 11;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSwitchToLogin
            // 
            lblSwitchToLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblSwitchToLogin.AutoSize = true;
            lblSwitchToLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSwitchToLogin.ForeColor = Color.FromArgb(255, 249, 249);
            lblSwitchToLogin.Location = new Point(131, 515);
            lblSwitchToLogin.Margin = new Padding(4, 0, 4, 0);
            lblSwitchToLogin.Name = "lblSwitchToLogin";
            lblSwitchToLogin.Size = new Size(169, 15);
            lblSwitchToLogin.TabIndex = 7;
            lblSwitchToLogin.Text = "Already Registered? Login here";
            lblSwitchToLogin.TextAlign = ContentAlignment.MiddleCenter;
            lblSwitchToLogin.Click += lblSwitchEntryForm_Click;
            // 
            // lblRegister
            // 
            lblRegister.Anchor = AnchorStyles.None;
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.FromArgb(255, 249, 249);
            lblRegister.Location = new Point(18, 28);
            lblRegister.Margin = new Padding(4, 0, 4, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(107, 30);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            // 
            // boxEmail
            // 
            boxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxEmail.BackColor = Color.FromArgb(29, 16, 15);
            boxEmail.BaseColor = Color.FromArgb(29, 16, 15);
            boxEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            boxEmail.BorderColorB = Color.FromArgb(246, 221, 218);
            boxEmail.Font = new Font("Segoe UI", 12F);
            boxEmail.ForeColor = Color.FromArgb(255, 249, 249);
            boxEmail.Hint = "";
            boxEmail.Location = new Point(32, 401);
            boxEmail.MaxLength = 32767;
            boxEmail.Multiline = false;
            boxEmail.Name = "boxEmail";
            boxEmail.PasswordChar = '\0';
            boxEmail.ScrollBars = ScrollBars.None;
            boxEmail.SelectedText = "";
            boxEmail.SelectionLength = 0;
            boxEmail.SelectionStart = 0;
            boxEmail.Size = new Size(371, 38);
            boxEmail.TabIndex = 6;
            boxEmail.TabStop = false;
            boxEmail.UseSystemPasswordChar = false;
            boxEmail.KeyPress += box_KeyPress;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(255, 249, 249);
            lblUsername.Location = new Point(26, 146);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // boxRepeatPassword
            // 
            boxRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxRepeatPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxRepeatPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxRepeatPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxRepeatPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxRepeatPassword.Font = new Font("Segoe UI", 12F);
            boxRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxRepeatPassword.Hint = "";
            boxRepeatPassword.Location = new Point(32, 327);
            boxRepeatPassword.MaxLength = 32767;
            boxRepeatPassword.Multiline = false;
            boxRepeatPassword.Name = "boxRepeatPassword";
            boxRepeatPassword.PasswordChar = '\0';
            boxRepeatPassword.ScrollBars = ScrollBars.None;
            boxRepeatPassword.SelectedText = "";
            boxRepeatPassword.SelectionLength = 0;
            boxRepeatPassword.SelectionStart = 0;
            boxRepeatPassword.Size = new Size(371, 38);
            boxRepeatPassword.TabIndex = 5;
            boxRepeatPassword.TabStop = false;
            boxRepeatPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblPassword.Location = new Point(28, 229);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // boxRegisterPassword
            // 
            boxRegisterPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxRegisterPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxRegisterPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxRegisterPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxRegisterPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxRegisterPassword.Font = new Font("Segoe UI", 12F);
            boxRegisterPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxRegisterPassword.Hint = "";
            boxRegisterPassword.Location = new Point(32, 254);
            boxRegisterPassword.MaxLength = 32767;
            boxRegisterPassword.Multiline = false;
            boxRegisterPassword.Name = "boxRegisterPassword";
            boxRegisterPassword.PasswordChar = '\0';
            boxRegisterPassword.ScrollBars = ScrollBars.None;
            boxRegisterPassword.SelectedText = "";
            boxRegisterPassword.SelectionLength = 0;
            boxRegisterPassword.SelectionStart = 0;
            boxRegisterPassword.Size = new Size(371, 38);
            boxRegisterPassword.TabIndex = 4;
            boxRegisterPassword.TabStop = false;
            boxRegisterPassword.UseSystemPasswordChar = true;
            boxRegisterPassword.KeyPress += box_KeyPress;
            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblRepeatPassword.Location = new Point(30, 303);
            lblRepeatPassword.Margin = new Padding(4, 0, 4, 0);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(149, 21);
            lblRepeatPassword.TabIndex = 0;
            lblRepeatPassword.Text = "Repeat Password:";
            // 
            // boxRegisterUsername
            // 
            boxRegisterUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxRegisterUsername.BackColor = Color.FromArgb(29, 16, 15);
            boxRegisterUsername.BaseColor = Color.FromArgb(29, 16, 15);
            boxRegisterUsername.BorderColorA = Color.FromArgb(64, 158, 255);
            boxRegisterUsername.BorderColorB = Color.FromArgb(246, 221, 218);
            boxRegisterUsername.Font = new Font("Segoe UI", 12F);
            boxRegisterUsername.ForeColor = Color.FromArgb(255, 249, 249);
            boxRegisterUsername.Hint = "";
            boxRegisterUsername.Location = new Point(32, 173);
            boxRegisterUsername.MaxLength = 32767;
            boxRegisterUsername.Multiline = false;
            boxRegisterUsername.Name = "boxRegisterUsername";
            boxRegisterUsername.PasswordChar = '\0';
            boxRegisterUsername.ScrollBars = ScrollBars.None;
            boxRegisterUsername.SelectedText = "";
            boxRegisterUsername.SelectionLength = 0;
            boxRegisterUsername.SelectionStart = 0;
            boxRegisterUsername.Size = new Size(371, 38);
            boxRegisterUsername.TabIndex = 3;
            boxRegisterUsername.TabStop = false;
            boxRegisterUsername.UseSystemPasswordChar = false;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(255, 249, 249);
            lblEmail.Location = new Point(29, 375);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 21);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Trace Email:";
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(lblSwitchToRegister);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(boxLoginPassword);
            panelLogin.Controls.Add(boxLoginUsername);
            panelLogin.Controls.Add(lblLoginPassword);
            panelLogin.Controls.Add(lblLoginUsername);
            panelLogin.Controls.Add(lblLogin);
            panelLogin.Location = new Point(1, 115);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(426, 337);
            panelLogin.TabIndex = 0;
            // 
            // lblSwitchToRegister
            // 
            lblSwitchToRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblSwitchToRegister.AutoSize = true;
            lblSwitchToRegister.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSwitchToRegister.ForeColor = Color.FromArgb(255, 249, 249);
            lblSwitchToRegister.Location = new Point(106, 289);
            lblSwitchToRegister.Margin = new Padding(4, 0, 4, 0);
            lblSwitchToRegister.Name = "lblSwitchToRegister";
            lblSwitchToRegister.Size = new Size(221, 15);
            lblSwitchToRegister.TabIndex = 11;
            lblSwitchToRegister.Text = "Don't have an account yet? Register here";
            lblSwitchToRegister.TextAlign = ContentAlignment.MiddleCenter;
            lblSwitchToRegister.Click += lblSwitchEntryForm_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BaseColor = Color.FromArgb(229, 196, 146);
            btnLogin.Font = new Font("Segoe UI", 12F);
            btnLogin.Location = new Point(42, 239);
            btnLogin.Name = "btnLogin";
            btnLogin.Rounded = true;
            btnLogin.Size = new Size(351, 45);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.FromArgb(65, 45, 5);
            btnLogin.Click += btnAction_Click;
            // 
            // boxLoginPassword
            // 
            boxLoginPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxLoginPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxLoginPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxLoginPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxLoginPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxLoginPassword.Font = new Font("Segoe UI", 12F);
            boxLoginPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxLoginPassword.Hint = "";
            boxLoginPassword.Location = new Point(30, 177);
            boxLoginPassword.MaxLength = 32767;
            boxLoginPassword.Multiline = false;
            boxLoginPassword.Name = "boxLoginPassword";
            boxLoginPassword.PasswordChar = '\0';
            boxLoginPassword.ScrollBars = ScrollBars.None;
            boxLoginPassword.SelectedText = "";
            boxLoginPassword.SelectionLength = 0;
            boxLoginPassword.SelectionStart = 0;
            boxLoginPassword.Size = new Size(371, 38);
            boxLoginPassword.TabIndex = 9;
            boxLoginPassword.TabStop = false;
            boxLoginPassword.UseSystemPasswordChar = true;
            boxLoginPassword.KeyPress += box_KeyPress;
            // 
            // boxLoginUsername
            // 
            boxLoginUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxLoginUsername.BackColor = Color.FromArgb(29, 16, 15);
            boxLoginUsername.BaseColor = Color.FromArgb(29, 16, 15);
            boxLoginUsername.BorderColorA = Color.FromArgb(64, 158, 255);
            boxLoginUsername.BorderColorB = Color.FromArgb(246, 221, 218);
            boxLoginUsername.Font = new Font("Segoe UI", 12F);
            boxLoginUsername.ForeColor = Color.FromArgb(255, 249, 249);
            boxLoginUsername.Hint = "";
            boxLoginUsername.Location = new Point(30, 96);
            boxLoginUsername.MaxLength = 32767;
            boxLoginUsername.Multiline = false;
            boxLoginUsername.Name = "boxLoginUsername";
            boxLoginUsername.PasswordChar = '\0';
            boxLoginUsername.ScrollBars = ScrollBars.None;
            boxLoginUsername.SelectedText = "";
            boxLoginUsername.SelectionLength = 0;
            boxLoginUsername.SelectionStart = 0;
            boxLoginUsername.Size = new Size(371, 38);
            boxLoginUsername.TabIndex = 8;
            boxLoginUsername.TabStop = false;
            boxLoginUsername.UseSystemPasswordChar = false;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblLoginPassword.Location = new Point(26, 152);
            lblLoginPassword.Margin = new Padding(4, 0, 4, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(86, 21);
            lblLoginPassword.TabIndex = 5;
            lblLoginPassword.Text = "Password:";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginUsername.ForeColor = Color.FromArgb(255, 249, 249);
            lblLoginUsername.Location = new Point(24, 69);
            lblLoginUsername.Margin = new Padding(4, 0, 4, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(92, 21);
            lblLoginUsername.TabIndex = 6;
            lblLoginUsername.Text = "Username:";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.None;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(255, 249, 249);
            lblLogin.Location = new Point(19, 21);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(77, 30);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "Login";
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.FromArgb(255, 249, 249);
            lblClose.Location = new Point(385, 12);
            lblClose.Margin = new Padding(4, 0, 4, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(25, 30);
            lblClose.TabIndex = 0;
            lblClose.Text = "x";
            lblClose.Click += lblClose_Click;
            // 
            // ActionBar
            // 
            ActionBar.Location = new Point(0, 3);
            ActionBar.Name = "ActionBar";
            ActionBar.Size = new Size(375, 39);
            ActionBar.TabIndex = 1;
            ActionBar.MouseDown += ActionBar_MouseDown;
            // 
            // panelRight
            // 
            panelRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRight.BackColor = Color.FromArgb(26, 17, 17);
            panelRight.Controls.Add(ActionBar);
            panelRight.Controls.Add(lblClose);
            panelRight.Controls.Add(panelRegister);
            panelRight.Controls.Add(panelLogin);
            panelRight.Location = new Point(346, 0);
            panelRight.Margin = new Padding(4, 3, 4, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(430, 627);
            panelRight.TabIndex = 2;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 627);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Icon = Resources.trace_logo_ico;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CC";
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Panel ActionBar2;
        private Panel panelRegister;
        private Panel panelLogin;
        private Label lblSwitchToRegister;
        private ReaLTaiizor.Controls.ForeverButton btnLogin;
        private ReaLTaiizor.Controls.HopeTextBox boxLoginPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxLoginUsername;
        private Label lblLoginPassword;
        private Label lblLoginUsername;
        private Label lblLogin;
        private ReaLTaiizor.Controls.HopeTextBox boxRegisterLastName;
        private Label lblLastName;
        private ReaLTaiizor.Controls.HopeTextBox boxRegisterFirstName;
        private ReaLTaiizor.Controls.ForeverButton btnRegister;
        private Label lblFirstName;
        private Label lblSwitchToLogin;
        private Label lblRegister;
        private ReaLTaiizor.Controls.HopeTextBox boxEmail;
        private Label lblUsername;
        private ReaLTaiizor.Controls.HopeTextBox boxRepeatPassword;
        private Label lblPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxRegisterPassword;
        private Label lblRepeatPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxRegisterUsername;
        private Label lblEmail;
        private Label lblClose;
        private Panel ActionBar;
        private Panel panelRight;
    }
}
