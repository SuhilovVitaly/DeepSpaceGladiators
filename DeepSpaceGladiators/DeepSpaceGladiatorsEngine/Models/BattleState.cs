namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Full battle state: sides (ship + pilot each), phase, turn number, winner, and current turn (hands, planned cards).</summary>
public class BattleState
{
    /// <summary>Player side (ship and pilot).</summary>
    public SideState Player { get; set; } = null!;

    /// <summary>Opponent side (ship and pilot).</summary>
    public SideState Opponent { get; set; } = null!;

    /// <summary>Current turn number (1-based).</summary>
    public int CurrentTurnNumber { get; set; }

    /// <summary>Current phase of the battle.</summary>
    public BattlePhase Phase { get; set; }

    /// <summary>Winner when Phase == Ended; null otherwise.</summary>
    public Side? Winner { get; set; }

    /// <summary>Current turn state: hands, planned cards, applied maneuvers per side.</summary>
    public TurnState Turn { get; } = new();

    /// <summary>Get side state for the given side.</summary>
    public SideState GetSide(Side side) => side == Side.Player ? Player : Opponent;

    /// <summary>Get ship for the given side.</summary>
    public Ship GetShip(Side side) => GetSide(side).Ship;

    /// <summary>Get pilot for the given side.</summary>
    public Pilot GetPilot(Side side) => GetSide(side).Pilot;

    /// <summary>Creates a default battle state: player Duelist vs opponent Bruiser, turn 1, Planning phase.</summary>
    public static BattleState CreateDefault()
    {
        return new BattleState
        {
            Player = SideState.Create(ShipTemplateId.Duelist),
            Opponent = SideState.Create(ShipTemplateId.Bruiser),
            CurrentTurnNumber = 1,
            Phase = BattlePhase.Planning
        };
    }
}
