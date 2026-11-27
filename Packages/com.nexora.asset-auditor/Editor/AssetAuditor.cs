using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;
namespace Nexora.AssetAuditor {
 public static class AssetAuditor {
  [MenuItem("Nexora/Asset Auditor/Largest Assets")]
  public static void Run() {
   var files=AssetDatabase.GetAllAssetPaths().Where(p=>p.StartsWith("Assets/") && File.Exists(p)).Select(p=>new FileInfo(p)).OrderByDescending(f=>f.Length).Take(20);
   foreach(var f in files) Debug.Log($"{f.Length / 1048576.0:F2} MiB | {f.FullName}");
  }
 }
}
