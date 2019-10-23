using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for converting a battle result into xp to be awarded to the player.
/// 
/// TODO:
///     Respond to battle outcome with xp calculation based on;
///         player win 
///         how strong the win was
///         stats/levels of the dancers involved
///     Award the calculated XP to the player stats
///     Raise the player level up event if needed
/// </summary>
public class XPHandler : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.OnBattleConclude += GainXP;
    }

    private void OnDisable()
    {

    }

    public void GainXP(BattleResultEventData data)
    {
        int initialxp = 100;


        if (data.outcome > 0)
        {
            data.player.xp += 25;

            int xprequired = data.player.level * 500 + initialxp;

            if (data.player.xp >= xprequired)
            {
                data.player.xp = 0;
                data.player.level += 1;
                GameEvents.PlayerLevelUp(data.player.level);
            }
            Debug.Log("xp" + data.player.xp + "   level   " + data.player.level);
        }
    }

}
