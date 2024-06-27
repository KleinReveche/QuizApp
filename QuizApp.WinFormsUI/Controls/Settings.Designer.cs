namespace QuizApp.WinFormsUI.Controls
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new ReaLTaiizor.Controls.BigLabel();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            btnAction = new ReaLTaiizor.Controls.ForeverButton();
            lblOldRepeatPassword = new Label();
            boxOldRepeatPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblOldPassword = new Label();
            boxOldPassword = new ReaLTaiizor.Controls.HopeTextBox();
            boxNewRepeatPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblNewPassword = new Label();
            boxNewPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblNewRepeatPassword = new Label();
            parrotGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 25F);
            lblWelcome.ForeColor = Color.FromArgb(255, 179, 176);
            lblWelcome.Location = new Point(13, 14);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(141, 46);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Settings";
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BackColor = Color.Transparent;
            parrotGroupBox1.BorderColor = Color.DodgerBlue;
            parrotGroupBox1.BorderWidth = 1;
            parrotGroupBox1.Controls.Add(btnAction);
            parrotGroupBox1.Controls.Add(lblOldRepeatPassword);
            parrotGroupBox1.Controls.Add(boxOldRepeatPassword);
            parrotGroupBox1.Controls.Add(lblOldPassword);
            parrotGroupBox1.Controls.Add(boxOldPassword);
            parrotGroupBox1.Controls.Add(boxNewRepeatPassword);
            parrotGroupBox1.Controls.Add(lblNewPassword);
            parrotGroupBox1.Controls.Add(boxNewPassword);
            parrotGroupBox1.Controls.Add(lblNewRepeatPassword);
            parrotGroupBox1.Location = new Point(41, 78);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(409, 394);
            parrotGroupBox1.TabIndex = 3;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Change Password";
            parrotGroupBox1.TextColor = Color.DodgerBlue;
            // 
            // btnAction
            // 
            btnAction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnAction.BackColor = Color.Transparent;
            btnAction.BaseColor = Color.FromArgb(229, 196, 146);
            btnAction.Font = new Font("Segoe UI", 12F);
            btnAction.Location = new Point(27, 330);
            btnAction.Name = "btnAction";
            btnAction.Rounded = true;
            btnAction.Size = new Size(351, 45);
            btnAction.TabIndex = 12;
            btnAction.Text = "Change Password";
            btnAction.TextColor = Color.FromArgb(65, 45, 5);
            btnAction.Click += btnAction_Click;
            // 
            // lblOldRepeatPassword
            // 
            lblOldRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblOldRepeatPassword.AutoSize = true;
            lblOldRepeatPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblOldRepeatPassword.Location = new Point(17, 106);
            lblOldRepeatPassword.Margin = new Padding(4, 0, 4, 0);
            lblOldRepeatPassword.Name = "lblOldRepeatPassword";
            lblOldRepeatPassword.Size = new Size(181, 21);
            lblOldRepeatPassword.TabIndex = 12;
            lblOldRepeatPassword.Text = "Repeat Old Password:";
            // 
            // boxOldRepeatPassword
            // 
            boxOldRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxOldRepeatPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxOldRepeatPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxOldRepeatPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxOldRepeatPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxOldRepeatPassword.Font = new Font("Segoe UI", 12F);
            boxOldRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxOldRepeatPassword.Hint = "";
            boxOldRepeatPassword.Location = new Point(17, 130);
            boxOldRepeatPassword.MaxLength = 32767;
            boxOldRepeatPassword.Multiline = false;
            boxOldRepeatPassword.Name = "boxOldRepeatPassword";
            boxOldRepeatPassword.PasswordChar = '\0';
            boxOldRepeatPassword.ScrollBars = ScrollBars.None;
            boxOldRepeatPassword.SelectedText = "";
            boxOldRepeatPassword.SelectionLength = 0;
            boxOldRepeatPassword.SelectionStart = 0;
            boxOldRepeatPassword.Size = new Size(371, 38);
            boxOldRepeatPassword.TabIndex = 13;
            boxOldRepeatPassword.TabStop = false;
            boxOldRepeatPassword.UseSystemPasswordChar = true;
            // 
            // lblOldPassword
            // 
            lblOldPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblOldPassword.Location = new Point(17, 30);
            lblOldPassword.Margin = new Padding(4, 0, 4, 0);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(118, 21);
            lblOldPassword.TabIndex = 10;
            lblOldPassword.Text = "Old Password:";
            // 
            // boxOldPassword
            // 
            boxOldPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxOldPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxOldPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxOldPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxOldPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxOldPassword.Font = new Font("Segoe UI", 12F);
            boxOldPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxOldPassword.Hint = "";
            boxOldPassword.Location = new Point(17, 54);
            boxOldPassword.MaxLength = 32767;
            boxOldPassword.Multiline = false;
            boxOldPassword.Name = "boxOldPassword";
            boxOldPassword.PasswordChar = '\0';
            boxOldPassword.ScrollBars = ScrollBars.None;
            boxOldPassword.SelectedText = "";
            boxOldPassword.SelectionLength = 0;
            boxOldPassword.SelectionStart = 0;
            boxOldPassword.Size = new Size(371, 38);
            boxOldPassword.TabIndex = 11;
            boxOldPassword.TabStop = false;
            boxOldPassword.UseSystemPasswordChar = true;
            // 
            // boxNewRepeatPassword
            // 
            boxNewRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxNewRepeatPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxNewRepeatPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxNewRepeatPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxNewRepeatPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxNewRepeatPassword.Font = new Font("Segoe UI", 12F);
            boxNewRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxNewRepeatPassword.Hint = "";
            boxNewRepeatPassword.Location = new Point(17, 277);
            boxNewRepeatPassword.MaxLength = 32767;
            boxNewRepeatPassword.Multiline = false;
            boxNewRepeatPassword.Name = "boxNewRepeatPassword";
            boxNewRepeatPassword.PasswordChar = '\0';
            boxNewRepeatPassword.ScrollBars = ScrollBars.None;
            boxNewRepeatPassword.SelectedText = "";
            boxNewRepeatPassword.SelectionLength = 0;
            boxNewRepeatPassword.SelectionStart = 0;
            boxNewRepeatPassword.Size = new Size(371, 38);
            boxNewRepeatPassword.TabIndex = 9;
            boxNewRepeatPassword.TabStop = false;
            boxNewRepeatPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblNewPassword.Location = new Point(17, 180);
            lblNewPassword.Margin = new Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(126, 21);
            lblNewPassword.TabIndex = 7;
            lblNewPassword.Text = "New Password:";
            // 
            // boxNewPassword
            // 
            boxNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxNewPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxNewPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxNewPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxNewPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxNewPassword.Font = new Font("Segoe UI", 12F);
            boxNewPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxNewPassword.Hint = "";
            boxNewPassword.Location = new Point(17, 204);
            boxNewPassword.MaxLength = 32767;
            boxNewPassword.Multiline = false;
            boxNewPassword.Name = "boxNewPassword";
            boxNewPassword.PasswordChar = '\0';
            boxNewPassword.ScrollBars = ScrollBars.None;
            boxNewPassword.SelectedText = "";
            boxNewPassword.SelectionLength = 0;
            boxNewPassword.SelectionStart = 0;
            boxNewPassword.Size = new Size(371, 38);
            boxNewPassword.TabIndex = 8;
            boxNewPassword.TabStop = false;
            boxNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewRepeatPassword
            // 
            lblNewRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblNewRepeatPassword.AutoSize = true;
            lblNewRepeatPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblNewRepeatPassword.Location = new Point(15, 253);
            lblNewRepeatPassword.Margin = new Padding(4, 0, 4, 0);
            lblNewRepeatPassword.Name = "lblNewRepeatPassword";
            lblNewRepeatPassword.Size = new Size(189, 21);
            lblNewRepeatPassword.TabIndex = 6;
            lblNewRepeatPassword.Text = "New Repeat Password:";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(parrotGroupBox1);
            Controls.Add(lblWelcome);
            Name = "Settings";
            Size = new Size(1149, 709);
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel lblWelcome;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Label lblOldPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxOldPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxNewRepeatPassword;
        private Label lblNewPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxNewPassword;
        private Label lblNewRepeatPassword;
        private ReaLTaiizor.Controls.ForeverButton btnAction;
        private Label lblOldRepeatPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxOldRepeatPassword;
    }
}
