
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
    public class MaxProcessor: InputProcessor<float>
    {
        public float MaxValue = 0;

        public override float Process(float value, InputControl control)
        {
            return Mathf.Max(MaxValue, value);
        }

#if UNITY_EDITOR
        static MaxProcessor()
        {
            Initialize();
        }
#endif

        [RuntimeInitializeOnLoadMethod]
        private static void Initialize()
        {
            InputSystem.RegisterProcessor<MaxProcessor>();
        }
    }
}
