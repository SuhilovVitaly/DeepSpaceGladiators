# Product Context

## Why This Project Exists
Deep Space Gladiators is a tactical card game where players pilot spaceships in arena combat. The game combines card game mechanics with tactical decision-making.

## Core Gameplay Loop
1. **Planning Phase**: Both players secretly select cards from their hand
2. **Resolution Phase**: Cards resolve in order (maneuvers → actions)
3. **Repeat** until one ship is destroyed

## Key Mechanics

### Cards
- **Maneuver Cards**: Affect accuracy modifiers, positioning
  - Steady Vector (0 cost) - neutral
  - Evasive Drift (1 cost) - defensive
  - Aggressive Approach (1 cost) - offensive
  - Hard Turn (1 cost) - repositioning
  - Overburn (2 cost) - powerful but disables engine

- **Action Cards**: Attacks and utility
  - Pulse Shot (1 cost) - basic attack
  - Focused Fire (2 cost) - precise but risky
  - Scatter Burst (1 cost) - multi-hit
  - Shield Pulse (1 cost) - restore shields
  - Module Patch (1 cost) - repair modules

### Ships
- **Duelist**: High shields (8), low structure (5) - hit and run
- **Bruiser**: Low shields (5), high structure (8) - tank

### Resources
- **Stamina**: Spent to play cards, recovers 2 per turn (max 6)
- **Shields**: First line of defense, regeneratable
- **Structure**: Hull integrity, game over when depleted

## User Experience Goals
- Quick tactical decisions each turn
- Meaningful risk/reward choices
- Clear feedback on battle outcomes
