using QuizApp.WinFormsUI.Controls;
using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Forms
{
    partial class AdminDashboardForm
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
            SidePanel = new Panel();
            btnUsers = new Button();
            btnSettings = new Button();
            pictureBox1 = new PictureBox();
            SidePanelIndicator = new Panel();
            ActionBar = new Panel();
            ActionBarAccented = new Panel();
            btnClose = new Label();
            btnHome = new Button();
            btnQuizzes = new Button();
            settings = new Settings(_user);
            quizzes = new QuizzesAdmin();
            home = new HomeAdmin(_user);
            users = new ManageUsers();
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(39, 29, 29);
            SidePanel.Controls.Add(btnUsers);
            SidePanel.Controls.Add(btnSettings);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Controls.Add(SidePanelIndicator);
            SidePanel.Controls.Add(ActionBar);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Margin = new Padding(4);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(222, 718);
            SidePanel.TabIndex = 0;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(39, 29, 29);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(15, 329);
            btnUsers.Margin = new Padding(4);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(206, 66);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "       Manage Users";
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnMenu_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(39, 29, 29);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(15, 403);
            btnSettings.Margin = new Padding(4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(206, 66);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "       Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Resources.trace_logo;
            pictureBox1.Image = Resources.trace_logo;
            pictureBox1.InitialImage = Resources.trace_logo;
            pictureBox1.Location = new Point(53, 32);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SidePanelIndicator
            // 
            SidePanelIndicator.BackColor = Color.FromArgb(152, 26, 37);
            SidePanelIndicator.Location = new Point(1, 189);
            SidePanelIndicator.Margin = new Padding(4);
            SidePanelIndicator.Name = "SidePanelIndicator";
            SidePanelIndicator.Size = new Size(13, 66);
            SidePanelIndicator.TabIndex = 4;
            // 
            // ActionBar
            // 
            ActionBar.Location = new Point(3, 0);
            ActionBar.Name = "ActionBar";
            ActionBar.Size = new Size(219, 14);
            ActionBar.TabIndex = 3;
            ActionBar.MouseDown += ActionBar_MouseDown;
            // 
            // ActionBarAccented
            // 
            ActionBarAccented.BackColor = Color.FromArgb(152, 26, 37);
            ActionBarAccented.Dock = DockStyle.Top;
            ActionBarAccented.Location = new Point(222, 0);
            ActionBarAccented.Margin = new Padding(4);
            ActionBarAccented.Name = "ActionBarAccented";
            ActionBarAccented.Size = new Size(1146, 14);
            ActionBarAccented.TabIndex = 1;
            ActionBarAccented.MouseDown += ActionBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.AutoSize = true;
            btnClose.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(255, 249, 249);
            btnClose.Location = new Point(1330, 18);
            btnClose.Margin = new Padding(4, 0, 4, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "x";
            btnClose.Click += btnClose_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(39, 29, 29);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(15, 187);
            btnHome.Margin = new Padding(4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(206, 66);
            btnHome.TabIndex = 4;
            btnHome.Text = "       Overview";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnMenu_Click;
            // 
            // btnQuizzes
            // 
            btnQuizzes.BackColor = Color.FromArgb(39, 29, 29);
            btnQuizzes.FlatAppearance.BorderSize = 0;
            btnQuizzes.FlatStyle = FlatStyle.Flat;
            btnQuizzes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuizzes.ForeColor = Color.White;
            btnQuizzes.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuizzes.Location = new Point(15, 255);
            btnQuizzes.Margin = new Padding(4);
            btnQuizzes.Name = "btnQuizzes";
            btnQuizzes.Size = new Size(206, 66);
            btnQuizzes.TabIndex = 4;
            btnQuizzes.Text = "       Quizzes";
            btnQuizzes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuizzes.UseVisualStyleBackColor = false;
            btnQuizzes.Click += btnMenu_Click;
            // 
            // settings
            // 
            settings.AutoSize = true;
            settings.BackColor = Color.Transparent;
            settings.Location = new Point(222, 16);
            settings.Name = "settings";
            settings.Size = new Size(1146, 702);
            settings.TabIndex = 5;
            settings.Visible = false;
            // 
            // quizzes
            // 
            quizzes.AutoSize = true;
            quizzes.Location = new Point(223, 15);
            quizzes.Name = "quizzes";
            quizzes.Size = new Size(1145, 703);
            quizzes.TabIndex = 6;
            quizzes.Visible = false;
            // 
            // home
            // 
            home.AutoSize = true;
            home.BackColor = Color.Transparent;
            home.Location = new Point(222, 16);
            home.Name = "home";
            home.Size = new Size(1146, 702);
            home.TabIndex = 7;
            // 
            // users
            // 
            users.AutoSize = true;
            users.BackColor = Color.Transparent;
            users.Location = new Point(223, 15);
            users.Name = "users";
            users.Size = new Size(1145, 703);
            users.TabIndex = 8;
            users.Visible = false;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 17, 17);
            ClientSize = new Size(1368, 718);
            ControlBox = false;
            Controls.Add(users);
            Controls.Add(btnClose);
            Controls.Add(btnQuizzes);
            Controls.Add(btnHome);
            Controls.Add(ActionBarAccented);
            Controls.Add(SidePanel);
            Controls.Add(home);
            Controls.Add(settings);
            Controls.Add(quizzes);
            FormBorderStyle = FormBorderStyle.None;
            Icon = Resources.trace_logo_ico;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDashboard";
            WindowState = FormWindowState.Maximized;
            Layout += AdminDashboard_Layout;
            SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel SidePanel;
        private Panel ActionBarAccented;
        private Label btnClose;
        private Panel ActionBar;
        private Panel SidePanelIndicator;
        private Button btnHome;
        private Button btnQuizzes;
        private PictureBox pictureBox1;
        private Button btnSettings;
        private Button btnUsers;
        private Settings settings;
        private QuizzesAdmin quizzes;
        private HomeAdmin home;
        private ManageUsers users;
    }
}