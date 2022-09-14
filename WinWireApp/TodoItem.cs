
using System.Text.Json.Serialization;

public class TodoItem
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("isDone")]

    public bool IsDone { get; set; }
}
