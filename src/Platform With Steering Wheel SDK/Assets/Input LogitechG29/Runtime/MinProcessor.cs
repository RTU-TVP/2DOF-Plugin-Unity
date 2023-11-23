
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
    public class MinProcessor : InputProcessor<float>
    {
        public float MinValue = 0;

        public override float Process(float value, InputControl control)
        {
            return Mathf.Min(MinValue, value);
        }

#if UNITY_EDITOR
        static MinProcessor()
        {
            Initialize();
        }
#endif

        [RuntimeInitializeOnLoadMethod]
        private static void Initialize()
        {
            InputSystem.RegisterProcessor<MinProcessor>();
        }
    }
}
