using System.Text.Json;
using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiatorsEngine.Game.Generation;

public static class ShipGeneration
{
    private static readonly JsonSerializerOptions s_options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public static string GetShipsDirectory() =>
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Ships");

    public static Ship Generate(string id)
    {
        var filePath = Path.Combine(GetShipsDirectory(), $"{id}.json");
        var ship = LoadFromFile(filePath);

        ship.ShieldCurrent = ship.ShieldMax;
        ship.StructureCurrent = ship.StructureMax;
        ship.Modules = new List<ShipModule>
        {
            ModuleGeneration.Generate(ShipModuleType.Weapon, ""),
            ModuleGeneration.Generate(ShipModuleType.Engine, ""),
            ModuleGeneration.Generate(ShipModuleType.ShieldGenerator, "")
        };

        return ship;
    }

    private static Ship LoadFromFile(string filePath)
    {
        using var stream = File.OpenRead(filePath);
        return JsonSerializer.Deserialize<Ship>(stream, s_options)
            ?? throw new InvalidOperationException($"Failed to deserialize ship from {filePath}.");
    }
}
