using System.Text.Json.Serialization;

namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Pilot data loaded from JSON (id, name, stamina).</summary>
public class PilotDefinition
{
    /// <summary>Unique pilot identifier (e.g. "Tara", "AI_Basic").</summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>Display name.</summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>Maximum stamina for playing cards.</summary>
    [JsonPropertyName("staminaMax")]
    public int StaminaMax { get; set; }

    /// <summary>Optional description.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Creates a runtime Pilot instance with name and full stamina.</summary>
    public Pilot ToPilot()
    {
        return new Pilot
        {
            Name = Name,
            StaminaMax = StaminaMax,
            StaminaCurrent = StaminaMax
        };
    }
}
