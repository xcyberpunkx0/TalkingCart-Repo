using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TalkingCart.Patches.RoundDirectorPatch;

namespace TalkingCart.Patches
{
    [HarmonyPatch(typeof(EnemyParent))]
    class EnemyParentPatch
    {
        [HarmonyPatch("Despawn")]
        [HarmonyPostfix]
        static void EnemyDespawnPatch(EnemyParent __instance)
        {
            if (RoundDirectorPatch.initialEnemiesCommunicated)
            {
                int enemyNameInd = Array.IndexOf(RoundDirectorPatch.enemyNames, __instance.enemyName);
                if (enemyNameInd == 1 || enemyNameInd == 11) // Bangers and Gnomes
                    return;

                int enemyInd = RoundDirectorPatch.enemyParentList.IndexOf(__instance);
                if (enemyInd < 0 || enemyInd >= RoundDirectorPatch.currentEnemyStatus.Count)
                    return;

                RoundDirectorPatch.currentEnemyStatus[enemyInd] = EnemyStatus.Absent;

                TalkingCartBase.mls.LogInfo($"Enemy Despawned Start: {RoundDirectorPatch.GetEnemyDisplayName(__instance.enemyName)}");
            }
        }

        [HarmonyPatch("Spawn")]
        [HarmonyPostfix]
        static void EnemyRespawnPatch(EnemyParent __instance)
        {
            if (RoundDirectorPatch.initialEnemiesCommunicated)
            {
                int enemyNameInd = Array.IndexOf(RoundDirectorPatch.enemyNames, __instance.enemyName);
                if (enemyNameInd == 1 || enemyNameInd == 11) // Bangers and Gnomes
                    return;

                int enemyInd = RoundDirectorPatch.enemyParentList.IndexOf(__instance);
                if (enemyInd < 0 || enemyInd >= RoundDirectorPatch.currentEnemyStatus.Count)
                    return;

                RoundDirectorPatch.currentEnemyStatus[enemyInd] = EnemyStatus.Present;

                TalkingCartBase.mls.LogInfo($"Enemy Respawned Start: {RoundDirectorPatch.GetEnemyDisplayName(__instance.enemyName)}");
            }
        }
    }
}
