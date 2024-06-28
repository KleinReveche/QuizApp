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
            listUsers = new ReaLTaiizor.Controls.RoyalListBox();
            btnSaveUser = new ReaLTaiizor.Controls.ForeverButton();
            grpBxUserDetails = new ReaLTaiizor.Controls.HopeGroupBox();
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
            // 
            // btnRemoveUser
            // 
            btnRemoveUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemoveUser.BackColor = Color.Transparent;
            btnRemoveUser.BaseColor = Color.FromArgb(147, 0, 10);
            btnRemoveUser.Font = new Font("Segoe UI", 12F);
            btnRemoveUser.Location = new Point(693, 736);
            btnRemoveUser.Name = "btnRemoveUser";
            btnRemoveUser.Rounded = true;
            btnRemoveUser.Size = new Size(138, 45);
            btnRemoveUser.TabIndex = 20;
            btnRemoveUser.Text = "Remove User";
            btnRemoveUser.TextColor = Color.FromArgb(255, 180, 171);
            btnRemoveUser.Visible = false;
            // 
            // listUsers
            // 
            listUsers.BackColor = Color.FromArgb(50, 40, 39);
            listUsers.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listUsers.HotLightColor = Color.FromArgb(221, 221, 221);
            listUsers.HotLightedIndex = -1;
            listUsers.ItemHeight = 40;
            listUsers.Location = new Point(28, 131);
            listUsers.MultiSelection = false;
            listUsers.Name = "listUsers";
            listUsers.SelectedColor = Color.FromArgb(115, 51, 51);
            listUsers.SelectedIndex = -1;
            listUsers.Size = new Size(334, 644);
            listUsers.TabIndex = 21;
            listUsers.Visible = false;
            listUsers.Click += listUsers_Click;
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = Color.Transparent;
            btnSaveUser.BaseColor = Color.FromArgb(68, 41, 40);
            btnSaveUser.Font = new Font("Segoe UI", 12F);
            btnSaveUser.Location = new Point(851, 736);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Rounded = true;
            btnSaveUser.Size = new Size(115, 45);
            btnSaveUser.TabIndex = 19;
            btnSaveUser.Text = "Save User";
            btnSaveUser.TextColor = Color.FromArgb(230, 189, 186);
            btnSaveUser.Visible = false;
            // 
            // grpBxUserDetails
            // 
            grpBxUserDetails.BorderColor = Color.FromArgb(255, 222, 170);
            grpBxUserDetails.Font = new Font("Segoe UI", 12F);
            grpBxUserDetails.ForeColor = Color.FromArgb(48, 49, 51);
            grpBxUserDetails.LineColor = Color.FromArgb(255, 222, 170);
            grpBxUserDetails.Location = new Point(368, 131);
            grpBxUserDetails.Name = "grpBxUserDetails";
            grpBxUserDetails.ShowText = false;
            grpBxUserDetails.Size = new Size(598, 593);
            grpBxUserDetails.TabIndex = 22;
            grpBxUserDetails.TabStop = false;
            grpBxUserDetails.ThemeColor = Color.FromArgb(61, 50, 50);
            grpBxUserDetails.Visible = false;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Layout += ManageUsers_Layout;
            Controls.Add(grpBxUserDetails);
            Controls.Add(listUsers);
            Controls.Add(btnRemoveUser);
            Controls.Add(btnSaveUser);
            Controls.Add(btnAddUser);
            Controls.Add(LblNoUsersAvailable);
            Controls.Add(lblManage);
            Name = "ManageUsers";
            Size = new Size(1149, 784);
            Layout += ManageUsers_Layout;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel lblManage;
        private ReaLTaiizor.Controls.BigLabel LblNoUsersAvailable;
        private ReaLTaiizor.Controls.ForeverButton btnAddUser;
        private ReaLTaiizor.Controls.ForeverButton btnRemoveUser;
        private ReaLTaiizor.Controls.RoyalListBox listUsers;
        private ReaLTaiizor.Controls.ForeverButton btnSaveUser;
        private ReaLTaiizor.Controls.HopeGroupBox grpBxUserDetails;
    }
}
