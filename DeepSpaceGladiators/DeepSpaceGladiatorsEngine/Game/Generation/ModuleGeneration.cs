using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiatorsEngine.Game.Generation
{
    public static class ModuleGeneration
    {
        public static ShipModule Generate(ShipModuleType moduleType, string moduleId)
        {
            return new ShipModule(moduleType, true);
        }
    }
}
