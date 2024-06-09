using UnityEngine;

namespace HatchsTools.Utilities
{
    public class FramerateController : MonoBehaviour
    {
        [SerializeField] private int _targetFramerate = 60;

        private void Awake()
        {
            SetFramerate(_targetFramerate);
        }

        public static void SetFramerate(int framerate)
        {
            Application.targetFrameRate = framerate;
        }
    }
}
