using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiatorsEngine.Game.Generation;

public static class ShipGeneration
{
    public static Ship Generate(string id)
    {
        var shieldMax = 6;
        var structureMax = 6;

        var modules = new List<ShipModule>
        {
            ModuleGeneration.Generate(ShipModuleType.Weapon, ""),
            ModuleGeneration.Generate(ShipModuleType.Engine, ""),
            ModuleGeneration.Generate(ShipModuleType.ShieldGenerator, "")
        };

        return new Ship(shieldMax, structureMax, modules);
    }
}
