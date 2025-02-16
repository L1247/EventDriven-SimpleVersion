#region

using System.Collections.Generic;
using UnityEngine;

#endregion

namespace Scripts.Custom
{
    public static class SingletonHolder
    {
    #region Private Variables

        private static readonly List<Resetable> resets    = new List<Resetable>();
        private static readonly List<ITickable> tickables = new List<ITickable>();

        private static Ticker ticker;

    #endregion

    #region Public Methods

        public static void Register<T>(T singleton) where T : class , Resetable
        {
            if (singleton is ITickable tickable && tickables.Contains(tickable) == false) tickables.Add(tickable);
            if (resets.Contains(singleton)) return;
            resets.Add(singleton);
            SpawnTickerIfNoExist();
        }

        public static void Tick()
        {
            foreach (var tickable in tickables) tickable.Tick();
        }

    #endregion

    #region Private Methods

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Clear()
        {
            foreach (var singletonReset in resets) singletonReset.Reset();
            resets.Clear();
            tickables.Clear();
            Object.Destroy(ticker);
            ticker = null;
        }

        private static void SpawnTickerIfNoExist()
        {
            if (ticker != null) return;
            var tickerGo = new GameObject("Ticker") { hideFlags = HideFlags.HideInHierarchy };
            ticker = tickerGo.AddComponent<Ticker>();
        }

    #endregion
    }
}