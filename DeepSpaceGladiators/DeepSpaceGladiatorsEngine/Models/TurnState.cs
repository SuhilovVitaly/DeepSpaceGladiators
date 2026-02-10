namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Per-side data for the current turn: hand, planned cards, applied maneuvers.</summary>
public class SideTurnData
{
    private readonly List<ManeuverCard> _handManeuvers = new();
    private readonly List<ActionCard> _handActions = new();
    private readonly List<Card> _plannedCards = new();
    private readonly List<ManeuverCard> _appliedManeuvers = new();

    /// <summary>Current hand: up to 3 maneuver cards.</summary>
    public IReadOnlyList<ManeuverCard> HandManeuvers => _handManeuvers;

    /// <summary>Current hand: up to 3 action cards.</summary>
    public IReadOnlyList<ActionCard> HandActions => _handActions;

    /// <summary>Cards selected for this turn (to be resolved).</summary>
    public IReadOnlyList<Card> PlannedCards => _plannedCards;

    /// <summary>Maneuvers already applied this turn (for accuracy modifiers during resolve).</summary>
    public IReadOnlyList<ManeuverCard> AppliedManeuvers => _appliedManeuvers;

    /// <summary>Mutable list for engine: hand maneuver cards.</summary>
    internal List<ManeuverCard> HandManeuversMutable => _handManeuvers;

    /// <summary>Mutable list for engine: hand action cards.</summary>
    internal List<ActionCard> HandActionsMutable => _handActions;

    /// <summary>Mutable list for engine: planned cards.</summary>
    internal List<Card> PlannedCardsMutable => _plannedCards;

    /// <summary>Mutable list for engine: applied maneuvers.</summary>
    internal List<ManeuverCard> AppliedManeuversMutable => _appliedManeuvers;
}

/// <summary>State of the current turn: hands, planned cards, and applied maneuvers per side.</summary>
public class TurnState
{
    /// <summary>Player's hand, planned cards, and applied maneuvers.</summary>
    public SideTurnData Player { get; } = new();

    /// <summary>Opponent's hand, planned cards, and applied maneuvers.</summary>
    public SideTurnData Opponent { get; } = new();

    /// <summary>Get turn data for the given side.</summary>
    public SideTurnData GetSide(Side side)
    {
        return side == Side.Player ? Player : Opponent;
    }
}
