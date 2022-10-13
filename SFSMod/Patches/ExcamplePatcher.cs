using HarmonyLib;
using SFS.Builds;
using UnityEngine;

namespace SFSMod.Patches
{

    /**
     * This is the example how to patch things.
     * 
     * All you need to do is specify the class and the method name that you want to patch.
     * 
     * <see cref="https://harmony.pardeike.net/articles/patching.html"/>
     */
    [HarmonyPatch(typeof(BuildManager), "Start")]
    class ExcamplePatcher
    {
        /**
        * This is the example how to make a Prefix. A prefix is a method that is 
        * executed before the original method.
        * <see cref="https://harmony.pardeike.net/articles/patching-prefix.html"/>
        */
        [HarmonyPrefix]
        public static void Prefix()
        {
            Debug.Log("This code will be executed before the start method");
        }


        /**
         * This is the example how to make a Postfix. A postfix is a method 
         * that is executed after the original method
         * <see cref="https://harmony.pardeike.net/articles/patching-postfix.html"/>
         */
        [HarmonyPostfix]
        public static void Postfix()
        {
            Debug.Log("This code will be executed after the start method finishes");
        }


    }
}
