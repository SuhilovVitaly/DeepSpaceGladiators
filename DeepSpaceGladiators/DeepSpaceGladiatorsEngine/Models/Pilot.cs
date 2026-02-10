namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Pilot state: name and stamina for playing cards.</summary>
public class Pilot
{
    /// <summary>Display name (loaded from pilot definition).</summary>
    public string Name { get; set; } = string.Empty;

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
