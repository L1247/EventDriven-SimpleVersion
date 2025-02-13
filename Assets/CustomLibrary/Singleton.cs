#region

using System;

#endregion

namespace Scripts.Custom
{
    public class Singleton<T> where T : class
    {
    #region Public Variables

        public static T Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = Activator.CreateInstance<T>();
                (instance as Singleton<T>).Initialize();
                return instance;
            }
        }

        public bool Initialized { get; private set; }

    #endregion

    #region Private Variables

        private static T instance;

    #endregion

    #region Public Methods

        public void Initialize()
        {
            if (Initialized) return;
            Initialized = true;
            CustomInitialize();
        }

    #endregion

    #region Protected Methods

        protected virtual void CustomInitialize() { }

    #endregion
    }
}