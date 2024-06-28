using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Forms
{
    partial class InitialSetupForm
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
            boxEmail = new ReaLTaiizor.Controls.HopeTextBox();
            boxRepeatPassword = new ReaLTaiizor.Controls.HopeTextBox();
            boxPassword = new ReaLTaiizor.Controls.HopeTextBox();
            boxUsername = new ReaLTaiizor.Controls.HopeTextBox();
            btnAction = new ReaLTaiizor.Controls.ForeverButton();
            ActionBar = new Panel();
            lblEmail = new Label();
            lblRepeatPassword = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblClose = new Label();
            lblFormName = new Label();
            ActionBar2 = new Panel();
            pictureBox1 = new PictureBox();
            panelRight = new Panel();
            panelLeft = new Panel();
            lblSetup = new Label();
            boxFirstName = new ReaLTaiizor.Controls.HopeTextBox();
            lblFirstName = new Label();
            boxLastName = new ReaLTaiizor.Controls.HopeTextBox();
            lblLastName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRight.SuspendLayout();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // boxEmail
            // 
            boxEmail.BackColor = Color.FromArgb(29, 16, 15);
            boxEmail.BaseColor = Color.FromArgb(29, 16, 15);
            boxEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            boxEmail.BorderColorB = Color.FromArgb(246, 221, 218);
            boxEmail.Font = new Font("Segoe UI", 12F);
            boxEmail.ForeColor = Color.FromArgb(255, 249, 249);
            boxEmail.Hint = "";
            boxEmail.Location = new Point(39, 482);
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
            // 
            // boxRepeatPassword
            // 
            boxRepeatPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxRepeatPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxRepeatPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxRepeatPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxRepeatPassword.Font = new Font("Segoe UI", 12F);
            boxRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxRepeatPassword.Hint = "";
            boxRepeatPassword.Location = new Point(39, 400);
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
            // boxPassword
            // 
            boxPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxPassword.Font = new Font("Segoe UI", 12F);
            boxPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxPassword.Hint = "";
            boxPassword.Location = new Point(39, 327);
            boxPassword.MaxLength = 32767;
            boxPassword.Multiline = false;
            boxPassword.Name = "boxPassword";
            boxPassword.PasswordChar = '\0';
            boxPassword.ScrollBars = ScrollBars.None;
            boxPassword.SelectedText = "";
            boxPassword.SelectionLength = 0;
            boxPassword.SelectionStart = 0;
            boxPassword.Size = new Size(371, 38);
            boxPassword.TabIndex = 4;
            boxPassword.TabStop = false;
            boxPassword.UseSystemPasswordChar = true;
            // 
            // boxUsername
            // 
            boxUsername.BackColor = Color.FromArgb(29, 16, 15);
            boxUsername.BaseColor = Color.FromArgb(29, 16, 15);
            boxUsername.BorderColorA = Color.FromArgb(64, 158, 255);
            boxUsername.BorderColorB = Color.FromArgb(246, 221, 218);
            boxUsername.Font = new Font("Segoe UI", 12F);
            boxUsername.ForeColor = Color.FromArgb(255, 249, 249);
            boxUsername.Hint = "";
            boxUsername.Location = new Point(39, 246);
            boxUsername.MaxLength = 32767;
            boxUsername.Multiline = false;
            boxUsername.Name = "boxUsername";
            boxUsername.PasswordChar = '\0';
            boxUsername.ScrollBars = ScrollBars.None;
            boxUsername.SelectedText = "";
            boxUsername.SelectionLength = 0;
            boxUsername.SelectionStart = 0;
            boxUsername.Size = new Size(371, 38);
            boxUsername.TabIndex = 3;
            boxUsername.TabStop = false;
            boxUsername.UseSystemPasswordChar = false;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.Transparent;
            btnAction.BaseColor = Color.FromArgb(229, 196, 146);
            btnAction.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAction.Location = new Point(97, 541);
            btnAction.Name = "btnAction";
            btnAction.Rounded = true;
            btnAction.Size = new Size(247, 52);
            btnAction.TabIndex = 2;
            btnAction.Text = "Create";
            btnAction.TextColor = Color.FromArgb(65, 45, 5);
            btnAction.Click += btnAction_Click;
            // 
            // ActionBar
            // 
            ActionBar.Location = new Point(0, 3);
            ActionBar.Name = "ActionBar";
            ActionBar.Size = new Size(375, 39);
            ActionBar.TabIndex = 1;
            ActionBar.MouseDown += ActionBar_MouseDown;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(255, 249, 249);
            lblEmail.Location = new Point(36, 458);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 21);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Trace Email:";
            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblRepeatPassword.Location = new Point(37, 376);
            lblRepeatPassword.Margin = new Padding(4, 0, 4, 0);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(149, 21);
            lblRepeatPassword.TabIndex = 0;
            lblRepeatPassword.Text = "Repeat Password:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblPassword.Location = new Point(35, 302);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(255, 249, 249);
            lblUsername.Location = new Point(33, 219);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
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
            // lblFormName
            // 
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormName.ForeColor = Color.FromArgb(255, 249, 249);
            lblFormName.Location = new Point(21, 87);
            lblFormName.Margin = new Padding(4, 0, 4, 0);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(237, 30);
            lblFormName.TabIndex = 0;
            lblFormName.Text = "Create Admin User";
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
            pictureBox1.Location = new Point(66, 166);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRight.BackColor = Color.FromArgb(26, 17, 17);
            panelRight.Controls.Add(boxLastName);
            panelRight.Controls.Add(lblLastName);
            panelRight.Controls.Add(boxFirstName);
            panelRight.Controls.Add(lblFirstName);
            panelRight.Controls.Add(boxEmail);
            panelRight.Controls.Add(boxRepeatPassword);
            panelRight.Controls.Add(boxPassword);
            panelRight.Controls.Add(boxUsername);
            panelRight.Controls.Add(btnAction);
            panelRight.Controls.Add(ActionBar);
            panelRight.Controls.Add(lblEmail);
            panelRight.Controls.Add(lblRepeatPassword);
            panelRight.Controls.Add(lblPassword);
            panelRight.Controls.Add(lblUsername);
            panelRight.Controls.Add(lblClose);
            panelRight.Controls.Add(lblFormName);
            panelRight.Location = new Point(346, 0);
            panelRight.Margin = new Padding(4, 3, 4, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(430, 627);
            panelRight.TabIndex = 4;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(152, 26, 37);
            panelLeft.Controls.Add(lblSetup);
            panelLeft.Controls.Add(ActionBar2);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(4, 3, 4, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(346, 627);
            panelLeft.TabIndex = 3;
            // 
            // lblSetup
            // 
            lblSetup.AutoSize = true;
            lblSetup.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSetup.ForeColor = Color.FromArgb(255, 249, 249);
            lblSetup.Location = new Point(104, 402);
            lblSetup.Margin = new Padding(4, 0, 4, 0);
            lblSetup.Name = "lblSetup";
            lblSetup.Size = new Size(145, 28);
            lblSetup.TabIndex = 8;
            lblSetup.Text = "Initial Setup";
            // 
            // boxFirstName
            // 
            boxFirstName.BackColor = Color.FromArgb(29, 16, 15);
            boxFirstName.BaseColor = Color.FromArgb(29, 16, 15);
            boxFirstName.BorderColorA = Color.FromArgb(64, 158, 255);
            boxFirstName.BorderColorB = Color.FromArgb(246, 221, 218);
            boxFirstName.Font = new Font("Segoe UI", 12F);
            boxFirstName.ForeColor = Color.FromArgb(255, 249, 249);
            boxFirstName.Hint = "";
            boxFirstName.Location = new Point(37, 166);
            boxFirstName.MaxLength = 32767;
            boxFirstName.Multiline = false;
            boxFirstName.Name = "boxFirstName";
            boxFirstName.PasswordChar = '\0';
            boxFirstName.ScrollBars = ScrollBars.None;
            boxFirstName.SelectedText = "";
            boxFirstName.SelectionLength = 0;
            boxFirstName.SelectionStart = 0;
            boxFirstName.Size = new Size(183, 38);
            boxFirstName.TabIndex = 8;
            boxFirstName.TabStop = false;
            boxFirstName.UseSystemPasswordChar = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.FromArgb(255, 249, 249);
            lblFirstName.Location = new Point(30, 142);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(95, 21);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.TopCenter;
            // 
            // boxLastName
            // 
            boxLastName.BackColor = Color.FromArgb(29, 16, 15);
            boxLastName.BaseColor = Color.FromArgb(29, 16, 15);
            boxLastName.BorderColorA = Color.FromArgb(64, 158, 255);
            boxLastName.BorderColorB = Color.FromArgb(246, 221, 218);
            boxLastName.Font = new Font("Segoe UI", 12F);
            boxLastName.ForeColor = Color.FromArgb(255, 249, 249);
            boxLastName.Hint = "";
            boxLastName.Location = new Point(226, 166);
            boxLastName.MaxLength = 32767;
            boxLastName.Multiline = false;
            boxLastName.Name = "boxLastName";
            boxLastName.PasswordChar = '\0';
            boxLastName.ScrollBars = ScrollBars.None;
            boxLastName.SelectedText = "";
            boxLastName.SelectionLength = 0;
            boxLastName.SelectionStart = 0;
            boxLastName.Size = new Size(184, 38);
            boxLastName.TabIndex = 10;
            boxLastName.TabStop = false;
            boxLastName.UseSystemPasswordChar = false;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.FromArgb(255, 249, 249);
            lblLastName.Location = new Point(219, 142);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(97, 21);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.TopCenter;
            // 
            // InitialSetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 627);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Icon = Resources.trace_logo_ico;
            Name = "InitialSetupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InitialSetupForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox boxEmail;
        private ReaLTaiizor.Controls.HopeTextBox boxRepeatPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxUsername;
        private ReaLTaiizor.Controls.ForeverButton btnAction;
        private Panel ActionBar;
        private Label lblEmail;
        private Label lblRepeatPassword;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblClose;
        private Label lblFormName;
        private Panel ActionBar2;
        private PictureBox pictureBox1;
        private Panel panelRight;
        private Panel panelLeft;
        private Label lblSetup;
        private ReaLTaiizor.Controls.HopeTextBox boxLastName;
        private Label lblLastName;
        private ReaLTaiizor.Controls.HopeTextBox boxFirstName;
        private Label lblFirstName;
    }
}