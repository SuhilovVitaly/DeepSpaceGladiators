using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiatorsEngine.Definitions;

/// <summary>Static definitions for all 5 maneuver and 5 action cards (MVP deck).</summary>
public static class CardDefinitions
{
    /// <summary>Returns the full set of 5 maneuver cards for deck building.</summary>
    public static IReadOnlyList<ManeuverCard> GetManeuverDeck()
    {
        return new ManeuverCard[]
        {
            new ManeuverCard("man_steady", "Steady Vector", 0, "Hold course. No accuracy modifier.", ManeuverType.SteadyVector),
            new ManeuverCard("man_evasive", "Evasive Drift", 1, "Evasive maneuver. Defensive accuracy modifier.", ManeuverType.EvasiveDrift),
            new ManeuverCard("man_aggressive", "Aggressive Approach", 1, "Close in. Offensive accuracy modifier.", ManeuverType.AggressiveApproach),
            new ManeuverCard("man_hardturn", "Hard Turn", 1, "Sharp turn. Alters facing.", ManeuverType.HardTurn),
            new ManeuverCard("man_overburn", "Overburn", 2, "Engine overburn. Engine disabled after resolve.", ManeuverType.Overburn)
        };
    }

    /// <summary>Returns the full set of 5 action cards for deck building.</summary>
    public static IReadOnlyList<ActionCard> GetActionDeck()
    {
        return new ActionCard[]
        {
            new ActionCard("act_pulse", "Pulse Shot", 1, "Light weapon shot.", ActionType.PulseShot, 4, 1),
            new ActionCard("act_focused", "Focused Fire", 2, "Precise shot. On miss: -1 Shield to self.", ActionType.FocusedFire, 5, 2),
            new ActionCard("act_scatter", "Scatter Burst", 1, "Three 1-damage hits, one accuracy roll.", ActionType.ScatterBurst, 3, 3),
            new ActionCard("act_shield", "Shield Pulse", 1, "Reinforce shields.", ActionType.ShieldPulse, 0, 0),
            new ActionCard("act_patch", "Module Patch", 1, "Repair: Disabled module becomes Online.", ActionType.ModulePatch, 0, 0)
        };
    }
}
