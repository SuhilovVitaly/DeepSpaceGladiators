# Technical Context

## Technology Stack
- **.NET 10.0** (Preview)
- **C# Latest** (C# 13+)
- **NUnit 4.3** for testing
- **System.Text.Json** for serialization

## Project Structure
```
DeepSpaceGladiators/
├── DeepSpaceGladiators/           # Main application (Avalonia UI)
│   └── Data/                      # JSON data files
│       ├── Pilots/                # Pilot definitions
│       └── Cards/                 # Card definitions
├── DeepSpaceGladiatorsEngine/     # Game engine library
│   ├── Game/                      # Business logic
│   └── Models/                    # Data models
└── DeepSpaceGladiatorsTests/      # Unit tests (NUnit)
```

## Key Dependencies
- Engine project has `InternalsVisibleTo` for test project
- Tests reference Engine project

## Namespaces
- `DeepSpaceGladiatorsEngine.Models` - Data models
- `DeepSpaceGladiatorsEngine.Game` - Business logic
- `DeepSpaceGladiatorsEngine.Definitions` - Static definitions
- `DeepSpaceGladiatorsEngine` - Root (loaders, utilities)

## Data Files
- Pilots: `Data/Pilots/{id}.json`
- Portraits: `Data/Pilots/Portraits/`
- Cards: `Data/Cards/`
