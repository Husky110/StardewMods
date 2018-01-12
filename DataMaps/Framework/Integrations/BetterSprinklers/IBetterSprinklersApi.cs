using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Pathoschild.Stardew.DataMaps.Framework.Integrations.BetterSprinklers
{
    /// <summary>The API provided by the Better Sprinklers mod.</summary>
    public interface IBetterSprinklersApi
    {
        /// <summary>Get the maximum supported coverage width or height.</summary>
        int GetMaxGridSize();

        /// <summary>Get the relative tile coverage by supported sprinkler ID.</summary>
        IDictionary<int, Vector2[]> GetSprinklerCoverage();
    }
}