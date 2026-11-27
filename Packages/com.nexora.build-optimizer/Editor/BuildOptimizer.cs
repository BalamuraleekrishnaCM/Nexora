using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;
namespace Nexora.BuildOptimizer {
 public sealed class BuildOptimizer : IPostprocessBuildWithReport {
  public int callbackOrder=>0;
  public void OnPostprocessBuild(BuildReport report) {
   Debug.Log($"Nexora build: {report.summary.result}, {report.summary.totalSize / 1048576.0:F2} MiB, {report.summary.totalTime.TotalSeconds:F1}s");
  }
  [MenuItem("Nexora/Build Optimizer/Report Settings")]
  public static void Report() { Debug.Log($"Target: {EditorUserBuildSettings.activeBuildTarget}; development: {EditorUserBuildSettings.development}; enabled scenes: {System.Array.FindAll(EditorBuildSettings.scenes,s=>s.enabled).Length}"); }
 }
}
