namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Base type for maneuver and action cards.</summary>
public abstract class Card
{
    /// <summary>Unique card identifier.</summary>
    public string Id { get; }

    /// <summary>Display name.</summary>
    public string Name { get; }

    /// <summary>Stamina cost to play.</summary>
    public int Cost { get; }

    /// <summary>Description for UI.</summary>
    public string Description { get; }

    protected Card(string id, string name, int cost, string description)
    {
        Id = id;
        Name = name;
        Cost = cost;
        Description = description;
    }
}
