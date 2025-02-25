using System.Text;

namespace QuizApp.Core.Utils;

public static class JsonScrambler
{
    private const string ScramblerVersion1 = "v1";

    public static string Encode(string json)
    {
        var bytes = Encoding.UTF8.GetBytes(json);
        var base64 = Convert.ToBase64String(bytes);
        var base64EncodedBytes = Encoding.UTF8.GetBytes(base64);
        var hexString = Convert.ToHexString(base64EncodedBytes);

        // Add version number to the beginning of the string, to allow for changes later.
        return ScramblerVersion1 + hexString;
    }

    public static string Decode(string hexString)
    {
        var base64EncodedBytes = Convert.FromHexString(hexString[2..]);
        var base64 = Encoding.UTF8.GetString(base64EncodedBytes);
        var bytes = Convert.FromBase64String(base64);
        var json = Encoding.UTF8.GetString(bytes);
        return json;
    }
}