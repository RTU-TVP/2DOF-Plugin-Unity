using System.Collections;
using _2DOF;
using UnityEngine;

public class CarTelemetryHandler : MonoBehaviour
{
    private const float WAIT_TIME = SendingData.WAIT_TIME / 1000f;

    [SerializeField] private Transform vehicleTransform;
    [SerializeField] private Rigidbody rigidbody;

    private ObjectTelemetryData _telemetryDataData;
    private SendingData _sendingData;

    private void Awake()
    {
        _sendingData = new SendingData();
        _telemetryDataData = _sendingData.ObjectTelemetryData;
    }

    public void OnEnable()
    {
        StartCoroutine(TelemetryHandler());
        _sendingData.SendingStart();
    }

    public void OnDisable()
    {
        StopCoroutine(TelemetryHandler());
        _sendingData.SendingStop();
    }

    private IEnumerator TelemetryHandler()
    {
        while (true)
        {
            if (_telemetryDataData == null)
            {
                yield return new WaitForSeconds(WAIT_TIME * 10f);
                continue;
            }

            UpdateAngles();
            UpdateVelocity();

            yield return new WaitForSeconds(WAIT_TIME);
        }
    }

    private void UpdateVelocity()
    {
        _telemetryDataData.Velocity = rigidbody.linearVelocity;
    }

    private void UpdateAngles()
    {
        var rotation = vehicleTransform.rotation;
        rotation.x = rotation.eulerAngles.x > 180
            ? rotation.eulerAngles.x - 360
            : rotation.eulerAngles.x;
        rotation.z = rotation.eulerAngles.z > 180
            ? rotation.eulerAngles.z - 360
            : rotation.eulerAngles.z;
        rotation.y = rotation.eulerAngles.y > 180
            ? rotation.eulerAngles.y - 360
            : rotation.eulerAngles.y;
        _telemetryDataData.Angles = rotation.eulerAngles;
    }
}