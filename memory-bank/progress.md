# Progress

## Completed

### Core Models
- [x] BattleState - full battle state container
- [x] SideState - ship + pilot per side
- [x] TurnState/SideTurnData - hands, planned cards, applied maneuvers
- [x] Ship - shields, structure, modules
- [x] Pilot - stamina management
- [x] Card hierarchy (Card → ManeuverCard, ActionCard)

### Game Logic
- [x] GameTacticalEngine - turn execution
- [x] Maneuver resolution
- [x] Action resolution with damage
- [x] Shield/structure damage model
- [x] Win condition checking
- [x] Turn end (cleanup, stamina restore)

### Infrastructure
- [x] PilotLoader - JSON pilot loading
- [x] PortraitResolver - portrait path resolution
- [x] CardDefinitions - static MVP deck (5 maneuvers, 5 actions)
- [x] Ship templates (Duelist, Bruiser)
- [x] Unit test setup with NUnit

## In Progress
- [ ] Accuracy/hit system
- [ ] Card drawing mechanics

## Not Started
- [ ] Specific card effects (Shield Pulse, Module Patch, etc.)
- [ ] Module damage/disable system
- [ ] AI opponent logic
- [ ] UI integration
