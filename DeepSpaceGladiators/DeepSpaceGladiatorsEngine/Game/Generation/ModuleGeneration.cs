using System.Text.Json;
using System.Text.Json.Serialization;
using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiatorsEngine.Game.Generation
{
    public static class ModuleGeneration
    {
        private static readonly JsonSerializerOptions s_options = new()
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };

        public static string GetEquipmentDirectory() =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Ships", "Equipment");

        public static ShipModule Generate(string moduleId)
        {
            var filePath = Path.Combine(GetEquipmentDirectory(), $"{moduleId}.json");
            return LoadFromFile(filePath);
        }

        private static ShipModule LoadFromFile(string filePath)
        {
            using var stream = File.OpenRead(filePath);
            return JsonSerializer.Deserialize<ShipModule>(stream, s_options)
                ?? throw new InvalidOperationException($"Failed to deserialize module from {filePath}.");
        }
    }
}
