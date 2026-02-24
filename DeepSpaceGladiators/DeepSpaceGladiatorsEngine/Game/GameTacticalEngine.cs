using DeepSpaceGladiatorsEngine.Definitions;
using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiatorsEngine.Game;

/// <summary>Battle business logic engine. Handles turn execution, damage resolution, and win conditions.</summary>
public class GameTacticalEngine
{
    private readonly BattleState _state;

    public GameTacticalEngine(BattleState state)
    {
        _state = state ?? throw new ArgumentNullException(nameof(state));
    }

    /// <summary>Current battle state.</summary>
    public BattleState State => _state;

    /// <summary>Starts a new turn: deals all available cards to both sides.</summary>
    public void StartTurn()
    {
        DealCards(Side.Player);
        DealCards(Side.Opponent);
    }

    private void DealCards(Side side)
    {
        var turnData = _state.Turn.GetSide(side);

        turnData.HandManeuversMutable.Clear();
        turnData.HandManeuversMutable.AddRange(CardDefinitions.GetManeuverDeck());

        turnData.HandActionsMutable.Clear();
        turnData.HandActionsMutable.AddRange(CardDefinitions.GetActionDeck());
    }

    /// <summary>Executes the current turn: resolves maneuvers and actions for both sides, checks win condition, and advances to next turn.</summary>
    public void ExecuteTurn()
    {
        _state.Phase = BattlePhase.Resolving;

        ResolveManeuvers(Side.Player);
        ResolveManeuvers(Side.Opponent);

        ResolveActions(Side.Player);
        ResolveActions(Side.Opponent);

        CheckWinCondition();

        if (_state.Phase != BattlePhase.Ended)
        {
            EndTurn();
        }
    }

    private void ResolveManeuvers(Side side)
    {
        var turnData = _state.Turn.GetSide(side);

        foreach (var card in turnData.PlannedCards.OfType<ManeuverCard>().ToList())
        {
            turnData.AppliedManeuversMutable.Add(card);
        }
    }

    private void ResolveActions(Side attackerSide)
    {
        var attackerTurn = _state.Turn.GetSide(attackerSide);
        var defenderSide = attackerSide == Side.Player ? Side.Opponent : Side.Player;
        var defenderShip = _state.GetShip(defenderSide);

        foreach (var card in attackerTurn.PlannedCards.OfType<ActionCard>().ToList())
        {
            if (card.Damage > 0)
            {
                ApplyDamage(defenderShip, card.Damage);
            }
        }
    }

    private static void ApplyDamage(Ship ship, int damage)
    {
        var remainingDamage = damage;

        if (ship.ShieldCurrent > 0)
        {
            var shieldDamage = Math.Min(ship.ShieldCurrent, remainingDamage);
            ship.ShieldCurrent -= shieldDamage;
            remainingDamage -= shieldDamage;
        }

        if (remainingDamage > 0)
        {
            ship.StructureCurrent -= remainingDamage;
        }
    }

    private void CheckWinCondition()
    {
        if (_state.Opponent.Ship.StructureCurrent <= 0)
        {
            _state.Winner = Side.Player;
            _state.Phase = BattlePhase.Ended;
        }
        else if (_state.Player.Ship.StructureCurrent <= 0)
        {
            _state.Winner = Side.Opponent;
            _state.Phase = BattlePhase.Ended;
        }
    }

    private void EndTurn()
    {
        _state.Turn.Player.PlannedCardsMutable.Clear();
        _state.Turn.Player.AppliedManeuversMutable.Clear();
        _state.Turn.Opponent.PlannedCardsMutable.Clear();
        _state.Turn.Opponent.AppliedManeuversMutable.Clear();

        _state.Player.Pilot.RestoreStamina();
        _state.Opponent.Pilot.RestoreStamina();

        _state.CurrentTurnNumber++;
        _state.Phase = BattlePhase.Planning;
    }
}
