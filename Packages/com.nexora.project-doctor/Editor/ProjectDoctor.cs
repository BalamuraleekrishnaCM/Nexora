using UnityEditor;
using UnityEngine;
namespace Nexora.ProjectDoctor {
 public static class ProjectDoctor {
  [MenuItem("Nexora/Project Doctor/Run Diagnostics")]
  public static void Run() {
   var missing=0;
   foreach(var scene in EditorBuildSettings.scenes) if(scene.enabled && AssetDatabase.LoadAssetAtPath<SceneAsset>(scene.path)==null) { Debug.LogWarning("Missing enabled scene: "+scene.path); missing++; }
   if(!EditorBuildSettings.scenes.AnyEnabled()) Debug.LogWarning("No enabled build scenes.");
   Debug.Log($"Nexora diagnostics: Unity {Application.unityVersion}; target {EditorUserBuildSettings.activeBuildTarget}; missing scenes {missing}.");
  }
  public static bool AnyEnabled(this EditorBuildSettingsScene[] scenes) { foreach(var s in scenes) if(s.enabled) return true; return false; }
 }
}
