# Active Context

## Current Focus
Building the tactical battle engine with proper separation of models and business logic.

## Recent Changes
1. Created `GameTacticalEngine` in `Game/` folder for battle logic
2. Moved business logic out of `BattleState` model
3. Established folder structure: `Game/` for logic, `Models/` for data
4. Created battle simulation tests

## Architecture Decisions
- **Models are pure data**: No business logic in model classes
- **Game folder contains engines**: Business logic with DI pattern
- **Internal mutability**: Engine modifies state through internal accessors

## Current State
- Battle system supports:
  - Creating battle with two sides (player/opponent)
  - Ship templates (Duelist, Bruiser) with different stats
  - Pilots with stamina
  - Maneuver and action cards
  - Turn execution with damage resolution
  - Win condition checking

## Next Steps
- Implement accuracy system with dice rolls
- Add card drawing/deck management
- Implement specific card effects (Shield Pulse, Module Patch)
- Add module damage system
