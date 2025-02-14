#region

using System.Collections.Generic;
using UnityEngine;

#endregion

namespace Scripts.Custom
{
    public static class SingletonReseter
    {
    #region Private Variables

        private static readonly List<SingletonReset> singletons = new List<SingletonReset>();

    #endregion

    #region Public Methods

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Clear()
        {
            foreach (var singletonReset in singletons) singletonReset.Reset();
            singletons.Clear();
        }

        public static void Register<T>(T singleton) where T : class , SingletonReset
        {
            if (singletons.Contains(singleton)) return;
            singletons.Add(singleton);
        }

    #endregion
    }
}