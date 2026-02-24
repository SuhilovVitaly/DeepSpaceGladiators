namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Game card interface.</summary>
public interface IGameCard
{
    /// <summary>Unique card identifier.</summary>
    string Id { get; }

    /// <summary>Card source type (pilot skill or ship equipment).</summary>
    CardType CardType { get; }

    /// <summary>Stamina cost to use.</summary>
    int Cost { get; }
}
