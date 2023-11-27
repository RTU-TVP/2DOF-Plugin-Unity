using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace Input_LogitechG29.Runtime
{
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    [Preserve]
    public class ExtensionProcessor : InputProcessor<float>
    {
        [Tooltip("Sensitivity Speed")] public float SensitivitySpeed = 0;

        [Tooltip("Gravity Speed")] public float GravitySpeed = 0;

        private float _previousValue = 0f;

        public override float Process(float value, InputControl control)
        {
            if (value == 0)
            {
                _previousValue = Mathf.MoveTowards(_previousValue, 0f, GravitySpeed * Time.unscaledDeltaTime);
            }

            _previousValue = Mathf.MoveTowards(_previousValue, value, SensitivitySpeed * Time.unscaledDeltaTime);
            return _previousValue;
        }

#if UNITY_EDITOR
        static ExtensionProcessor()
        {
            Initialize();
        }
#endif

        [RuntimeInitializeOnLoadMethod]
        private static void Initialize()
        {
            InputSystem.RegisterProcessor<ExtensionProcessor>();
        }
    }
}