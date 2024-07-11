using System.ComponentModel.DataAnnotations;

namespace QuizApp.Core.Data.Models;

public class User
{
    [Key] public int Id { get; init; }
    [StringLength(255)] public required string FirstName { get; init; }
    [StringLength(255)] public required string LastName { get; init; }
    [StringLength(255)] public required string Username { get; init; }
    [StringLength(255)] public string PasswordHash { get; init; } = "password";
    public byte[] Salt { get; set; }
    [StringLength(255)] public required string Email { get; init; }

    public UserType UserType { get; init; } = UserType.User;

    public string FullName => $"{FirstName} {LastName}";
    public string ReversedFullName => $"{LastName}, {FirstName}";
}

public enum UserType
{
    Admin,
    User
}