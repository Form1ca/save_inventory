using HarmonyLib;
using ItemStatsSystem;
using System;
using UnityEngine;

namespace SaveInventoryMod
{
    [HarmonyPatch(typeof(CharacterMainControl))]
    [HarmonyPatch("DropAllItems")]
    class CharacterMainControl_DropAllItems
    {
        static bool Prefix()
        {
            Debug.Log("DisplayItemValue DropAllItems");
            return false;
        }
    }

    [HarmonyPatch(typeof(CharacterMainControl))]
    [HarmonyPatch("DestroyAllItem")]
    class CharacterMainControl_DestroyAllItem
    {
        static bool Prefix()
        {
            Debug.Log("DisplayItemValue DestroyAllItem");
            return false;
        }
    }

    [HarmonyPatch(typeof(LevelConfig), "SpawnTomb", MethodType.Getter)]
    class LevelConfig_SpawnTomb
    {
        static bool Prefix(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}
