using UnityEditor;
using UnityEngine;
namespace Nexora.EditorTools {
 public sealed class EditorTools : EditorWindow {
  [MenuItem("Nexora/Editor Tools/Selection Inspector")]
  public static void Open()=>GetWindow<EditorTools>("Nexora Selection");
  void OnSelectionChange()=>Repaint();
  void OnGUI() {
   EditorGUILayout.LabelField("Selected objects",Selection.objects.Length.ToString());
   foreach(var item in Selection.objects) EditorGUILayout.ObjectField(item,typeof(Object),true);
  }
 }
}
