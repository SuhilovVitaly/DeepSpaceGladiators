using DeepSpaceGladiatorsEngine.Game;
using DeepSpaceGladiatorsEngine.Game.Generation;
using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiatorsTests;

public class BattleSimulationTests
{
    private BattleState _battle = null!;
    private GameTacticalEngine _engine = null!;

    [SetUp]
    public void Setup()
    {
        var playerPilot = CreateTestPilot("Tara", "Tara");
        var opponentPilot = CreateTestPilot("AI_Basic", "AI Basic");

        _battle = new BattleState
        {
            Player = SideState.Create(GenerationConstants.DefaultShip, playerPilot),
            Opponent = SideState.Create(GenerationConstants.DefaultShip, opponentPilot),
            CurrentTurnNumber = 1,
            Phase = BattlePhase.Planning
        };

        _engine = new GameTacticalEngine(_battle);
    }

    [Test]
    public void NewBattleGame_ShouldFinish_Correct()
    {
        Assert.That(_battle.Phase, Is.EqualTo(BattlePhase.Planning));
        Assert.That(_battle.CurrentTurnNumber, Is.EqualTo(1));

        Assert.That(_battle.Player.Pilot.Name, Is.EqualTo("Tara"));
        Assert.That(_battle.Player.Ship.ShieldMax, Is.EqualTo(GameConstants.DuelistShieldMax));

        Assert.That(_battle.Opponent.Pilot.Name, Is.EqualTo("AI Basic"));
        Assert.That(_battle.Opponent.Ship.ShieldMax, Is.EqualTo(GameConstants.BruiserShieldMax));

        _engine.StartTurn();

        Assert.That(_battle.Turn.Player.HandManeuvers.Count, Is.EqualTo(5));
        Assert.That(_battle.Turn.Player.HandActions.Count, Is.EqualTo(5));
        Assert.That(_battle.Turn.Opponent.HandManeuvers.Count, Is.EqualTo(5));
        Assert.That(_battle.Turn.Opponent.HandActions.Count, Is.EqualTo(5));

        PlanCards(Side.Player, maneuverIndex: 0, actionIndex: 0);
        PlanCards(Side.Opponent, maneuverIndex: 1, actionIndex: 1);

        Assert.That(_battle.Turn.Player.PlannedCards.Count, Is.EqualTo(2));
        Assert.That(_battle.Turn.Opponent.PlannedCards.Count, Is.EqualTo(2));

        _engine.ExecuteTurn();

        Assert.That(_battle.Phase, Is.EqualTo(BattlePhase.Planning));
        Assert.That(_battle.CurrentTurnNumber, Is.EqualTo(2));
        Assert.That(_battle.Turn.Player.PlannedCards.Count, Is.EqualTo(0));
        Assert.That(_battle.Turn.Opponent.PlannedCards.Count, Is.EqualTo(0));
    }

    private static Pilot CreateTestPilot(string id, string name)
    {
        return new Pilot
        {
            Id = id,
            Name = name,
            Rank = PilotRank.LanceCorporal,
            StaminaMax = GameConstants.StaminaMax,
            StaminaCurrent = GameConstants.StaminaMax
        };
    }

    private void PlanCards(Side side, int maneuverIndex, int actionIndex)
    {
        var turnData = _battle.Turn.GetSide(side);
        var pilot = _battle.GetPilot(side);

        var maneuver = turnData.HandManeuvers[maneuverIndex];
        var action = turnData.HandActions[actionIndex];

        var totalCost = maneuver.Cost + action.Cost;
        Assert.That(pilot.StaminaCurrent, Is.GreaterThanOrEqualTo(totalCost),
            $"Not enough stamina to plan cards for {side}");

        pilot.StaminaCurrent -= totalCost;

        turnData.PlannedCardsMutable.Add(maneuver);
        turnData.PlannedCardsMutable.Add(action);

        turnData.HandManeuversMutable.Remove(maneuver);
        turnData.HandActionsMutable.Remove(action);
    }
}
