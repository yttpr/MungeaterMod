using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using System.IO;

namespace FSRMod
{
    public static class SoundClass
    {
        public static void CreateSoundBankFile(string resourceName, bool onlyIfNotExist = false)
        {
            CreateResourceFile(resourceName, Application.dataPath + "/StreamingAssets", resourceName + ".bank", onlyIfNotExist);
            //call this like, CreateSoundBankFile("FunnyGuyHitNoise");
        }

        public static void CreateResourceFile(string resourceName, string path, string outputName, bool onlyIfNotExist = false)
        {
            byte[] resource = new byte[0] { };
            try
            {
                resource = ResourceLoader.ResourceBinary(resourceName);
            }
            catch (Exception ex)
            {
                Debug.Log("YOUR FILE DOES NOT EXIST MOTHERFUCKER");
            }
            if (resource.Length > 0 && !(onlyIfNotExist && File.Exists(path + "/" + outputName)))
            {
                File.WriteAllBytes(path + "/" + outputName, resource);
            }
        }

        public static void Setup()
        {
            CreateSoundBankFile("Roblos");
            CreateSoundBankFile("Roblos.strings");

            FMODUnity.RuntimeManager.LoadBank("Roblos", true);
            FMODUnity.RuntimeManager.LoadBank("Roblos.strings", true);

        }
    }
}
