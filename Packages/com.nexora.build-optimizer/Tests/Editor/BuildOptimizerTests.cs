using NUnit.Framework;
using UnityEditor;
namespace Nexora.Tests { public class BuildOptimizerTests { [Test] public void EntryPointExists()=>Assert.IsNotNull(typeof(Nexora.BuildOptimizer.BuildOptimizer).GetMethod("Report")); } }
