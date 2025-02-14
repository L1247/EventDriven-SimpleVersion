#region

using System;

#endregion

namespace Scripts.Custom
{
    public class Singleton<T> : SingletonReset where T : class , SingletonReset
    {
    #region Public Variables

        public static T Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = Activator.CreateInstance<T>();
                (instance as Singleton<T>).Initialize();
                SingletonReseter.Register(instance);
                return instance;
            }
        }

        public bool Initialized { get; private set; }

    #endregion

    #region Private Variables

        private static T instance;

    #endregion

    #region Public Methods

        public void Reset()
        {
            if (Initialized == false) return;
            Initialized = false;
            instance    = null;
        }

    #endregion

    #region Protected Methods

        protected virtual void CustomInitialize() { }

    #endregion

    #region Private Methods

        private void Initialize()
        {
            if (Initialized) return;
            Initialized = true;
            CustomInitialize();
        }

    #endregion
    }
}