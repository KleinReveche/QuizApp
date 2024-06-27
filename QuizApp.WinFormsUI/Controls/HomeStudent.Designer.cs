namespace QuizApp.WinFormsUI.Controls
{
    partial class HomeStudent
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
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 25F);
            lblWelcome.ForeColor = Color.FromArgb(255, 179, 176);
            lblWelcome.Location = new Point(18, 21);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(296, 46);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome Student!";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            Controls.Add(lblWelcome);
            Name = "Home";
            Size = new Size(1149, 706);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel lblWelcome;
    }
}
