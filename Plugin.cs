using BepInEx;
using HarmonyLib;

namespace NoNametags
{
    [BepInPlugin(Constants.PLUGIN_UID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {

        private static Harmony harmony;

        private void Awake()
        {
            harmony = new Harmony(Constants.PLUGIN_UID);
            harmony.PatchAll();

            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_NAME} is loaded!");
        }
    }

    public static class Constants {
        public const string PLUGIN_UID = "games.braincells.modding.lethalcompnay.nonametags";
    }
}
