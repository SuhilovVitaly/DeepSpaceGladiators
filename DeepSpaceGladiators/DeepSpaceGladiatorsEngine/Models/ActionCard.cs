namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>Action card with type, accuracy and damage for resolve.</summary>
public class ActionCard : Card
{
    /// <inheritdoc />
    public override CardType CardType => CardType.PilotSkill;

    /// <summary>Action type (PulseShot, FocusedFire, etc.).</summary>
    public ActionType ActionType { get; }

    /// <summary>Base accuracy value for hit roll.</summary>
    public int AccuracyBase { get; }

    /// <summary>Damage dealt on hit (0 for non-attack actions).</summary>
    public int Damage { get; }

    public ActionCard(string id, string name, int cost, string description, ActionType actionType, int accuracyBase, int damage)
        : base(id, name, cost, description)
    {
        ActionType = actionType;
        AccuracyBase = accuracyBase;
        Damage = damage;
    }
}
