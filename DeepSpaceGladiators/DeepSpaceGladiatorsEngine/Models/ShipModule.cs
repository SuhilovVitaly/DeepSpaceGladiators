namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Single ship module (Weapon, Engine, or ShieldGenerator).</summary>
public class ShipModule
{
    /// <summary>Module type.</summary>
    public ShipModuleType Type { get; }

    /// <summary>Whether the module is online (not disabled).</summary>
    public bool IsOnline { get; set; }
    public List<IGameCard> Cards { get; set; }  

    /// <summary>Create a module by type, online by default.</summary>
    public ShipModule(ShipModuleType type, bool isOnline = true)
    {
        Type = type;
        IsOnline = isOnline;
    }
}
