using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace QuizApp.Core.Data.Models;

public class Quiz
{
    public required int Id { get; init; }
    [StringLength(1024)] public required string Title { get; init; }
    public required List<Question> Questions { get; init; }
    public List<TakerScore> TakerScores { get; init; } = [];
}

public class Question
{
    public required int Id { get; init; }
    [StringLength(1024)] public required string QuestionText { get; set; }
    public required List<string> Answers { get; set; }
    public required int CorrectAnswerIndex { get; set; }
}

public class TakerScore
{
    public required int Id { get; init; }
    public required int TakerId { get; init; }
    public required int Score { get; init; }
}

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(Quiz))]
public partial class QuizJsonContext : JsonSerializerContext;