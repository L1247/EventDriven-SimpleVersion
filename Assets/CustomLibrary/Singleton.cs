#region

using System;

#endregion

namespace Scripts.Custom
{
    public class Singleton<T> : Resetable , IInitializatable where T : class , Resetable
    {
    #region Public Variables

        public static T Instance
        {
            get
            {
                if (instance != null) return instance;
                instance = Activator.CreateInstance<T>();
                ((IInitializatable)instance).Initialize();
                SingletonHolder.Register(instance);
                return instance;
            }
        }

        public bool Initialized { get; private set; }

    #endregion

    #region Private Variables

        private static T instance;

    #endregion

    #region Protected Methods

        protected virtual void CustomInitialize() { }

    #endregion

    #region Private Methods

        void IInitializatable.Initialize()
        {
            if (Initialized) return;
            Initialized = true;
            CustomInitialize();
        }

        void Resetable.Reset()
        {
            if (Initialized == false) return;
            Initialized = false;
            instance    = null;
        }

    #endregion
    }
}