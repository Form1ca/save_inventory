using HarmonyLib;
using System.Reflection;
using UnityEngine;

namespace SaveInventoryMod
{

    public class ModBehaviour : Duckov.Modding.ModBehaviour
    {
        private const string Id = "Formica.SaveInventoryMod";
        private Harmony harmony;
        void Awake()
        {
            Debug.Log("SaveInventoryMod Loaded!!!");
        }
        void OnDestroy()
        {
        }
        void OnEnable()
        {
            harmony = new Harmony(Id);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            Debug.Log("SaveInventoryMod ENABLED!!!");

        }
        void OnDisable()
        {
            harmony.UnpatchAll(Id);
            Debug.Log("SaveInventoryMod DISABLED!!!");
        }
    }
}