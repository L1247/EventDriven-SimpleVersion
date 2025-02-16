#region

using UnityEngine;

#endregion

namespace Scripts.Custom
{
    public class Ticker : MonoBehaviour
    {
    #region Unity events

        private void Update()
        {
            SingletonHolder.Tick();
        }

    #endregion
    }
}