namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Maneuver card with type for accuracy modifiers and effects.</summary>
public class ManeuverCard : Card
{
    /// <summary>Maneuver type (SteadyVector, EvasiveDrift, etc.).</summary>
    public ManeuverType ManeuverType { get; }

    public ManeuverCard(string id, string name, int cost, string description, ManeuverType maneuverType)
        : base(id, name, cost, description)
    {
        ManeuverType = maneuverType;
    }
}
