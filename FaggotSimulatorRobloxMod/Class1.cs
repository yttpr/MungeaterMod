using BepInEx;
using BrutalAPI;
using System;
using UnityEngine;

namespace FSRMod
{
    [BepInPlugin("Mungeater.FaggotSim", "Two Devs Five Years", "0.0.0")]
    [BepInDependency("Bones404.BrutalAPI", BepInDependency.DependencyFlags.HardDependency)]
    public class Class1 : BaseUnityPlugin
    {
        public void Awake()
        {
            EZExtensions.PCall(AmbushManager.Setup, "Ambush manager");
            EZExtensions.PCall(SoundClass.Setup, "sound class");
            EZExtensions.PCall(MultiSpriteEnemyLayout.Setup, "multi outliner");
            EZExtensions.PCall(HooksGeneral.Setup, "generic hooks");
            Add();
        }

        public static void Add()
        {
            EZExtensions.PCall(Boomer.Add, "Boomer adding");
            EZExtensions.PCall(Tim.Add, "anthony adding");
        }

        static AssetBundle _assets;
        public static AssetBundle Assets
        {
            get
            {
                if (_assets == null)
                {
                    _assets = AssetBundle.LoadFromMemory(ResourceLoader.ResourceBinary("slop"));
                }
                return _assets;
            }
        }
    }
}