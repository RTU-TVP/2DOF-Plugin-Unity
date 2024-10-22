#region

using LogitechG29.Sample.Input;
using UnityEngine;
using UnityEngine.Serialization;

#endregion

namespace LogitechG29.Sample
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private InputControllerReader inputControllerReader;

        private void Start()
        {
            inputControllerReader.OnHomeCallback += value => Application.Quit();

            inputControllerReader.OnOptionsCallback += OnOptionsCallback;
        }

        private void Update()
        {
            if (inputControllerReader.Steering != 0)
            {
                Debug.Log("Steering: " + inputControllerReader.Steering);
            }

            if (inputControllerReader.Throttle > 10)
            {
                Debug.Log("Help me, please!");
            }
        }

        private void OnOptionsCallback(bool value)
        {
            Debug.Log("OnOptionsCallback: " + value);
        }
    }
}