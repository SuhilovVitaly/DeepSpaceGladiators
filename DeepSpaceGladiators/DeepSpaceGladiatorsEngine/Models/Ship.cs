namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Ship state: shield, structure, and three modules (Weapon, Engine, ShieldGenerator).</summary>
public class Ship
{
    /// <summary>Maximum shield.</summary>
    public int ShieldMax { get; set; }

    /// <summary>Current shield.</summary>
    public int ShieldCurrent { get; set; }

    /// <summary>Maximum structure (hull).</summary>
    public int StructureMax { get; set; }

    /// <summary>Current structure.</summary>
    public int StructureCurrent { get; set; }

    /// <summary>Three modules in order: Weapon, Engine, ShieldGenerator.</summary>
    public IReadOnlyList<ShipModule> Modules { get; set; } = [];

    /// <summary>Parameterless constructor for JSON deserialization.</summary>
    public Ship()
    {
    }

    /// <summary>Create ship with given shield/structure and three modules.</summary>
    public Ship(int shieldMax, int structureMax, IReadOnlyList<ShipModule> modules)
    {
        ShieldMax = shieldMax;
        ShieldCurrent = shieldMax;
        StructureMax = structureMax;
        StructureCurrent = structureMax;
        Modules = modules ?? throw new ArgumentNullException(nameof(modules));
        if (Modules.Count != 3)
            throw new ArgumentException("Ship must have exactly 3 modules (Weapon, Engine, ShieldGenerator).", nameof(modules));
    }
}
