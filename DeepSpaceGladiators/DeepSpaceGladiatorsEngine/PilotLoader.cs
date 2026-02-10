using System.Text.Json;
using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiatorsEngine;

/// <summary>Loads pilot definitions from JSON files.</summary>
public static class PilotLoader
{
    private static readonly JsonSerializerOptions s_options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    /// <summary>Full path to Data/Pilots folder.</summary>
    public static string GetPilotsDirectory() =>
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Pilots");

    /// <summary>Loads a pilot from Data/Pilots by filename (e.g. "Tara.json"), resolves portrait, and returns the Pilot.</summary>
    public static Pilot LoadFromFile(string fileName, bool isPlayer)
    {
        var filePath = Path.Combine(GetPilotsDirectory(), fileName);
        var pilot = LoadFromFile(filePath);
        pilot.Portrait = PortraitResolver.Resolve(pilot.Id, isPlayer);
        return pilot;
    }

    /// <summary>Loads a pilot definition from a JSON file and returns a runtime Pilot (portrait not resolved).</summary>
    public static Pilot LoadFromFile(string filePath)
    {
        using var stream = File.OpenRead(filePath);
        var definition = JsonSerializer.Deserialize<PilotDefinition>(stream, s_options)
            ?? throw new InvalidOperationException($"Failed to deserialize pilot from {filePath}.");
        return definition.ToPilot();
    }

    /// <summary>Loads a pilot definition from JSON stream and returns a runtime Pilot.</summary>
    public static Pilot LoadFromStream(Stream stream)
    {
        var definition = JsonSerializer.Deserialize<PilotDefinition>(stream, s_options)
            ?? throw new InvalidOperationException("Failed to deserialize pilot from stream.");
        return definition.ToPilot();
    }
}
