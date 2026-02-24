using System.Text.Json.Serialization;

namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Single ship module (Weapon, Engine, or ShieldGenerator).</summary>
public class ShipModule
{
    /// <summary>Module type.</summary>
    [JsonPropertyName("moduleType")]
    public ShipModuleType Type { get; set; }

    public string Name { get; set; } = string.Empty;

    /// <summary>Whether the module is online (not disabled).</summary>
    public bool IsOnline { get; set; }

    public List<IGameCard> Cards { get; set; } = [];

    public ShipModule()
    {
        Name = string.Empty;
        Cards = [];
    }

    /// <summary>Create a module by type, online by default.</summary>
    public ShipModule(ShipModuleType type, bool isOnline = true)
    {
        Type = type;
        IsOnline = isOnline;
    }
}
