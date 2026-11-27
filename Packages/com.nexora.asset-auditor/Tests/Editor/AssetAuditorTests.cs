using NUnit.Framework;
using UnityEditor;
namespace Nexora.Tests { public class AssetAuditorTests { [Test] public void EntryPointExists()=>Assert.IsNotNull(typeof(Nexora.AssetAuditor.AssetAuditor).GetMethod("Run")); } }
