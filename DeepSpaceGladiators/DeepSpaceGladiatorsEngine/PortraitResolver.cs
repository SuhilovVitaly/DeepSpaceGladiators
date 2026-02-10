using System.Text.Json;

namespace DeepSpaceGladiatorsEngine;

/// <summary>Resolves pilot portrait path: {id}.json in Portraits, then image by id, or random from Female/Male.</summary>
public static class PortraitResolver
{
    private static readonly string[] s_imageExtensions = { ".png", ".jpg", ".jpeg", ".gif", ".bmp", ".webp" };

    /// <summary>Full path to Data/Pilots/Portraits folder.</summary>
    public static string GetPortraitsDirectory() =>
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Pilots", "Portraits");

    /// <summary>
    /// Resolves portrait path for a pilot using Data/Pilots/Portraits. Calls Resolve(GetPortraitsDirectory(), pilotId, isPlayer).
    /// </summary>
    public static string? Resolve(string pilotId, bool isPlayer) =>
        Resolve(GetPortraitsDirectory(), pilotId, isPlayer);

    /// <summary>
    /// Resolves portrait path for a pilot.
    /// First looks for Portraits/{pilotId}.json (path to image inside); then image named {pilotId}; then random from Female/Male.
    /// </summary>
    /// <param name="portraitsDir">Full path to Portraits folder.</param>
    /// <param name="pilotId">Pilot id from definition (e.g. "Tara", "AI_Basic").</param>
    /// <param name="isPlayer">True for player (lookup + Female fallback), false for opponent (Male random).</param>
    /// <returns>Full path to image file, or null if none found.</returns>
    public static string? Resolve(string portraitsDir, string pilotId, bool isPlayer)
    {
        if (string.IsNullOrWhiteSpace(portraitsDir) || !Directory.Exists(portraitsDir))
            return null;

        var fromJson = TryReadFromJson(portraitsDir, pilotId);
        if (fromJson != null)
            return fromJson;

        if (isPlayer)
        {
            var byName = TryFindByName(portraitsDir, pilotId);
            if (byName != null)
                return byName;
            return PickRandomFromSubfolder(portraitsDir, "Female");
        }

        return PickRandomFromSubfolder(portraitsDir, "Female");
    }

    /// <summary>Reads Portraits/{pilotId}.json; expects {"path": "filename.png"} (path relative to Portraits).</summary>
    private static string? TryReadFromJson(string portraitsDir, string pilotId)
    {
        if (string.IsNullOrWhiteSpace(pilotId))
            return null;
        var jsonPath = Path.Combine(portraitsDir, pilotId.Trim() + ".json");
        if (!File.Exists(jsonPath))
            return null;
        try
        {
            var json = File.ReadAllText(jsonPath);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            if (root.TryGetProperty("path", out var pathProp))
            {
                var path = pathProp.GetString();
                if (!string.IsNullOrWhiteSpace(path))
                    return Path.Combine(portraitsDir, path);
            }
        }
        catch { /* ignore */ }
        return null;
    }

    private static string? TryFindByName(string portraitsDir, string pilotId)
    {
        if (string.IsNullOrWhiteSpace(pilotId))
            return null;
        var name = pilotId.Trim();
        foreach (var ext in s_imageExtensions)
        {
            var path = Path.Combine(portraitsDir, name + ext);
            if (File.Exists(path))
                return path;
        }
        return null;
    }

    private static string? PickRandomFromSubfolder(string portraitsDir, string subfolder)
    {
        var dir = Path.Combine(portraitsDir, subfolder);
        if (!Directory.Exists(dir))
            return null;
        var files = Directory.GetFiles(dir)
            .Where(f => s_imageExtensions.Contains(Path.GetExtension(f).ToLowerInvariant()))
            .ToArray();
        if (files.Length == 0)
            return null;
        return files[Random.Shared.Next(files.Length)];
    }
}
