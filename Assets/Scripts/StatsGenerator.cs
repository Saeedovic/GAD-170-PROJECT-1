using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  A <see langword="static"/> class with methods (functions) for initialising or randomising the stats class.
///  
/// TODO:
///     Initialise a stats instance with generated starting stats
///     Handle the assignment of extra points or xp into an existing stats of a character
///         - this is expected to be used by NPCs leveling up to match the player.
/// </summary>
public static class StatsGenerator
{
    
    public static void InitialStats(Stats stats)
    {
        stats.luck = Random.Range(0, 10);
        stats.xp = Random.Range(-6, 60);
        stats.style = Random.Range(-1, 100);
        stats.rhythm = 5;
        stats.level = 1;
    }

    public static void AssignUnusedPoints(Stats stats, int points)
    {
        int rhythm = Random.Range(0, 2);
            stats.rhythm += rhythm;
        points -= rhythm;

        stats.luck += Random.Range(1, 2);
    }
}
