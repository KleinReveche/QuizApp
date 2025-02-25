﻿using QuizApp.Core.Data;
using QuizApp.Core.Data.Models;
using QuizApp.Core.Data.Validation;
using QuizApp.WinFormsUI.Properties;

namespace QuizApp.WinFormsUI.Controls;

public partial class Settings : UserControl
{
    private readonly User _user;
    public bool DefaultPassword { get; set; }

    public Settings(User user, bool defaultPassword = false)
    {
        _user = user;
        InitializeComponent();
        DefaultPassword = defaultPassword;
    }

    private void btnAction_Click(object sender, EventArgs e)
    {
        var validation = new RegisterValidation(QuizApp.Repo);

        var validatedOld = validation.ValidatePassword(boxOldPassword.Text, boxOldPassword.Text, "Old ", DefaultPassword);
        if (validatedOld.Length > 0)
        {
            MessageBox.Show(validatedOld, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var validatedNew = validation.ValidatePassword(boxNewPassword.Text, boxNewRepeatPassword.Text, "New ");
        if (validatedNew.Length > 0)
        {
            MessageBox.Show(validatedNew, Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var updatedUser = new User
        {
            FirstName = _user.FirstName,
            LastName = _user.LastName,
            Username = _user.Username,
            Email = _user.Email,
            UserType = _user.UserType,
            Id = _user.Id,
            PasswordHash = new Credentials().HashPassword(boxNewPassword.Text, out var newSalt),
            Salt = newSalt
        };

        QuizApp.Repo.UpdateUser(_user, updatedUser);
        MessageBox.Show(Resources.password_updated_success, Resources.info, MessageBoxButtons.OK, MessageBoxIcon.Information);

        DefaultPassword = false;
    }
}