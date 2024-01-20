#region

using System.Collections;
using _2DOF.Core;
using UnityEngine;

#endregion

namespace _2DOF.Sample
{
    public class CarTelemetryHandler_Sample : MonoBehaviour
    {
        [SerializeField] private Transform vehicleTransform;
        [SerializeField] private Rigidbody _rigidbody;

        private ObjectTelemetryData _telemetryDataData;
        private Coroutine _coroutine;
        
        private void Start()
        {
            _telemetryDataData = new ObjectTelemetryData();
            SendingData.Instance = new SendingData(_telemetryDataData);
        }
        
        public void OnEnable()
        {
            _coroutine = StartCoroutine(TelemetryHandler());
            SendingData.Instance.SendingStart();
        }

        public void OnDisable()
        {
            StopCoroutine(_coroutine);
            SendingData.Instance.SendingStop();
        }

        private IEnumerator TelemetryHandler()
        {
            const float WAIT_TIME = SendingData.WAIT_TIME / 1000f;

            while (true)
            {
                if (_telemetryDataData == null)
                {
                    yield return new WaitForSeconds(WAIT_TIME * 10f);
                    continue;
                }

                var rotation = vehicleTransform.rotation;
                _telemetryDataData.AnglesX = rotation.eulerAngles.x > 180
                    ? rotation.eulerAngles.x - 360
                    : rotation.eulerAngles.x;
                _telemetryDataData.AnglesZ = rotation.eulerAngles.z > 180
                    ? rotation.eulerAngles.z - 360
                    : rotation.eulerAngles.z;
                _telemetryDataData.AnglesY = rotation.eulerAngles.y > 180
                    ? rotation.eulerAngles.y - 360
                    : rotation.eulerAngles.y;

                var velocity = _rigidbody.velocity;
                _telemetryDataData.VelocityZ = velocity.z;
                _telemetryDataData.VelocityX = velocity.x;
                _telemetryDataData.VelocityY = velocity.y;

                yield return new WaitForSeconds(WAIT_TIME);
            }
        }
    }
}