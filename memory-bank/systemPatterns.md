# System Patterns

## Architecture Overview

```
DeepSpaceGladiatorsEngine/
├── Game/                    # Business logic (game rules, turn execution)
│   └── GameTacticalEngine.cs
├── Models/                  # Data models (state, entities)
│   ├── BattleState.cs
│   ├── SideState.cs
│   ├── TurnState.cs
│   ├── Ship.cs
│   ├── Pilot.cs
│   ├── Card.cs (abstract)
│   ├── ManeuverCard.cs
│   ├── ActionCard.cs
│   └── ...
├── Definitions/             # Static card definitions
│   └── CardDefinitions.cs
├── PilotLoader.cs           # Pilot loading from JSON
└── PortraitResolver.cs      # Portrait path resolution
```

## Key Design Patterns

### Separation of Concerns
- **Models folder**: Pure data classes (state, no business logic)
- **Game folder**: Business logic engines that operate on models

### Dependency Injection
- `GameTacticalEngine` receives `BattleState` via constructor
- Enables unit testing without file system dependencies

### Internal Mutability Pattern
- Public read-only collections (`IReadOnlyList<T>`)
- Internal mutable lists (`*Mutable` properties) for engine access
- `InternalsVisibleTo` allows test project access

## Battle Flow

```
1. Planning Phase
   - Deal cards to hands
   - Select cards (pay stamina cost)
   - Cards move to PlannedCards

2. Resolving Phase (GameTacticalEngine.ExecuteTurn)
   - Resolve maneuvers (both sides)
   - Resolve actions (damage application)
   - Check win condition

3. End Turn
   - Clear planned/applied cards
   - Restore stamina
   - Increment turn number
   - Return to Planning phase
```

## Damage Model
- Damage first reduces shields
- Remaining damage goes to structure
- Ship destroyed when structure <= 0
