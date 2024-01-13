using HarmonyLib;
using GameNetcodeStuff;

namespace NoNametags.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB), "SendNewPlayerValuesClientRpc")]
    class SendValuesClientRPCPatch
    {
        static void Postfix(PlayerControllerB __instance)
        {
            __instance.drunkness = 1f;
            foreach (PlayerControllerB player in __instance.playersManager.allPlayerScripts)
            {
                player.usernameBillboardText.text = "";
            }
        }
    }
}