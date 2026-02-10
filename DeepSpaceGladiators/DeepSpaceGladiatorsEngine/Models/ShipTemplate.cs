namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Ship template identifier (Duelist or Bruiser).</summary>
public enum ShipTemplateId
{
    Duelist,
    Bruiser
}

/// <summary>Template for creating a ship: name/id, ShieldMax, StructureMax from GameConstants.</summary>
public static class ShipTemplate
{
    /// <summary>Create a Ship with three modules and shield/structure from GameConstants for the given template.</summary>
    public static Ship CreateShip(ShipTemplateId templateId)
    {
        var (shieldMax, structureMax) = templateId switch
        {
            ShipTemplateId.Duelist => (GameConstants.DuelistShieldMax, GameConstants.DuelistStructureMax),
            ShipTemplateId.Bruiser => (GameConstants.BruiserShieldMax, GameConstants.BruiserStructureMax),
            _ => throw new ArgumentOutOfRangeException(nameof(templateId), templateId, null)
        };
        var modules = new List<ShipModule>
        {
            ShipModule.Create(ShipModuleType.Weapon),
            ShipModule.Create(ShipModuleType.Engine),
            ShipModule.Create(ShipModuleType.ShieldGenerator)
        };
        return new Ship(shieldMax, structureMax, modules);
    }
}
