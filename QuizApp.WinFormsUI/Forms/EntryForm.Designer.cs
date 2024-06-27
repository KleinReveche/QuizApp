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
            ActionBar = new Panel();
            panelRight = new Panel();
            lblSwitchEntryForm = new Label();
            boxEmail = new ReaLTaiizor.Controls.HopeTextBox();
            boxRepeatPassword = new ReaLTaiizor.Controls.HopeTextBox();
            boxPassword = new ReaLTaiizor.Controls.HopeTextBox();
            boxUsername = new ReaLTaiizor.Controls.HopeTextBox();
            btnAction = new ReaLTaiizor.Controls.ForeverButton();
            lblEmail = new Label();
            lblRepeatPassword = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblClose = new Label();
            lblFormName = new Label();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panelRight.Controls.Add(lblSwitchEntryForm);
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
            panelRight.TabIndex = 2;
            // 
            // lblSwitchEntryForm
            // 
            lblSwitchEntryForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblSwitchEntryForm.AutoSize = true;
            lblSwitchEntryForm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSwitchEntryForm.ForeColor = Color.FromArgb(255, 249, 249);
            lblSwitchEntryForm.Location = new Point(110, 506);
            lblSwitchEntryForm.Margin = new Padding(4, 0, 4, 0);
            lblSwitchEntryForm.Name = "lblSwitchEntryForm";
            lblSwitchEntryForm.Size = new Size(221, 15);
            lblSwitchEntryForm.TabIndex = 7;
            lblSwitchEntryForm.Text = "Don't have an account yet? Register here";
            lblSwitchEntryForm.TextAlign = ContentAlignment.MiddleCenter;
            lblSwitchEntryForm.Click += LblSwitchEntryFormClick;
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
            boxEmail.Location = new Point(34, 402);
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
            boxEmail.Visible = false;
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
            boxRepeatPassword.Location = new Point(34, 320);
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
            boxRepeatPassword.Visible = false;
            // 
            // boxPassword
            // 
            boxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxPassword.Font = new Font("Segoe UI", 12F);
            boxPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxPassword.Hint = "";
            boxPassword.Location = new Point(34, 247);
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
            boxPassword.KeyPress += boxPassword_KeyPress;
            // 
            // boxUsername
            // 
            boxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxUsername.BackColor = Color.FromArgb(29, 16, 15);
            boxUsername.BaseColor = Color.FromArgb(29, 16, 15);
            boxUsername.BorderColorA = Color.FromArgb(64, 158, 255);
            boxUsername.BorderColorB = Color.FromArgb(246, 221, 218);
            boxUsername.Font = new Font("Segoe UI", 12F);
            boxUsername.ForeColor = Color.FromArgb(255, 249, 249);
            boxUsername.Hint = "";
            boxUsername.Location = new Point(34, 166);
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
            btnAction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAction.BackColor = Color.Transparent;
            btnAction.BaseColor = Color.FromArgb(229, 196, 146);
            btnAction.Font = new Font("Segoe UI", 12F);
            btnAction.Location = new Point(46, 456);
            btnAction.Name = "btnAction";
            btnAction.Rounded = true;
            btnAction.Size = new Size(351, 45);
            btnAction.TabIndex = 2;
            btnAction.Text = "Login";
            btnAction.TextColor = Color.FromArgb(65, 45, 5);
            btnAction.Click += btnAction_Click;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(255, 249, 249);
            lblEmail.Location = new Point(31, 378);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 21);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Trace Email:";
            lblEmail.Visible = false;
            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblRepeatPassword.Location = new Point(32, 296);
            lblRepeatPassword.Margin = new Padding(4, 0, 4, 0);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(149, 21);
            lblRepeatPassword.TabIndex = 0;
            lblRepeatPassword.Text = "Repeat Password:";
            lblRepeatPassword.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblPassword.Location = new Point(30, 222);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(255, 249, 249);
            lblUsername.Location = new Point(28, 139);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblClose
            
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
            lblFormName.Anchor = AnchorStyles.None;
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormName.ForeColor = Color.FromArgb(255, 249, 249);
            lblFormName.Location = new Point(20, 74);
            lblFormName.Margin = new Padding(4, 0, 4, 0);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(77, 30);
            lblFormName.TabIndex = 0;
            lblFormName.Text = "Login";
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
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Label lblPassword;
        private Label lblClose;
        private Panel ActionBar;
        private Panel ActionBar2;
        private ReaLTaiizor.Controls.ForeverButton btnAction;
        private ReaLTaiizor.Controls.HopeTextBox boxUsername;
        private ReaLTaiizor.Controls.HopeTextBox boxPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxRepeatPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxEmail;
        private Label lblSwitchEntryForm;
    }
}
