namespace DeepSpaceGladiatorsEngine.Models;

/// <summary>One side in battle: ship and pilot.</summary>
public class SideState
{
    /// <summary>Ship (shield, structure, modules).</summary>
    public Ship Ship { get; set; } = null!;

    /// <summary>Pilot (stamina for playing cards).</summary>
    public Pilot Pilot { get; set; } = null!;

    /// <summary>Creates a side with ship from template and full stamina pilot.</summary>
    public static SideState Create(ShipTemplateId shipTemplateId)
    {
        return new SideState
        {
            Ship = ShipTemplate.CreateShip(shipTemplateId),
            Pilot = new Pilot { StaminaMax = GameConstants.StaminaMax, StaminaCurrent = GameConstants.StaminaMax }
        };
    }
}
