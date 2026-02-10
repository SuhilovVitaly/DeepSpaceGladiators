namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Pilot state: name and stamina for playing cards.</summary>
public class Pilot
{
    /// <summary>Pilot identifier from definition (e.g. "Tara", "AI_Basic").</summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>Display name (loaded from pilot definition).</summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>Pilot rank (level).</summary>
    public PilotRank Rank { get; set; }

    /// <summary>Path to portrait image file (resolved from Portraits folder).</summary>
    public string? Portrait { get; set; }

    /// <summary>Maximum stamina (from GameConstants.StaminaMax).</summary>
    public int StaminaMax { get; set; }

    /// <summary>Current stamina.</summary>
    public int StaminaCurrent { get; set; }

    /// <summary>Restore stamina at end of turn: StaminaCurrent = min(StaminaMax, StaminaCurrent + StaminaRecoveryPerTurn).</summary>
    public void RestoreStamina()
    {
        StaminaCurrent = Math.Min(StaminaMax, StaminaCurrent + GameConstants.StaminaRecoveryPerTurn);
    }
}
