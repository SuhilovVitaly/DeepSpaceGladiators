using DeepSpaceGladiatorsEngine.Game.Generation;

namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>One side in battle: ship and pilot.</summary>
public class SideState
{
    /// <summary>Ship (shield, structure, modules).</summary>
    public Ship Ship { get; set; } = null!;

    /// <summary>Pilot (stamina for playing cards).</summary>
    public Pilot Pilot { get; set; } = null!;

    /// <summary>Creates a side with ship from template and default pilot (full stamina).</summary>
    public static SideState Create(string shipTemplateId)
    {
        return new SideState
        {
            Ship = ShipGeneration.Generate(shipTemplateId),
            Pilot = new Pilot { StaminaMax = GameConstants.StaminaMax, StaminaCurrent = GameConstants.StaminaMax }
        };
    }

    /// <summary>Creates a side with ship from template and the given pilot.</summary>
    public static SideState Create(string shipTemplateId, Pilot pilot)
    {
        return new SideState
        {
            Ship = ShipGeneration.Generate(shipTemplateId),
            Pilot = pilot ?? throw new ArgumentNullException(nameof(pilot))
        };
    }
}
