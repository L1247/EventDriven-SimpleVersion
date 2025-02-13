#region

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#endregion

namespace Scripts.Custom
{
    public static class EventBus
    {
    #region Private Variables

        private static readonly Dictionary<string , List<object>> events = new Dictionary<string , List<object>>();

    #endregion

    #region Public Methods

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Clear()
        {
            events.Clear();
        }

        public static void Raise<T>(Action<T> action) where T : class
        {
            var observerType     = typeof(T).ToString();
            var containsObserver = events.ContainsKey(observerType);
            if (containsObserver == false) return;
            var objects = events[observerType];
            foreach (var obj in objects) action.Invoke((T)obj);
        }

        public static void Subscribe<T>() where T : class
        {
            var interfaces = typeof(T).GetInterfaces();
            if (interfaces.Length == 0) return;
            var obj = Activator.CreateInstance<T>();
            foreach (var observer in interfaces)
            {
                var observerType     = observer.ToString();
                var containsObserver = events.ContainsKey(observerType);
                if (containsObserver)
                {
                    var objects                    = events[observerType];
                    var containsDuplicatedInstance = objects.Any(o => o.GetType() == typeof(T));
                    if (containsDuplicatedInstance)
                    {
                        Debug.LogWarning($"重複註冊相同的EventHandler[{typeof(T)}]");
                        continue;
                    }

                    objects.Add(obj);
                }
                else
                {
                    var objects = new List<object> { obj };
                    events.Add(observerType , objects);
                }
            }
        }

    #endregion
    }
}