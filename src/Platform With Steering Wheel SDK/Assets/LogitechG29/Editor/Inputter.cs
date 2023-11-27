using System.Linq;
using UnityEditor;

namespace Input_LogitechG29.Editor
{
    /// <summary>
    /// Добавляет заданные символы определения в символы определения PlayerSettings.
    /// Просто добавьте свои собственные символы определения в свойство «Символы» ниже.
    /// </summary>
    [InitializeOnLoad]
    public class Inputter : UnityEditor.Editor
    {
        /// <summary>
        /// Символы, которые будут добавлены в редактор
        /// </summary>
        public static readonly string[] Symbols = new[]
        {
            "INPUTTER"
        };

        /// <summary>
        /// Добавьте символы определения, как только Unity завершит компиляцию.
        /// </summary>
        static Inputter()
        {
            var definesString = PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup);

            var allDefines = definesString.Split(';').ToList();

            allDefines.AddRange(Symbols.Except(allDefines));

            PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup,
                string.Join(";", allDefines.ToArray()));
        }
    }
}