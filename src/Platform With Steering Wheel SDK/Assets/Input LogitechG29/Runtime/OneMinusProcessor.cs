
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
    public class OneMinusProcessor: InputProcessor<float>
    {
        public override float Process(float value, InputControl control)
        {
            return 1f - value;
        }

#if UNITY_EDITOR
        static OneMinusProcessor()
        {
            Initialize();
        }
#endif

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Initialize()
        {
            InputSystem.RegisterProcessor<OneMinusProcessor>();
        }
    }
}
