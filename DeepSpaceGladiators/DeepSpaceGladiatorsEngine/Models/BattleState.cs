namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Full battle state: ships, pilots, phase, turn number, winner, and current turn (hands, planned cards).</summary>
public class BattleState
{
    /// <summary>Player's ship.</summary>
    public Ship PlayerShip { get; set; } = null!;

    /// <summary>Player's pilot.</summary>
    public Pilot PlayerPilot { get; set; } = null!;

    /// <summary>Opponent's ship.</summary>
    public Ship OpponentShip { get; set; } = null!;

    /// <summary>Opponent's pilot.</summary>
    public Pilot OpponentPilot { get; set; } = null!;

    /// <summary>Current turn number (1-based).</summary>
    public int CurrentTurnNumber { get; set; }

    /// <summary>Current phase of the battle.</summary>
    public BattlePhase Phase { get; set; }

    /// <summary>Winner when Phase == Ended; null otherwise.</summary>
    public Side? Winner { get; set; }

    /// <summary>Current turn state: hands, planned cards, applied maneuvers per side.</summary>
    public TurnState Turn { get; } = new();

    /// <summary>Get ship for the given side.</summary>
    public Ship GetShip(Side side) => side == Side.Player ? PlayerShip : OpponentShip;

    /// <summary>Get pilot for the given side.</summary>
    public Pilot GetPilot(Side side) => side == Side.Player ? PlayerPilot : OpponentPilot;
}
