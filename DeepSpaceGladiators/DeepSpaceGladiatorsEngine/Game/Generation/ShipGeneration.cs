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
        var shipData = LoadFromFile(filePath);

        var modules = shipData.Modules
            .Select(moduleId => ModuleGeneration.Generate(moduleId))
            .ToList();

        var ship = new Ship(shipData.ShieldMax, shipData.StructureMax, modules);

        return ship;
    }

    private static ShipData LoadFromFile(string filePath)
    {
        using var stream = File.OpenRead(filePath);
        return JsonSerializer.Deserialize<ShipData>(stream, s_options)
            ?? throw new InvalidOperationException($"Failed to deserialize ship from {filePath}.");
    }

    private class ShipData
    {
        public string Id { get; set; } = string.Empty;
        public int ShieldMax { get; set; }
        public int StructureMax { get; set; }
        public List<string> Modules { get; set; } = [];
    }
}
