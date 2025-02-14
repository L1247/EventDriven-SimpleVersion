#region

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#endregion

namespace Scripts.Custom
{
    public static class SingletonReseter
    {
    #region Private Variables

        private static readonly List<object> singletons = new List<object>();

    #endregion

    #region Public Methods

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Clear()
        {
            var singletonResets = singletons.Select(singleton => singleton as SingletonReset);
            foreach (var singletonReset in singletonResets) singletonReset.Reset();

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