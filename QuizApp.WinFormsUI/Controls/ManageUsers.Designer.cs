namespace QuizApp.WinFormsUI.Controls
{
    partial class ManageUsers
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
            lblManage = new ReaLTaiizor.Controls.BigLabel();
            LblNoUsersAvailable = new ReaLTaiizor.Controls.BigLabel();
            btnAddUser = new ReaLTaiizor.Controls.ForeverButton();
            btnRemoveUser = new ReaLTaiizor.Controls.ForeverButton();
            btnSaveUser = new ReaLTaiizor.Controls.ForeverButton();
            grpBxUserDetails = new ReaLTaiizor.Controls.HopeGroupBox();
            btnEditUser = new ReaLTaiizor.Controls.ForeverButton();
            lblUserDetails = new Label();
            boxLastName = new ReaLTaiizor.Controls.HopeTextBox();
            lblLastName = new Label();
            boxFirstName = new ReaLTaiizor.Controls.HopeTextBox();
            lblFirstName = new Label();
            boxEmail = new ReaLTaiizor.Controls.HopeTextBox();
            lblUsername = new Label();
            boxRepeatPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblPassword = new Label();
            boxPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblRepeatPassword = new Label();
            boxUsername = new ReaLTaiizor.Controls.HopeTextBox();
            lblEmail = new Label();
            btnImportUsers = new ReaLTaiizor.Controls.ForeverButton();
            listUsers = new ReaLTaiizor.Controls.MetroListBox();
            grpBxUserDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblManage
            // 
            lblManage.AutoSize = true;
            lblManage.BackColor = Color.Transparent;
            lblManage.Font = new Font("Segoe UI", 25F);
            lblManage.ForeColor = Color.FromArgb(255, 179, 176);
            lblManage.Location = new Point(16, 16);
            lblManage.Name = "lblManage";
            lblManage.Size = new Size(232, 46);
            lblManage.TabIndex = 2;
            lblManage.Text = "Manage Users";
            // 
            // LblNoUsersAvailable
            // 
            LblNoUsersAvailable.AutoSize = true;
            LblNoUsersAvailable.BackColor = Color.Transparent;
            LblNoUsersAvailable.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNoUsersAvailable.ForeColor = Color.FromArgb(80, 80, 80);
            LblNoUsersAvailable.Location = new Point(28, 171);
            LblNoUsersAvailable.Name = "LblNoUsersAvailable";
            LblNoUsersAvailable.Size = new Size(194, 30);
            LblNoUsersAvailable.TabIndex = 17;
            LblNoUsersAvailable.Text = "No Users Available";
            LblNoUsersAvailable.Visible = false;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Transparent;
            btnAddUser.BaseColor = Color.FromArgb(229, 196, 146);
            btnAddUser.Font = new Font("Segoe UI", 12F);
            btnAddUser.Location = new Point(28, 80);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Rounded = true;
            btnAddUser.Size = new Size(189, 45);
            btnAddUser.TabIndex = 18;
            btnAddUser.Text = "Add User";
            btnAddUser.TextColor = Color.FromArgb(65, 45, 5);
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.BackColor = Color.Transparent;
            btnRemoveUser.BaseColor = Color.FromArgb(147, 0, 10);
            btnRemoveUser.Font = new Font("Segoe UI", 12F);
            btnRemoveUser.Location = new Point(447, 37);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Rounded = true;
            btnRemoveUser.Size = new Size(120, 45);
            btnRemoveUser.TabIndex = 20;
            btnRemoveUser.Text = "Remove User";
            btnRemoveUser.TextColor = Color.FromArgb(255, 180, 171);
            btnRemoveUser.Visible = false;
            btnRemoveUser.Click += btnRemoveUser_Click;
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = Color.Transparent;
            btnSaveUser.BaseColor = Color.FromArgb(255, 184, 117);
            btnSaveUser.Enabled = false;
            btnSaveUser.Font = new Font("Segoe UI", 12F);
            btnSaveUser.Location = new Point(452, 573);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Rounded = true;
            btnSaveUser.Size = new Size(115, 45);
            btnSaveUser.TabIndex = 19;
            btnSaveUser.Text = "Save User";
            btnSaveUser.TextColor = Color.FromArgb(75, 40, 0);
            btnSaveUser.Visible = false;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // grpBxUserDetails
            // 
            grpBxUserDetails.BorderColor = Color.FromArgb(255, 222, 170);
            grpBxUserDetails.Controls.Add(btnEditUser);
            grpBxUserDetails.Controls.Add(lblUserDetails);
            grpBxUserDetails.Controls.Add(boxLastName);
            grpBxUserDetails.Controls.Add(btnRemoveUser);
            grpBxUserDetails.Controls.Add(btnSaveUser);
            grpBxUserDetails.Controls.Add(lblLastName);
            grpBxUserDetails.Controls.Add(boxFirstName);
            grpBxUserDetails.Controls.Add(lblFirstName);
            grpBxUserDetails.Controls.Add(boxEmail);
            grpBxUserDetails.Controls.Add(lblUsername);
            grpBxUserDetails.Controls.Add(boxRepeatPassword);
            grpBxUserDetails.Controls.Add(lblPassword);
            grpBxUserDetails.Controls.Add(boxPassword);
            grpBxUserDetails.Controls.Add(lblRepeatPassword);
            grpBxUserDetails.Controls.Add(boxUsername);
            grpBxUserDetails.Controls.Add(lblEmail);
            grpBxUserDetails.Font = new Font("Segoe UI", 12F);
            grpBxUserDetails.ForeColor = Color.FromArgb(48, 49, 51);
            grpBxUserDetails.LineColor = Color.FromArgb(255, 222, 170);
            grpBxUserDetails.Location = new Point(393, 131);
            grpBxUserDetails.Name = "grpBxUserDetails";
            grpBxUserDetails.ShowText = false;
            grpBxUserDetails.Size = new Size(598, 644);
            grpBxUserDetails.TabIndex = 22;
            grpBxUserDetails.TabStop = false;
            grpBxUserDetails.ThemeColor = Color.FromArgb(61, 50, 50);
            grpBxUserDetails.Visible = false;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.Transparent;
            btnEditUser.BaseColor = Color.FromArgb(104, 57, 0);
            btnEditUser.Font = new Font("Segoe UI", 12F);
            btnEditUser.Location = new Point(326, 37);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Rounded = true;
            btnEditUser.Size = new Size(106, 45);
            btnEditUser.TabIndex = 23;
            btnEditUser.Text = "Edit User";
            btnEditUser.TextColor = Color.FromArgb(255, 180, 171);
            btnEditUser.Visible = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // lblUserDetails
            // 
            lblUserDetails.Anchor = AnchorStyles.None;
            lblUserDetails.AutoSize = true;
            lblUserDetails.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserDetails.ForeColor = Color.FromArgb(255, 249, 249);
            lblUserDetails.Location = new Point(26, 40);
            lblUserDetails.Margin = new Padding(4, 0, 4, 0);
            lblUserDetails.Name = "lblUserDetails";
            lblUserDetails.Size = new Size(164, 32);
            lblUserDetails.TabIndex = 27;
            lblUserDetails.Text = "User Details";
            // 
            // boxLastName
            // 
            boxLastName.BackColor = Color.FromArgb(29, 16, 15);
            boxLastName.BaseColor = Color.FromArgb(29, 16, 15);
            boxLastName.BorderColorA = Color.FromArgb(64, 158, 255);
            boxLastName.BorderColorB = Color.FromArgb(246, 221, 218);
            boxLastName.Enabled = false;
            boxLastName.Font = new Font("Segoe UI", 12F);
            boxLastName.ForeColor = Color.FromArgb(255, 249, 249);
            boxLastName.Hint = "Last Name";
            boxLastName.Location = new Point(30, 207);
            boxLastName.MaxLength = 32767;
            boxLastName.Multiline = false;
            boxLastName.Name = "boxLastName";
            boxLastName.PasswordChar = '\0';
            boxLastName.ScrollBars = ScrollBars.None;
            boxLastName.SelectedText = "";
            boxLastName.SelectionLength = 0;
            boxLastName.SelectionStart = 0;
            boxLastName.Size = new Size(537, 38);
            boxLastName.TabIndex = 26;
            boxLastName.TabStop = false;
            boxLastName.UseSystemPasswordChar = false;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.FromArgb(255, 249, 249);
            lblLastName.Location = new Point(26, 183);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(97, 21);
            lblLastName.TabIndex = 25;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.TopCenter;
            // 
            // boxFirstName
            // 
            boxFirstName.BackColor = Color.FromArgb(29, 16, 15);
            boxFirstName.BaseColor = Color.FromArgb(29, 16, 15);
            boxFirstName.BorderColorA = Color.FromArgb(64, 158, 255);
            boxFirstName.BorderColorB = Color.FromArgb(246, 221, 218);
            boxFirstName.Enabled = false;
            boxFirstName.Font = new Font("Segoe UI", 12F);
            boxFirstName.ForeColor = Color.FromArgb(255, 249, 249);
            boxFirstName.Hint = "First Name";
            boxFirstName.Location = new Point(30, 125);
            boxFirstName.MaxLength = 32767;
            boxFirstName.Multiline = false;
            boxFirstName.Name = "boxFirstName";
            boxFirstName.PasswordChar = '\0';
            boxFirstName.ScrollBars = ScrollBars.None;
            boxFirstName.SelectedText = "";
            boxFirstName.SelectionLength = 0;
            boxFirstName.SelectionStart = 0;
            boxFirstName.Size = new Size(537, 38);
            boxFirstName.TabIndex = 24;
            boxFirstName.TabStop = false;
            boxFirstName.UseSystemPasswordChar = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.FromArgb(255, 249, 249);
            lblFirstName.Location = new Point(26, 101);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(95, 21);
            lblFirstName.TabIndex = 23;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.TopCenter;
            // 
            // boxEmail
            // 
            boxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxEmail.BackColor = Color.FromArgb(29, 16, 15);
            boxEmail.BaseColor = Color.FromArgb(29, 16, 15);
            boxEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            boxEmail.BorderColorB = Color.FromArgb(246, 221, 218);
            boxEmail.Enabled = false;
            boxEmail.Font = new Font("Segoe UI", 12F);
            boxEmail.ForeColor = Color.FromArgb(255, 249, 249);
            boxEmail.Hint = "Email";
            boxEmail.Location = new Point(32, 520);
            boxEmail.MaxLength = 32767;
            boxEmail.Multiline = false;
            boxEmail.Name = "boxEmail";
            boxEmail.PasswordChar = '\0';
            boxEmail.ScrollBars = ScrollBars.None;
            boxEmail.SelectedText = "";
            boxEmail.SelectionLength = 0;
            boxEmail.SelectionStart = 0;
            boxEmail.Size = new Size(535, 38);
            boxEmail.TabIndex = 22;
            boxEmail.TabStop = false;
            boxEmail.UseSystemPasswordChar = false;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(255, 249, 249);
            lblUsername.Location = new Point(26, 264);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 21);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "Username:";
            // 
            // boxRepeatPassword
            // 
            boxRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxRepeatPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxRepeatPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxRepeatPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxRepeatPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxRepeatPassword.Enabled = false;
            boxRepeatPassword.Font = new Font("Segoe UI", 12F);
            boxRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxRepeatPassword.Hint = "●●●●●●●●";
            boxRepeatPassword.Location = new Point(32, 448);
            boxRepeatPassword.MaxLength = 32767;
            boxRepeatPassword.Multiline = false;
            boxRepeatPassword.Name = "boxRepeatPassword";
            boxRepeatPassword.PasswordChar = '\0';
            boxRepeatPassword.ScrollBars = ScrollBars.None;
            boxRepeatPassword.SelectedText = "";
            boxRepeatPassword.SelectionLength = 0;
            boxRepeatPassword.SelectionStart = 0;
            boxRepeatPassword.Size = new Size(535, 38);
            boxRepeatPassword.TabIndex = 21;
            boxRepeatPassword.TabStop = false;
            boxRepeatPassword.Text = "password";
            boxRepeatPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblPassword.Location = new Point(26, 345);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 21);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Password:";
            // 
            // boxPassword
            // 
            boxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxPassword.BackColor = Color.FromArgb(29, 16, 15);
            boxPassword.BaseColor = Color.FromArgb(29, 16, 15);
            boxPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            boxPassword.BorderColorB = Color.FromArgb(246, 221, 218);
            boxPassword.Enabled = false;
            boxPassword.Font = new Font("Segoe UI", 12F);
            boxPassword.ForeColor = Color.FromArgb(255, 249, 249);
            boxPassword.Hint = "●●●●●●●●";
            boxPassword.Location = new Point(32, 369);
            boxPassword.MaxLength = 32767;
            boxPassword.Multiline = false;
            boxPassword.Name = "boxPassword";
            boxPassword.PasswordChar = '\0';
            boxPassword.ScrollBars = ScrollBars.None;
            boxPassword.SelectedText = "";
            boxPassword.SelectionLength = 0;
            boxPassword.SelectionStart = 0;
            boxPassword.Size = new Size(535, 38);
            boxPassword.TabIndex = 20;
            boxPassword.TabStop = false;
            boxPassword.Text = "password";
            boxPassword.UseSystemPasswordChar = true;
            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepeatPassword.ForeColor = Color.FromArgb(255, 249, 249);
            lblRepeatPassword.Location = new Point(28, 424);
            lblRepeatPassword.Margin = new Padding(4, 0, 4, 0);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new Size(149, 21);
            lblRepeatPassword.TabIndex = 17;
            lblRepeatPassword.Text = "Repeat Password:";
            // 
            // boxUsername
            // 
            boxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            boxUsername.BackColor = Color.FromArgb(29, 16, 15);
            boxUsername.BaseColor = Color.FromArgb(29, 16, 15);
            boxUsername.BorderColorA = Color.FromArgb(64, 158, 255);
            boxUsername.BorderColorB = Color.FromArgb(246, 221, 218);
            boxUsername.Enabled = false;
            boxUsername.Font = new Font("Segoe UI", 12F);
            boxUsername.ForeColor = Color.FromArgb(255, 249, 249);
            boxUsername.Hint = "Username";
            boxUsername.Location = new Point(32, 291);
            boxUsername.MaxLength = 32767;
            boxUsername.Multiline = false;
            boxUsername.Name = "boxUsername";
            boxUsername.PasswordChar = '\0';
            boxUsername.ScrollBars = ScrollBars.None;
            boxUsername.SelectedText = "";
            boxUsername.SelectionLength = 0;
            boxUsername.SelectionStart = 0;
            boxUsername.Size = new Size(535, 38);
            boxUsername.TabIndex = 19;
            boxUsername.TabStop = false;
            boxUsername.UseSystemPasswordChar = false;
            boxUsername.KeyPress += boxUsername_KeyPress;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(255, 249, 249);
            lblEmail.Location = new Point(27, 496);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 21);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Trace Email:";
            // 
            // btnImportUsers
            // 
            btnImportUsers.BackColor = Color.Transparent;
            btnImportUsers.BaseColor = Color.FromArgb(255, 179, 176);
            btnImportUsers.Font = new Font("Segoe UI", 12F);
            btnImportUsers.Location = new Point(224, 80);
            btnImportUsers.Name = "btnImportUsers";
            btnImportUsers.Rounded = true;
            btnImportUsers.Size = new Size(138, 45);
            btnImportUsers.TabIndex = 23;
            btnImportUsers.Text = "Import Users";
            btnImportUsers.TextColor = Color.FromArgb(88, 28, 29);
            btnImportUsers.Click += btnImportUsers_Click;
            // 
            // listUsers
            // 
            listUsers.BackColor = Color.FromArgb(50, 40, 39);
            listUsers.BorderColor = Color.FromArgb(64, 64, 64);
            listUsers.DisabledBackColor = Color.FromArgb(80, 80, 80);
            listUsers.DisabledForeColor = Color.FromArgb(109, 109, 109);
            listUsers.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listUsers.HoveredItemBackColor = Color.FromArgb(186, 100, 100);
            listUsers.HoveredItemColor = Color.FromArgb(64, 64, 64);
            listUsers.IsDerivedStyle = false;
            listUsers.ItemHeight = 40;
            listUsers.Location = new Point(28, 131);
            listUsers.MultiSelect = false;
            listUsers.Name = "listUsers";
            listUsers.SelectedIndex = -1;
            listUsers.SelectedItem = null;
            listUsers.SelectedItemBackColor = Color.FromArgb(115, 51, 51);
            listUsers.SelectedItemColor = Color.White;
            listUsers.SelectedText = null;
            listUsers.SelectedValue = null;
            listUsers.ShowBorder = false;
            listUsers.ShowScrollBar = true;
            listUsers.Size = new Size(359, 644);
            listUsers.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            listUsers.StyleManager = null;
            listUsers.TabIndex = 24;
            listUsers.ThemeAuthor = "Taiizor";
            listUsers.ThemeName = "MetroDark";
            listUsers.SelectedIndexChanged += listUsers_SelectedIndexChanged;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(btnImportUsers);
            Controls.Add(grpBxUserDetails);
            Controls.Add(btnAddUser);
            Controls.Add(LblNoUsersAvailable);
            Controls.Add(lblManage);
            Controls.Add(listUsers);
            Name = "ManageUsers";
            Size = new Size(1149, 784);
            Load += ManageUsers_Load;
            Layout += ManageUsers_Layout;
            grpBxUserDetails.ResumeLayout(false);
            grpBxUserDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel lblManage;
        private ReaLTaiizor.Controls.BigLabel LblNoUsersAvailable;
        private ReaLTaiizor.Controls.ForeverButton btnAddUser;
        private ReaLTaiizor.Controls.ForeverButton btnRemoveUser;
        private ReaLTaiizor.Controls.ForeverButton btnSaveUser;
        private ReaLTaiizor.Controls.HopeGroupBox grpBxUserDetails;
        private ReaLTaiizor.Controls.HopeTextBox boxLastName;
        private Label lblLastName;
        private ReaLTaiizor.Controls.HopeTextBox boxFirstName;
        private Label lblFirstName;
        private ReaLTaiizor.Controls.HopeTextBox boxEmail;
        private Label lblUsername;
        private ReaLTaiizor.Controls.HopeTextBox boxRepeatPassword;
        private Label lblPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxPassword;
        private Label lblRepeatPassword;
        private ReaLTaiizor.Controls.HopeTextBox boxUsername;
        private Label lblEmail;
        private Label lblUserDetails;
        private ReaLTaiizor.Controls.ForeverButton btnEditUser;
        private ReaLTaiizor.Controls.ForeverButton btnImportUsers;
        private ReaLTaiizor.Controls.MetroListBox listUsers;
    }
}
