using System.ComponentModel.DataAnnotations;

namespace QuizApp.Core.Data.Models;

public class User
{
    [Key] public int Id { get; init; }

    [StringLength(255)] public required string Username { get; init; }

    [StringLength(255)] public required string PasswordHash { get; init; }

    public required byte[] Salt { get; set; }

    [StringLength(255)] public required string Email { get; init; }

    public UserType UserType { get; init; } = UserType.User;
}

public enum UserType
{
    Admin,
    User
}