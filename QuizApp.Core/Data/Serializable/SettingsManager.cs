using System.Text.Json;
using QuizApp.Core.Data.Models;
using QuizApp.Core.Utils;

namespace QuizApp.Core.Data.Serializable;

public static class SettingsManager
{
    public const string SettingsJsonLocation = "QuizAppSettings.dat";

    private static readonly JsonSerializerOptions SourceGenOptions = new()
    {
        TypeInfoResolver = SettingsJsonContext.Default,
        WriteIndented = true
    };

    private static readonly SettingsJsonContext Context = new(SourceGenOptions);

    public static QuizAppSettings LoadOptions()
    {
        var defaultOptions = new QuizAppSettings();

        if (!File.Exists(SettingsJsonLocation)) return defaultOptions;

        var json = File.ReadAllText(SettingsJsonLocation);
        return JsonSerializer.Deserialize(
            JsonScrambler.Decode(json), Context.QuizAppSettings) ?? defaultOptions;
    }


    public static void SaveSettings(QuizAppSettings quizAppSettings)
    {
        var json = JsonSerializer.Serialize(quizAppSettings, Context.QuizAppSettings);
        File.WriteAllText(SettingsJsonLocation, JsonScrambler.Encode(json));
    }
}