using System.Text.Json.Serialization;

namespace QuizApp.Core.Data.Models;

public class QuizAppSettings
{
    
}

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(QuizAppSettings))]
internal partial class SettingsJsonContext : JsonSerializerContext;