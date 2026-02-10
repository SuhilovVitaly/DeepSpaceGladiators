namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Single ship module (Weapon, Engine, or ShieldGenerator).</summary>
public class ShipModule
{
    /// <summary>Module type.</summary>
    public ShipModuleType Type { get; }

    /// <summary>Whether the module is online (not disabled).</summary>
    public bool IsOnline { get; set; }

    /// <summary>Create a module by type, online by default.</summary>
    public ShipModule(ShipModuleType type, bool isOnline = true)
    {
        Type = type;
        IsOnline = isOnline;
    }

    /// <summary>Factory: create a module by type.</summary>
    public static ShipModule Create(ShipModuleType type, bool isOnline = true) => new ShipModule(type, isOnline);
}
